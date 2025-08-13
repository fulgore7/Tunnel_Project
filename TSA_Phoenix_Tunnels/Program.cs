using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSA_Phoenix_Tunnels.Logic;
using TSA_Phoenix_Tunnels.OPC.DA;
using TSA_Phoenix_Tunnels.UI;

namespace TSA_Phoenix_Tunnels
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load config and connect
            string configPath = "C:\\Users\\colem160\\source\\repos\\TunnelProject\\Tunnel_Project\\TSA_Phoenix_Tunnels\\Config\\phoenix.json";
            var config = OpcDaConfigLoader.Load(configPath);
            var opcClient = new OPCDAClient();
            opcClient.Connect(config);

            // Setup TagManager and subscribe tags
            var tagManager = new TagManager(opcClient);
            tagManager.AddTag("Wash_Cycle");
            tagManager.AddTag("MainQ");
            tagManager.AddTag("Cycles");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(tagManager));
        }
    }
}
