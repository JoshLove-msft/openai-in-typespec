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
    internal partial class InternalRunStepDetailsToolCallsCodeOutputImageObject : IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>
    {
        internal InternalRunStepDetailsToolCallsCodeOutputImageObject()
        {
        }

        void IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("image"u8);
            writer.WriteObjectValue<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>(_image, options);
        }

        InternalRunStepDetailsToolCallsCodeOutputImageObject IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRunStepDetailsToolCallsCodeOutputImageObject)JsonModelCreateCore(ref reader, options);

        protected override RunStepCodeInterpreterOutput JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObject(document.RootElement, options);
        }

        internal static InternalRunStepDetailsToolCallsCodeOutputImageObject DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRunStepDetailsToolCallsCodeOutputImageObjectImage image = default;
            string @type = "image";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("image"u8))
                {
                    image = InternalRunStepDetailsToolCallsCodeOutputImageObjectImage.DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(prop.Value, options);
                    continue;
                }
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
            return new InternalRunStepDetailsToolCallsCodeOutputImageObject(image, @type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsToolCallsCodeOutputImageObject IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRunStepDetailsToolCallsCodeOutputImageObject)PersistableModelCreateCore(data, options);

        protected override RunStepCodeInterpreterOutput PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRunStepDetailsToolCallsCodeOutputImageObject internalRunStepDetailsToolCallsCodeOutputImageObject)
        {
            return BinaryContent.Create(internalRunStepDetailsToolCallsCodeOutputImageObject, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRunStepDetailsToolCallsCodeOutputImageObject(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObject(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
