// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Batch
{
    internal partial class InternalBatchErrors
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalBatchErrors()
        {
            Data = new ChangeTrackingList<InternalBatchError>();
        }

        internal InternalBatchErrors(InternalBatchErrorsObject? @object, IList<InternalBatchError> data, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Object = @object;
            Data = data;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalBatchErrorsObject? Object { get; }

        public IList<InternalBatchError> Data { get; }
    }
}
