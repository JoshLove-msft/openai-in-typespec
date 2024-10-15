// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationContentPartStartedUpdate : ConversationUpdate
    {
        internal ConversationContentPartStartedUpdate(string responseId, string itemId, int outputIndex, int contentIndex, ConversationContentPart internalContentPart, string eventId, RealtimeConversation.ConversationUpdateKind kind) : base(eventId, kind)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
        }

        internal ConversationContentPartStartedUpdate(string responseId, string itemId, int outputIndex, int contentIndex, ConversationContentPart internalContentPart, string eventId, RealtimeConversation.ConversationUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(eventId, kind, additionalBinaryDataProperties)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
        }

        public string ResponseId { get; set; }

        public string ItemId { get; set; }

        public int OutputIndex { get; set; }

        public int ContentIndex { get; set; }
    }
}
