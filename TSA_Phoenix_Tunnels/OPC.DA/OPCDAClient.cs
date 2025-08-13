using System;
using TSA_Phoenix_Tunnels.Models;
using System.Collections.Generic;
using System.Linq;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using System.Security.Policy;
using System.IO;
using System.Text.Json;


namespace TSA_Phoenix_Tunnels.OPC.DA
{

    
    //Data connection logic
    /// <summary>
    /// Event args for tag value change, for TDD you can raise this in tests.
    /// </summary>
    public class TagValueChangedEventArgs : EventArgs
    {
        public Tag Tag { get; }
        public TagValueChangedEventArgs(Tag tag) => Tag = tag;
    }

    /// <summary>
    /// Interface for OPCDAClient to allow TDD with mocking/stubbing.
    /// </summary>
    public interface IOPCDAClient : IDisposable
    {
        event EventHandler<TagValueChangedEventArgs> TagValueChanged;
        bool Connect(OpcDaConfig config);
        object ReadTag(string tagName);
        void SubscribeTag(string tagName);
    }

    /// <summary>
    /// Implementation of OPCDAClient, compatible with TDD and interface-based mocking.
    /// </summary>
    public class OPCDAClient : IOPCDAClient
    {
        private OpcDaServer _server;
        private OpcDaGroup _group;
        private readonly Dictionary<string, OpcDaItem> _items = new Dictionary<string, OpcDaItem>();
        private OpcDaConfig _config;

        public event EventHandler<TagValueChangedEventArgs> TagValueChanged;

        /// <summary>
        /// Connects to OPC DA server using configuration.
        /// </summary>
        public virtual bool Connect(OpcDaConfig config)
        {
            _config = config;

            Uri url = UrlBuilder.Build(config.ServerProgId);
            _server = new OpcDaServer(url);
            _server.Connect();

            _group = _server.AddGroup(config.GroupName ?? "MyGroup");
            _group.IsActive = true;
            _group.UpdateRate = TimeSpan.FromMilliseconds(config.UpdateRateMs);

            _group.ValuesChanged += OnGroupValuesChanged;

            if (_config.Tags != null)
            {
                foreach (var tag in _config.Tags)
                    SubscribeTag(tag);
            }
            return true;
        }
        public virtual bool WriteTag(string tagName, object value)
        {
            if (_group == null)
                throw new InvalidOperationException("Group not created. Connect first.");

            OpcDaItem item;
            if (!_items.TryGetValue(tagName, out item))
            {
                // Item not subscribed yet, so add it
                var definition = new OpcDaItemDefinition { ItemId = tagName, IsActive = true };
                var results = _group.AddItems(new[] { definition });
                if (results.Length > 0 && !results[0].Error.Failed)
                {
                    item = _group.Items[_group.Items.Count - 1];
                    _items[tagName] = item;
                }
                else
                    return false;
            }

            var items = new[] { item };
            var values = new[] { value };
            var resultsWrite = _group.Write(items, values);
            return resultsWrite.Length > 0 && !resultsWrite[0].Failed;
        }
        /// <summary>
        /// Reads a tag value synchronously. Virtual for TDD.
        /// </summary>
        public virtual object ReadTag(string tagName)
        {
            var definition = new OpcDaItemDefinition
            {
                ItemId = tagName,
                IsActive = true
            };

            _group.AddItems(new[] { definition });
            var item = _group.Items[_group.Items.Count - 1];

            var values = _group.Read(new[] { item }, OpcDaDataSource.Device);
            object value = values.Length > 0 ? values[0].Value : null;

            _group.RemoveItems(new[] { item });

            return value;
        }

        /// <summary>
        /// Subscribes to a tag for real-time changes. Virtual for TDD.
        /// </summary>
        public virtual void SubscribeTag(string tagName)
        {
            if (_items.ContainsKey(tagName))
                return;

            var definition = new OpcDaItemDefinition
            {
                ItemId = tagName,
                IsActive = true
            };

            var results = _group.AddItems(new[] { definition });
            if (results.Length > 0 && !results[0].Error.Failed)
            {
                _items[tagName] = _group.Items[_group.Items.Count - 1];
            }
        }

        /// <summary>
        /// Handles value changes and raises event. 
        /// Protected and virtual for TDD (can be overridden/mocked).
        /// </summary>
        protected virtual void OnGroupValuesChanged(object sender, OpcDaItemValuesChangedEventArgs args)
        {
            foreach (var value in args.Values)
            {
                var tag = new Tag
                {
                    Name = value.Item.ItemId,
                    Value = value.Value,
                    Quality = value.Quality.ToString(),
                    Timestamp = value.Timestamp
                };
                TagValueChanged?.Invoke(this, new TagValueChangedEventArgs(tag));
            }
        }

        /// <summary>
        /// Dispose pattern allows for TDD and resource release.
        /// </summary>
        public virtual void Dispose()
        {
            if (_group != null)
            {
                _group.ValuesChanged -= OnGroupValuesChanged;
                ///_group.Dispose();
                _group = null;
            }
            if (_server != null)
            {
                _server.Dispose();
                _server = null;
            }
            _items.Clear();
        }
    }
    #region JSON Config

    //JSON Config holder
    /// <summary>
    /// POCO for OPC DA configuration, compatible with TDD and mocking.
    /// </summary>
    public class OpcDaConfig
    {
        public string ServerProgId { get; set; }
        public string GroupName { get; set; } = "MyGroup";
        public int UpdateRateMs { get; set; } = 100;
        public List<string> Tags { get; set; } = new List<string>();
    }
    /// <summary>
    /// Loads OPC DA configuration from JSON files.
    /// TDD compatible: static method can be mocked or wrapped as needed.
    /// </summary>
    public static class OpcDaConfigLoader
    {
        public static OpcDaConfig Load(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<OpcDaConfig>(json);
        }
    }

    #endregion
}
