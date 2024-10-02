// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Embeddings
{
    public partial class EmbeddingCollection : IJsonModel<EmbeddingCollection>
    {
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmbeddingCollection)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model);
            writer.WritePropertyName("usage"u8);
            writer.WriteObjectValue(Usage, options);
            writer.WritePropertyName("object"u8);
            writer.WriteObjectValue<InternalCreateEmbeddingResponseObject>(Object, options);
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        EmbeddingCollection IJsonModel<EmbeddingCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual EmbeddingCollection JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmbeddingCollection)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return EmbeddingCollection.DeserializeEmbeddingCollection(document.RootElement, options);
        }

        BinaryData IPersistableModel<EmbeddingCollection>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingCollection>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EmbeddingCollection)} does not support writing '{options.Format}' format.");
            }
        }

        EmbeddingCollection IPersistableModel<EmbeddingCollection>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual EmbeddingCollection PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<EmbeddingCollection>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return EmbeddingCollection.DeserializeEmbeddingCollection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EmbeddingCollection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EmbeddingCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(EmbeddingCollection embeddingCollection)
        {
            return BinaryContent.Create(embeddingCollection, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator EmbeddingCollection(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return EmbeddingCollection.DeserializeEmbeddingCollection(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
