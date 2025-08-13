using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using TSA_Phoenix_Tunnels.OPC.DA;
using TSA_Phoenix_Tunnels.Models;

namespace Tunnel_Test
{
    [TestFixture]
    public class OpcDaClientTests
    {
        private OpcDaConfig _config;
        private OPCDAClient _client;

        [SetUp]
        public void SetUp()
        {
            // Adjust path if needed based on your test project directory.
            string configPath = "C:\\Users\\colem160\\source\\repos\\TunnelProject\\Tunnel_Project\\TSA_Phoenix_Tunnels\\Config\\phoenix.json";
            Assert.That(File.Exists(configPath), $"Config file not found: {configPath}");

            _config = OpcDaConfigLoader.Load(configPath);

            _client = new OPCDAClient();
        }

        [Test]
        public void Connect_And_ReadAllTags_ReturnsValues()
        {
            // Connect to OPC DA server using config
            bool connected = _client.Connect(_config);
            Assert.IsTrue(connected, "Failed to connect to OPC DA server.");

            // Read all tags listed in config and print their values
            var results = new List<Tag>();
            foreach (var tagName in _config.Tags)
            {
                var value = _client.ReadTag(tagName);
                results.Add(new Tag
                {
                    Name = tagName,
                    Value = value,
                    // Optionally, you could fill Quality/Timestamp if needed
                });
            }

            // Output (for demonstration/logging)
            foreach (var tag in results)
            {
                TestContext.WriteLine($"Tag: {tag.Name}, Value: {tag.Value}");
            }

            Assert.That(results.Count, Is.EqualTo(_config.Tags.Count), "Not all tags were read.");
            foreach (var tag in results)
            {
                Assert.That(tag.Value, Is.Not.Null, $"Tag '{tag.Name}' returned null value.");
            }
        }

        [TearDown]
        public void TearDown()
        {
            _client?.Dispose();
        }
    }
}