namespace TunnelProject.Opc
{
    internal sealed class OpcObjectKey
    {
        public string GroupName { get; set; }
        public string PLCName { get; set; }
        public string TagName { get; set; }

        public OpcObjectKey(string plcName, string tagName, string groupName)
        {
            PLCName = plcName;
            TagName = tagName;
            GroupName = groupName;
        }

        public override string ToString()
        {
            return string.Format("[{0}]{1}", PLCName, TagName);
        }
    }
}
