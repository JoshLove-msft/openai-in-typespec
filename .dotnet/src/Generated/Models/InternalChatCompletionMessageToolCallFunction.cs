// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionMessageToolCallFunction
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalChatCompletionMessageToolCallFunction(string name, string arguments)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(arguments, nameof(arguments));

            Name = name;
            Arguments = arguments;
        }

        internal InternalChatCompletionMessageToolCallFunction(string name, string arguments, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            Arguments = arguments;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Name { get; set; }

        public string Arguments { get; set; }
    }
}
