// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class FunctionChatMessage : ChatMessage
    {
        internal FunctionChatMessage(string content, string name, string role, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(role, additionalBinaryDataProperties)
        {
            Content = content;
            Name = name;
        }

        public string Content { get; set; }
    }
}
