namespace TunnelProject.Opc
{
    using System;
    using System.Collections.Generic;
    using TunnelProject.Opc.Interfaces;

   
    
        public class OpcGroupDataChangeEventArgs : System.EventArgs
        {
            public List<IOpcObject> ListOfOpcObjects { get; }

            public OpcGroupDataChangeEventArgs(List<IOpcObject> listOfOPCObjects)
            {
                ListOfOpcObjects = listOfOPCObjects;
            }
        }
    }

