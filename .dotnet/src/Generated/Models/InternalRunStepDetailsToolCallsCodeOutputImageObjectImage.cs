// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsCodeOutputImageObjectImage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalRunStepDetailsToolCallsCodeOutputImageObjectImage(string fileId)
        {
            FileId = fileId;
        }

        internal InternalRunStepDetailsToolCallsCodeOutputImageObjectImage(string fileId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FileId = fileId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string FileId { get; set; }
    }
}
