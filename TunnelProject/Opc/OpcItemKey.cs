namespace TunnelProject.Opc
{
    internal sealed class OpcItemKey
    {
        private int _serverHandle;
        private readonly OpcComm _opcComm; // Add a reference to an OpcComm instance  

        public int ClientHandle { get; set; }

        public string PlcTagName { get; set; }

        public string GroupName { get; set; }

        public int ServerHandle
        {
            get
            {
                if (_serverHandle < 0)
                    _serverHandle = _opcComm.GetItemServerHandle(GroupName, PlcTagName); // Use the instance of OpcComm  
                return _serverHandle;
            }
            set
            {
                _serverHandle = value;
            }
        }

        public object Value { get; set; }

        public OpcItemKey(int clientHandle, string groupName, string tagName, OpcComm opcComm) // Add OpcComm as a parameter  
        {
            this.ClientHandle = clientHandle;
            PlcTagName = tagName;
            this.GroupName = groupName;
            ServerHandle = -1;
            _opcComm = opcComm ?? throw new ArgumentNullException(nameof(opcComm)); // Ensure OpcComm is not null  
        }
    }
}
