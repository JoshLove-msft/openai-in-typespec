// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class MessageContentTextAnnotationsFileCitationObject : IJsonModel<MessageContentTextAnnotationsFileCitationObject>
    {
        void IJsonModel<MessageContentTextAnnotationsFileCitationObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFileCitationObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("file_citation"u8);
            writer.WriteObjectValue(FileCitation, options);
            writer.WritePropertyName("start_index"u8);
            writer.WriteNumberValue(StartIndex);
            writer.WritePropertyName("end_index"u8);
            writer.WriteNumberValue(EndIndex);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            writer.WriteEndObject();
        }

        MessageContentTextAnnotationsFileCitationObject IJsonModel<MessageContentTextAnnotationsFileCitationObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFileCitationObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageContentTextAnnotationsFileCitationObject(document.RootElement, options);
        }

        internal static MessageContentTextAnnotationsFileCitationObject DeserializeMessageContentTextAnnotationsFileCitationObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MessageContentTextAnnotationsFileCitationObjectType type = default;
            string text = default;
            MessageContentTextAnnotationsFileCitationObjectFileCitation fileCitation = default;
            int startIndex = default;
            int endIndex = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new MessageContentTextAnnotationsFileCitationObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file_citation"u8))
                {
                    fileCitation = MessageContentTextAnnotationsFileCitationObjectFileCitation.DeserializeMessageContentTextAnnotationsFileCitationObjectFileCitation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("start_index"u8))
                {
                    startIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end_index"u8))
                {
                    endIndex = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MessageContentTextAnnotationsFileCitationObject(
                type,
                text,
                fileCitation,
                startIndex,
                endIndex,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MessageContentTextAnnotationsFileCitationObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFileCitationObject)} does not support writing '{options.Format}' format.");
            }
        }

        MessageContentTextAnnotationsFileCitationObject IPersistableModel<MessageContentTextAnnotationsFileCitationObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageContentTextAnnotationsFileCitationObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageContentTextAnnotationsFileCitationObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageContentTextAnnotationsFileCitationObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static MessageContentTextAnnotationsFileCitationObject FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMessageContentTextAnnotationsFileCitationObject(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
