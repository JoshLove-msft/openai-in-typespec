// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Files
{
    internal partial class InternalCompleteUploadRequest : IJsonModel<InternalCompleteUploadRequest>
    {
        internal InternalCompleteUploadRequest()
        {
        }

        void IJsonModel<InternalCompleteUploadRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCompleteUploadRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCompleteUploadRequest)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("part_ids"u8);
            writer.WriteStartArray();
            foreach (string item in PartIds)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Md5))
            {
                writer.WritePropertyName("md5"u8);
                writer.WriteStringValue(Md5);
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

        InternalCompleteUploadRequest IJsonModel<InternalCompleteUploadRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalCompleteUploadRequest JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCompleteUploadRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCompleteUploadRequest)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCompleteUploadRequest(document.RootElement, options);
        }

        internal static InternalCompleteUploadRequest DeserializeInternalCompleteUploadRequest(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> partIds = default;
            string md5 = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("part_ids"u8))
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
                    partIds = array;
                    continue;
                }
                if (prop.NameEquals("md5"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        md5 = null;
                        continue;
                    }
                    md5 = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalCompleteUploadRequest(partIds, md5, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalCompleteUploadRequest>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCompleteUploadRequest>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCompleteUploadRequest)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCompleteUploadRequest IPersistableModel<InternalCompleteUploadRequest>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalCompleteUploadRequest PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCompleteUploadRequest>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalCompleteUploadRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCompleteUploadRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCompleteUploadRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalCompleteUploadRequest internalCompleteUploadRequest)
        {
            return BinaryContent.Create(internalCompleteUploadRequest, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalCompleteUploadRequest(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCompleteUploadRequest(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
