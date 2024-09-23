// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRequiredFunctionToolCall
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalRequiredFunctionToolCall(string id, InternalRunToolCallObjectFunction function)
        {
            Id = id;
            Function = function;
        }

        internal InternalRequiredFunctionToolCall(string id, InternalRunToolCallObjectType @type, InternalRunToolCallObjectFunction function, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Type = @type;
            Function = function;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; set; }

        public InternalRunToolCallObjectType Type { get; } = "function";

        public InternalRunToolCallObjectFunction Function { get; set; }
    }
}
