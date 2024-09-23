// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class RunTruncationStrategy
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal RunTruncationStrategy(InternalTruncationObjectType @type, int? lastMessages, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Type = @type;
            LastMessages = lastMessages;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalTruncationObjectType Type { get; set; }
    }
}
