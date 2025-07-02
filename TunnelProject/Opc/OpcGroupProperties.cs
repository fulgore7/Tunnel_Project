namespace TunnelProject.Opc
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Wdw_Sust.OpcDa.Core.EventArgs;
    using Wdw_Sust.OpcDa.Core.Interfaces;
    using Wdw_Sust.Core.Helpers;
    using TunnelProject.Opc.Interfaces;

    public sealed class OpcGroupProperties : IDisposable
    {
        #region Fields  

        private bool _isGroupConnected;
        private bool _isGroupSyncronized;
        private bool _isAsyncInProgress;
        private Dictionary<string, int> _opcPLCTagList = new Dictionary<string, int>();
        private List<IOpcObject> _opcObjects = new List<IOpcObject>();
        private bool _isOPCGlobalDataChangeEventSuppressing;

        #endregion

        #region Events  
        /// <summary>  
        /// This event will only be raised if IsOPCGlobalDataChangeEventSuppressing is set to true   
        /// </summary>  
        public event EventHandler<OpcGroupDataChangeEventArgs> DataChangeEvent;
        #endregion

        #region Properties  
        internal bool IsAsyncInProgress
        {
            get { return _isAsyncInProgress; }
            set { _isAsyncInProgress = value; }
        }

        public bool IsGroupSyncronized
        {
            get { return _isGroupSyncronized; }
            set { _isGroupSyncronized = value; }
        }

        public bool IsGroupConnected
        {
            get { return _isGroupConnected; }
            set { _isGroupConnected = value; }
        }

        public bool IsOPCGlobalDataChangeEventSuppressing
        {
            get { return _isOPCGlobalDataChangeEventSuppressing; }
            set { _isOPCGlobalDataChangeEventSuppressing = value; }
        }

        internal List<IOpcObject> OPCObjects
        {
            get { return _opcObjects; }
        }
        #endregion

        #region Constructors  
        public OpcGroupProperties()
        {
            _isGroupConnected = false;
            _isGroupSyncronized = true;
        }
        #endregion

        #region Methods  

        internal bool AddTag(string plcTagName, int clientHandle)
        {
            if (!_opcPLCTagList.ContainsKey(plcTagName))
            {
                _opcPLCTagList.Add(plcTagName, clientHandle);
                return true;
            }
            return false;
        }

        internal List<string> GetListOfTags()
        {
            return new List<string>(_opcPLCTagList.Keys);
        }

        internal int GetPLCTagCounts()
        {
            return _opcPLCTagList.Count;
        }

        internal int GetClientHandle(string plcTagName)
        {
            return _opcPLCTagList[plcTagName];
        }

        internal List<int> GetClientHandles()
        {
            var listOfHandles = new List<int>();
            foreach (var tag in GetListOfTags())
            {
                listOfHandles.Add(GetClientHandle(tag));
            }
            return listOfHandles;
        }

        internal List<string> GetPLCTagNames()
        {
            var list = new List<string>();
            foreach (var pair in _opcPLCTagList)
            {
                list.Add(pair.Key);
            }
            return list;
        }

        internal string GetPLCTagName(int clientHandle)
        {
            foreach (var de in _opcPLCTagList)
            {
                if (de.Value == clientHandle)
                    return de.Key;
            }
            throw new Exception("Tag is not defined for the client handle!!");
        }

        internal Dictionary<string, int> GetPLCTagNameWithHandles()
        {
            return _opcPLCTagList;
        }

        internal void AddOPCItemObjectToList(IOpcObject item)
        {
            _opcObjects.Add(item);
        }

        /// <summary>  
        /// This method will only be fired if IsOPCGlobalDataChangeEventSuppressing is set to true   
        /// </summary>  
        internal void RaiseGroupDataChangeEvent(OpcGroupDataChangeEventArgs e)
        {
            if (OpcComm.ThreadMode == OpcThreadMode.MULTI_THREADED)
            {
                Helpers.RaiseMultiThreadedEvent(DataChangeEvent, new object[] { this, e });
            }
            else
            {
                DataChangeEvent?.Invoke(this, e);
            }
        }
        #endregion

        #region IDisposable Support  
        private bool disposedValue = false; // To detect redundant calls  

        private void Dispose(bool disposing) // Changed from protected virtual to private  
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _opcObjects.Clear();
                    _opcPLCTagList.Clear();
                    _opcObjects = null;
                    _opcPLCTagList = null;
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
