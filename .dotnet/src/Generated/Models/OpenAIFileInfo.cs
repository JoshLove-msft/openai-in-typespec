// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Files
{
    public partial class OpenAIFileInfo
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal OpenAIFileInfo(string id, int? bytes, DateTimeOffset createdAt, string filename, OpenAIFilePurpose purpose, OpenAIFileStatus status)
        {
            Id = id;
            Bytes = bytes;
            CreatedAt = createdAt;
            Filename = filename;
            Purpose = purpose;
            Status = status;
        }

        internal OpenAIFileInfo(string id, int? bytes, DateTimeOffset createdAt, string filename, InternalOpenAIFileObject @object, OpenAIFilePurpose purpose, OpenAIFileStatus status, string statusDetails, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Bytes = bytes;
            CreatedAt = createdAt;
            Filename = filename;
            Object = @object;
            Purpose = purpose;
            Status = status;
            StatusDetails = statusDetails;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Filename { get; set; }

        public OpenAIFilePurpose Purpose { get; set; }
    }
}
