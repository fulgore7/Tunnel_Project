using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wdw_Sust.OpcDa.Core.Phoenix
{
    // Fix: Replace primary constructor with explicit constructor and assign parameters to properties
    public class OpcObjectPhoenixBase : OpcObjectBase
    {
        public string PlcName { get; set; }
        public string GroupName { get; set; }
        public string TagName { get; set; }
        public DateTime TimeStamp { get; set; }

        protected override void ValueFromPlcToObject(int index, object value)
        {
            throw new NotImplementedException();
        }
    }
}
