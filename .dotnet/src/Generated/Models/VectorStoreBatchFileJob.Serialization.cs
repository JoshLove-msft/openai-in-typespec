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
    public partial class VectorStoreBatchFileJob : IJsonModel<VectorStoreBatchFileJob>
    {
        internal VectorStoreBatchFileJob()
        {
        }

        void IJsonModel<VectorStoreBatchFileJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<VectorStoreBatchFileJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreBatchFileJob)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            writer.WritePropertyName("vector_store_id"u8);
            writer.WriteStringValue(VectorStoreId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(BatchId);
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

        VectorStoreBatchFileJob IJsonModel<VectorStoreBatchFileJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual VectorStoreBatchFileJob JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<VectorStoreBatchFileJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreBatchFileJob)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorStoreBatchFileJob(document.RootElement, options);
        }

        internal static VectorStoreBatchFileJob DeserializeVectorStoreBatchFileJob(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalVectorStoreFileBatchObjectObject @object = default;
            DateTimeOffset createdAt = default;
            string vectorStoreId = default;
            VectorStoreBatchFileJobStatus status = default;
            string batchId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalVectorStoreFileBatchObjectObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("vector_store_id"u8))
                {
                    vectorStoreId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    status = new VectorStoreBatchFileJobStatus(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    batchId = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new VectorStoreBatchFileJob(
                @object,
                createdAt,
                vectorStoreId,
                status,
                batchId,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<VectorStoreBatchFileJob>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<VectorStoreBatchFileJob>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VectorStoreBatchFileJob)} does not support writing '{options.Format}' format.");
            }
        }

        VectorStoreBatchFileJob IPersistableModel<VectorStoreBatchFileJob>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual VectorStoreBatchFileJob PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<VectorStoreBatchFileJob>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeVectorStoreBatchFileJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VectorStoreBatchFileJob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VectorStoreBatchFileJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(VectorStoreBatchFileJob vectorStoreBatchFileJob)
        {
            return BinaryContent.Create(vectorStoreBatchFileJob, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator VectorStoreBatchFileJob(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeVectorStoreBatchFileJob(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
