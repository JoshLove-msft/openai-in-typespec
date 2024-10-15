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
    public partial class ConversationInputAudioBufferCommittedUpdate : IJsonModel<ConversationInputAudioBufferCommittedUpdate>
    {
        internal ConversationInputAudioBufferCommittedUpdate()
        {
        }

        void IJsonModel<ConversationInputAudioBufferCommittedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioBufferCommittedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationInputAudioBufferCommittedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("item_id"u8);
            writer.WriteStringValue(ItemId);
            if (Optional.IsDefined(PreviousItemId))
            {
                writer.WritePropertyName("previous_item_id"u8);
                writer.WriteStringValue(PreviousItemId);
            }
        }

        ConversationInputAudioBufferCommittedUpdate IJsonModel<ConversationInputAudioBufferCommittedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (ConversationInputAudioBufferCommittedUpdate)JsonModelCreateCore(ref reader, options);

        protected override ConversationUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioBufferCommittedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationInputAudioBufferCommittedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationInputAudioBufferCommittedUpdate(document.RootElement, options);
        }

        internal static ConversationInputAudioBufferCommittedUpdate DeserializeConversationInputAudioBufferCommittedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string itemId = default;
            string previousItemId = default;
            string eventId = default;
            RealtimeConversation.ConversationUpdateKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("previous_item_id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        previousItemId = null;
                        continue;
                    }
                    previousItemId = prop.Value.GetString();
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
            return new ConversationInputAudioBufferCommittedUpdate(itemId, previousItemId, eventId, kind, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ConversationInputAudioBufferCommittedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioBufferCommittedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationInputAudioBufferCommittedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationInputAudioBufferCommittedUpdate IPersistableModel<ConversationInputAudioBufferCommittedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (ConversationInputAudioBufferCommittedUpdate)PersistableModelCreateCore(data, options);

        protected override ConversationUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioBufferCommittedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationInputAudioBufferCommittedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationInputAudioBufferCommittedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationInputAudioBufferCommittedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ConversationInputAudioBufferCommittedUpdate conversationInputAudioBufferCommittedUpdate)
        {
            return BinaryContent.Create(conversationInputAudioBufferCommittedUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ConversationInputAudioBufferCommittedUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeConversationInputAudioBufferCommittedUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
