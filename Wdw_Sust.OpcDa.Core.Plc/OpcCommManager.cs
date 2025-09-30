using System;
using Wdw_Sust.Core;
using Wdw_Sust.OpcDa.core.Phoenix;
using Wdw_Sust.OpcDa.Core;
using Wdw_Sust.OpcDa.Core.Interfaces;

namespace Wdw_Sust.OpcDa.core
{
    /// <summary>
    /// Specifies the type of OPC server to connect to.
    /// </summary>
    public enum OpcServerType
    {
        /// <summary>
        /// Phoenix Contact OPC Server.
        /// </summary>
        Phoenix,

        /// <summary>
        /// Allen-Bradley (RSLinx) OPC Server.
        /// </summary>
        AllenBradley
    }

    /// <summary>
    /// Manages the creation of OPC communication client instances.
    /// </summary>
    public class OpcCommManager : IOpcComm, IDisposable
    {
        private IOpcComm _opcComm;
        private bool _disposedValue;

        /// <summary>
        /// Gets or sets a flag indicating if the application is in the process of closing.
        /// </summary>
        public bool IsApplicationClosing
        {
            get => _opcComm?.IsApplicationClosing ?? false;
            set
            {
                if (_opcComm != null)
                    _opcComm.IsApplicationClosing = value;
            }
        }

        /// <summary>
        /// Event fired when data values for subscribed OPC items change.
        /// </summary>
        public event IOpcComm.GlobalDataChangeEventEventHandler GlobalDataChangeEvent
        {
            add
            {
                if (_opcComm != null)
                    _opcComm.GlobalDataChangeEvent += value;
            }
            remove
            {
                if (_opcComm != null)
                    _opcComm.GlobalDataChangeEvent -= value;
            }
        }

        /// <summary>
        /// Event fired when there is an error related to the OPC server state.
        /// </summary>
        public event IOpcComm.OpcServerStateErrorEventHandler OpcServerStateError
        {
            add
            {
                if (_opcComm != null)
                    _opcComm.OpcServerStateError += value;
            }
            remove
            {
                if (_opcComm != null)
                    _opcComm.OpcServerStateError -= value;
            }
        }

        /// <summary>
        /// Gets an instance of an OPC communication client based on the specified server type.
        /// </summary>
        /// <param name="serverType">The type of OPC server.</param>
        /// <returns>An instance of IOpcComm for the specified server type.</returns>
        private IOpcComm GetInstance(OpcServerType serverType)
        {
            switch (serverType)
            {
                case OpcServerType.Phoenix:
                    return SingletonProviderBase<PhoenixOpcComm>.get_Instance();

                case OpcServerType.AllenBradley:
                    // Fix: Use get_Instance() instead of Instance property
                    return SingletonProviderBase<OpcComm>.get_Instance();

                default:
                    throw new ArgumentException("Invalid OPC server type specified.", nameof(serverType));
            }
        }

        /// <summary>
        /// Adds an IOpcObject and subscribes to all its associated PLC tags.
        /// </summary>
        /// <param name="opcObject">The OPC object to add.</param>
        /// <returns>The total number of registered IOpcObjects.</returns>
        /// <exception cref="ArgumentNullException">Thrown if opcObject is null.</exception>
        public int AddOpcObject(IOpcObject opcObject)
        {
            if (opcObject == null)
                throw new ArgumentNullException(nameof(opcObject));

            // Determine server type based on opcObject type
            switch (opcObject)
            {
                case IOpcObjectPhoenix _:
                    _opcComm = GetInstance(OpcServerType.Phoenix);
                    break;

                case IOpcObjectAllenBradley _:
                    _opcComm = GetInstance(OpcServerType.AllenBradley);
                    break;

                // Add other OPC object types here as needed
                default:
                    // Default to AllenBradley for non-Phoenix objects
                    throw new NotImplementedException();
            }

            return _opcComm?.AddOpcObject(opcObject) ?? 0;
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
            // Determine server type based on T type

            object[] contructorArgs = new object[] { plcName, tagName, groupName };
            T temp = (T)Activator.CreateInstance(typeof(T), contructorArgs);
            AddOpcObject(temp);
            return temp;
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
            // Determine server type based on T type

            object[] contructorArgs = new object[] { plcName, tagName, groupName, parentForm };
            T temp = (T)Activator.CreateInstance(typeof(T), contructorArgs);
            AddOpcObject(temp);
            return temp;
        }

        /// <summary>
        /// Adds multiple IOpcObject instances at once.
        /// </summary>
        /// <param name="opcObjects">An array of IOpcObjects to add.</param>
        public void AddOpcObjects(params IOpcObject[] opcObjects)
        {
            if (opcObjects == null || opcObjects.Length == 0)
                return;

            foreach (var opcObject in opcObjects)
            {
                if (opcObject == null)
                {
                    throw new ArgumentNullException(nameof(opcObject), "One of the provided IOpcObjects is null.");
                }
                AddOpcObjects(opcObject);
            }
        }

        /// <summary>
        /// Asynchronously writes values for all items in a group.
        /// </summary>
        /// <param name="groupName">The name of the group to write to.</param>
        /// <returns>An integer indicating the result or number of items written.</returns>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public int AsyncWrite(string groupName)
        {
            EnsureOpcCommInstance();

            return _opcComm?.AsyncWrite(groupName) ?? 0;
        }

        /// <summary>
        /// Closes the OPC communication and disposes all resources.
        /// </summary>
        public void CloseOpcComm()
        {
            EnsureOpcCommInstance();

            _opcComm?.CloseOpcComm();
        }

        /// <summary>
        /// Closes communication for a specific group, optionally clearing client handles.
        /// </summary>
        /// <param name="groupName">The name of the group to close.</param>
        /// <param name="clearClientHandles">If true, removes items belonging to the group.</param>
        public void CloseOpcComm(string groupName, bool clearClientHandles)
        {
            EnsureOpcCommInstance();

            _opcComm?.CloseOpcComm(groupName, clearClientHandles);
        }

        /// <summary>
        /// Gets an array of all registered PLC tag names.
        /// </summary>
        /// <returns>An array of strings containing the tag names.</returns>
        public string[] GetAllTagNames()
        {
            EnsureOpcCommInstance();

            return _opcComm?.GetAllTagNames() ?? new string[0];
        }

        /// <summary>
        /// Gets the total number of registered IOpcObject instances.
        /// </summary>
        /// <returns>The count of IOpcObjects.</returns>
        public int GetNumberOfOpcItems()
        {
            EnsureOpcCommInstance();

            return _opcComm?.GetNumberOfOpcItems() ?? 0;
        }

        /// <summary>
        /// Checks if the OPC server is currently connected.
        /// </summary>
        /// <returns>True if the server is connected, otherwise false.</returns>
        public bool IsServerRunning()
        {
            EnsureOpcCommInstance();

            return _opcComm?.IsServerRunning() ?? false;
        }

        /// <summary>
        /// Opens the OPC communication using the current configuration.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the configuration is not set.</exception>
        public void OpenOpcComm()
        {
            EnsureOpcCommInstance();

            _opcComm.OpenOpcComm();
        }

        /// <summary>
        /// Opens OPC communication based on a parent form's context.
        /// </summary>
        /// <param name="frm">The parent form implementing IHaveOpcObjects.</param>
        /// <param name="updateRate">The update rate in milliseconds.</param>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public void OpenOpcComm(IHaveOpcObjects frm, int updateRate = 1000)
        {
            EnsureOpcCommInstance();

            _opcComm.OpenOpcComm(frm, updateRate);
        }

        /// <summary>
        /// Opens OPC communication with custom group settings.
        /// </summary>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public void OpenOpcComm(string groupName, int updateRate = 1000, bool isSubscribed = true, bool isActive = true, bool isSyncronized = true, bool opcGlobalDataChangeEventSuppressing = false)
        {
            EnsureOpcCommInstance();
            _opcComm.OpenOpcComm(groupName, updateRate, isSubscribed, isActive, isSyncronized, opcGlobalDataChangeEventSuppressing);
        }

        private OpcServerType GetServerTypeByGroupName(string groupName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the active state of a specific group.
        /// </summary>
        /// <param name="groupName">The name of the group.</param>
        /// <param name="isActive">The desired active state.</param>
        public void SetGroupActive(string groupName, bool isActive)
        {
            EnsureOpcCommInstance();
            _opcComm?.SetGroupActive(groupName, isActive);
        }

        /// <summary>
        /// Synchronously writes values for all items in a group.
        /// </summary>
        /// <param name="groupName">The name of the group to write to.</param>
        /// <returns>An integer indicating the result or number of items written.</returns>
        /// <exception cref="NotImplementedException">This method is not yet implemented.</exception>
        public int SyncWrite(string groupName)
        {
            EnsureOpcCommInstance();
            return _opcComm?.SyncWrite(groupName) ?? 0;
        }

        /// <summary>
        /// Attempts to close the OPC communication and safely handles exceptions.
        /// </summary>
        /// <returns>True if the connection was closed successfully, otherwise false.</returns>
        public bool TryCloseOpcComm()
        {
            try
            {
                _opcComm?.TryCloseOpcComm();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Ensures the OPC communication instance is initialized with the specified server type.
        /// </summary>
        /// <param name="serverType">The type of OPC server to initialize.</param>
        private void EnsureOpcCommInstance()
        {
            if (_opcComm == null)
            {
                _opcComm = GetInstance(OpcServerType.AllenBradley);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    if (_opcComm is IDisposable disposableOpc)
                    {
                        disposableOpc.Dispose();
                    }
                    _opcComm = null;
                }
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}