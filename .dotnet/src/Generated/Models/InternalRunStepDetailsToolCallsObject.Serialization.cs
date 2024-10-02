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
    internal partial class InternalRunStepDetailsToolCallsObject : IJsonModel<InternalRunStepDetailsToolCallsObject>
    {
        internal InternalRunStepDetailsToolCallsObject()
        {
        }

        void IJsonModel<InternalRunStepDetailsToolCallsObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("tool_calls"u8);
            writer.WriteStartArray();
            foreach (RunStepToolCall item in InternalToolCalls)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
        }

        InternalRunStepDetailsToolCallsObject IJsonModel<InternalRunStepDetailsToolCallsObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRunStepDetailsToolCallsObject)JsonModelCreateCore(ref reader, options);

        protected override RunStepDetails JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsToolCallsObject(document.RootElement, options);
        }

        internal static InternalRunStepDetailsToolCallsObject DeserializeInternalRunStepDetailsToolCallsObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RunStepToolCall> internalToolCalls = default;
            string @type = "tool_calls";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("tool_calls"u8))
                {
                    List<RunStepToolCall> array = new List<RunStepToolCall>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(RunStepToolCall.DeserializeRunStepToolCall(item, options));
                    }
                    internalToolCalls = array;
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
            return new InternalRunStepDetailsToolCallsObject(internalToolCalls, @type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsToolCallsObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsToolCallsObject IPersistableModel<InternalRunStepDetailsToolCallsObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRunStepDetailsToolCallsObject)PersistableModelCreateCore(data, options);

        protected override RunStepDetails PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDetailsToolCallsObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsToolCallsObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRunStepDetailsToolCallsObject internalRunStepDetailsToolCallsObject)
        {
            return BinaryContent.Create(internalRunStepDetailsToolCallsObject, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRunStepDetailsToolCallsObject(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDetailsToolCallsObject(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
