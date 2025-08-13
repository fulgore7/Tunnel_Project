using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da.Browsing;
using TitaniumAS.Opc.Client.Da;
using TSA_Phoenix_Tunnels.OPC.DA;

namespace Tunnel_Test
{
    internal class AllElements
    {
        [TestFixture]
        public class OpcDaBrowserTests
        {
            private OpcDaConfig _config;
            private OpcDaServer _server;

            [SetUp]
            public void SetUp()
            {
                // Adjust path as needed for your test project
                string configPath = "C:\\Users\\colem160\\source\\repos\\TunnelProject\\Tunnel_Project\\TSA_Phoenix_Tunnels\\Config\\phoenix.json";
                Assert.That(File.Exists(configPath), $"Config file not found: {configPath}");

                _config = OpcDaConfigLoader.Load(configPath);

                Uri url = UrlBuilder.Build(_config.ServerProgId);
                _server = new OpcDaServer(url);
                _server.Connect();
            }

            [Test]
            public void BrowseAllElements_Recursively_PrintsResults()
            {
                // Create a browser for the server
                var browser = new OpcDaBrowserAuto(_server);

                // Start recursive browse from the root
                BrowseChildren(browser, null, 0);
            }

            private void BrowseChildren(IOpcDaBrowser browser, string itemId, int indent)
            {
                // Get elements for current itemId (null means root)
                OpcDaBrowseElement[] elements = browser.GetElements(itemId);

                foreach (var element in elements)
                {
                    // Print the element name with indentation
                    TestContext.WriteLine($"{new string(' ', indent)}{element.ItemId} (HasChildren: {element.HasChildren})");

                    // Recurse into children
                    if (element.HasChildren)
                        BrowseChildren(browser, element.ItemId, indent + 2);
                }
            }

            [TearDown]
            public void TearDown()
            {
                if (_server != null)
                    _server.Dispose();
            }
        }
    }
}
