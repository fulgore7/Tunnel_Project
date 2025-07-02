namespace TunnelProject.Opc
{
    public class OpcCommStatusEvent : EventArgs
    {
        public DateTime TimeStamp { get; }
        public string GroupName { get; }
        public string Message { get; }
        public OPC_COMM_TYPE InfoType { get; }

        public OpcCommStatusEvent(DateTime timeStamp, string groupName, string message, OPC_COMM_TYPE infoType)
        {
            TimeStamp = timeStamp;
            GroupName = groupName;
            Message = message;
            InfoType = infoType;
        }
    }
}
