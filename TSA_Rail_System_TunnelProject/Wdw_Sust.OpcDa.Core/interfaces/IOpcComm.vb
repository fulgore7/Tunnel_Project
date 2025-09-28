Namespace Interfaces

    ''' <summary>
    ''' Interface to define all the Opc operations how to write and read tags from the Plc processor
    ''' which is in compliance with the Opc Da technology.
    ''' </summary>
    Public Interface IOpcComm

        '''' <summary>
        '''' This will only fire when property "IsSyncronized" is set to false
        '''' </summary>
        '''' <param name="TransactionID">Transaction ID assigned by the caller</param>
        '''' <param name="GroupHandle">Handle of the group</param>
        '''' <param name="NumItems">Number of items returned from the data change event</param>
        '''' <param name="ClientHandles">Array of client handles for the data change event</param>
        '''' <param name="ItemValues">
        '''' Array of Item values. The index of the array goes with the array of client handles
        '''' </param>
        '''' <param name="Qualities"></param>
        '''' <param name="TimeStamps">When the data change event received from the PLC</param>
        '''' <remarks>"IsSyncronized" is set to true by default</remarks>
        'Event GlobalDataChangeFromPLC(ByVal TransactionID As Integer, ByVal GroupHandle As Integer, ByVal NumItems As Integer, ByRef ClientHandles As System.Array, ByRef ItemValues As System.Array, ByRef Qualities As System.Array, ByRef TimeStamps As System.Array)
        ''' <summary>
        ''' This will only fire when property "IsSyncronized" is set to true
        ''' </summary>
        ''' <param name="groupName">Name of the group for this data change event.</param>
        ''' <param name="listOfOpcObjects">
        ''' List of opc items that were changed during the data change event.
        ''' </param>
        ''' <remarks>"IsSyncronized" is set to true by default</remarks>
        Event GlobalDataChangeEvent(groupName As String, listOfOpcObjects As List(Of IOpcObject))

        '''' <summary>
        '''' This will only fire when property "IsSyncronized" is set to false
        '''' </summary>
        '''' <param name="groupName"></param>
        '''' <param name="listOfOpcObjects"></param>
        '''' <remarks></remarks>
        'Event GroupDataChangeEvent(ByVal groupName As String, ByVal listOfOpcObjects As List(Of IOpcObject))

        'Event RegisteringProgress(ByVal sender As Object, ByVal e As OpcItemRegisteringProgressEventArgs)
        '''' <summary>
        '''' Used to broadcast information related to OPC communication
        '''' </summary>
        '''' <param name="timeStamp">When was the event happened</param>
        '''' <param name="groupName">Name of the group</param>
        '''' <param name="message">Message itself</param>
        '''' <param name="infoType">What kind of the message</param>
        '''' <remarks></remarks>
        'Event OpcCommStatus(ByVal timeStamp As DateTime, ByVal groupName As String, ByVal message As String, ByVal infoType As OPC_COMM_TYPE)
        'Event AsyncRefreshFinished(ByVal groupName As String)
        '''' <summary>
        '''' Raise event when async read is completed
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <remarks></remarks>
        'Event AsyncReadCompleted(ByVal groupName As String, ByVal listOfOPCObjects As List(Of IOpcObject))
        '''' <summary>
        '''' Raise event when async write is completed
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <remarks></remarks>
        'Event AsyncWriteCompleted(ByVal groupName As String)
        Event OpcServerStateError(serverState As Boolean)

        Property IsApplicationClosing() As Boolean

        '''' <summary>
        '''' Used to add item to the OPC instance for OPC communication
        '''' </summary>
        '''' <param name="opcItem">Item to be added</param>
        '''' <remarks></remarks>
        'Sub AddOpcItem(ByVal opcItem As IOpcObject)
        ''' <summary>
        ''' Used to add items to the OPC instance for OPC communication. IMPORTANT!! If the parent
        ''' form which owns this object and also inherits from LINTOPCFormBase, make sure to use
        ''' AddOPCObject(ByVal opcItem as IOPCObject, ByVal parentForm As Form) instead!!
        ''' </summary>
        ''' <param name="opcObject">
        ''' Item to be added - Look at summary for reference on how to use this subroutine
        ''' </param>
        ''' <remarks></remarks>
        Function AddOpcObject(opcObject As IOpcObject) As Integer

        '''' <summary>
        '''' Used to add items to the OPC instance for OPC communication. It is very important that
        '''' if the parent form inherits from LINTOPCFormBase, the second argument needs to be set
        '''' to the parent form itself to make sure all groups in the form will be closed properly.
        '''' </summary>
        '''' <param name="opcItem">
        '''' Item to be added - Look at summary for reference on how to use this subroutine
        '''' </param>
        '''' <param name="parentForm">
        '''' Form object which has the group of the opc object and also inherits from LINTOPCFormBase
        '''' </param>
        '''' <remarks></remarks>
        'Sub AddOpcObject(ByVal opcItem As IOpcObject, ByVal parentForm As IHaveOpcObjects)
        ''' <summary>
        ''' Used to add items to the OPC instance for OPC communication.
        ''' </summary>
        ''' <typeparam name="T">Type to create the instance</typeparam>
        ''' <param name="plcName">Topic name of the PLC</param>
        ''' <param name="tagName">Tag name of the PLC</param>
        ''' <param name="groupName">Group name of the PLC</param>
        ''' <returns>The newly created object</returns>
        ''' <remarks></remarks>
        Function AddOpcObject(Of T As IOpcObject)(plcName As String, tagName As String, groupName As String) As T

        ''' <summary>
        ''' Used to add items to the OPC instance for OPC communication.
        ''' </summary>
        ''' <typeparam name="T">Type to create the instance</typeparam>
        ''' <param name="plcName">Topic name of the PLC</param>
        ''' <param name="tagName">Tag name of the PLC</param>
        ''' <param name="groupName">Group name of the PLC</param>
        ''' <returns>The newly created object</returns>
        ''' <remarks></remarks>
        Function AddOpcObject(Of T As IOpcObject)(plcName As String, tagName As String, groupName As String, parentForm As IHaveOpcObjects) As T

        ''' <summary>
        ''' Add more than one object at the same time.
        ''' </summary>
        ''' <param name="opcObjects"></param>
        ''' <remarks></remarks>
        Sub AddOpcObjects(ParamArray opcObjects() As IOpcObject)

        '''' <summary>
        '''' Set group to be active or not active
        '''' </summary>
        '''' <param name="parentForm">Name of the parent form</param>
        '''' <param name="isActive">Boolean to indicate the desired value</param>
        '''' <remarks></remarks>
        'Sub SetGroupActive(ByVal parentForm As IHaveOpcObjects, ByVal isActive As Boolean)
        'Sub SetGroupSynchronized(ByVal groupName As String, ByVal isSyncronized As Boolean)
        '''' <summary>
        '''' Set the specified group to subscribe
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <param name="isSubscribed">Boolean value to indicate the desired state</param>
        '''' <remarks></remarks>
        'Sub SetGroupSubscribed(ByVal groupName As String, ByVal isSubscribed As Boolean)
        '''' <summary>
        '''' Set the specified group to subscribe
        '''' </summary>
        '''' <param name="parentForm">Name of the parent form</param>
        '''' <param name="isSubscribed">Boolean value to indicate the desired state</param>
        '''' <remarks></remarks>
        'Sub SetGroupSubscribed(ByVal parentForm As IHaveOpcObjects, ByVal isSubscribed As Boolean)
        '''' <summary>
        '''' Set group update rate
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <param name="updateRate">Update rate in milliseconds</param>
        '''' <remarks></remarks>
        'Sub SetGroupUpdateRate(ByVal groupName As String, ByVal updateRate As Integer)
        '''' <summary>
        '''' To determine if the OPC Communication is being initialized.
        '''' </summary>
        '''' <value></value>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Property IsInitializingOPCCommunication() As Boolean
        '''' <summary>
        '''' Async read by the group name
        '''' </summary>
        '''' <param name="groupName">Group name to perform read operation</param>
        '''' <returns>Transaction ID for the operation</returns>
        '''' <remarks></remarks>
        'Function AsyncRead(ByVal groupName As String) As Integer
        'Function AsyncRefresh(ByVal groupName As String) As Integer
        ''' <summary>
        ''' Use this to write to items in the OPC in an Async manner
        ''' </summary>
        ''' <param name="groupName">Name of the group to perform async operation</param>
        ''' <returns>The transaction ID for the transaction</returns>
        ''' <remarks>-1 will return if no sync operation executed.</remarks>
        Function AsyncWrite(groupName As String) As Integer

        ''' <summary>
        ''' Close all active OPC groups in the server and then disconnect from it.
        ''' </summary>
        ''' <remarks>
        ''' This is only called when the application is going to shut down. Otherwise, call
        ''' CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        ''' </remarks>
        Sub CloseOpcComm()

        ''' <summary>
        ''' Close the OPC group specified
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <param name="clearClientHandles">
        ''' Determine if clearing the client handles in the memory buffer is needed
        ''' </param>
        ''' <remarks>
        ''' This is only called when the application is going to shut down. Otherwise, call
        ''' CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        ''' </remarks>
        Sub CloseOpcComm(groupName As String, clearClientHandles As Boolean)

        'Function GetOpcGroupProperties(ByVal groupName As String) As OpcGroupProperties
        'Function GetAllTagNames(ByVal groupName As String) As String()
        Function GetAllTagNames() As String()

        '''' <summary>
        '''' Use to tell if the objects in the group is synchronized with the PLC values
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Function IsGroupSynchronized(ByVal groupName As String) As Boolean
        'Function ContainsGroup(ByRef frm As IHaveOpcObjects, ByVal groupName As String) As Boolean
        '''' <summary>
        '''' Get number of items in a group
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <returns>Count in an integer</returns>
        '''' <remarks></remarks>
        'Function GetNumberOfOpcItems(ByVal groupName As String) As Integer
        'Function GetListOfOpcObjectsByGroup(ByVal groupName As String) As List(Of IOpcObject)
        Function GetNumberOfOpcItems() As Integer

        'Function GetOpcItemTagNames() As List(Of String)
        'Function GetOpcObjectTagNames() As List(Of String)
        '''' <summary>
        '''' Close the OPC group specified
        '''' </summary>
        '''' <param name="parentForm">Parent object which as the group resides in it</param>
        '''' <remarks>
        '''' This is only called when the application is going to shut down. Otherwise, call
        '''' CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        '''' </remarks>
        'Sub CloseOpcComm(ByVal parentForm As IHaveOpcObjects)
        '''' <summary>
        '''' Get the value from the PLC and assign it to the object
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <param name="plcTagName">PLC tag name</param>
        '''' <returns>Value of the item in the PLC</returns>
        '''' <remarks></remarks>
        'Function GetItemValue(ByVal groupName As String, ByVal plcTagName As String) As Object
        'Function GetItemValue(ByVal opcItem As IOpcObject, ByVal itemName As String) As Object
        '''' <summary>
        '''' Get all group names which have already connected to the PLC
        '''' </summary>
        '''' <returns>Array of group names</returns>
        '''' <remarks></remarks>
        'Function GetGroupNames() As String()
        '''' <summary>
        '''' Check if group is active
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Function IsGroupActive(ByVal groupName As String) As Boolean
        ''' <summary>
        ''' Check if the server is running
        ''' </summary>
        ''' <returns>Boolean to tell if the OPC server is running</returns>
        ''' <remarks></remarks>
        ''' GetNumberOfOpcItems
        Function IsServerRunning() As Boolean

        '''' <summary>
        '''' Use to tell if the group is subscribed
        '''' </summary>
        '''' <param name="groupName">Name of the group</param>
        '''' <returns>Boolean indicate if the group is subscribed</returns>
        '''' <remarks></remarks>
        'Function IsGroupSubscribed(ByVal groupName As String) As Boolean
        ''' <summary>
        ''' Open OPC communication for all groups existed in _opcGroupDetails which have not called
        ''' the OpenOPCComm subroutine yet
        ''' </summary>
        ''' <remarks></remarks>
        Sub OpenOpcComm()

        ''' <summary>
        ''' Open OPC communication for all groups reside in the frm object
        ''' </summary>
        ''' <param name="frm">Form object which contains all intended groups for communication</param>
        ''' <param name="updateRate">Update rate for all group inside of the form</param>
        ''' <remarks></remarks>
        Sub OpenOpcComm(frm As IHaveOpcObjects, Optional updateRate As Integer = 1000)

        ''' <summary>
        ''' Use to set different property for the group specified. If default properties are used We
        ''' should only call OpenOPCComm to open all groups at the same time
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <param name="updateRate">Group update rate</param>
        ''' <param name="isSubscribed">Is the group subscribed</param>
        ''' <param name="isActive">Is the group active</param>
        ''' <param name="isSyncronized">
        ''' Set to see if the data from VB is in sync with data from PLC through the data change
        ''' event. If value is set to false, the data change event will not update value to object.
        ''' </param>
        ''' <param name="opcGlobalDataChangeEventSuppressing">
        ''' Default is set to false. If individual opc data change event is desired, set this to true
        ''' </param>
        ''' <remarks>
        ''' IsSyncronized property is set to true by default. If you would like to fire off the raw
        ''' opc data change event you should set IsSyncronized to false and use the WithEvents VB
        ''' keyword to subscribe GlobalDataChangeFromPLC event from the OPCComm.Instance
        ''' </remarks>
        Sub OpenOpcComm(groupName As String, Optional updateRate As Integer = 1000, Optional isSubscribed As Boolean = True, Optional isActive As Boolean = True, Optional isSyncronized As Boolean = True, Optional opcGlobalDataChangeEventSuppressing As Boolean = False)

        ''' <summary>
        ''' Set group to be active or not active
        ''' </summary>
        ''' <param name="groupName">Name of the group</param>
        ''' <param name="isActive">Boolean to indicate the desired value</param>
        ''' <remarks></remarks>
        Sub SetGroupActive(groupName As String, isActive As Boolean)

        ''' <summary>
        ''' Use this to write to items in the OPC in a Sync manner
        ''' </summary>
        ''' <param name="groupName">Name of the group to perform async operation</param>
        ''' <returns>The transaction ID for the transaction</returns>
        ''' <remarks>-1 will return if no sync operation executed.</remarks>
        Function SyncWrite(groupName As String) As Integer

        Function TryCloseOpcComm() As Boolean

        '''' <summary>
        '''' Get class object from the list
        '''' </summary>
        '''' <param name="plcName">PLC topic name where the tag belongs to</param>
        '''' <param name="opcObjectTagName">Tag name of the class object</param>
        '''' <returns>Class object</returns>
        '''' <remarks>Tag name should be unique.</remarks>
        'Function GetOpcObject(ByVal plcName As String, ByVal opcObjectTagName As String) As IOpcObject
    End Interface

End Namespace