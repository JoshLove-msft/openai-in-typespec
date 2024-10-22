// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationInputTranscriptionOptions
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public ConversationInputTranscriptionOptions()
        {
        }

        internal ConversationInputTranscriptionOptions(ConversationTranscriptionModel? model, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Model = model;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public ConversationTranscriptionModel? Model { get; set; }
    }
}
