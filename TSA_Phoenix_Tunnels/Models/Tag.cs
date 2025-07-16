using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA_Phoenix_Tunnels.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public string Quality { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
