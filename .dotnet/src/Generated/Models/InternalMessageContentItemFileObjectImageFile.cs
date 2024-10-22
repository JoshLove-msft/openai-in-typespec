// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageContentItemFileObjectImageFile
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalMessageContentItemFileObjectImageFile(string fileId)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));

            FileId = fileId;
        }

        internal InternalMessageContentItemFileObjectImageFile(string fileId, string detail, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FileId = fileId;
            Detail = detail;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string FileId { get; set; }
    }
}
