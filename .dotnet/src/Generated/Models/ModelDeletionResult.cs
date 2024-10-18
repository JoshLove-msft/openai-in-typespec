// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Models
{
    public partial class ModelDeletionResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ModelDeletionResult(bool deleted, string modelId)
        {
            Deleted = deleted;
            ModelId = modelId;
        }

        internal ModelDeletionResult(bool deleted, string modelId, InternalDeleteModelResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Deleted = deleted;
            ModelId = modelId;
            this.Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public bool Deleted { get; }
    }
}
