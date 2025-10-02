using System;
using System.Collections.Generic;
using NUnit.Framework;
using Wdw_Sust.OpcDa.Core.Plc.AllenBradley;

namespace Tunnel_Test
{
    //Concrete implementation
    public class TestOpcTagGenerator : OpcTagGeneratorBase
    {
        protected override string GenerateOpcElementTagName(IOpcObject obj)
        {
            return $"[{obj.PlcName}]{obj.TagName}";
        }

        protected override string GenerateOpcTagName(string plcTopicName, string tagName, string subTagName)
        {
            return $"[{plcTopicName}]{tagName}.{subTagName}";
        }

        public override string HandleOpcArrayTagName(string tagName, string propertyName, int index)
        {
            // No transformation for now
            return tagName;
        }
    }

    // fake IOpcObject so the test can run
    public class FakeOpcObject : IOpcObject
    {
        public string PlcName { get; set; } = "";
        public string TagName { get; set; } = "";
        public string[] FilterProperties { get; set; } = Array.Empty<string>();
        public Dictionary<string, int> ListOfOpcTags { get; } = new();

        // --- Unused members for test,
        public string GroupName { get; set; } = "";
        public bool IsRegisteringInProgress => false;
        public bool IsSerializable => false;
        public int RegisterItems { get; set; }
        public DateTime TimeStamp { get; set; }

        public event EventHandler ItemsRegisteringCompleted;
        public event EventHandler PropertiesUpdateCompleted;

        public string GetPlcTagName(string itemName) => "";
        public string[] GetPlcTagNames() => Array.Empty<string>();
        public int GetPropertyIndex(string plcTag) => -1;
        public void RaisePropertiesUpdatedEvent(EventArgs e) { }
        public IOpcObject ShallowClone() => this;
        public void ValueFromObjectToPlc(string itemName, object value, bool asyncWrite = false) { }
        public void ValueFromPlcToObject(int index, object value) { }
    }

    // The actual NUnit test
    [TestFixture]
    public class OpcTagGeneratorTests
    {
        [Test]
        public void GenerateOpcTags_ReturnsExpectedTags()
        {
            // Arrange
            var generator = new TestOpcTagGenerator();
            var obj = new FakeOpcObject
            {
                PlcName = "ASA_Main",
                TagName = "Mass_Towel_Productivity_Data",
                FilterProperties = Array.Empty<string>()
            };

            // Act
            var tags = generator.GenerateOpcTags(obj);

            // Assert
            Assert.That(tags, Is.Not.Null);
            Assert.That(tags.Length, Is.EqualTo(1)); // For now, single-tag scenario
            Assert.That(tags[0], Does.Contain("[ASA_Main]Mass_Towel_Productivity_Data"));
        }
    }
}
