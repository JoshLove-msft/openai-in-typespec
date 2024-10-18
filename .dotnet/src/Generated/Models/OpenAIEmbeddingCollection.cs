// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Embeddings
{
    public partial class OpenAIEmbeddingCollection
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal OpenAIEmbeddingCollection(string model, EmbeddingTokenUsage usage)
        {
            Model = model;
            Usage = usage;
        }

        internal OpenAIEmbeddingCollection(string model, EmbeddingTokenUsage usage, InternalCreateEmbeddingResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Model = model;
            Usage = usage;
            this.Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Model { get; }

        public EmbeddingTokenUsage Usage { get; }
    }
}
