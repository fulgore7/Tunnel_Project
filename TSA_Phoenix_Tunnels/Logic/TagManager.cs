using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSA_Phoenix_Tunnels.Models;
using TSA_Phoenix_Tunnels.OPC.DA;

namespace TSA_Phoenix_Tunnels.Logic
{   /// <summary>
    /// Event args for tag update, can be raised in tests.
    /// </summary>
    public class TagUpdatedEventArgs : EventArgs
    {
        public Tag Tag { get; }
        public TagUpdatedEventArgs(Tag tag) => Tag = tag;
    }

    /// <summary>
    /// Interface for TagManager to allow TDD & mocking.
    /// </summary>
    public interface ITagManager : IDisposable
    {
        event EventHandler<TagUpdatedEventArgs> TagUpdated;
        void AddTag(string tagName);
        IEnumerable<Tag> GetTags();
        Tag GetTag(string tagName);
        bool WriteTag(string tagName, object value);
    }

    /// <summary>
    /// TagManager mediates between OPCDAClient and UI.
    /// Compatible with TDD via ITagManager and dependency injection.
    /// </summary>
    public class TagManager : ITagManager
    {
        private readonly IOPCDAClient _opcClient;
        private readonly Dictionary<string, Tag> _tags = new Dictionary<string, Tag>();

        public event EventHandler<TagUpdatedEventArgs> TagUpdated;

        /// <summary>
        /// Inject IOPCDAClient for TDD/mocking.
        /// </summary>
        public TagManager(IOPCDAClient opcClient)
        {
            _opcClient = opcClient ?? throw new ArgumentNullException(nameof(opcClient));
            _opcClient.TagValueChanged += OpcClient_TagValueChanged;
        }

        /// <summary>
        /// Add a tag for subscription and management.
        /// </summary>
        public virtual void AddTag(string tagName)
        {
            _opcClient.SubscribeTag(tagName);
            if (!_tags.ContainsKey(tagName))
                _tags[tagName] = new Tag { Name = tagName };
        }

        /// <summary>
        /// Returns all managed tags.
        /// </summary>
        public virtual IEnumerable<Tag> GetTags() => _tags.Values;

        /// <summary>
        /// Returns a single tag by name.
        /// </summary>
        public virtual Tag GetTag(string tagName)
        {
            _tags.TryGetValue(tagName, out var tag);
            return tag;
        }
        public virtual bool WriteTag(string tagName, object value)
        {
            // Expose write through to OPCDAClient
            var writeTagMethod = _opcClient.GetType().GetMethod("WriteTag");
            if (writeTagMethod != null)
                return (bool)writeTagMethod.Invoke(_opcClient, new object[] { tagName, value });
            return false;
        }
        /// <summary>
        /// Handles tag value changes. Virtual for TDD.
        /// </summary>
        protected virtual void OpcClient_TagValueChanged(object sender, TagValueChangedEventArgs e)
        {
            _tags[e.Tag.Name] = e.Tag;
            TagUpdated?.Invoke(this, new TagUpdatedEventArgs(e.Tag));
        }

        /// <summary>
        /// Unsubscribe from events and clean resources.
        /// </summary>
        public virtual void Dispose()
        {
            _opcClient.TagValueChanged -= OpcClient_TagValueChanged;
            _opcClient.Dispose();
        }

    }
}
