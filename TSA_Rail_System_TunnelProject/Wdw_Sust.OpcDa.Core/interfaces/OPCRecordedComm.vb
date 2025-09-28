Imports DotNetRsiOpcAuto

Imports WDW_SUST.Textile.LINT.DAL.Core
Imports WDW_SUST.Textile.LINT.OPC.Core.EventArgs
Imports WDW_SUST.Util.Communication

Imports System.Linq
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization

Namespace Textile.LINT.OPC.Core
    Public Class OPCRecordedComm
        Inherits LINTSingletonProviderBase(Of OPCRecordedComm)
        Implements IOPCComm

#Region "Fields"

        Private Shared ReadOnly _listOfGroups As New Dictionary(Of String, OPCGroup)()
        ''' <summary>
        ''' RSLinx Server
        ''' </summary>
        ''' <remarks></remarks>

        Private ReadOnly _opcItems As New OPCItemDictionary()
        Private ReadOnly _opcItemObjects As New OPCObjectDictionary()
        Private Shared _isApplicationClosing As Boolean
        Private Shared _LINXGatewayServerName As String = ""
        Private Shared _useRemoteGateway As Boolean
        Private Shared OPCClientHandleIndex As Integer = 1
        Private Shared OPCTransactionIDIndex As Integer = 1
        Private Shared OPCObjectHandle As Integer
        Private Shared _enableOPCCommunication As Boolean = True
        Private Shared _printTagNameWhenDebug As Boolean
        Private Shared ReadOnly _frmOPCGroupMap As New Dictionary(Of Form, List(Of String))()
        Private Shared ReadOnly _queue As New Queue(Of OPCIncomingData)()
        Private Shared _isListeningToIncomingData As Boolean
        Private Shared _updateTime As DateTime
        Private Shared ReadOnly ASYNC_GROUP_LOCK As New Object
        Private Shared ReadOnly QUEUE_LOCK As New Object
        Private Shared _threadMode As OPCThreadMode = OPCThreadMode.SINGLE_THREADED
        Private Shared _dataProcessedCount As Long

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

        ''' <summary>
        ''' Dictionary(Of groupName, groupProperties)
        ''' </summary>
        ''' <remarks></remarks>
        Private ReadOnly _opcGroupDetails As New Dictionary(Of String, OPCGroupProperties)()
        Private _numberOfItemsConnectedToOPC As Integer

        'Public constants
        Public Const OPC_DS_CACHE As Integer = 1
        Public Const OPC_DS_DEVICE As Integer = 2
        Private _isInitializingOPCCommunication As Boolean = True
#End Region

#Region "Events"
        'Public Events
        ''' <summary>
        ''' This will only fire when property "IsSyncronized" is set to false
        ''' </summary>
        ''' <param name="TransactionID">Transaction ID assigned by the caller</param>
        ''' <param name="GroupHandle">Handle of the group</param>
        ''' <param name="NumItems">Number of items returned from the data change event</param>
        ''' <param name="ClientHandles">Array of client handles for the data change event</param>
        ''' <param name="ItemValues">Array of Item values. The index of the array goes with the array of client handles</param>
        ''' <param name="Qualities"></param>
        ''' <param name="TimeStamps">When the data change event received from the PLC</param>
        ''' <remarks>"IsSyncronized" is set to true by default</remarks>
        Public Event GlobalDataChangeFromPLC(ByVal TransactionID As Integer, ByVal GroupHandle As Integer, ByVal NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array) Implements IOPCComm.GlobalDataChangeFromPLC

        ''' <summary>
        ''' This will only fire when property "IsSyncronized" is set to true
        ''' </summary>
        ''' <param name="groupName">Name of the group for this data change event.</param>
        ''' <param name="listOfOPCObjects">List of opc items that were changed during the data change event.</param>
        ''' <remarks>"IsSyncronized" is set to true by default</remarks>
        Public Event GlobalDataChangeEvent(ByVal groupName As String, ByRef listOfOPCObjects As List(Of IOPCObject)) Implements IOPCComm.GlobalDataChangeEvent

        ''' <summary>
        ''' This will only fire when property "IsSyncronized" is set to false
        ''' </summary>
        ''' <param name="groupName"></param>
        ''' <param name="listofopcobjects"></param>
        ''' <remarks></remarks>
        Public Event GroupDataChangeEvent(ByVal groupName As String, ByRef listOfOPCObjects As List(Of IOPCObject)) Implements IOPCComm.GroupDataChangeEvent

        Public Event GlobalOPCItemChangeEvent(ByVal groupName As String, ByVal listOfNetworkOPCData As List(Of NetworkOPCData)) Implements IOPCComm.GlobalOPCItemChangeEvent
        Public Event RegisteringProgress(ByVal sender As Object, ByVal e As OPCItemRegisteringProgressEventArgs) Implements IOPCComm.RegisteringProgress

        ''' <summary>
        ''' Used to broadcast information related to OPC communication
        ''' </summary>
        ''' <param name="timeStamp">When was the event happened</param>
        ''' <param name="groupName">Name of the group</param>
        ''' <param name="message">Message itself</param>
        ''' <param name="infoType">What kind of the message</param>
        ''' <remarks></remarks>
        Public Event OPCCommStatus(ByVal timeStamp As DateTime, ByVal groupName As String, ByVal message As String, ByVal infoType As OPC_COMM_TYPE) Implements IOPCComm.OPCCommStatus

        Public Event AsyncRefreshFinished(ByVal groupName As String) Implements IOPCComm.AsyncRefreshFinished
        ''' <summary>
        ''' Raise event when async read is completed
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <remarks></remarks>
        Public Event AsyncReadCompleted(ByVal groupName As String, ByRef listOfOPCObjects As List(Of IOPCObject)) Implements IOPCComm.AsyncReadCompleted

        ''' <summary>
        ''' Raise event when async write is completed
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <remarks></remarks>
        Public Event AsyncWriteCompleted(ByVal groupName As String) Implements IOPCComm.AsyncWriteCompleted
#End Region

#Region "Properties"

        ''' <summary>
        ''' This can only be set to false when the developer makes sure that no cross-thread issues will arise from the program. Data collection to be recommended
        ''' to use Multi-threaded
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property ThreadMode As OPCThreadMode
            Get
                Return _threadMode
            End Get
            Set(ByVal value As OPCThreadMode)
                _threadMode = value
            End Set
        End Property

        ''' <summary>
        ''' This will enable or disable OPC communication for debugging purposes. If this is true it will ignore anything related to OPC, such as 
        ''' tag definitions, OPCComm.OpenOPCComm
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property EnableOPCCommunication() As Boolean
            Get
                Return _enableOPCCommunication
            End Get
            Set(ByVal value As Boolean)
                _enableOPCCommunication = value
            End Set
        End Property

        Public Property IsApplicationClosing() As Boolean Implements IOPCComm.IsApplicationClosing
            Get
                Return _isApplicationClosing
            End Get
            Set(ByVal value As Boolean)
                If _isApplicationClosing Then Exit Property
                _isApplicationClosing = value
            End Set
        End Property

        ''' <summary>
        ''' This is only in effect if the remote LINX option is used.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property LINXGatewayServerName() As String
            Get
                Return _LINXGatewayServerName
            End Get
            Set(ByVal value As String)
                _LINXGatewayServerName = value
            End Set
        End Property

        ''' <summary>
        ''' For debugging purposes. This can be set to true to 
        ''' see what the tags are. This is useful information
        ''' when a new class is developed. So you can map the property
        ''' index accordingly.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property PrintTagNameWhenDebug() As Boolean
            Get
                Return _printTagNameWhenDebug
            End Get
            Set(ByVal value As Boolean)
                _printTagNameWhenDebug = value
            End Set
        End Property

        Public Shared Property UseRemoteGateway() As Boolean
            Get
                Return _useRemoteGateway
            End Get
            Set(ByVal value As Boolean)
                _useRemoteGateway = value
            End Set
        End Property

        Public Shared ReadOnly Property HasItemsInQueue As Boolean
            Get
                'If ThreadMode = OPCThreadMode.SINGLE_THREADED Then
                '    Return False
                'End If
                'Dim returnValue As Boolean
                'SyncLock QUEUE_LOCK
                '    returnValue = _queue.Count > 0
                'End SyncLock
                'Return returnValue
                Return ItemsInQueue > 0
            End Get
        End Property

        Public Shared ReadOnly Property ItemsInQueue As Integer
            Get
                If ThreadMode = OPCThreadMode.SINGLE_THREADED Then
                    Return 0
                End If
                Dim returnValue As Integer
                SyncLock QUEUE_LOCK
                    returnValue = _queue.Count
                End SyncLock
                Return returnValue
            End Get
        End Property

        Public Shared ReadOnly Property ProcessCount As Long
            Get
                Return _dataProcessedCount
            End Get
        End Property

#End Region

#Region "Members"

        Friend Function GetOPCTagWithHandle(ByVal groupName As String) As List(Of OPCItemKey)
            Dim listOfKey As New List(Of OPCItemKey)
            For Each o As KeyValuePair(Of OPCItemKey, IOPCObject) In _opcItems
                If o.Key.GroupName = groupName Then
                    listOfKey.Add(o.Key)
                End If
            Next
            Return listOfKey
        End Function

#Region "Private"

        Private Sub _myOPCGroup_AsyncWriteComplete(ByVal TransactionID As Integer, ByVal NumItems As Integer, ByRef ClientHandles As System.Array, ByRef Errors As System.Array)
            Dim groupName As String = _asyncGroupPendingTable(TransactionID)
            SyncLock ASYNC_GROUP_LOCK
                _asyncGroupPendingTable.Remove(TransactionID)
                _asyncPendingItems.Remove(groupName)
            End SyncLock
            RaiseEvent AsyncWriteCompleted(groupName)
        End Sub

        Private Sub RecordTagInfo(ByVal timeStamp As Long, ByVal plcTag As String, ByVal value As Object)
            Dim data As New OPCLogData With {.PLCTag = plcTag, .Value = value, .TimeStamp = timeStamp}
            Dim fs As New FileStream("def.txt", FileMode.Append, FileAccess.Write)
            Try
                Dim bytes As Byte() = WDW_SUST.Util.Serialization.SerializationManager.SerializeData(data)
                fs.Write(bytes, 0, bytes.Length)
                fs.Close()
            Catch ex As Exception

            End Try
        End Sub

        Public Function GetOPCGroupProperties(ByVal groupName As String) As OPCGroupProperties Implements IOPCComm.GetOPCGroupProperties
            If OPCComm.EnableOPCCommunication AndAlso groupName IsNot Nothing Then
                If _opcGroupDetails.ContainsKey(groupName) Then
                    Return _opcGroupDetails(groupName)
                Else
                    Throw New Exception("The group does not exist in the OPCComm object!")
                End If
            Else
                Return Nothing
            End If
        End Function

        Private Sub RaiseOPCCommStatusEvent(ByVal time As DateTime, ByVal groupName As String, ByVal message As String, ByVal commType As OPC_COMM_TYPE)
            If OPCComm.ThreadMode = OPCThreadMode.MULTI_THREADED Then
                LINTFunctions.RaiseMultiThreadedEvent(OPCCommStatusEvent, New Object() {time, groupName, message, commType})
            Else
                RaiseEvent OPCCommStatus(time, groupName, message, commType)
            End If
        End Sub


        Private Function FillItemValuesToObjects(ByVal logData As List(Of OPCLogData)) As List(Of IOPCObject)
            Dim listOfItems As New List(Of IOPCObject)
            Dim tempIndex As Integer
            Dim opcItem As IOPCObject
            Dim key As OPCItemKey
            For Each item As OPCLogData In logData
                'Get the opc item from the OPCComm object by the client handles
                'key contains PLC tag, client handle, server handle and the value to be inserted
                key = _opcItems.GetKey(item.PLCTag)
                opcItem = _opcItems(key)
                'Get the value returned from the data change event
                key.Value = item.Value
                'Get the index from the specific class
                tempIndex = opcItem.GetPropertyIndex(key.PLCTagName)
                'Update the value from the PLC to the class property
                opcItem.ValueFromPLCToObject(tempIndex, key.Value)
                If OPCComm.PrintTagNameWhenDebug Then
                    Console.WriteLine(String.Format("{0}: Value:{1}", key.PLCTagName, key.Value)) 'with index of {2}", tempPLCTag, tempValue, tempIndex))
                End If
                If Not listOfItems.Contains(opcItem) Then
                    opcItem.TimeStamp = New DateTime(item.TimeStamp)
                    listOfItems.Add(opcItem)
                End If
                _dataProcessedCount += 1
            Next
            Return listOfItems
        End Function

        Private Sub ProcessData(ByVal data As List(Of OPCLogData))
            Dim listOfOPCObjects As List(Of IOPCObject) = FillItemValuesToObjects(data)
            If listOfOPCObjects.Count > 0 Then
                For Each item As IOPCObject In listOfOPCObjects
                    item.RaisePropertiesUpdatedEvent(System.EventArgs.Empty)
                    'WDW_SUST.Util.Serialization.SerializationManager.SerializeToFile("abc.txt", item)
                    'TODO: Sum - Should I remove the item if it has its own property change event fired??
                Next
                If ThreadMode = OPCThreadMode.MULTI_THREADED Then
                    LINTFunctions.RaiseMultiThreadedEvent(GlobalDataChangeEventEvent, New Object() {String.Empty, listOfOPCObjects})
                Else
                    RaiseEvent GlobalDataChangeEvent(String.Empty, listOfOPCObjects)
                End If
            End If
        End Sub

        Private Sub AddOPCItems(ByVal groupName As String, ByVal isActive As Boolean)
            '====================================================================================================
            '   Step 3: Add OPC items to group
            '====================================================================================================
            RaiseOPCCommStatusEvent(Now, Nothing, String.Format("Add OPC items to group {0} is in progress", groupName), OPC_COMM_TYPE.OPCCommStatus)
            Try
                Dim count() As Integer = {_opcGroupDetails(groupName).GetListOfTags.Count}
                Dim lowerBound() As Integer = {1}
                Dim listOfTags As System.Array = Array.CreateInstance(GetType(String), count, lowerBound)
                Dim errors As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)

                Dim serverHandles As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
                Dim clientHandles As System.Array = Array.CreateInstance(GetType(Integer), count, lowerBound)
                Dim index As Integer = 1
                For Each pair As KeyValuePair(Of String, Integer) In _opcGroupDetails(groupName).GetPLCTagNameWithHandles
                    listOfTags.SetValue(CStr(pair.Key), index)
                    clientHandles.SetValue(CInt(pair.Value), index)
                    index += 1
                Next

                If OPCComm.ThreadMode = OPCThreadMode.MULTI_THREADED AndAlso Not _isListeningToIncomingData Then
                    _isListeningToIncomingData = True
                    'Listening to incoming OPC data
                    LINTFunctions.CreateAndRunBackgroundThread(AddressOf ProcessMultiThreadedIncomingOPCData)
                End If

            Catch ex As System.Runtime.InteropServices.COMException
                Throw New OPCComExceptions(OPCComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode)
            End Try
            _numberOfItemsConnectedToOPC += _opcGroupDetails(groupName).GetListOfTags.Count
            RaiseEvent OPCCommStatus(Now, Nothing, String.Format("OPC items added to group {0} successfully", groupName), OPC_COMM_TYPE.OPCCommStatus)
        End Sub

        Private Sub ProcessMultiThreadedIncomingOPCData()
            While True
                If _queue.Count > 0 Then
                    Try
                        Dim data As OPCIncomingData
                        SyncLock QUEUE_LOCK
                            data = _queue.Dequeue
                            Console.WriteLine("Unloading {0} items - {1} Events pending", data.ClientHandles.Length, _queue.Count)
                        End SyncLock

                        If data.GroupHandle > 0 Then 'Why GroupHandle = 0 ???
                            'ProcessData (data.TransactionID, data.GroupHandle, data.NumItems, data.ClientHandles, data.ItemValues, data.Qualities, data.TimeStamps)
                        End If
                    Catch ex As Exception
                        WriteLog(String.Format("{0}, {1}", Now.ToString, ex.Message), My.Application.Info.ProductName)
                    End Try
                End If
                Threading.Thread.Sleep(50)
            End While
        End Sub

        Private Function AssignClientHandle() As Integer
            Dim i As Integer = 0
            Do
                i = GetRandomNumber()
            Loop Until Not _opcItems.ContainsKey(i)
            Return i
        End Function

        Private Function DoesGroupExistInServer(ByVal groupName As String) As Boolean
            If _opcGroupDetails.ContainsKey(groupName) Then
                Return True
            End If
            Return False
        End Function

     
#End Region

#Region "Public"

        'Private Sub _myOPCGroup_DataChange(ByVal TransactionID As Integer, ByVal NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array)
        '    Dim groupName As String = _asyncGroupPendingTable(TransactionID)
        '    _asyncGroupPendingTable.Remove(TransactionID)
        '    FillItemValuesToObjects(groupName, NumItems, ClientHandles, ItemValues, Qualities, TimeStamps)
        '    RemoveHandler MyOPCServer.OPCGroups.Item(groupName).DataChange, AddressOf _myOPCGroup_DataChange
        'End Sub

        Public Function GetAllTagNames(ByVal groupName As String) As String() Implements IOPCComm.GetAllTagNames
            Return _opcGroupDetails(groupName).GetPLCTagNames.ToArray
        End Function
        ''' <summary>
        ''' Use to tell if the objects in the group is synchronized with the PLC values
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsGroupSynchronized(ByVal groupName As String) As Boolean Implements IOPCComm.IsGroupSynchronized
            Return _opcGroupDetails(groupName).IsGroupSyncronized
        End Function

        Public Function ContainsGroup(ByRef frm As Form, ByVal groupName As String) Implements IOPCComm.ContainsGroup
            If _frmOPCGroupMap.ContainsKey(frm) Then
                For Each s As String In _frmOPCGroupMap(frm)
                    If s.ToLower = groupName.ToLower Then
                        Return True
                    End If
                Next
            End If
            Return False
        End Function

        Public Function GetListOfOPCObjectsByGroup(ByVal groupName As String) As List(Of IOPCObject) Implements IOPCComm.GetListOfOPCObjectsByGroup
            'Dim list As New List(Of IOPCObject)
            'For Each opcObjectKey As OPCObjectKey In _opcItemObjects.Keys
            '    If opcObjectKey.GroupName = groupName Then
            '        list.Add(_opcItemObjects(opcObjectKey))
            '    End If
            'Next
            'Return list
            Return _opcGroupDetails(groupName).OPCObjects
        End Function

        Public Function GetNumberOfOPCItems() As Integer Implements IOPCComm.GetNumberOfOPCItems
            Return _opcItems.Count
        End Function

      
        ''' <summary>
        ''' Used to add item to the OPC instance for OPC communication
        ''' </summary>
        ''' <param name="opcItem">Item to be added</param>
        ''' <remarks></remarks>
        <Obsolete("Use AddOPCObject instead")> _
        Public Sub AddOPCItem(ByVal opcItem As IOPCObject) Implements IOPCComm.AddOPCItem
            Dim t As Array = opcItem.GetPLCTagNames
            If Not _opcGroupDetails.ContainsKey(opcItem.GroupName) Then
                _opcGroupDetails.Add(opcItem.GroupName, New OPCGroupProperties)
            End If
            'Add a reference to the OPCGroupDetails
            _opcGroupDetails(opcItem.GroupName).AddOPCItemObjectToList(opcItem)
            For Each s As String In t
                Dim tempHandle As Integer = AssignClientHandle()
                _opcItems.Add(New OPCItemKey(tempHandle, opcItem.GroupName, s), opcItem)
                _opcGroupDetails.Item(opcItem.GroupName).AddTag(s, tempHandle)
            Next
            _opcItemObjects.Add(New OPCObjectKey(opcItem.PLCName, opcItem.TagName, opcItem.GroupName), opcItem)
        End Sub

        ''' <summary>
        ''' Used to add item to the OPC instance for OPC communication. IMPORTANT!! If the parent form which owns this object and also inherits
        ''' from LINTOPCFormBase, make sure to use AddOPCObject(ByVal opcItem as IOPCObject, ByVal parentForm As Form) instead!!
        ''' </summary>
        ''' <param name="opcObject">Item to be added - Look at summary for reference on how to use this subroutine</param>
        ''' <remarks></remarks>
        Public Function AddOPCObject(ByVal opcObject As IOPCObject) As Integer Implements IOPCComm.AddOPCObject
            If EnableOPCCommunication Then
                Dim t As Array = opcObject.GetPLCTagNames
                If Not _opcGroupDetails.ContainsKey(opcObject.GroupName) Then
                    _opcGroupDetails.Add(opcObject.GroupName, New OPCGroupProperties)
                End If
                'Add a reference to the OPCGroupDetails
                _opcGroupDetails(opcObject.GroupName).AddOPCItemObjectToList(opcObject)
                For Each s As String In t
                    Dim tempHandle As Integer = OPCClientHandleIndex
                    OPCClientHandleIndex += 1
                    If OPCComm.PrintTagNameWhenDebug Then
                        Console.WriteLine(String.Format("{0}: Handle:{1}", s, tempHandle))
                    End If
                    If Not _opcGroupDetails.Item(opcObject.GroupName).AddTag(s, tempHandle) Then Throw New Exception(String.Format("PLC Tag Name {0} has already been defined in the group {1}", s, opcObject.GroupName))
                    _opcItems.Add(New OPCItemKey(tempHandle, opcObject.GroupName, s), opcObject)
                Next
                _opcItemObjects.Add(New OPCObjectKey(opcObject.PLCName, opcObject.TagName, opcObject.GroupName), opcObject)
                OPCObjectHandle += 1
                Return OPCObjectHandle
            End If
        End Function

        ''' <summary>
        ''' Used to add item to the OPC instance for OPC communication. It is very important that if the 
        ''' parent form inherits from LINTOPCFormBase, the second argument needs to be set to the parent form itself
        ''' to make sure all groups in the form will be closed properly.
        ''' </summary>
        ''' <param name="opcItem">Item to be added - Look at summary for reference on how to use this subroutine</param>
        ''' <param name="parentForm">Form object which has the group of the opc object and also inherits from LINTOPCFormBase</param>
        ''' <remarks></remarks>
        Public Sub AddOPCObject(ByVal opcItem As IOPCObject, ByVal parentForm As Form) Implements IOPCComm.AddOPCObject
            If EnableOPCCommunication Then
                If _frmOPCGroupMap.ContainsKey(parentForm) Then
                    If Not _frmOPCGroupMap(parentForm).Contains(opcItem.GroupName) Then
                        _frmOPCGroupMap(parentForm).Add(opcItem.GroupName)
                    End If
                Else
                    _frmOPCGroupMap.Add(parentForm, New List(Of String))
                    _frmOPCGroupMap(parentForm).Add(opcItem.GroupName)
                End If
            End If
            AddOPCObject(opcItem)
        End Sub

        ''' <summary>
        ''' Close all active OPC groups in the server and then disconnect from it.
        ''' </summary>
        ''' <remarks>This is only called when the application is going to shut down.
        ''' Otherwise, call CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        ''' </remarks>
        Public Sub CloseOPCComm() Implements IOPCComm.CloseOPCComm

        End Sub

        Public Function TryCloseOPCComm() As Boolean Implements IOPCComm.TryCloseOPCComm
            Try
                CloseOPCComm()
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

        ''' <summary>
        ''' Close the OPC group specified
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <param name="clearClientHandles">Determine if clearing the client handles in the memory buffer is needed</param>
        ''' <remarks>This is only called when the application is going to shut down.
        ''' Otherwise, call CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        ''' </remarks>
        Public Sub CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) Implements IOPCComm.CloseOPCComm
            If EnableOPCCommunication Then
                If _opcGroupDetails.ContainsKey(groupName) Then
                    If clearClientHandles Then
                        For Each handle As Integer In _opcGroupDetails.Item(groupName).GetClientHandles
                            For Each key As OPCItemKey In _opcItems.Keys
                                If key.ClientHandle = handle Then
                                    _opcItems.Remove(key)
                                    Exit For
                                End If
                            Next
                        Next
                        _numberOfItemsConnectedToOPC -= _opcGroupDetails.Item(groupName).GetPLCTagCounts
                    End If
                    _opcGroupDetails(groupName).Dispose()
                    _opcGroupDetails.Remove(groupName)
                    _opcItemObjects.Remove(groupName)
                End If
            End If
        End Sub

        'TODO: This is for testing purposes and will need to be removed.
        Public Function GetOPCItemTagNames() As List(Of String) Implements IOPCComm.GetOPCItemTagNames
            For Each obj As OPCItemKey In _opcItems.Keys
                Console.WriteLine(obj.PLCTagName)
            Next
            Return Nothing
        End Function

        'TODO: This is for testing purposes and will need to be removed.
        Public Function GetOPCObjectTagNames() As List(Of String) Implements IOPCComm.GetOPCObjectTagNames
            Throw New NotImplementedException
        End Function

        ''' <summary>
        ''' Close the OPC group specified
        ''' </summary>
        ''' <param name="parentForm">Parent object which as the group resides in it</param>
        ''' <remarks>This is only called when the application is going to shut down.
        ''' Otherwise, call CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        ''' </remarks>
        Public Sub CloseOPCComm(ByVal parentForm As Form) Implements IOPCComm.CloseOPCComm
            If EnableOPCCommunication AndAlso _frmOPCGroupMap.ContainsKey(parentForm) Then
                For Each group As String In _frmOPCGroupMap(parentForm)
                    CloseOPCComm(group, True)
                Next
                _frmOPCGroupMap.Remove(parentForm)
                parentForm = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Open OPC communication for all groups existed in _opcGroupDetails
        ''' which have not called the OpenOPCComm subroutine yet
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub OpenOPCComm() Implements IOPCComm.OpenOPCComm
            Threading.ThreadPool.QueueUserWorkItem(AddressOf LoadPlaybackData)
        End Sub

        Private _logData As New Dictionary(Of Long, List(Of OPCLogData))
        Private _logDataLoaded As Boolean
        Private Sub LoadPlaybackData()
            If Not _logDataLoaded Then
                Dim fs As New FileStream("C:\Documents and Settings\yeunc009\My Documents\Visual Studio 2010\Projects\TSA_Rail_System\TSA_Rail_System\bin\Release\def.txt", FileMode.Open)
                Try
                    Dim formatter As New BinaryFormatter
                    Dim data As OPCLogData
                    While fs.Position < fs.Length
                        data = formatter.Deserialize(fs)
                        If Not _logData.ContainsKey(data.TimeStamp) Then _logData.Add(data.TimeStamp, New List(Of OPCLogData))
                        _logData(data.TimeStamp).Add(data)
                    End While
                    fs.Close()
                Catch a As SerializationException
                    Console.WriteLine("Failed to deserialize. Reason: " & a.Message)
                    Throw
                Finally
                    fs.Close()
                    _logDataLoaded = True
                End Try
            End If
        End Sub
        Private _isPlaybackStarted As Boolean
        Private _timeOrigin As Long
        Public Sub PlayStep()
            Threading.ThreadPool.QueueUserWorkItem(AddressOf AsyncPlayStep)
        End Sub

        Private Sub AsyncPlayStep()
            If _logDataLoaded Then
                Dim i As List(Of OPCLogData)
                Dim deltaTime As Integer
                While _logData.Count > 0
                    _timeOrigin = _logData.Keys.ElementAt(0)
                    i = _logData.ElementAt(0).Value
                    _logData.Remove(i(0).TimeStamp)
                    deltaTime = CInt((_logData.Keys.ElementAt(0) - _timeOrigin) / 10000)
                    ProcessData(i)
                    Threading.Thread.Sleep(deltaTime)
                End While
            End If
        End Sub

        ''' <summary>
        ''' Open OPC communication for all groups reside in the frm object
        ''' </summary>
        ''' <param name="frm">Form object which contains all intended groups for communication</param>
        ''' <param name="updateRate">Update rate for all group inside of the form</param>
        ''' <remarks></remarks>
        Public Sub OpenOPCComm(ByVal frm As Form, Optional ByVal updateRate As Integer = 1000) Implements IOPCComm.OpenOPCComm
            Threading.ThreadPool.QueueUserWorkItem(AddressOf LoadPlaybackData)
        End Sub

        '''<summary>
        ''' Use to set different property for the group specified. If default properties are used
        ''' We should only call OpenOPCComm to open all groups at the same time
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <param name="updateRate">Group update rate</param>
        ''' <param name="isSubscribed">Is the group subscribed</param>
        ''' <param name="isActive">Is the group active</param>
        ''' <param name="isSyncronized">Set to see if the data from VB is in sync with data from PLC
        ''' through the data change event. If value is set to false, the data change event will not update
        ''' value to object.</param>
        ''' <param name="opcGlobalDataChangeEventSuppressing">Default is set to false. If individual opc data
        ''' change event is desired, set this to true</param>
        ''' <remarks>IsSyncronized property is set to true by default. If you would like to fire off the raw opc data change event
        ''' you should set IsSyncronized to false and use the WithEvents VB keyword to subscribe GlobalDataChangeFromPLC event from the 
        ''' OPCComm.Instance</remarks>
        Public Sub OpenOPCComm(ByVal groupName As String, Optional ByVal updateRate As Integer = 1000, _
                               Optional ByVal isSubscribed As Boolean = True, Optional ByVal isActive As Boolean = True, _
                               Optional ByVal isSyncronized As Boolean = True, Optional ByVal opcGlobalDataChangeEventSuppressing As Boolean = False) Implements IOPCComm.OpenOPCComm
            Threading.ThreadPool.QueueUserWorkItem(AddressOf LoadPlaybackData)
        End Sub

        Public Sub SetGroupSyncronized(ByVal groupName As String, ByVal isSyncronized As Boolean) Implements IOPCComm.SetGroupSyncronized
            If _opcGroupDetails(groupName).IsGroupConnected Then
                _opcGroupDetails(groupName).IsGroupSyncronized = isSyncronized
            End If
        End Sub
        ''' <summary>
        ''' To determine if the OPC Communication is being initialized.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IsInitializingOPCCommunication() As Boolean Implements IOPCComm.IsInitializingOPCCommunication
            Get
                Return _isInitializingOPCCommunication
            End Get
            Set(ByVal value As Boolean)
                _isInitializingOPCCommunication = value
            End Set
        End Property
#End Region
      
        ''' <summary>
        ''' Get class object from the list
        ''' </summary>
        ''' <param name="plcName">PLC topic name where the tag belongs to</param>
        ''' <param name="opcObjectTagName">Tag name of the class object</param>
        ''' <returns>Class object</returns>
        ''' <remarks>Tag name should be unique.</remarks>
        Public Function GetOPCObject(ByVal plcName As String, ByVal opcObjectTagName As String) As IOPCObject Implements IOPCComm.GetOPCObject
            If _opcItemObjects.Contains(plcName, opcObjectTagName) Then
                Return _opcItemObjects.Item(plcName, opcObjectTagName)
            Else
                Throw New ArgumentException(String.Format("[{0}]{1} can not be found!!", plcName, opcObjectTagName))
            End If
        End Function
#End Region
        Public Function AsyncRead(groupName As String) As Integer Implements IOPCComm.AsyncRead
            Throw New NotImplementedException
        End Function

        Public Function AsyncRefresh(groupName As String) As Integer Implements IOPCComm.AsyncRefresh
            Throw New NotImplementedException
        End Function

        Public Function AsyncWrite(groupName As String) As Integer Implements IOPCComm.AsyncWrite
            Throw New NotImplementedException
        End Function

        Public Function GetGroupNames() As String() Implements IOPCComm.GetGroupNames
            Throw New NotImplementedException
        End Function

        Public Function GetItemValue(groupName As String, plcTagName As String) As Object Implements IOPCComm.GetItemValue
            Throw New NotImplementedException
        End Function

        Public Function GetNumberOfOPCItems1(groupName As String) As Integer Implements IOPCComm.GetNumberOfOPCItems
            Throw New NotImplementedException
        End Function

        Public Function IsGroupActive(groupName As String) As Boolean Implements IOPCComm.IsGroupActive
            Throw New NotImplementedException
        End Function

        Public Function IsGroupSubscribed(groupName As String) As Boolean Implements IOPCComm.IsGroupSubscribed
            Throw New NotImplementedException
        End Function

        Public Function IsServerRunning() As Boolean Implements IOPCComm.IsServerRunning
            Throw New NotImplementedException
        End Function

        Public Sub SetGroupActive(groupName As String, isActive As Boolean) Implements IOPCComm.SetGroupActive
            Throw New NotImplementedException
        End Sub

        Public Sub SetGroupActive(parentForm As System.Windows.Forms.Form, isActive As Boolean) Implements IOPCComm.SetGroupActive
            Throw New NotImplementedException
        End Sub

        Public Sub SetGroupSubscribed(groupName As String, isSubscribed As Boolean) Implements IOPCComm.SetGroupSubscribed
            Throw New NotImplementedException
        End Sub

        Public Sub SetGroupSubscribed(parentForm As System.Windows.Forms.Form, isSubscribed As Boolean) Implements IOPCComm.SetGroupSubscribed
            Throw New NotImplementedException
        End Sub

        Public Sub SetGroupUpdateRate(groupName As String, updateRate As Integer) Implements IOPCComm.SetGroupUpdateRate
            Throw New NotImplementedException
        End Sub

    End Class

    Public Class PlayBackManager
        Private _isPlaying As Boolean
        Private _originTime
        Private _duration As Long
        Private _isDataLoaded As Boolean

        Public Sub Play()
            If Not _isDataLoaded Then
                Throw New InvalidOperationException("LoadData needs to be called!!")
            End If
        End Sub

        Public Sub [Stop]()

        End Sub

        Public Sub PlayStep()

        End Sub

        Private Sub AsyncPlayBack()

        End Sub

        Public ReadOnly Property IsPlaying As Boolean
            Get
                Return _isPlaying
            End Get
        End Property

        Public Sub LoadData(ByVal filePath As String)

        End Sub

    End Class


End Namespace

