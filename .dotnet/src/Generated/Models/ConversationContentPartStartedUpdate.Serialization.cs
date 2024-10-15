// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationContentPartStartedUpdate : IJsonModel<ConversationContentPartStartedUpdate>
    {
        internal ConversationContentPartStartedUpdate()
        {
        }

        void IJsonModel<ConversationContentPartStartedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationContentPartStartedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationContentPartStartedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("response_id"u8);
            writer.WriteStringValue(ResponseId);
            writer.WritePropertyName("item_id"u8);
            writer.WriteStringValue(ItemId);
            writer.WritePropertyName("output_index"u8);
            writer.WriteNumberValue(OutputIndex);
            writer.WritePropertyName("content_index"u8);
            writer.WriteNumberValue(ContentIndex);
            writer.WritePropertyName("part"u8);
            writer.WriteObjectValue<ConversationContentPart>(_internalContentPart, options);
        }

        ConversationContentPartStartedUpdate IJsonModel<ConversationContentPartStartedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (ConversationContentPartStartedUpdate)JsonModelCreateCore(ref reader, options);

        protected override ConversationUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationContentPartStartedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationContentPartStartedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationContentPartStartedUpdate(document.RootElement, options);
        }

        internal static ConversationContentPartStartedUpdate DeserializeConversationContentPartStartedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string responseId = default;
            string itemId = default;
            int outputIndex = default;
            int contentIndex = default;
            ConversationContentPart internalContentPart = default;
            string eventId = default;
            RealtimeConversation.ConversationUpdateKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("response_id"u8))
                {
                    responseId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output_index"u8))
                {
                    outputIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("content_index"u8))
                {
                    contentIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("part"u8))
                {
                    internalContentPart = ConversationContentPart.DeserializeConversationContentPart(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("event_id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        eventId = null;
                        continue;
                    }
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToConversationUpdateKind();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ConversationContentPartStartedUpdate(
                responseId,
                itemId,
                outputIndex,
                contentIndex,
                internalContentPart,
                eventId,
                kind,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ConversationContentPartStartedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationContentPartStartedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationContentPartStartedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationContentPartStartedUpdate IPersistableModel<ConversationContentPartStartedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (ConversationContentPartStartedUpdate)PersistableModelCreateCore(data, options);

        protected override ConversationUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationContentPartStartedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationContentPartStartedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationContentPartStartedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationContentPartStartedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ConversationContentPartStartedUpdate conversationContentPartStartedUpdate)
        {
            return BinaryContent.Create(conversationContentPartStartedUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ConversationContentPartStartedUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeConversationContentPartStartedUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
