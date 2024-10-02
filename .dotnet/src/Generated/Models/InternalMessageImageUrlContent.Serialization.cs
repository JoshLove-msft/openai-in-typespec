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
    internal partial class InternalMessageImageUrlContent : IJsonModel<InternalMessageImageUrlContent>
    {
        internal InternalMessageImageUrlContent()
        {
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageImageUrlContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalMessageImageUrlContent)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("image_url"u8);
            writer.WriteObjectValue(ImageUrl, options);
        }

        InternalMessageImageUrlContent IJsonModel<InternalMessageImageUrlContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalMessageImageUrlContent)JsonModelCreateCore(ref reader, options);

        protected override MessageContent JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageImageUrlContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalMessageImageUrlContent)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalMessageImageUrlContent(document.RootElement, options);
        }

        internal static InternalMessageImageUrlContent DeserializeInternalMessageImageUrlContent(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalMessageContentImageUrlObjectType @type = default;
            InternalMessageContentImageUrlObjectImageUrl imageUrl = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalMessageContentImageUrlObjectType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("image_url"u8))
                {
                    imageUrl = InternalMessageContentImageUrlObjectImageUrl.DeserializeInternalMessageContentImageUrlObjectImageUrl(prop.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalMessageImageUrlContent(@type, imageUrl, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalMessageImageUrlContent>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageImageUrlContent>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalMessageImageUrlContent)} does not support writing '{options.Format}' format.");
            }
        }

        InternalMessageImageUrlContent IPersistableModel<InternalMessageImageUrlContent>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalMessageImageUrlContent)PersistableModelCreateCore(data, options);

        protected override MessageContent PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalMessageImageUrlContent>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalMessageImageUrlContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalMessageImageUrlContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalMessageImageUrlContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalMessageImageUrlContent internalMessageImageUrlContent)
        {
            return BinaryContent.Create(internalMessageImageUrlContent, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalMessageImageUrlContent(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalMessageImageUrlContent(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
