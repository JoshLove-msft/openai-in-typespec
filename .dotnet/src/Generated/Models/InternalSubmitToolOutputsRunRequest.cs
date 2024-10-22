// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalSubmitToolOutputsRunRequest
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalSubmitToolOutputsRunRequest(IEnumerable<ToolOutput> toolOutputs)
        {
            Argument.AssertNotNull(toolOutputs, nameof(toolOutputs));

            ToolOutputs = toolOutputs.ToList();
        }

        internal InternalSubmitToolOutputsRunRequest(IList<ToolOutput> toolOutputs, bool? stream, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            ToolOutputs = toolOutputs;
            Stream = stream;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<ToolOutput> ToolOutputs { get; }

        public bool? Stream { get; set; }
    }
}
