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
    public partial class RunStepFileSearchResult : IJsonModel<RunStepFileSearchResult>
    {
        internal RunStepFileSearchResult()
        {
        }

        void IJsonModel<RunStepFileSearchResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepFileSearchResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepFileSearchResult)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("file_id"u8);
            writer.WriteStringValue(FileId);
            writer.WritePropertyName("file_name"u8);
            writer.WriteStringValue(FileName);
            writer.WritePropertyName("score"u8);
            writer.WriteNumberValue(Score);
            if (Optional.IsCollectionDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStartArray();
                foreach (InternalRunStepDetailsToolCallsFileSearchResultObjectContent item in Content)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        RunStepFileSearchResult IJsonModel<RunStepFileSearchResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual RunStepFileSearchResult JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepFileSearchResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepFileSearchResult)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepFileSearchResult(document.RootElement, options);
        }

        internal static RunStepFileSearchResult DeserializeRunStepFileSearchResult(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileId = default;
            string fileName = default;
            float score = default;
            IReadOnlyList<InternalRunStepDetailsToolCallsFileSearchResultObjectContent> content = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("file_id"u8))
                {
                    fileId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("file_name"u8))
                {
                    fileName = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("score"u8))
                {
                    score = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("content"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InternalRunStepDetailsToolCallsFileSearchResultObjectContent> array = new List<InternalRunStepDetailsToolCallsFileSearchResultObjectContent>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(InternalRunStepDetailsToolCallsFileSearchResultObjectContent.DeserializeInternalRunStepDetailsToolCallsFileSearchResultObjectContent(item, options));
                    }
                    content = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new RunStepFileSearchResult(fileId, fileName, score, content ?? new ChangeTrackingList<InternalRunStepDetailsToolCallsFileSearchResultObjectContent>(), additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<RunStepFileSearchResult>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepFileSearchResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStepFileSearchResult)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepFileSearchResult IPersistableModel<RunStepFileSearchResult>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual RunStepFileSearchResult PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStepFileSearchResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeRunStepFileSearchResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepFileSearchResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepFileSearchResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(RunStepFileSearchResult runStepFileSearchResult)
        {
            return BinaryContent.Create(runStepFileSearchResult, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator RunStepFileSearchResult(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeRunStepFileSearchResult(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
