namespace TunnelProject.Opc
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using RsiOPCAuto;
    using System.Security.Cryptography;
    using System.Text;
    using System.Runtime.InteropServices;
    using TunnelProject.Opc.Interfaces;
    using TunnelProject.Opc;
    using Wdw_Sust.Logging;
    public abstract class OpcCommBase : SingletonProviderBase<OpcComm>, IOpcComm
    {
        public abstract bool IsApplicationClosing { get; set; }

        // Fix for CS0738: Ensure the event matches the interface signature  
        public event IOpcComm.GlobalDataChangeEventEventHandler GlobalDataChangeEvent;

        // Fix for CS0738: Ensure the event matches the interface signature  
        public event IOpcComm.OpcServerStateErrorEventHandler OpcServerStateError;

        protected void OnRaiseGlobalDataChangeEvent(string groupName, IEnumerable<IOpcObject> listOfOpcObjects)
        {
            GlobalDataChangeEvent?.Invoke(groupName, (List<IOpcObject>)listOfOpcObjects);
        }

        protected void OnRaiseMultiThreadedGlobalDataChangeEvent(string groupName, IEnumerable<IOpcObject> listOfOpcObjects)
        {
            Helpers.RaiseMultiThreadedEvent(GlobalDataChangeEvent, new object[] { groupName, listOfOpcObjects });
        }

        public abstract void AddOpcObjects(params IOpcObject[] opcObjects);
        public abstract void CloseOpcComm();
        public abstract void CloseOpcComm(string groupName, bool clearClientHandles);
        public abstract void OpenOpcComm();
        public abstract void OpenOpcComm(string groupName, int updateRate = 1000, bool isSubscribed = true, bool isActive = true, bool isSyncronized = true, bool opcGlobalDataChangeEventSuppressing = false);
        public abstract void SetGroupActive(string groupName, bool isActive);
        public abstract string[] GetAllTagNames();
        public abstract int GetNumberOfOpcItems();
        public abstract int AddOpcObject(IOpcObject opcObject);
        public abstract T AddOpcObject<T>(string plcName, string tagName, string groupName) where T : IOpcObject;
        public abstract T AddOpcObject<T>(string plcName, string tagName, string groupName, IHaveOpcObjects parentForm) where T : IOpcObject;
        public abstract bool TryCloseOpcComm();
        public abstract bool IsServerRunning();
        public abstract int AsyncWrite(string groupName);
        public abstract int SyncWrite(string groupName);

        protected void OnRaiseOpcServerStateError(bool IsServerRunning)
        {
            OpcServerStateError?.Invoke(IsServerRunning);
        }

        public abstract void OpenOpcComm(IHaveOpcObjects frm, int updateRate = 1000);
    }

    /// <summary>
    /// Terminologies: ItemName: name of the item; TagName: name of the property; 
    /// PLCTagName: PLC compliance tag name
    /// </summary>
    /// <remarks>Group definition is global, which means that different PLCs can not
    /// use the same group definition. Name of the PLC tag can be the same as long as
    /// the tags reside in different groups.</remarks>
    public class OpcComm : OpcCommBase
    {
        #region Fields

        private static readonly Dictionary<string, OPCGroup> _listOfGroups = new Dictionary<string, OPCGroup>();
        /// <summary>
        /// RSLinx Server
        /// </summary>
        /// <remarks></remarks>
        private static OPCServer _myOpcServer;
        private OPCGroups _myOpcGroups;
        private readonly OpcItemDictionary _opcItems = new OpcItemDictionary();
        private readonly OpcObjectDictionary _opcItemObjects = new OpcObjectDictionary();
        private static bool _isApplicationClosing;
        private static string _LINXGatewayServerName = string.Empty;
        private static bool _useRemoteGateway;
        private static int OpcClientHandleIndex = 1;
        private static int OpcTransactionIDIndex = 1;
        private static int OpcObjectHandle;
        private static bool _enableOpcCommunication = true;
        private static bool _printTagNameWhenDebug;
        private static readonly Dictionary<IHaveOpcObjects, List<string>> _frmOpcGroupMap = new Dictionary<IHaveOpcObjects, List<string>>();
        private static readonly Queue<OpcIncomingData> _queue = new Queue<OpcIncomingData>();
        private static bool _isListeningToIncomingData;
        private static DateTime _updateTime;
        private static readonly object ASYNC_GROUP_LOCK = new object();
        private static readonly object QUEUE_LOCK = new object();
        private static readonly object ADD_ITEM_LOCK = new object();
        private static readonly object OPEN_GROUP_LOCK = new object();
        private static OpcThreadMode _threadMode = OpcThreadMode.SINGLE_THREADED;
        private static long _dataProcessedCount;
        private static bool _enableSubscribingGlobalDataChangeEvent;
        private static JobManager _jobManager = new JobManager();

        /// <summary>
        /// Dictionary(Of transactionID, groupName)
        /// </summary>
        /// <remarks></remarks>
        private static readonly Dictionary<int, string> _asyncGroupPendingTable = new Dictionary<int, string>();

        /// <summary>
        /// Dictionary(Of groupName, Dictionary(Of PLCTag, value))
        /// </summary>
        /// <remarks></remarks>
        private static readonly Dictionary<string, Dictionary<string, object>> _asyncPendingItems = new Dictionary<string, Dictionary<string, object>>();

        /// <summary>
        /// Dictionary(Of groupName, groupProperties)
        /// </summary>
        /// <remarks></remarks>
        private readonly Dictionary<string, OpcGroupProperties> _opcGroupDetails = new Dictionary<string, OpcGroupProperties>();
        private int _numberOfItemsConnectedToOpc;

        // Public constants
        public const int Opc_DS_CACHE = 1;
        public const int Opc_DS_DEVICE = 2;
        private bool _isInitializingOpcCommunication = true;

        #endregion

        #region Events
        // Public Events
        /// <summary>
        /// This will only fire when property "IsSyncronized" is set to false
        /// </summary>
        /// <param name="TransactionID">Transaction ID assigned by the caller</param>
        /// <param name="GroupHandle">Handle of the group</param>
        /// <param name="NumItems">Number of items returned from the data change event</param>
        /// <param name="ClientHandles">Array of client handles for the data change event</param>
        /// <param name="ItemValues">Array of Item values. The index of the array goes with the array of client handles</param>
        /// <param name="Qualities"></param>
        /// <param name="TimeStamps">When the data change event received from the PLC</param>
        /// <remarks>"IsSyncronized" is set to true by default</remarks>
        public event GlobalDataChangeFromPLCHandler GlobalDataChangeFromPLC;
        public delegate void GlobalDataChangeFromPLCHandler(int TransactionID, int GroupHandle, int NumItems, ref System.Array ClientHandles, ref System.Array ItemValues, ref System.Array Qualities, ref System.Array TimeStamps);

        /// <summary>
        /// This will only fire when property "IsSyncronized" is set to false
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="listOfOpcObjects"></param>
        /// <remarks></remarks>
        public event GroupDataChangeEventHandler GroupDataChangeEvent;
        public delegate void GroupDataChangeEventHandler(string groupName, List<IOpcObject> listOfOpcObjects);

        public event RegisteringProgressHandler RegisteringProgress;
        public delegate void RegisteringProgressHandler(object sender, OpcItemRegisteringProgressEventArgs e);

        /// <summary>
        /// Used to broadcast information related to Opc communication
        /// </summary>
        /// <param name="timeStamp">When was the event happened</param>
        /// <param name="groupName">Name of the group</param>
        /// <param name="message">Message itself</param>
        /// <param name="infoType">What kind of the message</param>
        /// <remarks></remarks>
        public event OpcCommStatusHandler OpcCommStatus;
        public delegate void OpcCommStatusHandler(DateTime timeStamp, string groupName, string message, OPC_COMM_TYPE infoType);

        public event AsyncRefreshFinishedHandler AsyncRefreshFinished;
        public delegate void AsyncRefreshFinishedHandler(string groupName);

        /// <summary>
        /// Raise event when async read is completed
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <remarks></remarks>
        public event AsyncReadCompletedHandler AsyncReadCompleted;
        public delegate void AsyncReadCompletedHandler(string groupName, List<IOpcObject> listOfOpcObjects);

        /// <summary>
        /// Raise event when async write is completed
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <remarks></remarks>
        public event AsyncWriteCompletedHandler AsyncWriteCompleted;
        public delegate void AsyncWriteCompletedHandler(string groupName);

        public event OpcObjectReadyToConnectHandler OpcObjectReadyToConnect;
        public delegate void OpcObjectReadyToConnectHandler(string groupName, string tagName);

        public event OpcCommErrorHandler OpcCommError;
        public delegate void OpcCommErrorHandler(string TagName, string Message);

        #endregion

        #region Properties

        /// <summary>
        /// This can only be set to false when the developer makes sure that no cross-thread issues will arise from the program. Data collection to be recommended
        /// to use Multi-threaded
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public static OpcThreadMode ThreadMode
        {
            get
            {
                return _threadMode;
            }
            set
            {
                _threadMode = value;
            }
        }

        /// <summary>
        /// This will enable or disable Opc communication for debugging purposes. If this is true it will ignore anything related to Opc, such as 
        /// tag definitions, OpcComm.OpenOpcComm
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool EnableOpcCommunication
        {
            get
            {
                return _enableOpcCommunication;
            }
            set
            {
                _enableOpcCommunication = value;
            }
        }

        private static OPCServer MyOpcServer
        {
            get
            {
                if (_myOpcServer == null)
                {
                    _myOpcServer = new OPCServer();
                }
                return _myOpcServer;
            }
        }

        public override bool IsApplicationClosing
        {
            get
            {
                return _isApplicationClosing;
            }
            set
            {
                if (_isApplicationClosing) return;
                _isApplicationClosing = value;
                EnableSubscribingGlobalDataChangeEvent = false;
            }
        }

        public bool EnableSubscribingGlobalDataChangeEvent
        {
            get
            {
                return _enableSubscribingGlobalDataChangeEvent;
            }
            set
            {
                if (_enableSubscribingGlobalDataChangeEvent != value)
                {
                    _enableSubscribingGlobalDataChangeEvent = value;
                    if (_enableSubscribingGlobalDataChangeEvent)
                    {
                        if (_myOpcGroups == null)
                        {
                            _myOpcGroups = (OPCGroups?)MyOpcServer.OPCGroups;
                        }
                        _myOpcGroups.GlobalDataChange += _myOpcGroups_GlobalDataChange;
                    }
                    else
                    {
                        if (_myOpcGroups != null)
                        {
                            _myOpcGroups.GlobalDataChange -= _myOpcGroups_GlobalDataChange;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This is only in effect if the remote LINX option is used.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string LINXGatewayServerName
        {
            get
            {
                return _LINXGatewayServerName;
            }
            set
            {
                _LINXGatewayServerName = value;
            }
        }

        /// <summary>
        /// For debugging purposes. This can be set to true to 
        /// see what the tags are. This is useful information
        /// when a new class is developed. So you can map the property
        /// index accordingly.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool PrintTagNameWhenDebug
        {
            get
            {
                return _printTagNameWhenDebug;
            }
            set
            {
                _printTagNameWhenDebug = value;
            }
        }

        public static bool UseRemoteGateway
        {
            get
            {
                return _useRemoteGateway;
            }
            set
            {
                _useRemoteGateway = value;
            }
        }

        public static bool HasItemsInQueue
        {
            get
            {
                return ItemsInQueue > 0;
            }
        }

        public static int ItemsInQueue
        {
            get
            {
                if (ThreadMode == OpcThreadMode.SINGLE_THREADED)
                {
                    return 0;
                }
                int returnValue;
                // SyncLock QUEUE_LOCK
                returnValue = _queue.Count;
                // End SyncLock
                return returnValue;
            }
        }

        public static long ProcessCount
        {
            get
            {
                return _dataProcessedCount;
            }
        }

        public bool EnableProcessQueueData { get; set; } = true;

        #endregion

        #region Members

        internal List<OpcItemKey> GetOpcTagWithHandle(string groupName)
        {
            var listOfKey = new List<OpcItemKey>();
            foreach (var o in _opcItems)
            {
                if (o.Key.GroupName == groupName)
                {
                    listOfKey.Add(o.Key);
                }
            }
            return listOfKey;
        }

        #region Private
        private void _myOpcGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref System.Array ClientHandles, ref System.Array Errors)
        {
            string groupName = _asyncGroupPendingTable[TransactionID];
            lock (ASYNC_GROUP_LOCK)
            {
                _asyncGroupPendingTable.Remove(TransactionID);
                _asyncPendingItems.Remove(groupName);
            }
            AsyncWriteCompleted?.Invoke(groupName);
        }

        private void CheckServerState()
        {

        }

        // Private Sub RecordTagInfo(ByVal timeStamp As Long, ByVal plcTag As String, ByVal value As Object)
        //     Dim data As New OpcLogData With {.PLCTag = plcTag, .Value = value, .TimeStamp = timeStamp}
        //     Dim fs As New FileStream("data.bin", FileMode.Append, FileAccess.Write)
        //     Try
        //         Dim bytes As Byte() = WDW_SUST.Util.Serialization.SerializationManager.SerializeData(data)
        //         fs.Write(bytes, 0, bytes.Length)
        //         fs.Close()
        //     Catch ex As Exception
        // 
        //     End Try
        // End Sub

        private List<IOpcObject> FillItemValuesToObjects(string GroupName, int NumItems, ref System.Array ClientHandles, ref System.Array ItemValues, ref System.Array TimeStamps)
        {
            var listOfItems = new List<IOpcObject>();
            int tempIndex = 0;
            // Dim timeStamp As Long = Now.Ticks
            for (int i = 1; i <= NumItems; i++)
            {
                // Get the opc item from the OpcComm object by the client handles

                // key contains PLC tag, client handle, server handle and the value to be inserted
                OpcItemKey key = _opcItems.GetKey(ClientHandles.GetValue(i));
                IOpcObject opcItem = _opcItems[key];
                // Get the value returned from the data change event
                if (!key.Value.Equals(ItemValues.GetValue(i)))
                {

                }
                key.Value = ItemValues.GetValue(i);
                // Get the index from the specific class
                tempIndex = opcItem.GetPropertyIndex(key.PlcTagName);
                // Update the value from the PLC to the class property
                opcItem.ValueFromPlcToObject(tempIndex, key.Value);
                // RecordTagInfo(timeStamp, key.PLCTagName, key.Value)
                if (OpcComm.PrintTagNameWhenDebug)
                {
                    Console.WriteLine(string.Format("{0}: Value:{1}", key.PlcTagName, key.Value)); // with index of {2}", tempPLCTag, tempValue, tempIndex))
                                                                                                   // Dim message = String.Format("{0},{1},{2}", key.PlcTagName.Replace(",", "-"), key.Value, DateTime.Now.ToString())
                                                                                                   // LoggingManager.WriteUserMessageToLog(message, "OpcCommLog")
                }

                RaiseOpcCommStatusEvent(DateTime.Now, GroupName, string.Format("{0} = {1}", key.PlcTagName, key.Value), OPC_COMM_TYPE.OPCTagValueChanged);

                if (opcItem.IsRegisteringInProgress)
                {
                    opcItem.RegisterItems += 1;
                    _numberOfItemsConnectedToOpc += 1;
                }

                if (!listOfItems.Contains(opcItem) && !opcItem.IsRegisteringInProgress)
                {
                    opcItem.TimeStamp = ((DateTime)TimeStamps.GetValue(i)).ToLocalTime();
                    if (ThreadMode == OpcThreadMode.MULTI_THREADED)
                    {
                        Helpers.RaiseMultiThreadedEvent(OpcCommStatusEvent, new object[] { DateTime.Now, GroupName, string.Format("Opc item {0} was changed", opcItem.TagName), OPC_COMM_TYPE.OpcCommStatus });
                    }
                    else
                    {
                        OpcCommStatus?.Invoke(DateTime.Now, GroupName, string.Format("Opc item {0} was changed", opcItem.TagName), OPC_COMM_TYPE.OpcCommStatus);
                    }
                    // TODO: Sum - This is to check if the object is serializable. Needs to come back to develop this.
                    // If opcItem.GetObjectType.IsSerializable Then

                    // End If
                    listOfItems.Add(opcItem);
                    // listOfItems.Add(CType(opcItem, OpcObjectBase).Clone)
                }

                _dataProcessedCount += 1;
            }
            // TODO: Sum - need to develop this
            // If _OpcAccessMode = OpcAccessMode.Opc_REMOTE_ACCESS_MODE Then
            //     'RaiseEvent GlobalOpcItemChangeEvent(GroupName, listOfOpcItems)
            //     LINTFunctions.RaiseMultiThreadedEvent(GlobalOpcItemChangeEventEvent, New Object() {GroupName, listOfOpcItems})
            // End If
            // Event is raised when the group is in synchronized mode
            // RaiseEvent Test(Me, New OpcGlobalDataChangeEventArgs(tempGroupName, listOfItems))
            return listOfItems;
        }

        public void AddAsyncPendingItemToList(string groupName, string plcTagName, object value)
        {
            if (_asyncPendingItems.ContainsKey(groupName))
            {
                if (_asyncPendingItems[groupName].ContainsKey(plcTagName))
                {
                    _asyncPendingItems[groupName][plcTagName] = value;
                }
                else
                {
                    _asyncPendingItems[groupName].Add(plcTagName, value);
                }
            }
            else
            {
                var dict = new Dictionary<string, object>();
                dict.Add(plcTagName, value);
                _asyncPendingItems.Add(groupName, dict);
            }
        }

        /// <summary>
        /// Get Opc group object from the list of groups in the Opc server
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <returns></returns>
        /// <remarks></remarks>
        internal OPCGroup GetOpcGroup(string groupName)
        {
            if (DoesGroupExistInServer(groupName))
            {
                return MyOpcServer.OPCGroups.Item(groupName);
            }
            else
            {
                throw new ArgumentException("Group does not exist!!");
            }
        }

        public OpcGroupProperties GetOpcGroupProperties(string groupName)
        {
            if (OpcComm.EnableOpcCommunication && groupName != null)
            {
                if (_opcGroupDetails.ContainsKey(groupName))
                {
                    return _opcGroupDetails[groupName];
                }
                else
                {
                    WriteUserMessageToLog(string.Format("The group {0} does not exist in the OpcComm object!", groupName));
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Implementation of the Opc data change event.
        /// </summary>
        /// <param name="TransactionID">A number assigned to the transaction</param>
        /// <param name="GroupHandle">Server Handle of the group</param>
        /// <param name="NumItems">Number of items was modified in the data change event</param>
        /// <param name="ClientHandles">Array of client handles of all changed items</param>
        /// <param name="ItemValues">Array of values of all changed items</param>
        /// <param name="Qualities"></param>
        /// <param name="TimeStamps"></param>
        /// <remarks></remarks>
        private void _myOpcGroups_GlobalDataChange(int TransactionID, int GroupHandle, int NumItems, ref System.Array ClientHandles, ref System.Array ItemValues, ref System.Array Qualities, ref System.Array TimeStamps) // ZRL 2020-11-11 removed handles code, cause data duplication bug
        {
            _updateTime = DateTime.Now;
            if (IsApplicationClosing) return;
            switch (OpcComm.ThreadMode)
            {
                case OpcThreadMode.SINGLE_THREADED:
                    ProcessOpcIncomingData(TransactionID, GroupHandle, NumItems, ref ClientHandles, ref ItemValues, ref Qualities, ref TimeStamps);
                    break;
                case OpcThreadMode.MULTI_THREADED:
                    lock (QUEUE_LOCK)
                    {
                        _queue.Enqueue(new OpcIncomingData(TransactionID, GroupHandle, ClientHandles, NumItems, ItemValues, TimeStamps, Qualities));
                        Console.WriteLine("Loading {0} items - {1} Events pending", ClientHandles.Length, _queue.Count);
                    }
                    break;
            }
        }

        private void RaiseOpcCommStatusEvent(DateTime time, string groupName, string message, OPC_COMM_TYPE commType)
        {
            if (OpcComm.ThreadMode == OpcThreadMode.MULTI_THREADED)
            {
                Helpers.RaiseMultiThreadedEvent(OpcCommStatusEvent, new object[] { time, groupName, message, commType });
            }
            else
            {
                OpcCommStatus?.Invoke(time, groupName, message, commType);
            }
        }



        private void ProcessOpcIncomingData(int TransactionID, int GroupHandle, int NumItems, ref System.Array ClientHandles, ref System.Array ItemValues, ref System.Array Qualities, ref System.Array TimeStamps)
        {
            string tempGroupName = GetGroupNameByHandle(GroupHandle);
            if (tempGroupName == string.Empty) return;
            OpcGroupProperties group = GetOpcGroupProperties(tempGroupName);
            RaiseOpcCommStatusEvent(DateTime.Now, tempGroupName, "New data has arrived", OPC_COMM_TYPE.OpcCommStatus);

            if (_opcGroupDetails.ContainsKey(tempGroupName))
            {
                if (_opcGroupDetails[tempGroupName].IsGroupSyncronized)
                {
                    List<IOpcObject> listOfOpcObjects = FillItemValuesToObjects(tempGroupName, NumItems, ref ClientHandles, ref ItemValues, ref TimeStamps);
                    if (listOfOpcObjects.Count > 0)
                    {
                        foreach (IOpcObject item in listOfOpcObjects)
                        {
                            item.RaisePropertiesUpdatedEvent(System.EventArgs.Empty);
                        }
                        if (_opcGroupDetails[tempGroupName].IsOPCGlobalDataChangeEventSuppressing)
                        {
                            group.RaiseGroupDataChangeEvent(new OpcGroupDataChangeEventArgs(listOfOpcObjects));
                        }
                        else
                        {
                            if (ThreadMode == OpcThreadMode.MULTI_THREADED)
                            {
                                OnRaiseMultiThreadedGlobalDataChangeEvent(tempGroupName, listOfOpcObjects);
                            }
                            else
                            {
                                OnRaiseGlobalDataChangeEvent(tempGroupName, listOfOpcObjects);
                            }
                        }
                    }
                    if (TransactionID > 0)
                    {
                        lock (ASYNC_GROUP_LOCK)
                        {
                            _asyncGroupPendingTable.Remove(TransactionID);
                        }
                        if (ThreadMode == OpcThreadMode.MULTI_THREADED)
                        {
                            Helpers.RaiseMultiThreadedEvent(AsyncRefreshFinishedEvent, new object[] { tempGroupName });
                        }
                        else
                        {
                            AsyncRefreshFinished?.Invoke(tempGroupName);
                        }
                    }
                }
                else
                {
                    if (ThreadMode == OpcThreadMode.MULTI_THREADED)
                    {
                        Helpers.RaiseMultiThreadedEvent(GlobalDataChangeFromPLCEvent, new object[] { TransactionID, GroupHandle, NumItems, ClientHandles, ItemValues, Qualities, TimeStamps });
                    }
                    else
                    {
                        GlobalDataChangeFromPLC?.Invoke(TransactionID, GroupHandle, NumItems, ref ClientHandles, ref ItemValues, ref Qualities, ref TimeStamps);
                    }
                }
            }
        }

        private void AddOpcItems(string groupName, bool isActive)
        {
            //==
            //   Step 3: Add Opc items to group
            //==
            RaiseOpcCommStatusEvent(DateTime.Now, null, string.Format("Add Opc items to group {0} is in progress", groupName), OPC_COMM_TYPE.OpcCommStatus);
            try
            {
                int[] count = { _opcGroupDetails[groupName].GetListOfTags.Count };
                int[] lowerBound = { 1 };
                System.Array listOfTags = Array.CreateInstance(typeof(string), count, lowerBound); //tags to be connected
                System.Array errors = Array.CreateInstance(typeof(int), count, lowerBound); //errors just in case there are errors return
                System.Array serverHandles = Array.CreateInstance(typeof(int), count, lowerBound); //server handles
                System.Array clientHandles = Array.CreateInstance(typeof(int), count, lowerBound); //client handles
                int index = 1;

                foreach (KeyValuePair<string, int> pair in _opcGroupDetails[groupName].GetPLCTagNameWithHandles)
                {
                    listOfTags.SetValue(pair.Key.ToString(), index);
                    clientHandles.SetValue((int)pair.Value, index);
                    index += 1;
                }

                MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.AddItems(index - 1, listOfTags, clientHandles, serverHandles, errors); //add the items
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive = isActive; //set the group to be active after open

                if (errors.Length > 0) //check if errors occurred
                {
                    int[] potentialErrors = new int[errors.Length - 1];
                    for (int i = 0; i <= potentialErrors.Length - 1; i++)
                    {
                        potentialErrors[i] = (int)errors.GetValue(i + 1);
                    }

                    if (Array.Exists(potentialErrors, err => err != 0))
                    {
                        StringBuilder s = new StringBuilder();
                        for (int i = 0; i <= potentialErrors.Length - 1; i++)
                        {
                            switch (potentialErrors[i])
                            {
                                case -1073479672:
                                    s.AppendLine(string.Format("Group:{0} - {1} does not conform to the server's syntax.!!", groupName, listOfTags.GetValue(i + 1)));
                                    break;
                                default:
                                    if (potentialErrors[i] != 0)
                                    {
                                        s.AppendLine(string.Format("Group:{0} - {1} is not defined in PLC!!", groupName, listOfTags.GetValue(i + 1)));
                                        //RaiseMultiThreadedEvent(OpcCommError, new object[] { listOfTags.GetValue(i + 1), "Test" });
                                    }
                                    break;
                            }
                        }

                        //MessageBox.Show(s.ToString());
                    }
                }

                if (OpcComm.ThreadMode == OpcThreadMode.MULTI_THREADED && !_isListeningToIncomingData)
                {
                    _isListeningToIncomingData = true;
                    //Listening to incoming Opc data
                    CreateAndRunBackgroundThread(() => ProcessMultiThreadedIncomingOpcData());
                }

            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                string exceptionString = OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode);

                if (ex.ErrorCode == OpcComExceptions.ExceptionCode.WrongTag)
                {
                    OpcCommError?.Invoke("Test", "TagName not defined in the PLC");
                }
                else
                {
                    throw new OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode);
                }
            }
            _numberOfItemsConnectedToOpc += _opcGroupDetails[groupName].GetListOfTags.Count;
            OpcCommStatus?.Invoke(DateTime.Now, null, string.Format("Opc items added to group {0} successfully", groupName), OPC_COMM_TYPE.OpcCommStatus);
        }

        /// <summary>
        /// Processes the multi threaded incoming opc data.
        /// This thread will run continuously when MULTI_THREAD mode is used when start the OpcComm object
        /// </summary>
        private void ProcessMultiThreadedIncomingOpcData()
        {
            OpcIncomingData data;
            while (true)
            {
                //Console.WriteLine("Server State: " + MyOpcServer.ServerState.ToString());
                if (_queue.Count > 0 && EnableProcessQueueData)
                {
                    try
                    {
                        lock (QUEUE_LOCK)
                        {
                            data = _queue.Dequeue();
                            Console.WriteLine("Unloading {0} items - {1} Events pending", data.ClientHandles.Length, _queue.Count);
                        }
                        if (data.Qualities.Length > 0)
                        {
                            int[] potentialErrors = new int[data.Qualities.Length - 1];
                            for (int i = 0; i < potentialErrors.Length; i++)
                            {
                                potentialErrors[i] = data.Qualities[i + 1];
                            }
                            int[] errorsFromPLC = Array.FindAll(potentialErrors, err => err != 0xC0);
                            if (errorsFromPLC.Length > 0)
                            {
                                for (int i = 0; i < errorsFromPLC.Length; i++)
                                {
                                    WriteUserMessageToLog(String.Format("{0}, Quality of data is not good for group: {1}, {2}", DateTime.Now.ToString(), GetGroupNameByHandle(data.GroupHandle), errorsFromPLC[i]));
                                }
                            }
                        }
                        if (data.GroupHandle > 0) //Why GroupHandle = 0 ???
                        {
                            ProcessOpcIncomingData(data.TransactionID, data.GroupHandle, data.NumItems, data.ClientHandles, data.ItemValues, data.Qualities, data.TimeStamps);
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteUserMessageToLog(String.Format("{0}, {1}", DateTime.Now.ToString(), ex.Message));
                    }
                }
                else
                {
                    Thread.Sleep(50);
                }
            }
            //Dim x = 5
            //x += 1
            //UpdateTagValue(Nothing, Nothing)
            //_x = True
        }

        //Private _x As Boolean
        private int AssignClientHandle()
        {
            int i = 0;
            do
            {
                i = Helpers.GetRandomNumber();
            }
            while (_opcItems.ContainsKey(i));
            return i;
        }

        private void ConnectOpcServer(string OpcProgramID, bool isExistingGroupsDeleted)
        {
            if (!IsServerRunning())
            {
                //==
                //   Step 1: Initialize RSLinx Opc Server
                //==
                //RaiseOpcCommStatusEvent(Now, Nothing, "Connecting to Opc server!!", Opc_COMM_TYPE.OpcCommStatus)
                //If UseRemoteGateway Then
                //    MyOpcServer.Connect("RSLinx Remote Opc Server", LINXGatewayServerName)
                //Else
                //    MyOpcServer.Connect("RSLinx Opc Server")
                //End If
                //If isExistingGroupsDeleted Then MyOpcServer.OpcGroups.RemoveAll()
                //EnableSubscribingGlobalDataChangeEvent = True
                //==
                //   Step 1: Initialize RSLinx Opc Server
                //==
                RaiseOpcCommStatusEvent(DateTime.Now, null, "Connecting to Opc server!!", OPC_COMM_TYPE.OpcCommStatus);
                if (UseRemoteGateway)
                {
                    try
                    {
                        MyOpcServer.Connect(OpcProgramID, LINXGatewayServerName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    MyOpcServer.Connect(OpcProgramID);
                }
                if (isExistingGroupsDeleted) MyOpcServer.OPCGroups.RemoveAll();
                EnableSubscribingGlobalDataChangeEvent = true;
                _jobManager.AddJob("periodic-server-state-check", TimeSpan.FromSeconds(30), CheckServerState);
                _jobManager.StartProcessingJobs();
            }
        }

        private bool DoesGroupExistInServer(string groupName)
        {
            if (_opcGroupDetails.ContainsKey(groupName))
            {
                return true;
            }
            return false;
        }


        internal int GetItemServerHandle(string groupName, string tagName)
        {
            return _myOpcGroups.GetOPCGroup(groupName).OPCItems.Item(tagName).ServerHandle;
        }

        /// <summary>
        /// Write the value from the object to the PLC tag
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="plcTagName">Name of the PLC tag name</param>
        /// <param name="value">Value to be written</param>
        /// <remarks></remarks>
        public bool SetItemValue(string groupName, string plcTagName, object value, bool shouldThrowIfError = false)
        {
            if (_opcGroupDetails.ContainsKey(groupName))
            {
                if (shouldThrowIfError)
                {
                    MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.Item(plcTagName).Write(value);
                }
                else
                {
                    return TryUserAction(act: () => MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.Item(plcTagName).Write(value), message: $"SetItemValue(groupName={groupName}; plcTagName={plcTagName}; value={value})");
                }
            }
            return true;
        }

        internal void UpdateTagValue(string plcTagName, object value)
        {
            OpcItemKey opcItemKey = _opcItems.GetKey(plcTagName);
            opcItemKey.Value = value;
        }

        private void SetOpcGroup(string groupName, int updateRate, bool isSubscribed)
        {
            //==
            //   Step 2: Setup Opc group
            //==
            RaiseOpcCommStatusEvent(DateTime.Now, null, string.Format("Adding group {0} to Opc server", groupName), OPC_COMM_TYPE.OpcCommStatus);
            OPCGroup group = MyOpcServer.OPCGroups.Add(groupName);

            var opcGroup = MyOpcServer.OPCGroups.GetOPCGroup(groupName);
            opcGroup.IsSubscribed = isSubscribed;
            opcGroup.UpdateRate = updateRate;
            opcGroup.IsActive = false;

            AddGroupHandlers(ref group);
            _listOfGroups.Add(groupName, group);
        }

        private void AddGroupHandlers(ref OPCGroup group)
        {
            group.AsyncWriteComplete += _myOpcGroup_AsyncWriteComplete;
            group.AsyncReadComplete += _myOpcGroup_AsyncReadComplete;
        }

        private void RemoveGroupHandlers(ref OPCGroup group)
        {
            group.AsyncWriteComplete -= _myOpcGroup_AsyncWriteComplete;
            group.AsyncReadComplete -= _myOpcGroup_AsyncReadComplete;
        }

        private string GetGroupNameByHandle(int groupHandle)
        {
            //If IsApplicationClosing Then
            //    Return Nothing
            //End If
            foreach (OPCGroup group in MyOpcServer.OPCGroups)
            {
                if (group.ServerHandle == groupHandle)
                {
                    return group.Name;
                }
            }
            //Throw New Exception("Group Can Not Be Found!!")
            return string.Empty;
        }


        #endregion

        #region Public
        public string[] GetAllTagNames(string groupName)
        {
            return _opcGroupDetails[groupName].GetPLCTagNames.ToArray();
        }

        public override string[] GetAllTagNames()
        {
            var list = new List<string>();
            foreach (KeyValuePair<string, OpcGroupProperties> pair in _opcGroupDetails)
            {
                list.AddRange(pair.Value.GetPLCTagName);
            }
            return list.ToArray();
        }

        /// <summary>
        /// Use to tell if the objects in the group is synchronized with the PLC values
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsGroupSynchronized(string groupName)
        {
            return _opcGroupDetails[groupName].IsGroupSyncronized;
        }

        public bool ContainsGroup(ref IHaveOpcObjects frm, string groupName)
        {
            if (ContainsGroupInForm(ref frm))
            {
                foreach (string s in _frmOpcGroupMap[frm])
                {
                    if (s.ToLower() == groupName.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ContainsGroupInForm(ref IHaveOpcObjects frm)
        {
            return _frmOpcGroupMap.ContainsKey(frm);
        }

        /// <summary>
        /// Get number of items in a group
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <returns>Count in an integer</returns>
        /// <remarks></remarks>
        public int GetNumberOfOpcItems(string groupName)
        {
            return MyOpcServer.OPCGroups.GetOPCGroup(groupName).OPCItems.Count;
        }

        public List<IOpcObject> GetListOfOpcObjectsByGroup(string groupName)
        {
            //var list = new List<IOpcObject>();
            //foreach (OpcObjectKey opcObjectKey in _opcItemObjects.Keys)
            //{
            //    if (opcObjectKey.GroupName == groupName)
            //    {
            //        list.Add(_opcItemObjects[opcObjectKey]);
            //    }
            //}
            //return list;
            return _opcGroupDetails[groupName].OPCObjects;
        }

        public override int GetNumberOfOpcItems()
        {
            return _opcItems.Count;
        }

        //public void OpenOpcComm(string plcName, string groupName, int updateRate = 1000,
        //                       bool isSubscribed = true, bool isActive = true)
        //{
        //    if (!DoesGroupExistInServer(groupName)) throw new Exception("Group is not defined!!");
        //    if (!IsServerRunning) ConnectToServer(true);
        //    SetOpcGroup(groupName, updateRate, isSubscribed);
        //    AddOpcItems(plcName, groupName, isActive);
        //}

        /// <summary>
        /// Used to add item to the Opc instance for Opc communication
        /// </summary>
        /// <param name="opcItem">Item to be added</param>
        /// <remarks></remarks>
        [Obsolete("Use AddOpcObject instead")]
        public void AddOpcItem(IOpcObject opcItem)
        {
            Array t = opcItem.GetPlcTagNames();
            if (!_opcGroupDetails.ContainsKey(opcItem.GroupName))
            {
                _opcGroupDetails.Add(opcItem.GroupName, new OpcGroupProperties());
            }
            //Add a reference to the OpcGroupDetails
            _opcGroupDetails[opcItem.GroupName].AddOPCItemObjectToList(opcItem);
            foreach (string s in t)
            {
                int tempHandle = AssignClientHandle();
                _opcItems.Add(new OpcItemKey(tempHandle, opcItem.GroupName, s), opcItem);
                _opcGroupDetails[opcItem.GroupName].AddTag(s, tempHandle);
            }
            _opcItemObjects.Add(new OpcObjectKey(opcItem.PlcName, opcItem.TagName, opcItem.GroupName), opcItem);
        }

        public DateTime GetMaxOpcTimeStamp()
        {
            try
            {
                return _opcItems.Aggregate((l, r) => l.Value.TimeStamp > r.Value.TimeStamp ? l : r).Value.TimeStamp;
            }
            catch (InvalidOperationException ex)
            {
                return System.Convert.ToDateTime("01/01/1900");
            }
        }

        public async Task AddOpcObjectAsync(IOpcObject opcObject)
        {
            await Task.Run(() => AddOpcObject(opcObject));
        }

        /// <summary>
        /// Used to add item to the Opc instance for Opc communication. IMPORTANT!! If the parent form which owns this object and also inherits
        /// from LINTOpcFormBase, make sure to use AddOpcObject(ByVal opcItem as IOpcObject, ByVal parentForm As Form) instead!!
        /// </summary>
        /// <param name="opcObject">Item to be added - Look at summary for reference on how to use this subroutine</param>
        /// <returns>Opc object handle</returns>
        /// <remarks></remarks>
        public override int AddOpcObject(IOpcObject opcObject)
        {
            if (EnableOpcCommunication)
            {
                lock (ADD_ITEM_LOCK)
                {
                    Array t = opcObject.GetPlcTagNames();
                    if (!_opcGroupDetails.ContainsKey(opcObject.GroupName))
                    {
                        _opcGroupDetails.Add(opcObject.GroupName, new OpcGroupProperties());
                    }
                    //Add a reference to the OpcGroupDetails
                    _opcGroupDetails[opcObject.GroupName].AddOPCItemObjectToList(opcObject);
                    foreach (string s in t)
                    {
                        int tempHandle = OpcClientHandleIndex;
                        OpcClientHandleIndex += 1;
                        if (OpcComm.PrintTagNameWhenDebug)
                        {
                            Console.WriteLine(String.Format("{0}: Handle:{1}", s, tempHandle));
                        }
                        if (!_opcGroupDetails[opcObject.GroupName].AddTag(s, tempHandle)) throw new Exception(String.Format("PLC Tag Name {0} has already been defined in the group {1}", s, opcObject.GroupName));
                        _opcItems.Add(new OpcItemKey(tempHandle, opcObject.GroupName, s), opcObject);
                    }
                    _opcItemObjects.Add(new OpcObjectKey(opcObject.PlcName, opcObject.TagName, opcObject.GroupName), opcObject);
                    OpcObjectHandle += 1;
                    OpcObjectReadyToConnect?.Invoke(opcObject.GroupName, opcObject.TagName);
                }
                return OpcObjectHandle;
            }
            return -1;
        }
        public override T AddOpcObject<T>(string plcName, string tagName, string groupName) where T : IOpcObject
        {
            T obj = (T)Activator.CreateInstance(typeof(T), plcName, tagName, groupName);
            this.AddOpcObject(obj);
            return obj;
        }

        public override T AddOpcObject<T>(string plcName, string tagName, string groupName, IHaveOpcObjects parentForm) where T : IOpcObject
        {
            T obj = (T)Activator.CreateInstance(typeof(T), plcName, tagName, groupName);
            this.AddOpcObject(obj, parentForm);
            return obj;
        }

        /// <summary>
        /// Used to add item to the Opc instance for Opc communication. It is very important that if the 
        /// parent form inherits from LINTOpcFormBase, the second argument needs to be set to the parent form itself
        /// to make sure all groups in the form will be closed properly.
        /// </summary>
        /// <param name="opcObject">Item to be added - Look at summary for reference on how to use this subroutine</param>
        /// <param name="parentForm">Form object which has the group of the opc object and also inherits from LINTOpcFormBase</param>
        /// <remarks></remarks>
        public void AddOpcObject(IOpcObject opcObject, IHaveOpcObjects parentForm)
        {
            if (EnableOpcCommunication)
            {
                if (_frmOpcGroupMap.ContainsKey(parentForm))
                {
                    if (!_frmOpcGroupMap[parentForm].Contains(opcObject.GroupName))
                    {
                        _frmOpcGroupMap[parentForm].Add(opcObject.GroupName);
                    }
                }
                else
                {
                    _frmOpcGroupMap.Add(parentForm, new List<string>());
                    _frmOpcGroupMap[parentForm].Add(opcObject.GroupName);
                }
            }
            AddOpcObject(opcObject);
        }

        /// <summary>
        /// Close all active Opc groups in the server and then disconnect from it.
        /// </summary>
        /// <remarks>This is only called when the application is going to shut down.
        /// Otherwise, call CloseOpcComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        /// </remarks>
        public override void CloseOpcComm()
        {
            EnableSubscribingGlobalDataChangeEvent = false;
            while (HasItemsInQueue)
            {
                Thread.Sleep(200);
            }
            foreach (OPCGroup opcGroup in MyOpcServer.OPCGroups)
            {
                try
                {
                    CloseOpcComm(opcGroup.Name, true);
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    WriteException(ex);
                }
            }

            DisconnectOpcServer();
        }

        private void DisconnectOpcServer()
        {
            MyOpcServer.Disconnect();
        }

        public void CloseOpcComm(ManualResetEvent waitHandle)
        {
            CloseOpcComm();
            waitHandle.Set();
        }

        public override bool TryCloseOpcComm()
        {
            try
            {
                CloseOpcComm();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Close the Opc group specified
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="clearClientHandles">Determine if clearing the client handles in the memory buffer is needed</param>
        /// <remarks>This is only called when the application is going to shut down.
        /// Otherwise, call CloseOpcComm(ByVal groupName As String, ByVal clearClientHandles As Boolean) instead
        /// </remarks>
        public override void CloseOpcComm(string groupName, bool clearClientHandles)
        {
            if (EnableOpcCommunication)
            {
                try
                {
                    if (string.IsNullOrEmpty(groupName)) return;
                    if (_opcGroupDetails.ContainsKey(groupName))
                    {
                        if (clearClientHandles)
                        {
                            foreach (int handle in _opcGroupDetails[groupName].GetClientHandles)
                            {
                                foreach (OpcItemKey key in _opcItems.Keys.ToList())
                                {
                                    if (key.ClientHandle == handle)
                                    {
                                        _opcItems.Remove(key);
                                        break;
                                    }
                                }
                            }
                            _numberOfItemsConnectedToOpc -= _opcGroupDetails[groupName].GetPLCTagCounts;
                            _opcGroupDetails[groupName].Dispose();
                            _opcGroupDetails.Remove(groupName);
                            _opcItemObjects.Remove(groupName);
                        }
                        else
                        {
                            _opcGroupDetails[groupName].IsGroupConnected = false;
                        }
                        if (MyOpcServer.OPCGroups.Count > 0)
                        {
                            RemoveGroupHandlers(_listOfGroups[groupName]);
                            _listOfGroups.Remove(groupName);
                            MyOpcServer.OPCGroups.Remove(groupName);
                        }
                    }
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    WriteException(ex);
                }
            }
        }
        //TODO: This is for testing purposes and will need to be removed.
        public List<string> GetOpcItemTagNames()
        {
            foreach (OpcItemKey obj in _opcItems.Keys)
            {
                Console.WriteLine(obj.PlcTagName);
            }
            return null;
        }

        //TODO: This is for testing purposes and will need to be removed.
        public List<string> GetOpcObjectTagNames()
        {
            foreach (IOpcObject obj in _opcItemObjects.Values)
            {
                //foreach (string s in obj.GetPLCTagNames)
                //{
                //    Console.WriteLine(s);
                //}
                Console.WriteLine(obj.TagName);
            }
            return null;
        }

        /// <summary>
        /// Close the Opc group specified
        /// </summary>
        /// <param name="parentForm">Parent object which as the group resides in it</param>
        /// <remarks>This is only called when the application is going to shut down.
        /// Otherwise, call CloseOpcComm(string groupName, bool clearClientHandles) instead
        /// </remarks>
        public void CloseOpcComm(IHaveOpcObjects parentForm)
        {
            if (EnableOpcCommunication && ContainsGroupInForm(frm: parentForm))
            {
                _frmOpcGroupMap[parentForm].ForEach(a => CloseOpcComm(a, true));
                _frmOpcGroupMap.Remove(parentForm);
                parentForm = null;
            }
        }

        /// <summary>
        /// Get the value from the PLC and assign it to the object
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="plcTagName">PLC tag name</param>
        /// <returns>Value of the item in the PLC</returns>
        /// <remarks></remarks>
        public object GetItemValue(string groupName, string plcTagName)
        {
            return _myOpcGroups.GetOPCGroup(groupName).OPCItems.Item(plcTagName).Value;
        }

        /// <summary>
        /// Get the value from the PLC and assign it to the object
        /// </summary>
        /// <param name="opcItem">Opc object</param>
        /// <param name="itemName">Name of the item</param>
        /// <returns></returns>
        /// <remarks>Item name should not include the tag name of the item. If the item is an OpcElement type,
        /// the item name should be value.</remarks>
        public object GetItemValue(IOpcObject opcItem, string itemName)
        {
            string plcTagName = opcItem.GetPlcTagName(itemName);
            return _myOpcGroups.GetOPCGroup(opcItem.GroupName).OPCItems.Item(plcTagName).Value;
        }

        /// <summary>
        /// Get all group names which have already connected to the PLC
        /// </summary>
        /// <returns>Array of group names</returns>
        /// <remarks></remarks>
        public string[] GetGroupNames()
        {
            List<string> names = new List<string>();
            foreach (OPCGroup group in MyOpcServer.OPCGroups)
            {
                names.Add(group.Name);
            }
            names.Sort();
            return names.ToArray();
        }

        /// <summary>
        /// Check if group is active
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsGroupActive(string groupName)
        {
            if (IsApplicationClosing)
            {
                return false;
            }
            return MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive;
        }

        /// <summary>
        /// Check if the server is running
        /// </summary>
        /// <returns>Boolean to tell if the Opc server is running</returns>
        /// <remarks></remarks>
        public override bool IsServerRunning()
        {
            bool state;
            try
            {
                state = MyOpcServer.ServerState == OPCServerState.OPCRunning;
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                state = false;
            }
            return state;
        }

        /// <summary>
        /// Use to tell if the group is subscribed
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <returns>Boolean indicate if the group is subscribed</returns>
        /// <remarks></remarks>
        public bool IsGroupSubscribed(string groupName)
        {
            return _myOpcGroups.GetOPCGroup(groupName).IsSubscribed;
        }

        /// <summary>
        /// Open Opc communication for all groups existed in _opcGroupDetails
        /// which have not called the OpenOpcComm subroutine yet
        /// </summary>
        /// <remarks></remarks>
        public override void OpenOpcComm()
        {
            if (EnableOpcCommunication)
            {
                if (_opcGroupDetails.Count == 0)
                {
                    throw new Exception("No group was defined to add to the Opc!!!");
                }
                foreach (string group in _opcGroupDetails.Keys)
                {
                    OpenOpcComm(group);
                    CalculateRegisteringProcess();
                }
            }
        }

        public async Task OpenOpcCommAsync(int updateRate = 1000)
        {
            if (EnableOpcCommunication)
            {
                if (_opcGroupDetails.Count == 0)
                {
                    throw new Exception("No group was defined to add to the Opc!!!");
                }

                List<Task> OpenCommTasks = new List<Task>();

                foreach (string group in _opcGroupDetails.Keys)
                {
                    Task t = Task.Run(() =>
                    {
                        TryUserAction(() => OpenOpcComm(group, updateRate));
                        CalculateRegisteringProcess();
                    });
                    OpenCommTasks.Add(t);
                }

                await Task.WhenAll(OpenCommTasks);
            }
        }
        public overload void OpenOpcComm(ManualResetEvent waitHandle)
        {
            OpenOpcComm();
            //waitHandle.Set();
        }

        /// <summary>
        /// Open Opc communication for all groups reside in the frm object
        /// </summary>
        /// <param name="frm">Form object which contains all intended groups for communication</param>
        /// <param name="updateRate">Update rate for all group inside of the form</param>
        /// <remarks></remarks>
        public override void OpenOpcComm(IHaveOpcObjects frm, int updateRate = 1000)
        {
            if (EnableOpcCommunication)
            {
                if (ContainsGroupInForm(frm))
                {
                    if (_frmOpcGroupMap[frm].Count == 0)
                    {
                        throw new Exception("No group was defined to add to the Opc!!!");
                    }
                    foreach (string group in _frmOpcGroupMap[frm])
                    {
                        OpenOpcComm(group, updateRate);
                        CalculateRegisteringProcess(); //_opcGroupDetails[group].GetListOfTags.Count);
                    }
                }
            }
        }

        private void CalculateRegisteringProcess()
        {
            int progress = (int)(_numberOfItemsConnectedToOpc / _opcItems.Count * 100);
            if (progress > 100) progress = 100;
            //RaiseEvent RegisteringProgress(Me, New OpcItemRegisteringProgressEventArgs(progress))
            RaiseMultiThreadedEvent(RegisteringProgressEvent, new object[] { this, new OpcItemRegisteringProgressEventArgs(progress) });
        }
        //private void CalculateRegisteringProcess(int tagCounts)
        //{
        //    int progress = (int)(tagCounts / (_opcItems.Count - _numberOfItemsConnectedToOpc) * 100);
        //    RaiseEvent RegisteringProgress(Me, New OpcItemRegisteringProgressEventArgs(progress));
        //}

        /// <summary>
        /// Use to set different property for the group specified. If default properties are used
        /// We should only call OpenOpcComm to open all groups at the same time
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
        /// OpcComm.Instance</remarks>
        public override void OpenOpcComm(string groupName, int updateRate = 1000,
                                  bool isSubscribed = true, bool isActive = true,
                                  bool isSyncronized = true, bool opcGlobalDataChangeEventSuppressing = false)
        {
            //           var x = new OpcGroupDefinition(groupName, updateRate, isSubscribed, isActive, isSyncronized);
            //           var y = new Thread(new ParameterizedThreadStart(OpenOpcComm));
            //          y.Start(x);
            if (EnableOpcCommunication)
            {
                Console.WriteLine(string.Format("{0} for group {1} to start", DateTime.Now.ToString(), groupName));
                if (!_opcGroupDetails.ContainsKey(groupName))
                {
                    //throw new Exception(string.Format("Group '{0}' is not defined!!", groupName));
                    return;
                }
                //var query = from s in _opcGroupDetails[groupName].GetListOfTags
                //            group s by s into g
                //            where g.Count() > 1
                //            select g;
                lock (OPEN_GROUP_LOCK)
                {
                    if (!_opcGroupDetails[groupName].IsGroupConnected)
                    {
                        if (!DoesGroupExistInServer(groupName)) throw new Exception("Group is not defined!!");
                        ConnectOpcServer(RslinxOpcDaSettings.ServerName, true);
                        //ConnectOpcServer("opcda://localhost/RSLinx Opc Server/{a05bb6d5-2f8a-11d1-9bb0-080009d01446}", true);
                        SetOpcGroup(groupName, updateRate, isSubscribed);
                        AddOpcItems(groupName, isActive);

                        _opcGroupDetails[groupName].IsGroupSyncronized = isSyncronized;
                        _opcGroupDetails[groupName].IsGroupConnected = true;
                        _opcGroupDetails[groupName].IsOPCGlobalDataChangeEventSuppressing = opcGlobalDataChangeEventSuppressing;
                        if (!(isSubscribed && isActive))
                        {
                            foreach (IOpcObject item in _opcGroupDetails[groupName].OPCObjects)
                            {
                                item.RegisterItems = 9999; //workaround for setting the IsRegisteringInProcess bit to true
                            }
                        }
                    }
                }
                Console.WriteLine(string.Format("{0} for group {1} to finished", DateTime.Now.ToString(), groupName));
            }
        }

        private void OpenOpcComm(object data)
        {
            lock (OPEN_GROUP_LOCK)
            {
                OpcGroupDefinition y = (OpcGroupDefinition)data;
                if (!_opcGroupDetails.ContainsKey(y.GroupName))
                {
                    throw new Exception(string.Format("Group '{0}' is not defined!!", y.GroupName));
                }
                if (!_opcGroupDetails[y.GroupName].IsGroupConnected)
                {
                    if (!DoesGroupExistInServer(y.GroupName)) throw new ArgumentException("Group is not defined!!");
                    ConnectOpcServer("RSLinx Remote Opc Server", true);
                    SetOpcGroup(y.GroupName, y.UpdateRate, y.IsSubscribed);
                    AddOpcItems(y.GroupName, y.IsActive);
                    _opcGroupDetails[y.GroupName].IsGroupSyncronized = y.IsSyncronized;
                    _opcGroupDetails[y.GroupName].IsGroupConnected = true;
                    if (!(y.IsSubscribed && y.IsActive))
                    {
                        foreach (IOpcObject item in _opcGroupDetails[y.GroupName].OPCObjects)
                        {
                            item.RegisterItems = 9999; //Workaround for setting the IsRegisteringInProcess bit to true
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Set group to be active or not active
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="isActive">Boolean to indicate the desired value</param>
        /// <remarks></remarks>
        public override void SetGroupActive(string groupName, bool isActive)
        {
            if (_opcGroupDetails[groupName].IsGroupConnected)
            {
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive = isActive;
            }
        }

        /// <summary>
        /// Set group to be active or not active
        /// </summary>
        /// <param name="parentForm">Name of the parent form</param>
        /// <param name="isActive">Boolean to indicate the desired value</param>
        /// <remarks></remarks>
        public void SetGroupActive(IHaveOpcObjects parentForm, bool isActive)
        {
            foreach (string groupName in _frmOpcGroupMap[parentForm])
            {
                if (_opcGroupDetails[groupName].IsGroupConnected)
                {
                    MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsActive = isActive;
                }
            }
        }

        public void SetGroupSynchronized(string groupName, bool isSyncronized)
        {
            if (_opcGroupDetails[groupName].IsGroupConnected)
            {
                _opcGroupDetails[groupName].IsGroupSyncronized = isSyncronized;
            }
        }

        /// <summary>
        /// Set the specified group to subscribe
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="isSubscribed">Boolean value to indicate the desired state</param>
        /// <remarks></remarks>
        public void SetGroupSubscribed(string groupName, bool isSubscribed)
        {
            if (_opcGroupDetails.ContainsKey(groupName) && _opcGroupDetails[groupName].IsGroupConnected)
            {
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsSubscribed = isSubscribed;
            }
        }

        /// <summary>
        /// Set the specified group to subscribe
        /// </summary>
        /// <param name="parentForm">Name of the parent form</param>
        /// <param name="isSubscribed">Boolean value to indicate the desired state</param>
        /// <remarks></remarks>
        public void SetGroupSubscribed(IHaveOpcObjects parentForm, bool isSubscribed)
        {
            foreach (string groupName in _frmOpcGroupMap[parentForm])
            {
                if (_opcGroupDetails.ContainsKey(groupName) && _opcGroupDetails[groupName].IsGroupConnected)
                {
                    MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsSubscribed = isSubscribed;
                }
            }
        }

        /// <summary>
        /// Set group update rate
        /// </summary>
        /// <param name="groupName">Name of the group</param>
        /// <param name="updateRate">Update rate in milliseconds</param>
        /// <remarks></remarks>
        public void SetGroupUpdateRate(string groupName, int updateRate)
        {
            if (_opcGroupDetails[groupName].IsGroupConnected)
            {
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).UpdateRate = updateRate;
            }
        }

        /// <summary>
        /// To determine if the Opc Communication is being initialized.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsInitializingOpcCommunication
        {
            get
            {
                return _isInitializingOpcCommunication;
            }
            set
            {
                _isInitializingOpcCommunication = value;
            }
        }
        #endregion
        private void _myOpcGroup_AsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            string groupName = _asyncGroupPendingTable[TransactionID];
            List<IOpcObject> listOfOpcObjects = FillItemValuesToObjects(groupName, NumItems, ClientHandles, ItemValues, TimeStamps);
            lock (ASYNC_GROUP_LOCK)
            {
                _asyncGroupPendingTable.Remove(TransactionID);
            }
            AsyncReadCompleted?.Invoke(groupName, listOfOpcObjects);
        }

        /// <summary>
        /// Async read by the group name
        /// </summary>
        /// <param name="groupName">Group name to perform read operation</param>
        /// <returns>Transaction ID for the operation</returns>
        /// <remarks></remarks>
        public int AsyncRead(string groupName)
        {
            if (!MyOpcServer.OPCGroups.GetOPCGroup(groupName).IsSubscribed)
            {
                throw new ArgumentException("AsyncRead can not be called if the property IsSubscribed for the group is set to false in the OpcComm.OpenOpcComm!!");
            }
            try
            {
                int numberOfItems = MyOpcServer.OPCGroups.Item[groupName].OPCItems.Count;
                int[] count = { numberOfItems };
                int[] lowerBound = { 1 };
                Array errors = Array.CreateInstance(typeof(int), count, lowerBound);
                Array serverHandles = Array.CreateInstance(typeof(int), count, lowerBound);
                int index = 1;
                int tempTransaction = GetCurrentOpcTransactionID();
                foreach (OpcItemKey key in _opcItems.Keys)
                {
                    if (key.GroupName == groupName)
                    {
                        serverHandles.SetValue((int)key.ServerHandle, index);
                        index++;
                    }
                }
                MyOpcServer.OPCGroups.GetOPCGroup(groupName).AsyncRead(numberOfItems, serverHandles, errors, tempTransaction, 0);
                lock (ASYNC_GROUP_LOCK)
                {
                    _asyncGroupPendingTable.Add(tempTransaction, groupName);
                }
                return tempTransaction;
            }
            catch (COMException ex)
            {
                throw new OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode);
            }
        }

        public int AsyncRefresh(string groupName)
        {
            if (!MyOpcServer.OPCGroups.Item[groupName].IsSubscribed && !MyOpcServer.OPCGroups.Item[groupName].IsActive)
            {
                throw new ArgumentException("This Sub can not be called if the property IsSubscribed for the group is set to false in the OpcComm.OpenOpcComm!!");
            }
            int cancelID;
            int tempID = GetCurrentOpcTransactionID();
            MyOpcServer.OPCGroups.GetOPCGroup(groupName).AsyncRefresh(Opc_DS_DEVICE, tempID, out cancelID);
            lock (ASYNC_GROUP_LOCK)
            {
                _asyncGroupPendingTable.Add(tempID, groupName);
            }
            return tempID;
        }

        /// <summary>
        /// Get current transaction ID and also advance the ID index
        /// </summary>
        /// <returns>Current transaction ID</returns>
        /// <remarks></remarks>
        private static int GetCurrentOpcTransactionID()
        {
            int currentTransactionID = OpcTransactionIDIndex;
            OpcTransactionIDIndex++;
            return currentTransactionID;
        }

        /// <summary>
        /// Use this to write to items in the Opc in an Async manner
        /// </summary>
        /// <param name="groupName">Name of the group to perform async operation</param>
        /// <returns>The transaction ID for the transaction</returns>
        /// <remarks>-1 will return if no async operation executed.</remarks>
        public override int AsyncWrite(string groupName)
        {
            try
            {
                if (_asyncPendingItems.ContainsKey(groupName))
                {
                    int numberOfItems = _asyncPendingItems[groupName].Count;
                    if (numberOfItems > 0)
                    {
                        int[] count = { numberOfItems };
                        int[] lowerBound = { 1 };
                        Array listOfTags = Array.CreateInstance(typeof(string), count, lowerBound);
                        Array errors = Array.CreateInstance(typeof(int), count, lowerBound);
                        Array serverHandles = Array.CreateInstance(typeof(int), count, lowerBound);
                        Array values = Array.CreateInstance(typeof(object), count, lowerBound);
                        int index = 1;
                        foreach (string tag in _asyncPendingItems[groupName].Keys)
                        {
                            try
                            {
                                OpcItemKey key = _opcItems.GetKey(tag);
                                listOfTags.SetValue(key.PlcTagName, index);
                                serverHandles.SetValue(key.ServerHandle, index);
                                values.SetValue(_asyncPendingItems[groupName][tag], index);
                            }
                            catch (Exception ex)
                            {
                                WriteUserMessageToLog(string.Format("Async Write - {0}", ex.Message));
                            }
                            //listOfTags.SetValue(tag, index);
                            //serverHandles.SetValue(GetItemServerHandle(groupName, tag), index);
                            //values.SetValue(_asyncPendingItems[groupName][tag], index);
                            index++;
                        }
                        int tempID = GetCurrentOpcTransactionID();
                        MyOpcServer.OPCGroups.Item[groupName].AsyncWrite(numberOfItems, serverHandles, values, errors, tempID, 0);
                        lock (ASYNC_GROUP_LOCK)
                        {
                            _asyncGroupPendingTable.Add(tempID, groupName);
                        }
                        return tempID;
                    }
                }
                return -1;
            }
            catch (COMException ex)
            {
                throw new OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode);
            }
        }

        /// <summary>
        /// Use this to write to items in the OPC in an Sync manner
        /// </summary>
        /// <param name="groupName">Name of the group to perform async operation</param>
        /// <returns>The transaction ID for the transaction</returns>
        /// <remarks>-1 will return if no sync operation executed.</remarks>
        public override int SyncWrite(string groupName)
        {
            try
            {
                if (_asyncPendingItems.ContainsKey(groupName))
                {
                    int numberOfItems = _asyncPendingItems[groupName].Count;
                    if (numberOfItems > 0)
                    {
                        int[] count = { numberOfItems };
                        int[] lowerBound = { 1 };
                        Array listOfTags = Array.CreateInstance(typeof(string), count, lowerBound);
                        Array errors = Array.CreateInstance(typeof(int), count, lowerBound);
                        Array serverHandles = Array.CreateInstance(typeof(int), count, lowerBound);
                        Array values = Array.CreateInstance(typeof(object), count, lowerBound);
                        int index = 1;
                        foreach (string tag in _asyncPendingItems[groupName].Keys)
                        {
                            try
                            {
                                OpcItemKey key = _opcItems.GetKey(tag);
                                listOfTags.SetValue(key.PlcTagName, index);
                                serverHandles.SetValue(key.ServerHandle, index);
                                values.SetValue(_asyncPendingItems[groupName][tag], index);
                            }
                            catch (Exception ex)
                            {
                                WriteUserMessageToLog(string.Format("Async Write - {0}", ex.Message));
                            }
                            //listOfTags.SetValue(tag, index);
                            //serverHandles.SetValue(GetItemServerHandle(groupName, tag), index);
                            //values.SetValue(_asyncPendingItems[groupName][tag], index);
                            index++;
                        }
                        int tempID = GetCurrentOpcTransactionID();
                        MyOpcServer.OPCGroups.Item[groupName].SyncWrite(numberOfItems, serverHandles, values, errors);

                        return tempID;
                    }
                }
                return -1;
            }
            catch (COMException ex)
            {
                throw new OpcComExceptions(OpcComExceptions.GetOPCErrorMessage(ex.ErrorCode), ex.ErrorCode);
            }
        }

        /// <summary>
        /// Get class object from the list
        /// </summary>
        /// <param name="plcName">PLC topic name where the tag belongs to</param>
        /// <param name="opcObjectTagName">Tag name of the class object</param>
        /// <returns>Class object</returns>
        /// <remarks>Tag name should be unique.</remarks>
        public IOpcObject GetOpcObject(string plcName, string opcObjectTagName)
        {
            if (_opcItemObjects.Contains(plcName, opcObjectTagName))
            {
                return _opcItemObjects.Item[plcName, opcObjectTagName];
            }
            else
            {
                throw new ArgumentException(string.Format("[{0}]{1} can not be found!!", plcName, opcObjectTagName));
            }
        }

        public override void AddOpcObjects(params IOpcObject[] opcObjects)
        {
            foreach (IOpcObject opcObject in opcObjects)
            {
                AddOpcObject(opcObject);
            }
        }
        #endregion
    }
}
