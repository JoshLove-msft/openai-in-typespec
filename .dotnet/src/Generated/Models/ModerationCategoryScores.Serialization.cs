// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Moderations
{
    public partial class ModerationCategoryScores : IJsonModel<ModerationCategoryScores>
    {
        void IJsonModel<ModerationCategoryScores>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModerationCategoryScores>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModerationCategoryScores)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("hate"u8);
            writer.WriteNumberValue(Hate);
            writer.WritePropertyName("hate/threatening"u8);
            writer.WriteNumberValue(HateThreatening);
            writer.WritePropertyName("harassment"u8);
            writer.WriteNumberValue(Harassment);
            writer.WritePropertyName("harassment/threatening"u8);
            writer.WriteNumberValue(HarassmentThreatening);
            writer.WritePropertyName("self-harm"u8);
            writer.WriteNumberValue(SelfHarm);
            writer.WritePropertyName("self-harm/intent"u8);
            writer.WriteNumberValue(SelfHarmIntent);
            writer.WritePropertyName("self-harm/instructions"u8);
            writer.WriteNumberValue(SelfHarmInstructions);
            writer.WritePropertyName("sexual"u8);
            writer.WriteNumberValue(Sexual);
            writer.WritePropertyName("sexual/minors"u8);
            writer.WriteNumberValue(SexualMinors);
            writer.WritePropertyName("violence"u8);
            writer.WriteNumberValue(Violence);
            writer.WritePropertyName("violence/graphic"u8);
            writer.WriteNumberValue(ViolenceGraphic);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            writer.WriteEndObject();
        }

        ModerationCategoryScores IJsonModel<ModerationCategoryScores>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModerationCategoryScores>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModerationCategoryScores)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModerationCategoryScores(document.RootElement, options);
        }

        internal static ModerationCategoryScores DeserializeModerationCategoryScores(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float hate = default;
            float hateThreatening = default;
            float harassment = default;
            float harassmentThreatening = default;
            float selfHarm = default;
            float selfHarmIntent = default;
            float selfHarmInstructions = default;
            float sexual = default;
            float sexualMinors = default;
            float violence = default;
            float violenceGraphic = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hate"u8))
                {
                    hate = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("hate/threatening"u8))
                {
                    hateThreatening = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("harassment"u8))
                {
                    harassment = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("harassment/threatening"u8))
                {
                    harassmentThreatening = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("self-harm"u8))
                {
                    selfHarm = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("self-harm/intent"u8))
                {
                    selfHarmIntent = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("self-harm/instructions"u8))
                {
                    selfHarmInstructions = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sexual"u8))
                {
                    sexual = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sexual/minors"u8))
                {
                    sexualMinors = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("violence"u8))
                {
                    violence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("violence/graphic"u8))
                {
                    violenceGraphic = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ModerationCategoryScores(
                hate,
                hateThreatening,
                harassment,
                harassmentThreatening,
                selfHarm,
                selfHarmIntent,
                selfHarmInstructions,
                sexual,
                sexualMinors,
                violence,
                violenceGraphic,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ModerationCategoryScores>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModerationCategoryScores>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModerationCategoryScores)} does not support writing '{options.Format}' format.");
            }
        }

        ModerationCategoryScores IPersistableModel<ModerationCategoryScores>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModerationCategoryScores>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModerationCategoryScores(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModerationCategoryScores)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModerationCategoryScores>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ModerationCategoryScores FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeModerationCategoryScores(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
