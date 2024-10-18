// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatToolCall
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ChatToolCall(string id, InternalChatCompletionMessageToolCallFunction function, Chat.ChatToolCallKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Function = function;
            Kind = kind;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; set; }
    }
}
