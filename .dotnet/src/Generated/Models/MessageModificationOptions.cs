// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class MessageModificationOptions
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public MessageModificationOptions()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal MessageModificationOptions(IDictionary<string, string> metadata, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Metadata = metadata;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IDictionary<string, string> Metadata { get; set; }
    }
}
