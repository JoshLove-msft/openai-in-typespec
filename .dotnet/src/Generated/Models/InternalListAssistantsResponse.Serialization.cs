// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalListAssistantsResponse : IJsonModel<InternalListAssistantsResponse>
    {
        internal InternalListAssistantsResponse()
        {
        }

        void IJsonModel<InternalListAssistantsResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListAssistantsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListAssistantsResponse)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("first_id"u8);
            writer.WriteStringValue(FirstId);
            writer.WritePropertyName("last_id"u8);
            writer.WriteStringValue(LastId);
            writer.WritePropertyName("has_more"u8);
            writer.WriteBooleanValue(HasMore);
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

        InternalListAssistantsResponse IJsonModel<InternalListAssistantsResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalListAssistantsResponse JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListAssistantsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListAssistantsResponse)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalListAssistantsResponse(document.RootElement, options);
        }

        internal static InternalListAssistantsResponse DeserializeInternalListAssistantsResponse(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalListAssistantsResponseObject @object = default;
            IList<Assistant> data = default;
            string firstId = default;
            string lastId = default;
            bool hasMore = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalListAssistantsResponseObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("data"u8))
                {
                    List<Assistant> array = new List<Assistant>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(Assistant.DeserializeAssistant(item, options));
                    }
                    data = array;
                    continue;
                }
                if (prop.NameEquals("first_id"u8))
                {
                    firstId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("last_id"u8))
                {
                    lastId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("has_more"u8))
                {
                    hasMore = prop.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalListAssistantsResponse(
                @object,
                data,
                firstId,
                lastId,
                hasMore,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalListAssistantsResponse>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListAssistantsResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalListAssistantsResponse)} does not support writing '{options.Format}' format.");
            }
        }

        InternalListAssistantsResponse IPersistableModel<InternalListAssistantsResponse>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalListAssistantsResponse PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListAssistantsResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalListAssistantsResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalListAssistantsResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalListAssistantsResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalListAssistantsResponse internalListAssistantsResponse)
        {
            return BinaryContent.Create(internalListAssistantsResponse, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalListAssistantsResponse(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalListAssistantsResponse(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
