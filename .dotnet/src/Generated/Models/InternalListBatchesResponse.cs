// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Batch
{
    internal partial class InternalListBatchesResponse
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListBatchesResponse(IEnumerable<InternalBatchJob> data, bool hasMore)
        {
            Data = data.ToList();
            HasMore = hasMore;
        }

        internal InternalListBatchesResponse(IList<InternalBatchJob> data, string firstId, string lastId, bool hasMore, InternalListBatchesResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<InternalBatchJob> Data { get; }

        public string FirstId { get; }

        public string LastId { get; }

        public bool HasMore { get; }

        public InternalListBatchesResponseObject Object { get; } = "list";
    }
}
