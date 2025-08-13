using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA_Phoenix_Tunnels.Models
{
    /// <summary>
    /// Tag model for OPC DA, easy to mock and use in TDD.
    /// </summary>
    public class Tag
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public string Quality { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
