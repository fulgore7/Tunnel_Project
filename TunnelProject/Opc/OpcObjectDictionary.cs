namespace TunnelProject.Opc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TunnelProject.Opc.Interfaces;

    internal class OpcObjectDictionary : Dictionary<OPCObjectKey, IOpcObject>
    {
        public bool Contains(string plcName, string tagName)
        {
            foreach (OPCObjectKey k in Keys)
            {
                if (k.TagName == tagName && k.PLCName == plcName)
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(string groupName)
        {
            var itemsToBeRemoved = new List<OPCObjectKey>();
            foreach (OPCObjectKey key in Keys)
            {
                if (key.GroupName == groupName)
                {
                    itemsToBeRemoved.Add(key);
                }
            }
            foreach (OPCObjectKey key in itemsToBeRemoved)
            {
                this[key] = null;
                base.Remove(key);
            }
        }

        public IOpcObject Item(string plcName, string tagName)
        {
            foreach (OPCObjectKey s in Keys.ToList())
            {
                if (s.PLCName == plcName && s.TagName == tagName)
                {
                    return base[s];
                }
            }
            throw new ArgumentException("Key Does Not Exist");
        }

        public IOpcObject Item(OPCObjectKey key)
        {
            return base[key];
        }
    }
}
