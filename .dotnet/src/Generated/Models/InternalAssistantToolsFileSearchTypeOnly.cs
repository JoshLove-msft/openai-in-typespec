// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalAssistantToolsFileSearchTypeOnly
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalAssistantToolsFileSearchTypeOnly()
        {
        }

        internal InternalAssistantToolsFileSearchTypeOnly(InternalAssistantToolsFileSearchTypeOnlyType @type, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Type = @type;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalAssistantToolsFileSearchTypeOnlyType Type { get; } = "file_search";
    }
}
