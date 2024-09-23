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
    public readonly partial struct TranscribedSegment : IJsonModel<TranscribedSegment>, IJsonModel<object>
    {
        public TranscribedSegment()
        {
        }

        void IJsonModel<TranscribedSegment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranscribedSegment)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("id"u8);
            writer.WriteNumberValue(Id);
            writer.WritePropertyName("seek"u8);
            writer.WriteNumberValue(Seek);
            writer.WritePropertyName("start"u8);
            writer.WriteNumberValue(Convert.ToDouble(Start.ToString("s\\.FFF")));
            writer.WritePropertyName("end"u8);
            writer.WriteNumberValue(Convert.ToDouble(End.ToString("s\\.FFF")));
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("tokens"u8);
            writer.WriteStartArray();
            foreach (var item in Tokens)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("temperature"u8);
            writer.WriteNumberValue(Temperature);
            writer.WritePropertyName("avg_logprob"u8);
            writer.WriteNumberValue(AvgLogprob);
            writer.WritePropertyName("compression_ratio"u8);
            writer.WriteNumberValue(CompressionRatio);
            writer.WritePropertyName("no_speech_prob"u8);
            writer.WriteNumberValue(NoSpeechProb);
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

        TranscribedSegment IJsonModel<TranscribedSegment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual TranscribedSegment JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranscribedSegment)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTranscribedSegment(document.RootElement, options);
        }

        internal static TranscribedSegment DeserializeTranscribedSegment(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int id = default;
            int seek = default;
            TimeSpan start = default;
            TimeSpan end = default;
            string text = default;
            IList<int> tokens = default;
            float temperature = default;
            float avgLogprob = default;
            float compressionRatio = default;
            float noSpeechProb = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("seek"u8))
                {
                    seek = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("start"u8))
                {
                    start = TimeSpan.FromSeconds(prop.Value.GetDouble());
                    continue;
                }
                if (prop.NameEquals("end"u8))
                {
                    end = TimeSpan.FromSeconds(prop.Value.GetDouble());
                    continue;
                }
                if (prop.NameEquals("text"u8))
                {
                    text = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("tokens"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    tokens = array;
                    continue;
                }
                if (prop.NameEquals("temperature"u8))
                {
                    temperature = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("avg_logprob"u8))
                {
                    avgLogprob = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("compression_ratio"u8))
                {
                    compressionRatio = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("no_speech_prob"u8))
                {
                    noSpeechProb = prop.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new TranscribedSegment(
                id,
                seek,
                start,
                end,
                text,
                tokens,
                temperature,
                avgLogprob,
                compressionRatio,
                noSpeechProb,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<TranscribedSegment>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TranscribedSegment)} does not support writing '{options.Format}' format.");
            }
        }

        TranscribedSegment IPersistableModel<TranscribedSegment>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual TranscribedSegment PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeTranscribedSegment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TranscribedSegment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TranscribedSegment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(TranscribedSegment transcribedSegment)
        {
            return BinaryContent.Create(transcribedSegment, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator TranscribedSegment(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeTranscribedSegment(document.RootElement, ModelSerializationExtensions.WireOptions);
        }

        void IJsonModel<object>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TranscribedSegment>)this).Write(writer, options);

        object IJsonModel<object>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TranscribedSegment>)this).Create(ref reader, options);

        BinaryData IPersistableModel<object>.Write(ModelReaderWriterOptions options) => ((IPersistableModel<TranscribedSegment>)this).Write(options);

        string IPersistableModel<object>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options);

        object IPersistableModel<object>.Create(BinaryData data, ModelReaderWriterOptions options) => ((IPersistableModel<TranscribedSegment>)this).Create(data, options);
    }
}
