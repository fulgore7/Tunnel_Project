using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdw_Sust.OpcDa.Core.Interfaces;

namespace Wdw_Sust.OpcDa.Core.Phoenix
{
    public class OpcObjectPhoenix : OpcObjectPhoenixBase, IOpcObjectPhoenix
    {
        public OpcObjectPhoenix(string plcName, string tagName, string groupName)
        {
            PlcName = plcName;
            TagName = tagName;
            GroupName = groupName;

        }
        /// <summary>
        /// Concrete implementation of OpcObjectBase for use with Phoenix OPC client
        /// </summary>
        public string PlcName { get; set; }
        public string GroupName { get; set; }
        public string TagName { get; set; }
        public object Value { get; set; }

        public DateTime TimeStamp { get; set; }
        protected override void ValueFromPlcToObject(int index, object value)
        {
            // In this simple implementation, we only have one property to update
            switch (index)
            {
                case 1:
                    Value = value;
                    break;
                default:
                    // Handle other properties if needed
                    throw new ArgumentOutOfRangeException(nameof(index), $"Property index {index} is not handled.");
            }
        }

    }
}
