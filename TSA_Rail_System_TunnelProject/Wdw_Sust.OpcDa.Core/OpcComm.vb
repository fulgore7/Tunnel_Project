Imports System.Threading
Imports RsiOPCAuto
Imports Wdw_Sust.Core
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core.Job
Imports Wdw_Sust.Logging.LoggingManager
Imports Wdw_Sust.OpcDa.Core.Ab
Imports Wdw_Sust.OpcDa.Core.EventArgs
Imports Wdw_Sust.OpcDa.Core.Interfaces

''' <summary>
''' Terminologies: ItemName: name of the item; TagName: name of the property;
''' PLCTagName: PLC compliance tag name
''' </summary>
''' <remarks>
''' Group definition is global, which means that different PLCs can not use the same group
''' definition. Name of the PLC tag can be the same as long as the tags reside in different groups.
''' </remarks>
''' async
Public Class OpcComm
    Inherits OpcCommBase

#Region "Fields"

    Private WithEvents MyOpcGroupsEvents As OPCGroups = MyOpcServer.OPCGroups

    'Public constants
    Public Const Opc_DS_CACHE As Integer = 1

    Public Const Opc_DS_DEVICE As Integer = 2

    ''' <summary>
    ''' Dictionary(Of transactionID, groupName)
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared ReadOnly _asyncGroupPendingTable As New Dictionary(Of Integer, String)()

    ''' <summary>
    ''' Dictionary(Of groupName, Dictionary(Of PLCTag, value))
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared ReadOnly _asyncPendingItems As New Dictionary(Of String, Dictionary(Of String, Object))()

    Private Shared ReadOnly _frmOpcGroupMap As New Dictionary(Of IHaveOpcObjects, List(Of String))()
    Private Shared ReadOnly _jobManager As New JobManager()
    Private Shared ReadOnly _listOfGroups As New Dictionary(Of String, OPCGroup)()
    Private Shared ReadOnly _queue As New Queue(Of OpcIncomingData)()

    Private Shared ReadOnly ADD_ITEM_LOCK As New Object

    Private Shared ReadOnly ASYNC_GROUP_LOCK As New Object

    Private Shared ReadOnly OPEN_GROUP_LOCK As New Object

    Private Shared ReadOnly QUEUE_LOCK As New Object

    Private Shared _dataProcessedCount As Long

    Private Shared _enableSubscribingGlobalDataChangeEvent As Boolean

    Private Shared _isApplicationClosing As Boolean

    Private Shared _isListeningToIncomingData As Boolean

    ''' <summary>
    ''' RSLinx Server
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared _myOpcServer As OPCServer

    Private Shared _updateTime As DateTime
    Private Shared OpcClientHandleIndex As Integer = 1
    Private Shared OpcObjectHandle As Integer
    Private Shared OpcTransactionIDIndex As Integer = 1

    ''' <summary>
    ''' Dictionary(Of groupName, groupProperties)
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _opcGroupDetails As New Dictionary(Of String, OpcGroupProperties)()

    Private ReadOnly _opcItemObjects As New OpcObjectDictionary()
    Private ReadOnly _opcItems As New OpcItemDictionary()
    Private _isInitializingOpcCommunication As Boolean = True
    Private _numberOfItemsConnectedToOpc As Integer

#End Region

#Region "Events"

    ''' <summary>
    ''' Raise event when async read is completed
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <remarks></remarks>
    Public Event AsyncReadCompleted(groupName As String, listOfOpcObjects As List(Of IOpcObject))

    Public Event AsyncRefreshFinished(groupName As String)

    ''' <summary>
    ''' Raise event when async write is completed
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <remarks></remarks>
    Public Event AsyncWriteCompleted(groupName As String)

    'Public Events
    ''' <summary>
    ''' This will only fire when property "IsSyncronized" is set to false
    ''' </summary>
    ''' <param name="TransactionID">Transaction ID assigned by the caller</param>
    ''' <param name="GroupHandle">Handle of the group</param>
    ''' <param name="NumItems">Number of items returned from the data change event</param>
    ''' <param name="ClientHandles">Array of client handles for the data change event</param>
    ''' <param name="ItemValues">
    ''' Array of Item values. The index of the array goes with the array of client handles
    ''' </param>
    ''' <param name="Qualities"></param>
    ''' <param name="TimeStamps">When the data change event received from the PLC</param>
    ''' <remarks>"IsSyncronized" is set to true by default</remarks>
    Public Event GlobalDataChangeFromPLC(TransactionID As Integer, GroupHandle As Integer, NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array)

    ''' <summary>
    ''' This will only fire when property "IsSyncronized" is set to false
    ''' </summary>
    ''' <param name="groupName"></param>
    ''' <param name="listOfOpcObjects"></param>
    ''' <remarks></remarks>
    Public Event GroupDataChangeEvent(groupName As String, listOfOpcObjects As List(Of IOpcObject))

    Public Event OpcCommError(TagName As String, Message As String)

    ''' <summary>
    ''' Used to broadcast information related to OPC communication
    ''' </summary>
    ''' <param name="timeStamp">When was the event happened</param>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="message">Message itself</param>
    ''' <param name="infoType">What kind of the message</param>
    ''' <remarks></remarks>
    Public Event OpcCommStatus(timeStamp As DateTime, groupName As String, message As String, infoType As OPC_COMM_TYPE)

    Public Event OpcObjectReadyToConnect(groupName As String, tagName As String)

    Public Event RegisteringProgress(sender As Object, e As OpcItemRegisteringProgressEventArgs)

#End Region

#Region "Properties"

    Public Shared ReadOnly Property HasItemsInQueue As Boolean
        Get
            Return ItemsInQueue > 0
        End Get
    End Property

    Public Shared ReadOnly Property ItemsInQueue As Integer
        Get
            If ThreadMode = OpcThreadMode.SINGLE_THREADED Then
                Return 0
            End If
            Dim returnValue As Integer
            'SyncLock QUEUE_LOCK
            returnValue = _queue.Count
            'End SyncLock
            Return returnValue
        End Get
    End Property

    Public Shared ReadOnly Property ProcessCount As Long
        Get
            Return _dataProcessedCount
        End Get
    End Property

    ''' <summary>
    ''' This will enable or disable OPC communication for debugging purposes. If this is true it
    ''' will ignore anything related to OPC, such as tag definitions, OpcComm.OpenOpcComm
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property EnableOpcCommunication() As Boolean = True

    Public Property EnableProcessQueueData As Boolean = True

    Public Property EnableSubscribingGlobalDataChangeEvent As Boolean
        Get
            Return _enableSubscribingGlobalDataChangeEvent
        End Get
        Set(value As Boolean)
            If _enableSubscribingGlobalDataChangeEvent <> value Then
                _enableSubscribingGlobalDataChangeEvent = value
                If _enableSubscribingGlobalDataChangeEvent Then
                    AddHandler MyOpcGroupsEvents.GlobalDataChange, AddressOf MyOpcGroups_GlobalDataChange
                Else
                    RemoveHandler MyOpcGroupsEvents.GlobalDataChange, AddressOf MyOpcGroups_GlobalDataChange
                End If
            End If
        End Set
    End Property

    Public Overrides Property IsApplicationClosing() As Boolean
        Get
            Return _isApplicationClosing
        End Get
        Set
            If Not _isApplicationClosing Then
                _isApplicationClosing = Value
                EnableSubscribingGlobalDataChangeEvent = False
            End If
        End Set
    End Property

    ''' <summary>
    ''' This is only in effect if the remote LINX option is used.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property LINXGatewayServerName() As String = String.Empty

    ''' <summary>
    ''' For debugging purposes. This can be set to true to see what the tags are. This is useful
    ''' information when a new class is developed. So you can map the property index accordingly.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property PrintTagNameWhenDebug() As Boolean

    ''' <summary>
    ''' This can only be set to false when the developer makes sure that no cross-thread issues will
    ''' arise from the program. Data collection to be recommended to use Multi-threaded
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property ThreadMode As OpcThreadMode = OpcThreadMode.SINGLE_THREADED

    Public Shared Property UseRemoteGateway() As Boolean

    Private Shared ReadOnly Property MyOpcServer As OPCServer
        Get
            If _myOpcServer Is Nothing Then
                _myOpcServer = New OPCServer
            End If
            Return _myOpcServer
        End Get
    End Property

#End Region

#Region "Members"

    Public Overrides Sub AddOpcObjects(ParamArray opcObjects() As IOpcObject)
        For Each opcObject As IOpcObject In opcObjects
            AddOpcObject(opcObject)
        Next
    End Sub

    ''' <summary>
    ''' Async read by the group name
    ''' </summary>
    ''' <param name="groupName">Group name to perform read operation</param>
    ''' <returns>Transaction ID for the operation</returns>
    ''' <remarks></remarks>
    Public Function AsyncRead(groupName As String) As Integer
        If Not MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsSubscribed Then
            Throw New ArgumentException("AsyncRead can not be called if the property IsSubscribed for the group is set to false in the OpcComm.OpenOpcComm!!")
        End If
        Try
            Dim numberOfItems As Integer = MyOpcServer.OPCGroups.Item(groupName).OPCItems.Count
            Dim count As Integer() = {numberOfItems}
            Dim lowerBound As Integer() = {1}
            Dim errors As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
            Dim serverHandles As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
            Dim index As Integer = 1
            Dim tempTransaction As Integer = GetCurrentOpcTransactionID()
            For Each key As OpcItemKey In _opcItems.Keys
                If key.GroupName = groupName Then
                    serverHandles.SetValue(key.ServerHandle, index)
                    index += 1
                End If
            Next
            MyOpcServer.OPCGroups.GetOPCGroup(groupName).AsyncRead(numberOfItems, serverHandles, errors, tempTransaction, 0)
            SyncLock ASYNC_GROUP_LOCK
                _asyncGroupPendingTable.Add(tempTransaction, groupName)
            End SyncLock
            Return tempTransaction
        Catch ex As System.Runtime.InteropServices.COMException
            Throw New OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode)
        End Try
    End Function

    Public Function AsyncRefresh(groupName As String) As Integer
        If Not MyOpcServer.OPCGroups.Item(groupName).IsSubscribed AndAlso Not MyOpcServer.OPCGroups.Item(groupName).IsActive Then
            Throw New ArgumentException("This Sub can not be called if the property IsSubscribed for the group is set to false in the OpcComm.OpenOpcComm!!")
        End If
        Dim cancelID As Integer
        Dim tempID As Integer = GetCurrentOpcTransactionID()
        MyOpcServer.OPCGroups.GetOPCGroup(groupName).AsyncRefresh(Opc_DS_DEVICE, tempID, cancelID)
        SyncLock ASYNC_GROUP_LOCK
            _asyncGroupPendingTable.Add(tempID, groupName)
        End SyncLock
        Return tempID
    End Function

    ''' <summary>
    ''' Use this to write to items in the OPC in an Async manner
    ''' </summary>
    ''' <param name="groupName">Name of the group to perform async operation</param>
    ''' <returns>The transaction ID for the transaction</returns>
    ''' <remarks>-1 will return if no async operation executed.</remarks>
    Public Overrides Function AsyncWrite(groupName As String) As Integer
        Try
            If _asyncPendingItems.ContainsKey(groupName) Then
                Dim numberOfItems As Integer = _asyncPendingItems(groupName).Count
                If numberOfItems > 0 Then
                    Dim count As Integer() = {numberOfItems}
                    Dim lowerBound As Integer() = {1}
                    Dim listOfTags As System.Array = Array.CreateInstance(GetType(String), count, lowerBound)
                    Dim errors As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
                    Dim serverHandles As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
                    Dim values As System.Array = Array.CreateInstance(GetType(Object), count, lowerBound)
                    Dim index As Integer = 1
                    For Each tag As String In _asyncPendingItems(groupName).Keys
                        Try
                            Dim key As OpcItemKey = _opcItems.GetKey(tag)
                            listOfTags.SetValue(key.PlcTagName, index)
                            serverHandles.SetValue(key.ServerHandle, index)
                            values.SetValue(_asyncPendingItems(groupName).Item(tag), index)
                        Catch ex As Exception
                            WriteUserMessageToLog(String.Format("Async Write - {0}", ex.Message))
                        End Try
                        index += 1
                    Next
                    Dim tempID As Integer = GetCurrentOpcTransactionID()
                    MyOpcServer.OPCGroups.Item(groupName).AsyncWrite(numberOfItems, serverHandles, values, errors, tempID, 0)
                    SyncLock ASYNC_GROUP_LOCK
                        _asyncGroupPendingTable.Add(tempID, groupName)
                    End SyncLock
                    Return tempID
                End If
            End If
            Return -1
        Catch ex As System.Runtime.InteropServices.COMException
            Throw New OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode)
        End Try
    End Function

    ''' <summary>
    ''' Get class object from the list
    ''' </summary>
    ''' <param name="plcName">PLC topic name where the tag belongs to</param>
    ''' <param name="opcObjectTagName">Tag name of the class object</param>
    ''' <returns>Class object</returns>
    ''' <remarks>Tag name should be unique.</remarks>
    Public Function GetOpcObject(plcName As String, opcObjectTagName As String) As IOpcObject
        If _opcItemObjects.Contains(plcName, opcObjectTagName) Then
            Return _opcItemObjects.Item(plcName, opcObjectTagName)
        Else
            Throw New ArgumentException(String.Format("[{0}]{1} can not be found!!", plcName, opcObjectTagName))
        End If
    End Function

    ''' <summary>
    ''' Use this to write to items in the OPC in an Sync manner
    ''' </summary>
    ''' <param name="groupName">Name of the group to perform async operation</param>
    ''' <returns>The transaction ID for the transaction</returns>
    ''' <remarks>-1 will return if no sync operation executed.</remarks>
    Public Overrides Function SyncWrite(groupName As String) As Integer
        Try
            If _asyncPendingItems.ContainsKey(groupName) Then
                Dim numberOfItems As Integer = _asyncPendingItems(groupName).Count
                If numberOfItems > 0 Then
                    Dim count As Integer() = {numberOfItems}
                    Dim lowerBound As Integer() = {1}
                    Dim listOfTags As System.Array = Array.CreateInstance(GetType(String), count, lowerBound)
                    Dim errors As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
                    Dim serverHandles As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
                    Dim values As System.Array = Array.CreateInstance(GetType(Object), count, lowerBound)
                    Dim index As Integer = 1
                    For Each tag As String In _asyncPendingItems(groupName).Keys
                        Try
                            Dim key As OpcItemKey = _opcItems.GetKey(tag)
                            listOfTags.SetValue(key.PlcTagName, index)
                            serverHandles.SetValue(key.ServerHandle, index)
                            values.SetValue(_asyncPendingItems(groupName).Item(tag), index)
                        Catch ex As Exception
                            WriteUserMessageToLog(String.Format("Async Write - {0}", ex.Message))
                        End Try
                        index += 1
                    Next
                    Dim tempID As Integer = GetCurrentOpcTransactionID()
                    MyOpcServer.OPCGroups.Item(groupName).SyncWrite(numberOfItems, serverHandles, values, errors)

                    Return tempID
                End If
            End If
            Return -1
        Catch ex As System.Runtime.InteropServices.COMException
            Throw New OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode)
        End Try
    End Function

    Friend Function GetOpcTagWithHandle(groupName As String) As List(Of OpcItemKey)
        Dim listOfKey As New List(Of OpcItemKey)
        For Each o As KeyValuePair(Of OpcItemKey, IOpcObject) In _opcItems
            If o.Key.GroupName = groupName Then
                listOfKey.Add(o.Key)
            End If
        Next
        Return listOfKey
    End Function

#Region "Private"

    Public Sub AddAsyncPendingItemToList(groupName As String, plcTagName As String, value As Object)
        If _asyncPendingItems.ContainsKey(groupName) Then
            If _asyncPendingItems(groupName).ContainsKey(plcTagName) Then
                _asyncPendingItems(groupName).Item(plcTagName) = value
            Else
                _asyncPendingItems(groupName).Add(plcTagName, value)
            End If
        Else
            Dim dict As New Dictionary(Of String, Object) From {
                {plcTagName, value}
            }
            _asyncPendingItems.Add(groupName, dict)
        End If
    End Sub

    Public Function GetOpcGroupProperties(groupName As String) As OpcGroupProperties
        If EnableOpcCommunication AndAlso groupName IsNot Nothing Then
            If _opcGroupDetails.ContainsKey(groupName) Then
                Return _opcGroupDetails(groupName)
            Else
                WriteUserMessageToLog(String.Format("The group {0} does not exist in the OpcComm object!", groupName))
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Write the value from the object to the PLC tag
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="plcTagName">Name of the PLC tag name</param>
    ''' <param name="value">Value to be written</param>
    ''' <remarks></remarks>
    Public Function SetItemValue(groupName As String, plcTagName As String, value As Object, Optional shouldThrowIfError As Boolean = False) As Boolean
        If _opcGroupDetails.ContainsKey(groupName) Then
            If shouldThrowIfError Then
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.Item(plcTagName).Write(value)
            Else
                Return TryUserAction(act:=Sub() MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.Item(plcTagName).Write(value), message:=$"SetItemValue(groupName={groupName}; plcTagName={plcTagName}; value={value})")
            End If
        End If
        Return True
    End Function

    Friend Function GetItemServerHandle(groupName As String, tagName As String) As Integer
        Return MyOpcGroupsEvents.GetOPCGroup(groupName).OPCItems.Item(tagName).ServerHandle
    End Function

    ''' <summary>
    ''' Get OPC group object from the list of groups in the OPC server
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function GetOpcGroup(groupName As String) As OPCGroup
        If DoesGroupExistInServer(groupName) Then
            Return MyOpcServer.OPCGroups.Item(groupName)
        Else
            Throw New ArgumentException("Group does not exist!!")
        End If
    End Function

    Friend Sub UpdateTagValue(plcTagName As String, value As Object)
        Dim opcItemKey As OpcItemKey = _opcItems.GetKey(plcTagName)
        opcItemKey.Value = value
    End Sub

    Private Sub AddGroupHandlers(ByRef group As OPCGroup)
        AddHandler group.AsyncWriteComplete, AddressOf MyOpcGroup_AsyncWriteComplete
        AddHandler group.AsyncReadComplete, AddressOf _myOpcGroup_AsyncReadComplete
    End Sub

    Private Sub AddOpcItems(groupName As String, isActive As Boolean)
        '==
        '   Step 3: Add OPC items to group
        '==
        RaiseOpcCommStatusEvent(Now, Nothing, String.Format("Add OPC items to group {0} is in progress", groupName), OPC_COMM_TYPE.OpcCommStatus)
        Try
            Dim count As Integer() = {_opcGroupDetails(groupName).GetListOfTags.Count}
            Dim lowerBound As Integer() = {1}
            Dim listOfTags As System.Array = Array.CreateInstance(GetType(String), count, lowerBound) 'tags to be connected
            Dim errors As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound) 'errors just in case there are errors return
            Dim serverHandles As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound) 'server handles
            Dim clientHandles As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound) 'client handles
            Dim index As Integer = 1

            For Each pair As KeyValuePair(Of String, Integer) In _opcGroupDetails(groupName).GetPLCTagNameWithHandles
                listOfTags.SetValue(pair.Key, index)
                clientHandles.SetValue(pair.Value, index)
                index += 1
            Next

            MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.AddItems(index - 1, listOfTags, clientHandles, serverHandles, errors) 'add the items
            MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive = isActive 'set the group to be active after open

            If errors.Length > 0 Then 'check if errors occurred
                Dim potentialErrors(errors.Length - 1) As Integer
                For i As Integer = 0 To potentialErrors.Length - 1
                    potentialErrors(i) = errors(i + 1)
                Next

                If Array.Exists(potentialErrors, Function(err As Integer) err <> 0) Then
                    Dim s As New Text.StringBuilder
                    For i As Integer = 0 To potentialErrors.Length - 1
                        Select Case potentialErrors(i)
                            Case -1073479672
                                s.AppendLine(String.Format("Group:{0} - {1} does not conform to the server's syntax.!!", groupName, listOfTags(i + 1)))
                            Case Is <> 0
                                s.AppendLine(String.Format("Group:{0} - {1} is not defined in PLC!!", groupName, listOfTags(i + 1)))
                                'RaiseMultiThreadedEvent(OpcCommError, New Object() {listOfTags(i + 1), "Test"})
                        End Select
                    Next

                    'MsgBox(s.ToString)
                End If
            End If

            If OpcComm.ThreadMode = OpcThreadMode.MULTI_THREADED AndAlso Not _isListeningToIncomingData Then
                _isListeningToIncomingData = True
                'Listening to incoming OPC data
                CreateAndRunBackgroundThread(AddressOf ProcessMultiThreadedIncomingOpcData)
            End If
        Catch ex As System.Runtime.InteropServices.COMException
            Dim exceptionString As String = OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode)
            Console.WriteLine("COM Exception: {0}", exceptionString)

            If ex.ErrorCode = OpcComExceptions.ExceptionCode.WrongTag Then
                RaiseEvent OpcCommError("Test", "TagName not defined in the PLC")
            Else
                Throw New OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode)
            End If
        End Try
        _numberOfItemsConnectedToOpc += _opcGroupDetails(groupName).GetListOfTags.Count
        RaiseEvent OpcCommStatus(Now, Nothing, String.Format("OPC items added to group {0} successfully", groupName), OPC_COMM_TYPE.OpcCommStatus)
    End Sub

    Private Function AssignClientHandle() As Integer
        Dim i As Integer

        Do
            i = GetRandomNumber()
        Loop Until Not _opcItems.ContainsKey(i)
        Return i
    End Function

    Private Sub CheckServerState()
        ' do nothing at this time.
    End Sub

    Private Sub ConnectOpcServer(OpcProgramID As String, isExistingGroupsDeleted As Boolean)
        If Not IsServerRunning() Then
            '==
            '   Step 1: Initialize RSLinx OPC Server
            '==
            RaiseOpcCommStatusEvent(Now, Nothing, "Connecting to OPC server!!", OPC_COMM_TYPE.OpcCommStatus)
            If UseRemoteGateway Then
                Try
                    MyOpcServer.Connect(OpcProgramID, LINXGatewayServerName)
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                End Try
            Else
                MyOpcServer.Connect(OpcProgramID)
            End If
            If isExistingGroupsDeleted Then MyOpcServer.OPCGroups.RemoveAll()
            EnableSubscribingGlobalDataChangeEvent = True
            _jobManager.AddJob("periodic-server-state-check", TimeSpan.FromSeconds(30), AddressOf CheckServerState)
            _jobManager.StartProcessingJobs()
        End If
    End Sub

    Private Function DoesGroupExistInServer(groupName As String) As Boolean
        If _opcGroupDetails.ContainsKey(groupName) Then
            Return True
        End If
        Return False
    End Function

    Private Function FillItemValuesToObjects(GroupName As String, NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef TimeStamps As System.Array) As List(Of IOpcObject)
        Dim listOfItems As New List(Of IOpcObject)
        Dim tempIndex As Integer

        'Dim timeStamp As Long = Now.Ticks
        For i As Integer = 1 To NumItems
            'Get the OPC item from the OpcComm object by the client handles

            'key contains PLC tag, client handle, server handle and the value to be inserted
            Dim key As OpcItemKey = _opcItems.GetKey(ClientHandles(i))
            Dim opcItem As IOpcObject = _opcItems(key)

            'Get the value returned from the data change event
            key.Value = ItemValues(i)

            'Get the index from the specific class
            tempIndex = opcItem.GetPropertyIndex(key.PlcTagName)

            'Update the value from the PLC to the class property
            opcItem.ValueFromPlcToObject(tempIndex, key.Value)

            'RecordTagInfo(timeStamp, key.PLCTagName, key.Value)
            If PrintTagNameWhenDebug Then
                Console.WriteLine(String.Format("{0}: Value:{1}", key.PlcTagName, key.Value))
            End If

            RaiseOpcCommStatusEvent(Now, GroupName, String.Format("{0} = {1}", key.PlcTagName, key.Value), OPC_COMM_TYPE.OPCTagValueChanged)

            If opcItem.IsRegisteringInProgress Then
                opcItem.RegisterItems += 1
                _numberOfItemsConnectedToOpc += 1
            End If

            If Not listOfItems.Contains(opcItem) AndAlso Not opcItem.IsRegisteringInProgress Then
                opcItem.TimeStamp = CType(TimeStamps(i), Date).ToLocalTime
                If ThreadMode = OpcThreadMode.MULTI_THREADED Then
                    RaiseMultiThreadedEvent(OpcCommStatusEvent, New Object() {Now, GroupName, String.Format("OPC item {0} was changed", opcItem.TagName), OPC_COMM_TYPE.OpcCommStatus})
                Else
                    RaiseEvent OpcCommStatus(Now, GroupName, String.Format("OPC item {0} was changed", opcItem.TagName), OPC_COMM_TYPE.OpcCommStatus)
                End If
                'TODO: Sum - This is to check if the object is serializable. Needs to come back to develop this.
                'If opcItem.GetObjectType.IsSerializable Then

                'End If
                listOfItems.Add(opcItem)
            End If

            _dataProcessedCount += 1
        Next
        'TODO: Sum - need to develop this
        'If _OpcAccessMode = OpcAccessMode.Opc_REMOTE_ACCESS_MODE Then
        '    'RaiseEvent GlobalOpcItemChangeEvent(GroupName, listOfOpcItems)
        '    LINTFunctions.RaiseMultiThreadedEvent(GlobalOpcItemChangeEventEvent, New Object() {GroupName, listOfOpcItems})
        'End If
        'Event is raised when the group is in synchronized mode
        'RaiseEvent Test(Me, New OpcGlobalDataChangeEventArgs(tempGroupName, listOfItems))
        Return listOfItems
    End Function

    Private Function GetGroupNameByHandle(groupHandle As Integer) As String
        For Each group As OPCGroup In MyOpcServer.OPCGroups
            If group.ServerHandle = groupHandle Then
                Return group.Name
            End If
        Next
        Return String.Empty
    End Function

    Private Sub MyOpcGroup_AsyncWriteComplete(TransactionID As Integer, NumItems As Integer, ByRef ClientHandles As System.Array, ByRef Errors As System.Array)
        Dim groupName As String = _asyncGroupPendingTable(TransactionID)
        SyncLock ASYNC_GROUP_LOCK
            _asyncGroupPendingTable.Remove(TransactionID)
            _asyncPendingItems.Remove(groupName)
        End SyncLock
        RaiseEvent AsyncWriteCompleted(groupName)
    End Sub

    ''' <summary>
    ''' Implementation of the OPC data change event.
    ''' </summary>
    ''' <param name="TransactionID">A number assigned to the transaction</param>
    ''' <param name="GroupHandle">Server Handle of the group</param>
    ''' <param name="NumItems">Number of items was modified in the data change event</param>
    ''' <param name="ClientHandles">Array of client handles of all changed items</param>
    ''' <param name="ItemValues">Array of values of all changed items</param>
    ''' <param name="Qualities"></param>
    ''' <param name="TimeStamps"></param>
    ''' <remarks></remarks>
    Private Sub MyOpcGroups_GlobalDataChange(TransactionID As Integer, GroupHandle As Integer, NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array) 'ZRL 2020-11-11 removed handles code, cause data duplication bug
        _updateTime = Now
        If Not IsApplicationClosing Then
            Select Case ThreadMode
                Case OpcThreadMode.SINGLE_THREADED
                    ProcessOpcIncomingData(TransactionID, GroupHandle, NumItems, ClientHandles, ItemValues, Qualities, TimeStamps)
                Case OpcThreadMode.MULTI_THREADED
                    SyncLock QUEUE_LOCK
                        _queue.Enqueue(New OpcIncomingData(TransactionID, GroupHandle, ClientHandles, NumItems, ItemValues, TimeStamps, Qualities))
                        Console.WriteLine("Loading {0} items - {1} Events pending", ClientHandles.Length, _queue.Count)
                    End SyncLock
            End Select
        End If
    End Sub

    ''' <summary>
    ''' Processes the multi threaded incoming OPC data. This thread will run continuously when
    ''' MULTI_THREAD mode is used when start the OpcComm object
    ''' </summary>
    Private Sub ProcessMultiThreadedIncomingOpcData()
        Dim data As OpcIncomingData
        While True
            If _queue.Count > 0 AndAlso EnableProcessQueueData Then
                Try
                    SyncLock QUEUE_LOCK
                        data = _queue.Dequeue
                        Console.WriteLine("Unloading {0} items - {1} Events pending", data.ClientHandles.Length, _queue.Count)
                    End SyncLock
                    If data.Qualities.Length > 0 Then
                        Dim potentialErrors(data.Qualities.Length - 1) As Integer
                        For i As Integer = 0 To potentialErrors.Length - 1
                            potentialErrors(i) = data.Qualities(i + 1)
                        Next
                        Dim errorsFromPLC As Integer() = Array.FindAll(potentialErrors, Function(err As Integer) err <> &HC0)
                        If errorsFromPLC.Length > 0 Then
                            For i As Integer = 0 To errorsFromPLC.Length - 1
                                WriteUserMessageToLog(String.Format("{0}, Quality of data is not good for group: {1}, {2}", Now.ToString, GetGroupNameByHandle(data.GroupHandle), errorsFromPLC(i)))
                            Next
                        End If
                    End If
                    If data.GroupHandle > 0 Then 'Why GroupHandle = 0 ???
                        ProcessOpcIncomingData(data.TransactionID, data.GroupHandle, data.NumItems, data.ClientHandles, data.ItemValues, data.Qualities, data.TimeStamps)
                    End If
                Catch ex As Exception
                    WriteUserMessageToLog(String.Format("{0}, {1}", Now.ToString, ex.Message))
                End Try
            Else
                Thread.Sleep(50)
            End If
        End While
    End Sub

    '<DebuggerNonUserCode()> _
    Private Sub ProcessOpcIncomingData(TransactionID As Integer, GroupHandle As Integer, NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array)

        Dim tempGroupName As String = GetGroupNameByHandle(GroupHandle)
        If tempGroupName <> String.Empty Then
            Dim group As OpcGroupProperties = GetOpcGroupProperties(tempGroupName)
            RaiseOpcCommStatusEvent(Now, tempGroupName, "New data has arrived", OPC_COMM_TYPE.OpcCommStatus)

            If _opcGroupDetails.ContainsKey(tempGroupName) Then
                If _opcGroupDetails(tempGroupName).IsGroupSyncronized Then
                    Dim listOfOpcObjects As List(Of IOpcObject) = FillItemValuesToObjects(tempGroupName, NumItems, ClientHandles, ItemValues, TimeStamps)
                    If listOfOpcObjects.Count > 0 Then
                        For Each item As IOpcObject In listOfOpcObjects
                            item.RaisePropertiesUpdatedEvent(System.EventArgs.Empty)
                            'WDW_SUST.Util.Serialization.SerializationManager.SerializeToFile("abc.txt", item)
                            'TODO: Sum - Should I remove the item if it has its own property change event fired??
                        Next
                        If _opcGroupDetails(tempGroupName).IsOPCGlobalDataChangeEventSuppressing Then
                            group.RaiseGroupDataChangeEvent(New OpcGroupDataChangeEventArgs(listOfOpcObjects))
                        Else
                            If ThreadMode = OpcThreadMode.MULTI_THREADED Then
                                OnRaiseMultiThreadedGlobalDataChangeEvent(tempGroupName, listOfOpcObjects)
                            Else
                                OnRaiseGlobalDataChangeEvent(tempGroupName, listOfOpcObjects)
                            End If
                        End If
                    End If
                    If TransactionID > 0 Then
                        SyncLock ASYNC_GROUP_LOCK
                            _asyncGroupPendingTable.Remove(TransactionID)
                        End SyncLock
                        If ThreadMode = OpcThreadMode.MULTI_THREADED Then
                            RaiseMultiThreadedEvent(AsyncRefreshFinishedEvent, New Object() {tempGroupName})
                        Else
                            RaiseEvent AsyncRefreshFinished(tempGroupName)
                        End If
                    End If
                Else
                    'Event is raised when the group is not in synchronized mode
                    If ThreadMode = OpcThreadMode.MULTI_THREADED Then
                        RaiseMultiThreadedEvent(GlobalDataChangeFromPLCEvent, New Object() {TransactionID, GroupHandle, NumItems, ClientHandles, ItemValues, Qualities, TimeStamps})
                    Else
                        RaiseEvent GlobalDataChangeFromPLC(TransactionID, GroupHandle, NumItems, ClientHandles, ItemValues, Qualities, TimeStamps)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RaiseOpcCommStatusEvent(time As Date, groupName As String, message As String, commType As OPC_COMM_TYPE)
        If OpcComm.ThreadMode = OpcThreadMode.MULTI_THREADED Then
            RaiseMultiThreadedEvent(OpcCommStatusEvent, New Object() {time, groupName, message, commType})
        Else
            RaiseEvent OpcCommStatus(time, groupName, message, commType)
        End If
    End Sub

    Private Sub RemoveGroupHandlers(ByRef group As OPCGroup)
        RemoveHandler group.AsyncWriteComplete, AddressOf MyOpcGroup_AsyncWriteComplete
        RemoveHandler group.AsyncReadComplete, AddressOf _myOpcGroup_AsyncReadComplete
    End Sub

    Private Sub SetOpcGroup(groupName As String, updateRate As Integer, isSubscribed As Boolean)
        '==
        '   Step 2: Setup OPC group
        '==
        RaiseOpcCommStatusEvent(Now, Nothing, String.Format("Adding group {0} to OPC server", groupName), OPC_COMM_TYPE.OpcCommStatus)
        Dim group As OPCGroup = MyOpcServer.OPCGroups.Add(groupName)

        With MyOpcServer.OPCGroups.GetOPCGroup(groupName)
            .IsSubscribed = isSubscribed
            .UpdateRate = updateRate
            .IsActive = False
        End With

        AddGroupHandlers(group)
        _listOfGroups.Add(groupName, group)
    End Sub

#End Region

#Region "Public"

    ''' <summary>
    ''' To determine if the OPC Communication is being initialized.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsInitializingOpcCommunication() As Boolean
        Get
            Return _isInitializingOpcCommunication
        End Get
        Set(value As Boolean)
            _isInitializingOpcCommunication = value
        End Set
    End Property

    ''' <summary>
    ''' Used to add item to the OPC instance for OPC communication
    ''' </summary>
    ''' <param name="opcItem">Item to be added</param>
    ''' <remarks></remarks>
    <Obsolete("Use AddOpcObject instead")>
    Public Sub AddOpcItem(opcItem As IOpcObject)
        Dim t As Array = opcItem.GetPlcTagNames
        If Not _opcGroupDetails.ContainsKey(opcItem.GroupName) Then
            _opcGroupDetails.Add(opcItem.GroupName, New OpcGroupProperties)
        End If
        'Add a reference to the OpcGroupDetails
        _opcGroupDetails(opcItem.GroupName).AddOPCItemObjectToList(opcItem)
        For Each s As String In t
            Dim tempHandle As Integer = AssignClientHandle()
            _opcItems.Add(New OpcItemKey(tempHandle, opcItem.GroupName, s), opcItem)
            _opcGroupDetails.Item(opcItem.GroupName).AddTag(s, tempHandle)
        Next
        _opcItemObjects.Add(New OpcObjectKey(opcItem.PlcName, opcItem.TagName, opcItem.GroupName), opcItem)
    End Sub

    ''' <summary>
    ''' Used to add item to the OPC instance for OPC communication. IMPORTANT!! If the parent form
    ''' which owns this object and also inherits from LINTOpcFormBase, make sure to use
    ''' AddOpcObject(ByVal opcItem as IOpcObject, ByVal parentForm As Form) instead!!
    ''' </summary>
    ''' <param name="opcObject">
    ''' Item to be added - Look at summary for reference on how to use this subroutine
    ''' </param>
    ''' <returns>OPC object handle</returns>
    ''' <remarks></remarks>
    Public Overrides Function AddOpcObject(opcObject As IOpcObject) As Integer
        If EnableOpcCommunication Then
            SyncLock ADD_ITEM_LOCK
                Dim t As Array = opcObject.GetPlcTagNames
                If Not _opcGroupDetails.ContainsKey(opcObject.GroupName) Then
                    _opcGroupDetails.Add(opcObject.GroupName, New OpcGroupProperties)
                End If
                'Add a reference to the OpcGroupDetails
                _opcGroupDetails(opcObject.GroupName).AddOPCItemObjectToList(opcObject)
                For Each s As String In t
                    Dim tempHandle As Integer = OpcClientHandleIndex
                    OpcClientHandleIndex += 1
                    If PrintTagNameWhenDebug Then
                        Console.WriteLine(String.Format("{0}: Handle:{1}", s, tempHandle))
                    End If
                    If Not _opcGroupDetails.Item(opcObject.GroupName).AddTag(s, tempHandle) Then
                        Throw New Exception(String.Format("PLC Tag Name {0} has already been defined in the group {1}", s, opcObject.GroupName))
                    End If
                    _opcItems.Add(New OpcItemKey(tempHandle, opcObject.GroupName, s), opcObject)
                Next
                _opcItemObjects.Add(New OpcObjectKey(opcObject.PlcName, opcObject.TagName, opcObject.GroupName), opcObject)
                OpcObjectHandle += 1
                RaiseEvent OpcObjectReadyToConnect(opcObject.GroupName, opcObject.TagName)
            End SyncLock
            Return OpcObjectHandle
        End If
        Return -1
    End Function

    Public Overrides Function AddOpcObject(Of T As IOpcObject)(plcName As String, tagName As String, groupName As String) As T
        Dim obj As T = Activator.CreateInstance(GetType(T), plcName, tagName, groupName)
        AddOpcObject(obj)
        Return obj
    End Function

    Public Overrides Function AddOpcObject(Of T As IOpcObject)(plcName As String, tagName As String, groupName As String, parentForm As IHaveOpcObjects) As T
        Dim obj As T = Activator.CreateInstance(GetType(T), plcName, tagName, groupName)
        AddOpcObject(obj, parentForm)
        Return obj
    End Function

    ''' <summary>
    ''' Used to add item to the OPC instance for OPC communication. It is very important that if the
    ''' parent form inherits from LINTOpcFormBase, the second argument needs to be set to the parent
    ''' form itself to make sure all groups in the form will be closed properly.
    ''' </summary>
    ''' <param name="opcObject">
    ''' Item to be added - Look at summary for reference on how to use this subroutine
    ''' </param>
    ''' <param name="parentForm">
    ''' Form object which has the group of the OPC object and also inherits from LINTOpcFormBase
    ''' </param>
    ''' <remarks></remarks>
    Public Overloads Sub AddOpcObject(opcObject As IOpcObject, parentForm As IHaveOpcObjects)
        If EnableOpcCommunication Then
            If _frmOpcGroupMap.ContainsKey(parentForm) Then
                If Not _frmOpcGroupMap(parentForm).Contains(opcObject.GroupName) Then
                    _frmOpcGroupMap(parentForm).Add(opcObject.GroupName)
                End If
            Else
                _frmOpcGroupMap.Add(parentForm, New List(Of String))
                _frmOpcGroupMap(parentForm).Add(opcObject.GroupName)
            End If
        End If
        AddOpcObject(opcObject)
    End Sub

    Public Async Function AddOpcObjectAsync(opcObject As IOpcObject) As Task
        Await Task.Run(Sub() AddOpcObject(opcObject))
    End Function

    ''' <summary>
    ''' Close all active OPC groups in the server and then disconnect from it.
    ''' </summary>
    ''' <remarks>
    ''' This is only called when the application is going to shut down. Otherwise, call
    ''' CloseOpcComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
    ''' </remarks>
    Public Overrides Sub CloseOpcComm()
        EnableSubscribingGlobalDataChangeEvent = False
        While HasItemsInQueue
            Thread.Sleep(200)
        End While
        For Each opcGroup As OPCGroup In MyOpcServer.OPCGroups
            Try
                CloseOpcComm(opcGroup.Name, True)
            Catch ex As System.Runtime.InteropServices.COMException
                WriteException(ex)
            End Try
        Next

        DisconnectOpcServer()
    End Sub

    Public Overloads Sub CloseOpcComm(waitHandle As ManualResetEvent)
        CloseOpcComm()
        waitHandle.Set()
    End Sub

    ''' <summary>
    ''' Close the OPC group specified
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="clearClientHandles">
    ''' Determine if clearing the client handles in the memory buffer is needed
    ''' </param>
    ''' <remarks>
    ''' This is only called when the application is going to shut down. Otherwise, call
    ''' CloseOpcComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
    ''' </remarks>
    Public Overrides Sub CloseOpcComm(groupName As String, clearClientHandles As Boolean)
        If EnableOpcCommunication Then
            Try
                If Not String.IsNullOrEmpty(groupName) AndAlso _opcGroupDetails.ContainsKey(groupName) Then
                    If clearClientHandles Then
                        For Each handle As Integer In _opcGroupDetails.Item(groupName).GetClientHandles
                            For Each key As OpcItemKey In _opcItems.Keys.ToList
                                If key.ClientHandle = handle Then
                                    _opcItems.Remove(key)
                                    Exit For
                                End If
                            Next
                        Next
                        _numberOfItemsConnectedToOpc -= _opcGroupDetails.Item(groupName).GetPLCTagCounts
                        _opcGroupDetails(groupName).Dispose()
                        _opcGroupDetails.Remove(groupName)
                        _opcItemObjects.Remove(groupName)
                    Else
                        _opcGroupDetails(groupName).IsGroupConnected = False
                    End If
                    If MyOpcServer.OPCGroups.Count > 0 Then
                        RemoveGroupHandlers(_listOfGroups(groupName))
                        _listOfGroups.Remove(groupName)
                        MyOpcServer.OPCGroups.Remove(groupName)
                    End If
                End If
            Catch ex As System.Runtime.InteropServices.COMException
                WriteException(ex)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Close the OPC group specified
    ''' </summary>
    ''' <param name="parentForm">Parent object which as the group resides in it</param>
    ''' <remarks>
    ''' This is only called when the application is going to shut down. Otherwise, call
    ''' CloseOpcComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
    ''' </remarks>
    Public Overloads Sub CloseOpcComm(parentForm As IHaveOpcObjects)
        If EnableOpcCommunication AndAlso ContainsGroupInForm(frm:=parentForm) Then
            _frmOpcGroupMap(parentForm).ForEach(Sub(a) CloseOpcComm(a, True))
            _frmOpcGroupMap.Remove(parentForm)
            parentForm = Nothing
        End If
    End Sub

    Public Function ContainsGroup(ByRef frm As IHaveOpcObjects, groupName As String) As Boolean
        If ContainsGroupInForm(frm) Then
            For Each s As String In _frmOpcGroupMap(frm)
                If s.ToLower = groupName.ToLower Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    Public Function ContainsGroupInForm(ByRef frm As IHaveOpcObjects) As Boolean
        Return _frmOpcGroupMap.ContainsKey(frm)
    End Function

    Public Overloads Function GetAllTagNames(groupName As String) As String()
        Return _opcGroupDetails(groupName).GetPLCTagNames.ToArray
    End Function

    Public Overrides Function GetAllTagNames() As String()
        Dim list As New List(Of String)
        For Each pair As KeyValuePair(Of String, OpcGroupProperties) In _opcGroupDetails
            list.AddRange(pair.Value.GetPLCTagNames)
        Next
        Return list.ToArray
    End Function

    ''' <summary>
    ''' Get all group names which have already connected to the PLC
    ''' </summary>
    ''' <returns>Array of group names</returns>
    ''' <remarks></remarks>
    Public Function GetGroupNames() As String()
        Dim names As New List(Of String)
        For Each group As OPCGroup In MyOpcServer.OPCGroups
            names.Add(group.Name)
        Next
        names.Sort()
        Return names.ToArray
    End Function

    ''' <summary>
    ''' Get the value from the PLC and assign it to the object
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="plcTagName">PLC tag name</param>
    ''' <returns>Value of the item in the PLC</returns>
    ''' <remarks></remarks>
    Public Function GetItemValue(groupName As String, plcTagName As String) As Object
        Return MyOpcGroupsEvents.GetOPCGroup(groupName).OPCItems.Item(plcTagName).Value
    End Function

    ''' <summary>
    ''' Get the value from the PLC and assign it to the object
    ''' </summary>
    ''' <param name="opcItem">OPC object</param>
    ''' <param name="itemName">Name of the item</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' Item name should not include the tag name of the item. If the item is an OpcElement type,
    ''' the item name should be value.
    ''' </remarks>
    Public Function GetItemValue(opcItem As IOpcObject, itemName As String) As Object
        Dim plcTagName As String = opcItem.GetPlcTagName(itemName)
        Return MyOpcGroupsEvents.GetOPCGroup(opcItem.GroupName).OPCItems.Item(plcTagName).Value
    End Function

    Public Function GetListOfOpcObjectsByGroup(groupName As String) As List(Of IOpcObject)
        'Dim list As New List(Of IOpcObject)
        'For Each opcObjectKey As OpcObjectKey In _opcItemObjects.Keys
        '    If opcObjectKey.GroupName = groupName Then
        '        list.Add(_opcItemObjects(opcObjectKey))
        '    End If
        'Next
        'Return list
        Return _opcGroupDetails(groupName).OPCObjects
    End Function

    Public Function GetMaxOpcTimeStamp() As DateTime
        Try
            Return _opcItems.Aggregate(Function(l, r) If(l.Value.TimeStamp > r.Value.TimeStamp, l, r)).Value.TimeStamp
        Catch ex As InvalidOperationException
            Return System.Convert.ToDateTime("01/01/1900")
        End Try
    End Function

    '''<summary>
    ''' Get number of items in a group
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <returns>Count in an integer</returns>
    ''' <remarks></remarks>
    Public Overloads Function GetNumberOfOpcItems(groupName As String) As Integer
        Return MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.Count
    End Function

    Public Overrides Function GetNumberOfOpcItems() As Integer
        Return _opcItems.Count
    End Function

    'TODO: This is for testing purposes and will need to be removed.
    Public Function GetOpcItemTagNames() As List(Of String)
        For Each obj As OpcItemKey In _opcItems.Keys
            Console.WriteLine(obj.PlcTagName)
        Next
        Return Nothing
    End Function

    'TODO: This is for testing purposes and will need to be removed.
    Public Function GetOpcObjectTagNames() As List(Of String)
        For Each obj As IOpcObject In _opcItemObjects.Values
            'For Each s As String In obj.GetPLCTagNames
            '    Console.WriteLine(s)
            'Next
            Console.WriteLine(obj.TagName)
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Check if group is active
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsGroupActive(groupName As String) As Boolean
        If IsApplicationClosing Then
            Return False
        End If
        Return MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive
    End Function

    ''' <summary>
    ''' Use to tell if the group is subscribed
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <returns>Boolean indicate if the group is subscribed</returns>
    ''' <remarks></remarks>
    Public Function IsGroupSubscribed(groupName As String) As Boolean
        Return MyOpcGroupsEvents.GetOPCGroup(groupName).IsSubscribed
    End Function

    ''' <summary>
    ''' Use to tell if the objects in the group is synchronized with the PLC values
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsGroupSynchronized(groupName As String) As Boolean
        Return _opcGroupDetails(groupName).IsGroupSyncronized
    End Function

    ''' <summary>
    ''' Check if the server is running
    ''' </summary>
    ''' <returns>Boolean to tell if the OPC server is running</returns>
    ''' <remarks></remarks>
    Public Overrides Function IsServerRunning() As Boolean
        Dim state As Boolean
        Try
            state = MyOpcServer.ServerState = OPCServerState.OPCRunning
        Catch ex As System.Runtime.InteropServices.COMException
            state = False
        End Try
        Return state
    End Function

    ''' <summary>
    ''' Open OPC communication for all groups existed in _opcGroupDetails which have not called the
    ''' OpenOpcComm subroutine yet
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub OpenOpcComm()
        If EnableOpcCommunication Then
            If _opcGroupDetails.Count = 0 Then
                Throw New Exception("No group was defined to add to the Opc!!!")
            End If
            For Each group As String In _opcGroupDetails.Keys
                OpenOpcComm(group)
                CalculateRegisteringProcess()
            Next
        End If
    End Sub

    Public Overloads Sub OpenOpcComm(waitHandle As ManualResetEvent)
        OpenOpcComm()
    End Sub

    ''' <summary>
    ''' Open OPC communication for all groups reside in the form object
    ''' </summary>
    ''' <param name="frm">Form object which contains all intended groups for communication</param>
    ''' <param name="updateRate">Update rate for all group inside of the form</param>
    ''' <remarks></remarks>
    Public Overrides Sub OpenOpcComm(frm As IHaveOpcObjects, Optional updateRate As Integer = 1000)
        If EnableOpcCommunication AndAlso ContainsGroupInForm(frm) Then
            If _frmOpcGroupMap(frm).Count = 0 Then
                Throw New Exception("No group was defined to add to the Opc!!!")
            End If
            For Each group As String In _frmOpcGroupMap(frm)
                OpenOpcComm(group, updateRate)
                CalculateRegisteringProcess()
            Next
        End If
    End Sub

    '''<summary>
    ''' Use to set different property for the group specified. If default properties are used
    ''' We should only call OpenOpcComm to open all groups at the same time
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="updateRate">Group update rate</param>
    ''' <param name="isSubscribed">Is the group subscribed</param>
    ''' <param name="isActive">Is the group active</param>
    ''' <param name="isSyncronized">Set to see if the data from VB is in sync with data from PLC
    ''' through the data change event. If value is set to false, the data change event will not update
    ''' value to object.</param>
    ''' <param name="opcGlobalDataChangeEventSuppressing">Default is set to false. If individual OPC data
    ''' change event is desired, set this to true</param>
    ''' <remarks>IsSyncronized property is set to true by default. If you would like to fire off the raw OPC data change event
    ''' you should set IsSyncronized to false and use the WithEvents VB keyword to subscribe GlobalDataChangeFromPLC event from the
    ''' OpcComm.Instance</remarks>
    Public Overrides Sub OpenOpcComm(groupName As String, Optional updateRate As Integer = 1000,
                              Optional isSubscribed As Boolean = True, Optional isActive As Boolean = True,
                              Optional isSyncronized As Boolean = True, Optional opcGlobalDataChangeEventSuppressing As Boolean = False)
        If EnableOpcCommunication Then
            Console.WriteLine(String.Format("{0} for group {1} to start", Now.ToString, groupName))
            If _opcGroupDetails.ContainsKey(groupName) Then
                SyncLock OPEN_GROUP_LOCK
                    If Not _opcGroupDetails(groupName).IsGroupConnected Then
                        If Not DoesGroupExistInServer(groupName) Then
                            Throw New Exception("Group is not defined!!")
                        End If
                        ConnectOpcServer(RslinxOpcDaSettings.ServerName, True)
                        SetOpcGroup(groupName, updateRate, isSubscribed)
                        AddOpcItems(groupName, isActive)

                        _opcGroupDetails(groupName).IsGroupSyncronized = isSyncronized
                        _opcGroupDetails(groupName).IsGroupConnected = True
                        _opcGroupDetails(groupName).IsOPCGlobalDataChangeEventSuppressing = opcGlobalDataChangeEventSuppressing
                        If Not (isSubscribed AndAlso isActive) Then
                            For Each item As IOpcObject In _opcGroupDetails(groupName).OPCObjects
                                item.RegisterItems = 9999 'workaround for setting the IsRegisteringInProcess bit to true
                            Next
                        End If
                    End If
                End SyncLock
                Console.WriteLine(String.Format("{0} for group {1} to finished", Now.ToString, groupName))
            End If
        End If

    End Sub

    Public Async Function OpenOpcCommAsync(Optional updateRate As Integer = 1000) As Task
        If EnableOpcCommunication Then
            If _opcGroupDetails.Count = 0 Then
                Throw New Exception("No group was defined to add to the Opc!!!")
            End If

            Dim OpenCommTasks As List(Of Task) = New List(Of Task)

            For Each group As String In _opcGroupDetails.Keys
                Dim t As Task = Task.Run(Sub()
                                             TryUserAction(Sub() OpenOpcComm(group, updateRate))
                                             CalculateRegisteringProcess()
                                         End Sub)
                OpenCommTasks.Add(t)
            Next

            Await Task.WhenAll(OpenCommTasks)
        End If
    End Function

    ''' <summary>
    ''' Set group to be active or not active
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="isActive">Boolean to indicate the desired value</param>
    ''' <remarks></remarks>
    Public Overrides Sub SetGroupActive(groupName As String, isActive As Boolean)
        If _opcGroupDetails(groupName).IsGroupConnected Then
            MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive = isActive
        End If
    End Sub

    ''' <summary>
    ''' Set group to be active or not active
    ''' </summary>
    ''' <param name="parentForm">Name of the parent form</param>
    ''' <param name="isActive">Boolean to indicate the desired value</param>
    ''' <remarks></remarks>
    Public Overloads Sub SetGroupActive(parentForm As IHaveOpcObjects, isActive As Boolean)
        For Each groupName As String In _frmOpcGroupMap(parentForm)
            If _opcGroupDetails(groupName).IsGroupConnected Then
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive = isActive
            End If
        Next
    End Sub

    ''' <summary>
    ''' Set the specified group to subscribe
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="isSubscribed">Boolean value to indicate the desired state</param>
    ''' <remarks></remarks>
    Public Sub SetGroupSubscribed(groupName As String, isSubscribed As Boolean)
        If _opcGroupDetails.ContainsKey(groupName) AndAlso _opcGroupDetails(groupName).IsGroupConnected Then
            MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsSubscribed = isSubscribed
        End If
    End Sub

    ''' <summary>
    ''' Set the specified group to subscribe
    ''' </summary>
    ''' <param name="parentForm">Name of the parent form</param>
    ''' <param name="isSubscribed">Boolean value to indicate the desired state</param>
    ''' <remarks></remarks>
    Public Sub SetGroupSubscribed(parentForm As IHaveOpcObjects, isSubscribed As Boolean)
        For Each groupName As String In _frmOpcGroupMap(parentForm)
            If _opcGroupDetails.ContainsKey(groupName) AndAlso _opcGroupDetails(groupName).IsGroupConnected Then
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsSubscribed = isSubscribed
            End If
        Next
    End Sub

    Public Sub SetGroupSynchronized(groupName As String, isSyncronized As Boolean)
        If _opcGroupDetails(groupName).IsGroupConnected Then
            _opcGroupDetails(groupName).IsGroupSyncronized = isSyncronized
        End If
    End Sub

    ''' <summary>
    ''' Set group update rate
    ''' </summary>
    ''' <param name="groupName">Name of the group</param>
    ''' <param name="updateRate">Update rate in milliseconds</param>
    ''' <remarks></remarks>
    Public Sub SetGroupUpdateRate(groupName As String, updateRate As Integer)
        If _opcGroupDetails(groupName).IsGroupConnected Then
            MyOpcServer.OPCGroups.GetOPCGroup(groupName).UpdateRate = updateRate
        End If
    End Sub

    Public Overrides Function TryCloseOpcComm() As Boolean
        Try
            CloseOpcComm()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub CalculateRegisteringProcess()
        Dim progress As Integer = _numberOfItemsConnectedToOpc / _opcItems.Count * 100
        If progress > 100 Then
            progress = 100
        End If
        RaiseMultiThreadedEvent(RegisteringProgressEvent, New Object() {Me, New OpcItemRegisteringProgressEventArgs(progress)})
    End Sub

    Private Sub DisconnectOpcServer()
        MyOpcServer.Disconnect()
    End Sub

    Private Overloads Sub OpenOpcComm(data As Object)
        SyncLock OPEN_GROUP_LOCK
            Dim y As OpcGroupDefinition = CType(data, OpcGroupDefinition)
            If Not _opcGroupDetails.ContainsKey(y.GroupName) Then
                Throw New Exception(String.Format("Group '{0}' is not defined!!", y.GroupName))
            End If
            If Not _opcGroupDetails(y.GroupName).IsGroupConnected Then
                If Not DoesGroupExistInServer(y.GroupName) Then Throw New ArgumentException("Group is not defined!!")
                ConnectOpcServer("RSLinx Remote OPC Server", True)
                SetOpcGroup(y.GroupName, y.UpdateRate, y.IsSubscribed)
                AddOpcItems(y.GroupName, y.IsActive)
                _opcGroupDetails(y.GroupName).IsGroupSyncronized = y.IsSyncronized
                _opcGroupDetails(y.GroupName).IsGroupConnected = True
                If Not (y.IsSubscribed AndAlso y.IsActive) Then
                    For Each item As IOpcObject In _opcGroupDetails(y.GroupName).OPCObjects
                        item.RegisterItems = 9999 'Workaround for setting the IsRegisteringInProcess bit to true
                    Next
                End If
            End If
        End SyncLock
    End Sub

#End Region

    ''' <summary>
    ''' Get current transaction ID and also advance the ID index
    ''' </summary>
    ''' <returns>Current transaction ID</returns>
    ''' <remarks></remarks>
    Private Shared Function GetCurrentOpcTransactionID() As Integer
        Dim currentTransactionID As Integer = OpcTransactionIDIndex
        OpcTransactionIDIndex += 1
        Return currentTransactionID
    End Function

    Private Sub _myOpcGroup_AsyncReadComplete(TransactionID As Integer, NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array, ByRef Errors As System.Array)
        Dim groupName As String = _asyncGroupPendingTable(TransactionID)
        Dim listOfOpcObjects As List(Of IOpcObject) = FillItemValuesToObjects(groupName, NumItems, ClientHandles, ItemValues, TimeStamps)
        SyncLock ASYNC_GROUP_LOCK
            _asyncGroupPendingTable.Remove(TransactionID)
        End SyncLock
        RaiseEvent AsyncReadCompleted(groupName, listOfOpcObjects)
    End Sub

#End Region

End Class

Public MustInherit Class OpcCommBase
    Inherits SingletonProviderBase(Of OpcComm)
    Implements IOpcComm

    ''' <summary>
    ''' This will only fire when property "IsSyncronized" is set to true
    ''' </summary>
    ''' <param name="groupName">Name of the group for this data change event.</param>
    ''' <param name="listOfOpcObjects">
    ''' List of OPC items that were changed during the data change event.
    ''' </param>
    ''' <remarks>"IsSyncronized" is set to true by default</remarks>
    Public Event GlobalDataChangeEvent(groupName As String, listOfOpcObjects As List(Of IOpcObject)) Implements IOpcComm.GlobalDataChangeEvent

    Public Event OpcServerStateError(serverState As Boolean) Implements IOpcComm.OpcServerStateError

    Public MustOverride Property IsApplicationClosing As Boolean Implements IOpcComm.IsApplicationClosing

    Public MustOverride Function AddOpcObject(opcObject As IOpcObject) As Integer Implements IOpcComm.AddOpcObject

    Public MustOverride Function AddOpcObject(Of T As IOpcObject)(plcName As String, tagName As String, groupName As String) As T Implements IOpcComm.AddOpcObject

    Public MustOverride Function AddOpcObject(Of T As IOpcObject)(plcName As String, tagName As String, groupName As String, parentForm As IHaveOpcObjects) As T Implements IOpcComm.AddOpcObject

    Public MustOverride Sub AddOpcObjects(ParamArray opcObjects() As IOpcObject) Implements IOpcComm.AddOpcObjects

    Public MustOverride Function AsyncWrite(groupName As String) As Integer Implements IOpcComm.AsyncWrite

    Public MustOverride Sub CloseOpcComm() Implements IOpcComm.CloseOpcComm

    Public MustOverride Sub CloseOpcComm(groupName As String, clearClientHandles As Boolean) Implements IOpcComm.CloseOpcComm

    Public MustOverride Function GetAllTagNames() As String() Implements IOpcComm.GetAllTagNames

    Public MustOverride Function GetNumberOfOpcItems() As Integer Implements IOpcComm.GetNumberOfOpcItems

    Public MustOverride Function IsServerRunning() As Boolean Implements IOpcComm.IsServerRunning

    Public MustOverride Sub OpenOpcComm() Implements IOpcComm.OpenOpcComm

    Public MustOverride Sub OpenOpcComm(groupName As String, Optional updateRate As Integer = 1000, Optional isSubscribed As Boolean = True, Optional isActive As Boolean = True, Optional isSyncronized As Boolean = True, Optional opcGlobalDataChangeEventSuppressing As Boolean = False) Implements IOpcComm.OpenOpcComm

    Public MustOverride Sub OpenOpcComm(frm As IHaveOpcObjects, Optional updateRate As Integer = 1000) Implements IOpcComm.OpenOpcComm

    Public MustOverride Sub SetGroupActive(groupName As String, isActive As Boolean) Implements IOpcComm.SetGroupActive

    Public MustOverride Function SyncWrite(groupName As String) As Integer Implements IOpcComm.SyncWrite

    Public MustOverride Function TryCloseOpcComm() As Boolean Implements IOpcComm.TryCloseOpcComm

    Protected Sub OnRaiseGlobalDataChangeEvent(groupName As String, listOfOpcObjects As IEnumerable(Of IOpcObject))
        RaiseEvent GlobalDataChangeEvent(groupName, listOfOpcObjects)
    End Sub

    Protected Sub OnRaiseMultiThreadedGlobalDataChangeEvent(groupName As String, listOfOpcObjects As IEnumerable(Of IOpcObject))
        RaiseMultiThreadedEvent(GlobalDataChangeEventEvent, New Object() {groupName, listOfOpcObjects})
    End Sub

    Protected Sub OnRaiseOpcServerStateError(IsServerRunning)
        RaiseEvent OpcServerStateError(IsServerRunning)
    End Sub

End Class