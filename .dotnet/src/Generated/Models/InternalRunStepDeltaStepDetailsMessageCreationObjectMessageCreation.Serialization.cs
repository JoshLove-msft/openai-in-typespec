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
    internal partial class InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation : IJsonModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>
    {
        void IJsonModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("message_id"u8);
                writer.WriteStringValue(MessageId);
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

        InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation IJsonModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation(document.RootElement, options);
        }

        internal static InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation DeserializeInternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("message_id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        messageId = null;
                        continue;
                    }
                    messageId = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation(messageId, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation IPersistableModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation internalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation)
        {
            return BinaryContent.Create(internalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDeltaStepDetailsMessageCreationObjectMessageCreation(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
