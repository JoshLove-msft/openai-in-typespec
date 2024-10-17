// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationFunctionCallArgumentsDoneUpdate : ConversationUpdate
    {
        internal ConversationFunctionCallArgumentsDoneUpdate(string responseId, string itemId, int outputIndex, string callId, string name, string arguments, string eventId) : base(eventId, RealtimeConversation.ConversationUpdateKind.ResponseFunctionCallArgumentsDone)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            CallId = callId;
            Name = name;
            Arguments = arguments;
        }

        internal ConversationFunctionCallArgumentsDoneUpdate(string responseId, string itemId, int outputIndex, string callId, string name, string arguments, string eventId, RealtimeConversation.ConversationUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(eventId, kind, additionalBinaryDataProperties)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            CallId = callId;
            Name = name;
            Arguments = arguments;
        }

        public string ResponseId { get; }

        public string ItemId { get; }

        public int OutputIndex { get; }

        public string CallId { get; }

        public string Name { get; }

        public string Arguments { get; }
    }
}
