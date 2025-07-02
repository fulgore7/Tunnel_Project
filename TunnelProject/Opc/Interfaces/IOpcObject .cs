using System.ComponentModel;

namespace TunnelProject.Opc.Interfaces
{
    public interface IOpcObject : IOpcPlcNameLinkable
    {
        /// <summary>
        /// Group name of the item
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        string GroupName { get; set; }
        /// <summary>
        /// Tag number of the item. If this is an UDT the format of the tag would be
        /// [PLC_Topic_Name]TagName.SubTagName.SubSubTagName
        /// </summary>
        /// <value>Name of the tag</value>
        /// <returns></returns>
        /// <remarks></remarks>
        string TagName { get; set; }
        /// <summary>
        /// Time stamp to show when the item was come in
        /// </summary>
        DateTime TimeStamp { get; set; }
        bool IsSerializable { get; }
        /// <summary>
        /// To tell if the object is still loading information to the properties
        /// </summary>
        /// <value>Boolean to tell if it is still registering</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        bool IsRegisteringInProgress { get; }
        [Browsable(false)]
        int RegisterItems { get; set; }

        Dictionary<string, int> ListOfOpcTags { get; }
        string[] FilterProperties { get; }


        /// <summary>
        /// Raise event to tell the object's properties have been changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        event PropertiesUpdateCompletedEventHandler PropertiesUpdateCompleted;

        delegate void PropertiesUpdateCompletedEventHandler(IOpcObject sender, System.EventArgs e);

        /// <summary>
        /// Items registering has been completed. This only fires one time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        event ItemsRegisteringCompletedEventHandler ItemsRegisteringCompleted;

        delegate void ItemsRegisteringCompletedEventHandler(IOpcObject sender, System.EventArgs e);


        /// <summary>
        /// Get the tag name in the opc item format
        /// [PLC_Topic_Name]Item_Name.Sub_Item_Name.Sub_Sub_Item_Name
        /// </summary>
        /// <returns>List of opc items</returns>
        /// <remarks></remarks>
        string[] GetPlcTagNames();
        /// <summary>
        /// This is used to get the tag name of a property in a class.
        /// The format should be [PLCName]TagName.Property.SubProperty etc...
        /// </summary>
        /// <param name="itemName">Should not be included the TagName</param>
        /// <returns>PLC compliance tag name</returns>
        /// <remarks></remarks>
        string GetPlcTagName(string itemName);
        /// <summary>
        /// Get the index of the index so that the OPC server can put value in the right
        /// property
        /// </summary>
        /// <param name="plcTag">PLC tag is in the format of [PLC_Topic_Name]TagName.SubTagName</param>
        /// <returns>Index of the property</returns>
        /// <remarks></remarks>
        int GetPropertyIndex(string plcTag);
        /// <summary>
        /// Create a copy of the object
        /// </summary>
        IOpcObject ShallowClone();
        /// <summary>
        /// Value requested from the PLC and stored in the OPC object
        /// </summary>
        void ValueFromPlcToObject(int index, object value);
        /// <summary>
        /// Value to be put in to the PLC from the OPC object
        /// </summary>
        void ValueFromObjectToPlc(string itemName, object value, bool asyncWrite = false);

        /// <summary>
        /// This is to tell the object to raise an event if any of the property value has been changed in the data
        /// change event
        /// </summary>
        /// <param name="e">Dummy System.EventArgs</param>
        /// <remarks></remarks>
        void RaisePropertiesUpdatedEvent(System.EventArgs e);
    }
    public interface IOpcPlcNameLinkable
    {

        /// <summary>
        /// Topic name in RSLINX. If topic name is not setup, an exception will be thrown
        /// </summary>
        /// <value>name of the topic, usually the name of the PLC</value>
        string PlcName { get; set; }
    }
    /// <summary>
    /// Interface to define all the Opc operations how to write and read tags from the Plc processor which is
    /// in compliance with the Opc Da technology.
    /// </summary>
    public interface IOpcComm
    {
        /// <summary>
        /// This will only fire when property "IsSyncronized" is set to true
        /// </summary>
        /// <param name="groupName">Name of the group for this data change event.</param>
        /// <param name="listOfOpcObjects">List of opc items that were changed during the data change event.</param>
        /// <remarks>"IsSyncronized" is set to true by default</remarks>
        event GlobalDataChangeEventEventHandler GlobalDataChangeEvent;

        delegate void GlobalDataChangeEventEventHandler(string groupName, List<IOpcObject> listOfOpcObjects);

        event OpcServerStateErrorEventHandler OpcServerStateError;

        delegate void OpcServerStateErrorEventHandler(bool serverState);

        bool IsApplicationClosing { get; set; }

        string[] GetAllTagNames();

        int GetNumberOfOpcItems();

        /// <summary>
        /// Used to add items to the OPC instance for OPC communication. IMPORTANT!! If the parent form which owns this object and also inherits
        /// from LINTOPCFormBase, make sure to use AddOPCObject(ByVal opcItem as IOPCObject, ByVal parentForm As Form) instead!!
        /// </summary>
        /// <param name="opcObject">Item to be added - Look at summary for reference on how to use this subroutine</param>
        /// <remarks></remarks>
        int AddOpcObject(IOpcObject opcObject);
        /// <summary>
        /// Add more than one object at the same time.
        /// </summary>
        /// <param name="opcObjects"></param>
        /// <remarks></remarks>
        void AddOpcObjects(params IOpcObject[] opcObjects);

        /// <summary>
        /// Used to add items to the OPC instance for OPC communication.
        /// </summary>
        /// <typeparam name="T">Type to create the instance</typeparam>
        /// <param name="plcName">Topic name of the PLC</param>
        /// <param name="tagName">Tag name of the PLC</param>
        /// <param name="groupName">Group name of the PLC</param>
        /// <returns>The newly created object</returns>
        /// <remarks></remarks>
        T AddOpcObject<T>(string plcName, string tagName, string groupName) where T : IOpcObject;
        /// <summary>
        /// Used to add items to the OPC instance for OPC communication.
        /// </summary>
        /// <typeparam name="T">Type to create the instance</typeparam>
        /// <param name="plcName">Topic name of the PLC</param>
        /// <param name="tagName">Tag name of the PLC</param>
        /// <param name="groupName">Group name of the PLC</param>
        /// <returns>The newly created object</returns>
        /// <remarks></remarks>
        T AddOpcObject<T>(string plcName, string tagName, string groupName, IHaveOpcObjects parentForm) where T : IOpcObject;

        /// <summary>
        /// Close all active OPC groups in the server and then disconnect from it.
        /// </summary>
        /// <remarks>This is only called when the application is going to shut down.
        /// Otherwise, call CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        /// </remarks>
        void CloseOpcComm();

        bool TryCloseOpcComm();
        /// <summary>
        /// Close the OPC group specified
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="clearClientHandles">Determine if clearing the client handles in the memory buffer is needed</param>
        /// <remarks>This is only called when the application is going to shut down.
        /// Otherwise, call CloseOPCComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        /// </remarks>
        void CloseOpcComm(string groupName, bool clearClientHandles);
        /// <summary>
        /// Check if the server is running
        /// </summary>
        /// <returns>Boolean to tell if the OPC server is running</returns>
        /// <remarks></remarks>GetNumberOfOpcItems
        bool IsServerRunning();

        /// <summary>
        /// Open OPC communication for all groups existed in _opcGroupDetails
        /// which have not called the OpenOPCComm subroutine yet
        /// </summary>
        /// <remarks></remarks>
        void OpenOpcComm();
        /// <summary>
        /// Open OPC communication for all groups reside in the frm object
        /// </summary>
        /// <param name="frm">Form object which contains all intended groups for communication</param>
        /// <param name="updateRate">Update rate for all group inside of the form</param>
        /// <remarks></remarks>
        void OpenOpcComm(IHaveOpcObjects frm, int updateRate = 1000);
        /// <summary>
        /// Use to set different property for the group specified. If default properties are used
        /// We should only call OpenOPCComm to open all groups at the same time
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="updateRate">Group update rate</param>
        /// <param name="isSubscribed">Is the group subscribed</param>
        /// <param name="isActive">Is the group active</param>
        /// <param name="isSyncronized">Set to see if the data from VB is in sync with data from PLC
        /// through the data change event. If value is set to false, the data change event will not update
        /// value to object.</param>
        /// <param name="opcGlobalDataChangeEventSuppressing">Default is set to false. If individual opc data
        /// change event is desired, set this to true</param>
        /// <remarks>IsSyncronized property is set to true by default. If you would like to fire off the raw opc data change event
        /// you should set IsSyncronized to false and use the WithEvents VB keyword to subscribe GlobalDataChangeFromPLC event from the
        /// OPCComm.Instance</remarks>
        void OpenOpcComm(string groupName, int updateRate = 1000, bool isSubscribed = true, bool isActive = true, bool isSyncronized = true, bool opcGlobalDataChangeEventSuppressing = false);
        /// <summary>
        /// Set group to be active or not active
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="isActive">Boolean to indicate the desired value</param>
        /// <remarks></remarks>
        void SetGroupActive(string groupName, bool isActive);

        /// <summary>
        /// Use this to write to items in the OPC in an Async manner
        /// </summary>
        /// <param name="groupName">Name of the group to perform async operation</param>
        /// <returns>The transaction ID for the transaction</returns>
        /// <remarks>-1 will return if no sync operation executed.</remarks>
        int AsyncWrite(string groupName);
        /// <summary>
        /// Use this to write to items in the OPC in a Sync manner
        /// </summary>
        /// <param name="groupName">Name of the group to perform async operation</param>
        /// <returns>The transaction ID for the transaction</returns>
        /// <remarks>-1 will return if no sync operation executed.</remarks>
        int SyncWrite(string groupName);
    }

    public interface IHaveOpcObjects
    {
    }
}
