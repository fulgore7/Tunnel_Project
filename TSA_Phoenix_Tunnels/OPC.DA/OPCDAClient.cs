using System;
using System.Collections.Generic;
using TSA_Phoenix_Tunnels.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TSA_Phoenix_Tunnels.OPC.DA
{
    // Event args for tag value changed
    public class TagValueChangedEventArgs : EventArgs
    {
        public Tag Tag { get; }

        public TagValueChangedEventArgs(Tag tag)
        {
            Tag = tag;
        }
    }

    public class OPCDAClient
    {
        // Raised when a tag value changes
        public event EventHandler<TagValueChangedEventArgs> TagValueChanged;

        public bool Connect(string serverProgId, string host = null)
        {
            // TODO: Implement OPC DA connection logic
            return true;
        }

        public object ReadTag(string tagName)
        {
            // TODO: Implement tag read logic
            return null;
        }

        public void SubscribeTag(string tagName)
        {
            // TODO: Implement tag subscription logic
        }

        // This should be called internally when a tag value changes
        protected virtual void OnTagValueChanged(Tag tag)
        {
            TagValueChanged?.Invoke(this, new TagValueChangedEventArgs(tag));
        }
    }
}
