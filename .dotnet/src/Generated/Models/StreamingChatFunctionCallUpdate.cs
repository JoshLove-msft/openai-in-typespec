// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class StreamingChatFunctionCallUpdate
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal StreamingChatFunctionCallUpdate()
        {
        }

        internal StreamingChatFunctionCallUpdate(string functionName, BinaryData functionArgumentsUpdate, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FunctionName = functionName;
            FunctionArgumentsUpdate = functionArgumentsUpdate;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }
    }
}
