// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.VectorStores
{
    public partial class VectorStoreCreationOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public VectorStoreCreationOptions()
        {
            FileIds = new ChangeTrackingList<string>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal VectorStoreCreationOptions(IList<string> fileIds, string name, VectorStoreExpirationPolicy expiresAfter, BinaryData chunkingStrategy, IDictionary<string, string> metadata, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FileIds = fileIds;
            Name = name;
            ExpiresAfter = expiresAfter;
            ChunkingStrategy = chunkingStrategy;
            Metadata = metadata;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<string> FileIds { get; }

        public string Name { get; set; }

        public IDictionary<string, string> Metadata { get; set; }
    }
}
