// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath()
        {
        }

        internal InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath(string fileId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FileId = fileId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string FileId { get; }
    }
}
