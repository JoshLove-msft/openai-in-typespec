// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatFunctionCall
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ChatFunctionCall(string functionName, string functionArguments, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FunctionName = functionName;
            FunctionArguments = functionArguments;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }
    }
}
