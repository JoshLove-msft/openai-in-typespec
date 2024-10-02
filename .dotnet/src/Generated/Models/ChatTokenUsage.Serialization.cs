// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    public partial class ChatTokenUsage : IJsonModel<ChatTokenUsage>
    {
        internal ChatTokenUsage()
        {
        }

        void IJsonModel<ChatTokenUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("completion_tokens"u8);
            writer.WriteNumberValue(OutputTokenCount);
            writer.WritePropertyName("prompt_tokens"u8);
            writer.WriteNumberValue(InputTokenCount);
            writer.WritePropertyName("total_tokens"u8);
            writer.WriteNumberValue(TotalTokenCount);
            if (Optional.IsDefined(OutputTokenDetails))
            {
                writer.WritePropertyName("completion_tokens_details"u8);
                writer.WriteObjectValue<ChatOutputTokenUsageDetails>(OutputTokenDetails, options);
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

        ChatTokenUsage IJsonModel<ChatTokenUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ChatTokenUsage JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatTokenUsage(document.RootElement, options);
        }

        internal static ChatTokenUsage DeserializeChatTokenUsage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int outputTokenCount = default;
            int inputTokenCount = default;
            int totalTokenCount = default;
            ChatOutputTokenUsageDetails outputTokenDetails = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("completion_tokens"u8))
                {
                    outputTokenCount = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("prompt_tokens"u8))
                {
                    inputTokenCount = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("total_tokens"u8))
                {
                    totalTokenCount = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("completion_tokens_details"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputTokenDetails = ChatOutputTokenUsageDetails.DeserializeChatOutputTokenUsageDetails(prop.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ChatTokenUsage(outputTokenCount, inputTokenCount, totalTokenCount, outputTokenDetails, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ChatTokenUsage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support writing '{options.Format}' format.");
            }
        }

        ChatTokenUsage IPersistableModel<ChatTokenUsage>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ChatTokenUsage PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenUsage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeChatTokenUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatTokenUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatTokenUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ChatTokenUsage chatTokenUsage)
        {
            return BinaryContent.Create(chatTokenUsage, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ChatTokenUsage(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeChatTokenUsage(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
