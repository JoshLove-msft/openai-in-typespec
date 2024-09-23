// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionResponseMessage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalChatCompletionResponseMessage(string content, string refusal)
        {
            Content = content;
            Refusal = refusal;
            ToolCalls = new ChangeTrackingList<ChatToolCall>();
        }

        internal InternalChatCompletionResponseMessage(string content, string refusal, IList<ChatToolCall> toolCalls, InternalChatCompletionResponseMessageRole role, InternalChatCompletionResponseMessageFunctionCall functionCall, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Content = content;
            Refusal = refusal;
            ToolCalls = toolCalls;
            Role = role;
            FunctionCall = functionCall;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Refusal { get; set; }

        public IList<ChatToolCall> ToolCalls { get; }
    }
}
