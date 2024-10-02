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
    public partial class FileFromStoreRemovalResult : IJsonModel<FileFromStoreRemovalResult>
    {
        internal FileFromStoreRemovalResult()
        {
        }

        void IJsonModel<FileFromStoreRemovalResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileFromStoreRemovalResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileFromStoreRemovalResult)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(FileId);
            writer.WritePropertyName("deleted"u8);
            writer.WriteBooleanValue(Removed);
            writer.WritePropertyName("object"u8);
            writer.WriteObjectValue<InternalDeleteVectorStoreFileResponseObject>(Object, options);
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

        FileFromStoreRemovalResult IJsonModel<FileFromStoreRemovalResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual FileFromStoreRemovalResult JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileFromStoreRemovalResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileFromStoreRemovalResult)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileFromStoreRemovalResult(document.RootElement, options);
        }

        internal static FileFromStoreRemovalResult DeserializeFileFromStoreRemovalResult(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileId = default;
            bool removed = default;
            InternalDeleteVectorStoreFileResponseObject @object = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    fileId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("deleted"u8))
                {
                    removed = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = InternalDeleteVectorStoreFileResponseObject.DeserializeInternalDeleteVectorStoreFileResponseObject(prop.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new FileFromStoreRemovalResult(fileId, removed, @object, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<FileFromStoreRemovalResult>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileFromStoreRemovalResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileFromStoreRemovalResult)} does not support writing '{options.Format}' format.");
            }
        }

        FileFromStoreRemovalResult IPersistableModel<FileFromStoreRemovalResult>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual FileFromStoreRemovalResult PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FileFromStoreRemovalResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeFileFromStoreRemovalResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileFromStoreRemovalResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileFromStoreRemovalResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(FileFromStoreRemovalResult fileFromStoreRemovalResult)
        {
            return BinaryContent.Create(fileFromStoreRemovalResult, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator FileFromStoreRemovalResult(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeFileFromStoreRemovalResult(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
