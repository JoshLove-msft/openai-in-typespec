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
    internal partial class InternalMessageContentTextAnnotationsFileCitationObject : IJsonModel<InternalMessageContentTextAnnotationsFileCitationObject>
    {
        internal InternalMessageContentTextAnnotationsFileCitationObject()
        {
        }

        void IJsonModel<InternalMessageContentTextAnnotationsFileCitationObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalMessageContentTextAnnotationsFileCitationObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("file_citation"u8);
            writer.WriteObjectValue(FileCitation, options);
            writer.WritePropertyName("start_index"u8);
            writer.WriteNumberValue(StartIndex);
            writer.WritePropertyName("end_index"u8);
            writer.WriteNumberValue(EndIndex);
        }

        InternalMessageContentTextAnnotationsFileCitationObject IJsonModel<InternalMessageContentTextAnnotationsFileCitationObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalMessageContentTextAnnotationsFileCitationObject)JsonModelCreateCore(ref reader, options);

        protected override InternalMessageContentTextObjectAnnotation JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalMessageContentTextAnnotationsFileCitationObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalMessageContentTextAnnotationsFileCitationObject(document.RootElement, options);
        }

        internal static InternalMessageContentTextAnnotationsFileCitationObject DeserializeInternalMessageContentTextAnnotationsFileCitationObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            InternalMessageContentTextAnnotationsFileCitationObjectFileCitation fileCitation = default;
            int startIndex = default;
            int endIndex = default;
            string @type = "file_citation";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("text"u8))
                {
                    text = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("file_citation"u8))
                {
                    fileCitation = InternalMessageContentTextAnnotationsFileCitationObjectFileCitation.DeserializeInternalMessageContentTextAnnotationsFileCitationObjectFileCitation(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("start_index"u8))
                {
                    startIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("end_index"u8))
                {
                    endIndex = prop.Value.GetInt32();
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
            return new InternalMessageContentTextAnnotationsFileCitationObject(
                text,
                fileCitation,
                startIndex,
                endIndex,
                @type,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalMessageContentTextAnnotationsFileCitationObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalMessageContentTextAnnotationsFileCitationObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalMessageContentTextAnnotationsFileCitationObject IPersistableModel<InternalMessageContentTextAnnotationsFileCitationObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalMessageContentTextAnnotationsFileCitationObject)PersistableModelCreateCore(data, options);

        protected override InternalMessageContentTextObjectAnnotation PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageContentTextAnnotationsFileCitationObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalMessageContentTextAnnotationsFileCitationObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalMessageContentTextAnnotationsFileCitationObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalMessageContentTextAnnotationsFileCitationObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalMessageContentTextAnnotationsFileCitationObject internalMessageContentTextAnnotationsFileCitationObject)
        {
            return BinaryContent.Create(internalMessageContentTextAnnotationsFileCitationObject, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalMessageContentTextAnnotationsFileCitationObject(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalMessageContentTextAnnotationsFileCitationObject(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
