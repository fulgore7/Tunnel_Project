using Wdw_Sust.OpcDa.core.Ph;

namespace Tunnel_Test
{
    public class PhoenixOpcCommTests
    {
        private PhoenixOpcComm _opcComm;

        [SetUp]
        public void Setup()
        {
            _opcComm = new PhoenixOpcComm();
        }

        [TearDown]
        public void TearDown()
        {
            _opcComm.TryCloseOpcComm();
            _opcComm.Dispose();
        }

        [Test]
        public void OpenOpcComm_WithValidConfig_ShouldConnect()
        {
            // Arrange
            var config = new OpcDaConfig
            {
                ServerProgId = "PhoenixContact.AX-Server.21",
                GroupName = "MyGroup",
                UpdateRateMs = 1000
            };

            // Act
            _opcComm.OpenOpcComm(
                    config.GroupName,
                    config.UpdateRateMs,
                    true,   // isSubscribed
                    true,   // isActive
                    true,   // isSyncronized
                    false   // opcGlobalDataChangeEventSuppressing
                );
            // Assert
            Assert.IsTrue(_opcComm.IsServerRunning(), "Server should be running after opening communication.");
        }

        [Test]
        public void OpenOpcComm_WithoutConfig_ShouldThrowException()
        {
            // Arrange

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _opcComm.OpenOpcComm(), "Calling OpenOpcComm without a config should throw an InvalidOperationException.");
        }

        [Test]
        public void AddOpcObject_And_Subscribe_ShouldWork()
        {
            // Arrange
            var config = new OpcDaConfig
            {
                ServerProgId = "PhoenixContact.AX-Server.21",
                GroupName = "MyGroup",
                UpdateRateMs = 1000,
                Tags = new List<string> { "MyPLC.Cycles", "MyPLC.Wash_Cycle", "MyPLC.MainQ" }
            };
            _opcComm.OpenOpcComm(
                    config.GroupName,
                    config.UpdateRateMs,
                    true,   // isSubscribed
                    true,   // isActive
                    true,   // isSyncronized
                    false   // opcGlobalDataChangeEventSuppressing
                );

            // Act
            foreach (var tag in config.Tags)
            {
                _opcComm.SubscribeTag(tag);
            }

            var tagNames = _opcComm.GetAllTagNames();

            // Assert
            Assert.AreEqual(config.Tags.Count, tagNames.Length, "The number of subscribed tags should match the number of tags in the config.");
            CollectionAssert.AreEquivalent(config.Tags, tagNames, "The subscribed tags should be equivalent to the tags in the config.");
            Assert.Contains("MyPLC.MainQ", config.Tags);
            // Note: GetAllTagNames currently returns from _opcObjects, which is populated by AddOpcObject, not SubscribeTag directly.
            // This test assumes future or different implementation logic.
            // For now, we can check if the initial tag is in the config.
        }

        [Test]
        public void WriteTag_And_ReadTag_ShouldMatch()
        {
            // Arrange
            var config = new OpcDaConfig
            {
                ServerProgId = "PhoenixContact.AX-Server.21",
                GroupName = "MyGroup"
            };
            _opcComm.OpenOpcComm(
                   config.GroupName,
                   config.UpdateRateMs,
                   true,   // isSubscribed
                   true,   // isActive
                   true,   // isSyncronized
                   false   // opcGlobalDataChangeEventSuppressing
               );
            string tagName = "MyPLC.Cycles";
            object writeValue = 0;

            // Act
            bool writeSuccess = _opcComm.WriteTag(tagName, writeValue);
            object readValue = _opcComm.ReadTag(tagName);

            // Assert
            Assert.IsTrue(writeSuccess, "WriteTag should return true on success.");
            Assert.AreEqual(writeValue, Convert.ToDouble(readValue), "Read value should match the written value.");
        }

        [Test]
        public void ReadTagTeest()
        {
            // Arrange
            var config = new OpcDaConfig
            {
                ServerProgId = "PhoenixContact.AX-Server.21",
                GroupName = "MyGroup"
            };
            _opcComm.OpenOpcComm(
                   config.GroupName,
                   config.UpdateRateMs,
                   true,   // isSubscribed
                   true,   // isActive
                   true,   // isSyncronized
                   false   // opcGlobalDataChangeEventSuppressing
               );
            string tagName = "MyPLC.Cycles";

            // Act
            object readValue = _opcComm.ReadTag(tagName);
            Assert.AreEqual(1, Convert.ToDouble(readValue), "Read value should match the written value.");
        }
    }
}