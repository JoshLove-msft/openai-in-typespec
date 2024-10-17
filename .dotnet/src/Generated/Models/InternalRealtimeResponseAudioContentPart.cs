// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseAudioContentPart : ConversationContentPart
    {
        internal InternalRealtimeResponseAudioContentPart(string transcript, ConversationContentPartKind @type) : base(@type)
        {
            Transcript = transcript;
        }

        internal InternalRealtimeResponseAudioContentPart(string transcript, ConversationContentPartKind @type, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(@type, additionalBinaryDataProperties)
        {
            Transcript = transcript;
        }

        public string Transcript { get; }
    }
}
