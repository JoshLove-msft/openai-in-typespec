// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Embeddings
{
    public partial class OpenAIEmbedding
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal OpenAIEmbedding(int index, BinaryData embeddingProperty, InternalEmbeddingObject @object)
        {
            Index = index;
            EmbeddingProperty = embeddingProperty;
            this.Object = @object;
        }

        public int Index { get; set; }
    }
}
