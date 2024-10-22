// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Internal
{
    internal partial class InternalResponseFormatJsonSchemaSchema
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalResponseFormatJsonSchemaSchema()
        {
            _additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        internal InternalResponseFormatJsonSchemaSchema(IDictionary<string, BinaryData> additionalProperties)
        {
            _additionalBinaryDataProperties = additionalProperties;
        }

        public IDictionary<string, BinaryData> AdditionalProperties => _additionalBinaryDataProperties;
    }
}
