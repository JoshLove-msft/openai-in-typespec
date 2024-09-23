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
    internal partial class InternalAssistantResponseFormatText : IJsonModel<InternalAssistantResponseFormatText>
    {
        void IJsonModel<InternalAssistantResponseFormatText>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAssistantResponseFormatText)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        InternalAssistantResponseFormatText IJsonModel<InternalAssistantResponseFormatText>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalAssistantResponseFormatText)JsonModelCreateCore(ref reader, options);

        protected override AssistantResponseFormat JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAssistantResponseFormatText)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalAssistantResponseFormatText(document.RootElement, options);
        }

        internal static InternalAssistantResponseFormatText DeserializeInternalAssistantResponseFormatText(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @type = "text";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalAssistantResponseFormatText(@type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalAssistantResponseFormatText>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalAssistantResponseFormatText)} does not support writing '{options.Format}' format.");
            }
        }

        InternalAssistantResponseFormatText IPersistableModel<InternalAssistantResponseFormatText>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalAssistantResponseFormatText)PersistableModelCreateCore(data, options);

        protected override AssistantResponseFormat PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalAssistantResponseFormatText(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalAssistantResponseFormatText)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalAssistantResponseFormatText>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalAssistantResponseFormatText internalAssistantResponseFormatText)
        {
            return BinaryContent.Create(internalAssistantResponseFormatText, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalAssistantResponseFormatText(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalAssistantResponseFormatText(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
