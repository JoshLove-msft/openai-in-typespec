// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Images
{
    public partial class ImageVariationOptions : IJsonModel<ImageVariationOptions>
    {
        void IJsonModel<ImageVariationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ImageVariationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageVariationOptions)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Size))
            {
                if (Size != null)
                {
                    writer.WritePropertyName("size"u8);
                    writer.WriteObjectValue<Images.OpenAI.Images.GeneratedImageSize<GeneratedImageSize>?>(Size, options);
                }
                else
                {
                    writer.WriteNull("size"u8);
                }
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                if (ResponseFormat != null)
                {
                    writer.WritePropertyName("response_format"u8);
                    writer.WriteObjectValue<Images.OpenAI.Images.GeneratedImageFormat<Images.GeneratedImageFormat>?>(ResponseFormat, options);
                }
                else
                {
                    writer.WriteNull("responseFormat"u8);
                }
            }
            if (Optional.IsDefined(EndUserId))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(EndUserId);
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

        ImageVariationOptions IJsonModel<ImageVariationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ImageVariationOptions JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ImageVariationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageVariationOptions)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageVariationOptions(document.RootElement, options);
        }

        internal static ImageVariationOptions DeserializeImageVariationOptions(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Images.OpenAI.Images.GeneratedImageSize<GeneratedImageSize>? size = default;
            Images.OpenAI.Images.GeneratedImageFormat<Images.GeneratedImageFormat>? responseFormat = default;
            string endUserId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("size"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        size = null;
                        continue;
                    }
                    size = Images.OpenAI.Images.GeneratedImageSize<GeneratedImageSize>?.DeserializeOpenAI.Images.GeneratedImageSize(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("response_format"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        responseFormat = null;
                        continue;
                    }
                    responseFormat = Images.OpenAI.Images.GeneratedImageFormat<Images.GeneratedImageFormat>?.DeserializeOpenAI.Images.GeneratedImageFormat(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("user"u8))
                {
                    endUserId = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ImageVariationOptions(size, responseFormat, endUserId, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ImageVariationOptions>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ImageVariationOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageVariationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        ImageVariationOptions IPersistableModel<ImageVariationOptions>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ImageVariationOptions PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ImageVariationOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeImageVariationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageVariationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageVariationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ImageVariationOptions imageVariationOptions)
        {
            return BinaryContent.Create(imageVariationOptions, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ImageVariationOptions(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeImageVariationOptions(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
