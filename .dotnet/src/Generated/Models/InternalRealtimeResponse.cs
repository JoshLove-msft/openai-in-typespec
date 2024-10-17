// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalRealtimeResponse(string id, ConversationStatus status, InternalRealtimeResponseStatusDetails statusDetails, ConversationTokenUsage usage, IEnumerable<ConversationItem> output)
        {
            Id = id;
            Status = status;
            StatusDetails = statusDetails;
            Usage = usage;
            Output = output.ToList();
        }

        internal InternalRealtimeResponse(InternalRealtimeResponseObject @object, string id, ConversationStatus status, InternalRealtimeResponseStatusDetails statusDetails, ConversationTokenUsage usage, IReadOnlyList<ConversationItem> output, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Object = @object;
            Id = id;
            Status = status;
            StatusDetails = statusDetails;
            Usage = usage;
            Output = output;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalRealtimeResponseObject Object { get; } = "realtime.response";

        public string Id { get; }

        public ConversationStatus Status { get; }

        public InternalRealtimeResponseStatusDetails StatusDetails { get; }

        public ConversationTokenUsage Usage { get; }
    }
}
