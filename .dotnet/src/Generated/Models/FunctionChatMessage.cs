// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Chat
{
    public partial class FunctionChatMessage : ChatMessage
    {
        public FunctionChatMessage(string functionName, Chat.ChatMessageRole role) : base(role)
        {
            Argument.AssertNotNull(functionName, nameof(functionName));

            FunctionName = functionName;
        }

        internal FunctionChatMessage(string functionName, Chat.ChatMessageRole role, ChatMessageContent content, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(role, content, additionalBinaryDataProperties)
        {
            FunctionName = functionName;
        }
    }
}
