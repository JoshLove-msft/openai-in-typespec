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
    internal partial class InternalListMessagesResponse : IJsonModel<InternalListMessagesResponse>
    {
        internal InternalListMessagesResponse()
        {
        }

        void IJsonModel<InternalListMessagesResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListMessagesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListMessagesResponse)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (ThreadMessage item in Data)
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

        InternalListMessagesResponse IJsonModel<InternalListMessagesResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalListMessagesResponse JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListMessagesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListMessagesResponse)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalListMessagesResponse(document.RootElement, options);
        }

        internal static InternalListMessagesResponse DeserializeInternalListMessagesResponse(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalListMessagesResponseObject @object = default;
            IList<ThreadMessage> data = default;
            string firstId = default;
            string lastId = default;
            bool hasMore = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalListMessagesResponseObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("data"u8))
                {
                    List<ThreadMessage> array = new List<ThreadMessage>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ThreadMessage.DeserializeThreadMessage(item, options));
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
            return new InternalListMessagesResponse(
                @object,
                data,
                firstId,
                lastId,
                hasMore,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalListMessagesResponse>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListMessagesResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalListMessagesResponse)} does not support writing '{options.Format}' format.");
            }
        }

        InternalListMessagesResponse IPersistableModel<InternalListMessagesResponse>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalListMessagesResponse PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalListMessagesResponse>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalListMessagesResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalListMessagesResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalListMessagesResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalListMessagesResponse internalListMessagesResponse)
        {
            return BinaryContent.Create(internalListMessagesResponse, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalListMessagesResponse(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalListMessagesResponse(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
