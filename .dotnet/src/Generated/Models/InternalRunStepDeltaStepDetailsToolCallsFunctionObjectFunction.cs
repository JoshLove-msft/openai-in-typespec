// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction()
        {
        }

        internal InternalRunStepDeltaStepDetailsToolCallsFunctionObjectFunction(string name, string arguments, string output, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            Arguments = arguments;
            Output = output;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Name { get; }

        public string Arguments { get; }

        public string Output { get; }
    }
}
