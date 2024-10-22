// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public abstract partial class ConversationTool
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected ConversationTool(ConversationToolKind kind)
        {
            Kind = kind;
        }

        internal ConversationTool(ConversationToolKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }
    }
}
