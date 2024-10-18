// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal partial class InternalListVectorStoreFilesResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListVectorStoreFilesResponse(string firstId, string lastId, bool hasMore)
        {
            Data = new ChangeTrackingList<VectorStoreFileAssociation>();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        internal InternalListVectorStoreFilesResponse(InternalListVectorStoreFilesResponseObject @object, IReadOnlyList<VectorStoreFileAssociation> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Object = @object;
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalListVectorStoreFilesResponseObject Object { get; } = "list";

        public IReadOnlyList<VectorStoreFileAssociation> Data { get; }

        public string FirstId { get; }

        public string LastId { get; }

        public bool HasMore { get; }
    }
}
