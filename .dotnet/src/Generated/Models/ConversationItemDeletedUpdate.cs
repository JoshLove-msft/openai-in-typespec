// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationItemDeletedUpdate : ConversationUpdate
    {
        internal ConversationItemDeletedUpdate(string itemId, string eventId, RealtimeConversation.ConversationUpdateKind kind) : base(eventId, kind)
        {
            ItemId = itemId;
        }

        internal ConversationItemDeletedUpdate(string itemId, string eventId, RealtimeConversation.ConversationUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(eventId, kind, additionalBinaryDataProperties)
        {
            ItemId = itemId;
        }

        public string ItemId { get; set; }
    }
}
