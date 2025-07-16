using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSA_Phoenix_Tunnels.Models;
using TSA_Phoenix_Tunnels.OPC.DA;

namespace TSA_Phoenix_Tunnels.Logic
{
    // Event args for tag update
    public class TagUpdatedEventArgs : EventArgs
    {
        public Tag Tag { get; }
        public TagUpdatedEventArgs(Tag tag)
        {
            Tag = tag;
        }
    }

    public class TagManager
    {
        private readonly OPCDAClient _opcClient;
        private readonly Dictionary<string, Tag> _tags = new();

        public event EventHandler<TagUpdatedEventArgs> TagUpdated;

        public TagManager(OPCDAClient opcClient)
        {
            _opcClient = opcClient;
            _opcClient.TagValueChanged += OpcClient_TagValueChanged;
        }

        // Add a tag to be managed and subscribed
        public void AddTag(string tagName)
        {
            _opcClient.SubscribeTag(tagName);
            _tags[tagName] = new Tag { Name = tagName };
        }

        public IEnumerable<Tag> GetTags() => _tags.Values;

        public Tag GetTag(string tagName)
        {
            _tags.TryGetValue(tagName, out var tag);
            return tag;
        }

        private void OpcClient_TagValueChanged(object sender, TagValueChangedEventArgs e)
        {
            // Update cache
            _tags[e.Tag.Name] = e.Tag;
            // Notify subscribers
            TagUpdated?.Invoke(this, new TagUpdatedEventArgs(e.Tag));
        }
    }
}
