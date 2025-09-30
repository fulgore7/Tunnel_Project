using System;
using System.Collections.Generic;
using System.Linq;
using Wdw_Sust.OpcDa.Core.Interfaces;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using Wdw_Sust.Core;
using Wdw_Sust.OpcDa.Core.EventArgs;
using Newtonsoft.Json;
using System.IO;

namespace Wdw_Sust.OpcDa.Core.Phoenix
{
    /// <summary>
    /// Manages a connection to an OPC DA server, handling item subscriptions and data changes.
    /// This class implements the IOpcComm interface for OPC communication and IDisposable for resource management.
    /// </summary>
    public class PhoenixOpcComm : IOpcComm, IDisposable
    {
        // The OPC DA server instance from the TitaniumAS client library.
        private OpcDaServer _server;

        // The group on the OPC server to which items are added for monitoring.
        private OpcDaGroup _group;

        // A dictionary to store and manage subscribed OPC items, keyed by their tag name.
        private readonly Dictionary<string, OpcDaItem> _items = new Dictionary<string, OpcDaItem>();

        // A dictionary mapping PLC tag names to higher-level IOpcObject instances.
        private readonly Dictionary<string, IOpcObject> _opcObjects = new Dictionary<string, IOpcObject>();

        // Configuration for the OPC connection, including server details and update rates.
        private readonly OpcDaConfig _config;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the PhoenixOpcComm class with configuration loaded from JSON file.
        /// </summary>
        public PhoenixOpcComm()
        {
            const string configPath = "C:\\Users\\colem160\\source\\repos\\TunnelProject\\Tunnel_Project\\TSA_Phoenix_Tunnels\\Config\\phoenix.json";
            
            if (!System.IO.File.Exists(configPath))
                throw new System.IO.FileNotFoundException($"Configuration file not found: {configPath}");

            try
            {
                var json = File.ReadAllText(configPath);
                _config = JsonConvert.DeserializeObject<OpcDaConfig>(json);

                if (_config == null)
                    throw new InvalidOperationException("Failed to deserialize configuration from JSON.");
                
                // Initialize Tags list if null
                if (_config.Tags == null)
                    _config.Tags = new List<string>();
            }
            catch (Exception ex) when (!(ex is System.IO.FileNotFoundException))
            {
                throw new InvalidOperationException($"Error loading configuration from {configPath}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Gets or sets a flag indicating if the application is in the process of closing.
        /// </summary>
        public bool IsApplicationClosing { get; set; }

        /// <summary>
        /// Event fired when data values for subscribed OPC items change.
        /// </summary>
        public event IOpcComm.GlobalDataChangeEventEventHandler GlobalDataChangeEvent;

        /// <summary>
        /// Event fired when there is an error related to the OPC server state.
        /// </summary>
        public event IOpcComm.OpcServerStateErrorEventHandler OpcServerStateError;

        /// <summary>
        /// Adds an IOpcObject and subscribes to all its associated PLC tags.
        /// </summary>
        /// <param name="opcObject">The OPC object to add.</param>
        /// <returns>The total number of registered IOpcObjects.</returns>
        /// <exception cref="ArgumentNullException">Thrown if opcObject is null.</exception>
        public int AddOpcObject(IOpcObject opcObject)
        {
            if (opcObject == null)
            {
                throw new ArgumentNullException(nameof(opcObject));
            }

            // Use LINQ Where to filter tag names not already tracked, then subscribe.
            foreach (var tagName in opcObject.GetPlcTagNames().Where(tagName => !_opcObjects.ContainsKey(tagName)))
            {
                _opcObjects.Add(tagName, opcObject);
                SubscribeTag(tagName);
            }

            return _opcObjects.Count;
        }

        /// <summary>
        /// Creates and adds an IOpcObject of a specific type.
        /// </summary>
        /// <typeparam name="T">The type of IOpcObject to create.</typeparam>
        /// <param name="plcName">The name of the PLC.</param>
        /// <param name="tagName">The primary tag name for the object.</param>
        /// <param name="groupName">The group name for the object.</param>
        /// <returns>The newly created and added IOpcObject.</returns>
        public T AddOpcObject<T>(string plcName, string tagName, string groupName) where T : IOpcObject
        {
            // Create an instance of T using its constructor.
            T obj = (T)Activator.CreateInstance(typeof(T), plcName, tagName, groupName);
            AddOpcObject(obj);
            return obj;
        }

        /// <summary>
        /// Creates and adds an IOpcObject, associating it with a parent container.
        /// </summary>
        /// <typeparam name="T">The type of IOpcObject to create.</typeparam>
        /// <param name="plcName">The name of the PLC.</param>
        /// <param name="tagName">The primary tag name for the object.</param>
        /// <param name="groupName">The group name for the object.</param>
        /// <param name="parentForm">The parent container that manages this object's lifecycle.</param>
        /// <returns>The newly created and added IOpcObject.</returns>
        public T AddOpcObject<T>(string plcName, string tagName, string groupName, IHaveOpcObjects parentForm) where T : IOpcObject
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds multiple IOpcObject instances at once.
        /// </summary>
        /// <param name="opcObjects">An array of IOpcObjects to add.</param>
        public void AddOpcObjects(params IOpcObject[] opcObjects)
        {
            if (opcObjects == null) return;
            foreach (var obj in opcObjects)
                AddOpcObject(obj);
        }

        /// <summary>
        /// Asynchronously writes values for all items in a group.
        /// </summary>
        /// <param name="groupName">The name of the group to write to.</param>
        /// <returns>An integer indicating the result or number of items written.</returns>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public int AsyncWrite(string groupName)
        {
            // Example: Write all items in the group asynchronously
            throw new NotImplementedException();
        }

        /// <summary>
        /// Closes the OPC communication and disposes all resources.
        /// </summary>
        public void CloseOpcComm()
        {
            Dispose();
        }

        /// <summary>
        /// Closes communication for a specific group, optionally clearing client handles.
        /// </summary>
        /// <param name="groupName">The name of the group to close.</param>
        /// <param name="clearClientHandles">If true, removes items belonging to the group.</param>
        public void CloseOpcComm(string groupName, bool clearClientHandles)
        {
            // If handles should be cleared, find and remove items from the OPC group.
            if (_group != null && clearClientHandles)
            {
                var itemsToRemove = _group.Items.Where(i => i.ItemId.StartsWith(groupName)).ToArray();
                if (itemsToRemove.Any())
                {
                    _group.RemoveItems(itemsToRemove);
                }
            }
        }

        /// <summary>
        /// Gets an array of all registered PLC tag names.
        /// </summary>
        /// <returns>An array of strings containing the tag names.</returns>
        public string[] GetAllTagNames()
        {
            return _opcObjects.Keys.ToArray();
        }

        /// <summary>
        /// Gets the total number of registered IOpcObject instances.
        /// </summary>
        /// <returns>The count of IOpcObjects.</returns>
        public int GetNumberOfOpcItems()
        {
            return _opcObjects.Count;
        }

        /// <summary>
        /// Checks if the OPC server is currently connected.
        /// </summary>
        /// <returns>True if the server is connected, otherwise false.</returns>
        public bool IsServerRunning()
        {
            return _server != null && _server.IsConnected;
        }

        /// <summary>
        /// Opens the OPC communication using the current configuration.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the configuration is not set.</exception>
        public void OpenOpcComm()
        {
            if (_config == null)
                throw new InvalidOperationException("Config not set. Use OpenOpcComm(config) or assign _config before calling.");

            // Establish connection to the OPC server.
            Uri url = UrlBuilder.Build(_config.ServerProgId);
            _server = new OpcDaServer(url);
            _server.Connect();

            // Add and configure a group for item subscriptions.
            _group = _server.AddGroup(_config.GroupName ?? "MyGroup");
            _group.IsActive = true;
            _group.UpdateRate = TimeSpan.FromMilliseconds(_config.UpdateRateMs);

            // Subscribe to the group's value change events.
            _group.ValuesChanged += OnGroupValuesChanged;

            // Subscribe to any tags defined in the initial configuration.
            if (_config.Tags != null)
            {
                foreach (var tag in _config.Tags)
                    SubscribeTag(tag);
            }
        }

        /// <summary>
        /// Opens OPC communication based on a parent form's context.
        /// </summary>
        /// <param name="frm">The parent form implementing IHaveOpcObjects.</param>
        /// <param name="updateRate">The update rate in milliseconds.</param>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public void OpenOpcComm(IHaveOpcObjects frm, int updateRate = 1000)
        {
            // Implementation depends on frm's structure
            throw new NotImplementedException();
        }

        /// <summary>
        /// Opens OPC communication with custom group settings.
        /// </summary>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public void OpenOpcComm(string groupName, int updateRate = 1000, bool isSubscribed = true, bool isActive = true, bool isSyncronized = true, bool opcGlobalDataChangeEventSuppressing = false)
        {
            // Custom group open logic
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the active state of a specific group.
        /// </summary>
        /// <param name="groupName">The name of the group.</param>
        /// <param name="isActive">The desired active state.</param>
        public void SetGroupActive(string groupName, bool isActive)
        {
            if (_group != null && _group.Name == groupName)
                _group.IsActive = isActive;
        }

        /// <summary>
        /// Synchronously writes values for all items in a group.
        /// </summary>
        /// <param name="groupName">The name of the group to write to.</param>
        /// <returns>An integer indicating the result or number of items written.</returns>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public int SyncWrite(string groupName)
        {
            // Example: Write all items in the group synchronously
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to close the OPC communication and safely handles exceptions.
        /// </summary>
        /// <returns>True if the connection was closed successfully, otherwise false.</returns>
        public bool TryCloseOpcComm()
        {
            try
            {
                Dispose();
                return true;
            }
            catch
            {
                // Log exception here if necessary.
                return false;
            }
        }

        /// <summary>
        /// Subscribes to a single PLC tag by adding it to the OPC group.
        /// </summary>
        /// <param name="tagName">The name of the tag to subscribe to.</param>
        /// <exception cref="InvalidOperationException">Thrown if the group is not initialized.</exception>
        public void SubscribeTag(string tagName)
        {
            // Avoid duplicate subscriptions.
            if (_items.ContainsKey(tagName))
                return;

            // Define the OPC item.
            var definition = new OpcDaItemDefinition
            {
                ItemId = tagName,
                IsActive = true
            };

            if (_group == null)
            {
                throw new InvalidOperationException("Group is not initialized. Call OpenOpcComm first.");
            }

            // Add the item to the group and store the result.
            var results = _group.AddItems(new[] { definition });
            if (results.Length > 0 && !results[0].Error.Failed)
            {
                _items[tagName] = _group.Items.First(i => i.ItemId == tagName);
            }
        }

        /// <summary>
        /// Reads the value of a single tag synchronously from the device.
        /// This is an inefficient method for frequent reads as it adds and removes the item each time.
        /// </summary>
        /// <param name="tagName">The name of the tag to read.</param>
        /// <returns>The value of the tag.</returns>
        public object ReadTag(string tagName)
        {
            var definition = new OpcDaItemDefinition
            {
                ItemId = tagName,
                IsActive = true
            };

            // Temporarily add the item to the group for reading.
            _group.AddItems(new[] { definition });
            var item = _group.Items[_group.Items.Count - 1];

            // Read the value directly from the source device.
            var values = _group.Read(new[] { item }, OpcDaDataSource.Device);
            object value = values.Length > 0 ? values[0].Value : null;

            // Remove the temporary item.
            _group.RemoveItems(new[] { item });

            return value;
        }

        /// <summary>
        /// Writes a value to a single tag synchronously.
        /// </summary>
        /// <param name="tagName">The name of the tag to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <returns>True if the write was successful, otherwise false.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the group is not created.</exception>
        public bool WriteTag(string tagName, object value)
        {
            if (_group == null)
                throw new InvalidOperationException("Group not created. Connect first.");

            OpcDaItem item;
            // If the item is not already subscribed, add it.
            if (!_items.TryGetValue(tagName, out item))
            {
                var definition = new OpcDaItemDefinition { ItemId = tagName, IsActive = true };
                var results = _group.AddItems(new[] { definition });
                if (results.Length > 0 && !results[0].Error.Failed)
                {
                    item = _group.Items[_group.Items.Count - 1];
                    _items[tagName] = item;
                }
                else
                {
                    return false; // Failed to add the item.
                }
            }

            // Write the value to the item.
            var items = new[] { item };
            var values = new[] { value };
            var resultsWrite = _group.Write(items, values);
            return resultsWrite.Length > 0 && !resultsWrite[0].Failed;
        }

        /// <summary>
        /// Processes changed item values and updates the corresponding IOpcObject instances.
        /// </summary>
        /// <param name="groupName">The name of the group where the change occurred.</param>
        /// <param name="changedValues">The array of changed item values.</param>
        /// <returns>A list of IOpcObjects that were updated.</returns>
        private List<IOpcObject> FillItemValuesToObjects(string groupName, OpcDaItemValue[] changedValues)
        {
            var listOfItems = new List<IOpcObject>();

            foreach (var itemValue in changedValues)
            {
                // Find the IOpcObject associated with the changed tag.
                if (!_opcObjects.TryGetValue(itemValue.ToString(), out var opcItem))
                {
                    // An item was received that is not mapped to an IOpcObject.
                    continue;
                }

                // Determine the property index within the IOpcObject.
                int tempIndex = opcItem.GetPropertyIndex(itemValue.ToString());

                // Update the object's property with the new value from the PLC.
                opcItem.ValueFromPlcToObject(tempIndex, itemValue.Value);

                // If the object hasn't been added to the list and is not being registered, add it.
                if (!listOfItems.Contains(opcItem) && !opcItem.IsRegisteringInProgress)
                {
                    opcItem.TimeStamp = itemValue.Timestamp.ToLocalTime().UtcDateTime;
                    listOfItems.Add(opcItem);
                }
            }
            return listOfItems;
        }

        /// <summary>
        /// Event handler for the OpcDaGroup.ValuesChanged event.
        /// </summary>
        /// <param name="sender">The OpcDaGroup that raised the event.</param>
        /// <param name="args">The event arguments containing the changed values.</param>
        protected virtual void OnGroupValuesChanged(object sender, OpcDaItemValuesChangedEventArgs args)
        {
            var groupName = (sender as OpcDaGroup)?.Name ?? string.Empty;
            // Update the business objects with the new values.
            var updatedOpcObjects = FillItemValuesToObjects(groupName, args.Values);

            // If there are subscribers, raise the global data change event.
            if (GlobalDataChangeEvent != null)
            {
                //var eventArgs = new OpcGroupDataChangeEventArgs(updatedOpcObjects);
                GlobalDataChangeEvent(groupName, updatedOpcObjects);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Unsubscribe from events to prevent memory leaks.
                    if (_group != null)
                    {
                        _group.ValuesChanged -= OnGroupValuesChanged;
                        // Groups are often managed by the server and disposed when the server is disposed.
                        // If OpcDaGroup implements IDisposable, it should be disposed here.
                        
                        _group = null;
                    }
                    // Dispose the server connection.
                    if (_server != null)
                    {
                        _server.Dispose();
                        _server = null;
                    }
                    // Clear local collections.
                    _items.Clear();
                    _opcObjects.Clear();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    /// <summary>
    /// Holds configuration settings for an OPC DA connection.
    /// </summary>
    public sealed class OpcDaConfig
    {
        /// <summary>
        /// The Program ID of the OPC DA server (e.g., "Kepware.KEPServerEX.V6").
        /// </summary>
        public string ServerProgId { get; set; }
        
        /// <summary>
        /// The name of the group to create on the server.
        /// </summary>
        public string GroupName { get; set; } = "MyGroup";

        /// <summary>
        /// The desired update rate for the group in milliseconds.
        /// </summary>
        public int UpdateRateMs { get; set; } = 100;

        /// <summary>
        /// A list of tags to subscribe to automatically upon connection.
        /// </summary>
        public List<string> Tags { get; set; } = new List<string>();
    }
}