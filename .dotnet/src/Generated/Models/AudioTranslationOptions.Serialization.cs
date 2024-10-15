// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Audio
{
    public partial class AudioTranslationOptions : IJsonModel<AudioTranslationOptions>
    {
        void IJsonModel<AudioTranslationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Prompt))
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteStringValue(ResponseFormat.Value.ToString());
            }
            if (Optional.IsDefined(Temperature))
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            writer.WritePropertyName("file"u8);
            writer.WriteBase64StringValue(File.ToArray(), "D");
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model.ToString());
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

        AudioTranslationOptions IJsonModel<AudioTranslationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual AudioTranslationOptions JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTranslationOptions(document.RootElement, options);
        }

        internal static AudioTranslationOptions DeserializeAudioTranslationOptions(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string prompt = default;
            AudioTranslationFormat? responseFormat = default;
            float? temperature = default;
            BinaryData @file = default;
            InternalCreateTranslationRequestModel model = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("prompt"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        prompt = null;
                        continue;
                    }
                    prompt = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("response_format"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        responseFormat = null;
                        continue;
                    }
                    responseFormat = new AudioTranslationFormat(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("temperature"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        temperature = null;
                        continue;
                    }
                    temperature = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("file"u8))
                {
                    @file = BinaryData.FromBytes(prop.Value.GetBytesFromBase64("D"));
                    continue;
                }
                if (prop.NameEquals("model"u8))
                {
                    model = new InternalCreateTranslationRequestModel(prop.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new AudioTranslationOptions(
                prompt,
                responseFormat,
                temperature,
                @file,
                model,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<AudioTranslationOptions>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        AudioTranslationOptions IPersistableModel<AudioTranslationOptions>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual AudioTranslationOptions PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeAudioTranslationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioTranslationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(AudioTranslationOptions audioTranslationOptions)
        {
            return BinaryContent.Create(audioTranslationOptions, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator AudioTranslationOptions(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeAudioTranslationOptions(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
