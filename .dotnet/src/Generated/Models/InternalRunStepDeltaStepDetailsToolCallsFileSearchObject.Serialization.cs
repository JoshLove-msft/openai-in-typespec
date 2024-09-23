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
    internal partial class InternalRunStepDeltaStepDetailsToolCallsFileSearchObject : IJsonModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>
    {
        internal InternalRunStepDeltaStepDetailsToolCallsFileSearchObject()
        {
        }

        void IJsonModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsFileSearchObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("file_search"u8);
            writer.WriteStartObject();
            foreach (var item in FileSearch)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
#if NET6_0_OR_GREATER
                writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        InternalRunStepDeltaStepDetailsToolCallsFileSearchObject IJsonModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRunStepDeltaStepDetailsToolCallsFileSearchObject)JsonModelCreateCore(ref reader, options);

        protected override InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsFileSearchObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDeltaStepDetailsToolCallsFileSearchObject(document.RootElement, options);
        }

        internal static InternalRunStepDeltaStepDetailsToolCallsFileSearchObject DeserializeInternalRunStepDeltaStepDetailsToolCallsFileSearchObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int index = default;
            string id = default;
            IDictionary<string, BinaryData> fileSearch = default;
            string @type = "file_search";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("index"u8))
                {
                    index = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("file_search"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        if (prop0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(prop0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(prop0.Name, BinaryData.FromString(prop0.Value.GetRawText()));
                        }
                    }
                    fileSearch = dictionary;
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
            return new InternalRunStepDeltaStepDetailsToolCallsFileSearchObject(index, id, fileSearch, @type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsFileSearchObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDeltaStepDetailsToolCallsFileSearchObject IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRunStepDeltaStepDetailsToolCallsFileSearchObject)PersistableModelCreateCore(data, options);

        protected override InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDeltaStepDetailsToolCallsFileSearchObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsFileSearchObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsFileSearchObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRunStepDeltaStepDetailsToolCallsFileSearchObject internalRunStepDeltaStepDetailsToolCallsFileSearchObject)
        {
            return BinaryContent.Create(internalRunStepDeltaStepDetailsToolCallsFileSearchObject, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRunStepDeltaStepDetailsToolCallsFileSearchObject(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDeltaStepDetailsToolCallsFileSearchObject(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
