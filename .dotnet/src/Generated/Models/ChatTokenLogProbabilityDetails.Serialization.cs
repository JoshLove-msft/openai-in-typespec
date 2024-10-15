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
    public partial class ChatTokenLogProbabilityDetails : IJsonModel<ChatTokenLogProbabilityDetails>
    {
        internal ChatTokenLogProbabilityDetails()
        {
        }

        void IJsonModel<ChatTokenLogProbabilityDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenLogProbabilityDetails)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("token"u8);
            writer.WriteStringValue(Token);
            writer.WritePropertyName("logprob"u8);
            writer.WriteNumberValue(LogProbability);
            if (Utf8Bytes != null)
            {
                writer.WritePropertyName("bytes"u8);
                writer.WriteStartArray();
                foreach (byte item in Utf8Bytes.Value.Span)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("utf8Bytes"u8);
            }
            writer.WritePropertyName("top_logprobs"u8);
            writer.WriteStartArray();
            foreach (ChatTokenTopLogProbabilityDetails item in TopLogProbabilities)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        ChatTokenLogProbabilityDetails IJsonModel<ChatTokenLogProbabilityDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ChatTokenLogProbabilityDetails JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenLogProbabilityDetails)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatTokenLogProbabilityDetails(document.RootElement, options);
        }

        internal static ChatTokenLogProbabilityDetails DeserializeChatTokenLogProbabilityDetails(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            float logProbability = default;
            ReadOnlyMemory<byte>? utf8Bytes = default;
            IReadOnlyList<ChatTokenTopLogProbabilityDetails> topLogProbabilities = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("token"u8))
                {
                    token = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("logprob"u8))
                {
                    logProbability = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("bytes"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<byte> array = new List<byte>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetByte());
                    }
                    utf8Bytes = array;
                    continue;
                }
                if (prop.NameEquals("top_logprobs"u8))
                {
                    List<ChatTokenTopLogProbabilityDetails> array = new List<ChatTokenTopLogProbabilityDetails>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ChatTokenTopLogProbabilityDetails.DeserializeChatTokenTopLogProbabilityDetails(item, options));
                    }
                    topLogProbabilities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ChatTokenLogProbabilityDetails(token, logProbability, utf8Bytes, topLogProbabilities, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ChatTokenLogProbabilityDetails>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatTokenLogProbabilityDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ChatTokenLogProbabilityDetails IPersistableModel<ChatTokenLogProbabilityDetails>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ChatTokenLogProbabilityDetails PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeChatTokenLogProbabilityDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatTokenLogProbabilityDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatTokenLogProbabilityDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ChatTokenLogProbabilityDetails chatTokenLogProbabilityDetails)
        {
            return BinaryContent.Create(chatTokenLogProbabilityDetails, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ChatTokenLogProbabilityDetails(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeChatTokenLogProbabilityDetails(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
