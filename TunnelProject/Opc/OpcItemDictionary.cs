using System.Linq;
using TunnelProject.Opc.Interfaces;

namespace TunnelProject.Opc
{
    internal class OpcItemDictionary : Dictionary<OpcItemKey, IOpcObject>
    {
        /// <summary>
        /// Gets the OPC object by PLC tag name.
        /// Throws if not found.
        /// </summary>
        public IOpcObject GetByPlcTagName(string plcTagName)
        {
            var key = this.Keys.FirstOrDefault(k => k.PlcTagName == plcTagName);
            if (key != null)
                return this[key];
            throw new ArgumentException($"PLC tag name '{plcTagName}' does not exist.");
        }

        /// <summary>
        /// Gets the OPC object by client handle.
        /// Throws if not found.
        /// </summary>
        public IOpcObject GetByClientHandle(int clientHandle)
        {
            var key = this.Keys.FirstOrDefault(k => k.ClientHandle == clientHandle);
            if (key != null)
                return this[key];
            throw new ArgumentException($"Client handle '{clientHandle}' does not exist.");
        }

        /// <summary>
        /// Tries to get the OPC object by PLC tag name.
        /// </summary>
        public bool TryGetByPlcTagName(string plcTagName, out IOpcObject value)
        {
            var key = this.Keys.FirstOrDefault(k => k.PlcTagName == plcTagName);
            if (key != null)
            {
                value = this[key];
                return true;
            }
            value = default;
            return false;
        }

        /// <summary>
        /// Tries to get the OPC object by client handle.
        /// </summary>
        public bool TryGetByClientHandle(int clientHandle, out IOpcObject value)
        {
            var key = this.Keys.FirstOrDefault(k => k.ClientHandle == clientHandle);
            if (key != null)
            {
                value = this[key];
                return true;
            }
            value = default;
            return false;
        }

        /// <summary>
        /// Checks if a PLC tag name exists.
        /// </summary>
        public bool ContainsPlcTagName(string plcTagName)
        {
            return this.Keys.Any(k => k.PlcTagName == plcTagName);
        }

        /// <summary>
        /// Checks if a client handle exists.
        /// </summary>
        public bool ContainsClientHandle(int clientHandle)
        {
            return this.Keys.Any(k => k.ClientHandle == clientHandle);
        }

        /// <summary>
        /// Gets the OpcItemKey by client handle.
        /// Throws if not found.
        /// </summary>
        public OpcItemKey GetKeyByClientHandle(int clientHandle)
        {
            var key = this.Keys.FirstOrDefault(k => k.ClientHandle == clientHandle);
            if (key != null)
                return key;
            throw new ArgumentException($"Client handle '{clientHandle}' is not defined.");
        }

        /// <summary>
        /// Gets the OpcItemKey by PLC tag name.
        /// Throws if not found.
        /// </summary>
        public OpcItemKey GetKeyByPlcTagName(string plcTagName)
        {
            var key = this.Keys.FirstOrDefault(k => k.PlcTagName == plcTagName);
            if (key != null)
                return key;
            throw new ArgumentException($"PLC tag name '{plcTagName}' is not defined.");
        }
    }
}
