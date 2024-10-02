// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal partial class InternalCreateVectorStoreFileBatchRequest : IJsonModel<InternalCreateVectorStoreFileBatchRequest>
    {
        internal InternalCreateVectorStoreFileBatchRequest()
        {
        }

        void IJsonModel<InternalCreateVectorStoreFileBatchRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("file_ids"u8);
            writer.WriteStartArray();
            foreach (string item in FileIds)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ChunkingStrategy))
            {
                writer.WritePropertyName("chunking_strategy"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(ChunkingStrategy);
#else
                using (JsonDocument document = JsonDocument.Parse(ChunkingStrategy))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
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

        InternalCreateVectorStoreFileBatchRequest IJsonModel<InternalCreateVectorStoreFileBatchRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalCreateVectorStoreFileBatchRequest JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateVectorStoreFileBatchRequest(document.RootElement, options);
        }

        internal static InternalCreateVectorStoreFileBatchRequest DeserializeInternalCreateVectorStoreFileBatchRequest(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> fileIds = default;
            BinaryData chunkingStrategy = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("file_ids"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    fileIds = array;
                    continue;
                }
                if (prop.NameEquals("chunking_strategy"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        chunkingStrategy = null;
                        continue;
                    }
                    chunkingStrategy = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalCreateVectorStoreFileBatchRequest(fileIds, chunkingStrategy, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalCreateVectorStoreFileBatchRequest>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateVectorStoreFileBatchRequest IPersistableModel<InternalCreateVectorStoreFileBatchRequest>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalCreateVectorStoreFileBatchRequest PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCreateVectorStoreFileBatchRequest>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalCreateVectorStoreFileBatchRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateVectorStoreFileBatchRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateVectorStoreFileBatchRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalCreateVectorStoreFileBatchRequest internalCreateVectorStoreFileBatchRequest)
        {
            return BinaryContent.Create(internalCreateVectorStoreFileBatchRequest, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalCreateVectorStoreFileBatchRequest(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateVectorStoreFileBatchRequest(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
