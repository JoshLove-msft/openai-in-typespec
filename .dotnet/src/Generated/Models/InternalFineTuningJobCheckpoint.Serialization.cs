// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningJobCheckpoint : IJsonModel<InternalFineTuningJobCheckpoint>
    {
        internal InternalFineTuningJobCheckpoint()
        {
        }

        void IJsonModel<InternalFineTuningJobCheckpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobCheckpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuningJobCheckpoint)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            writer.WritePropertyName("fine_tuned_model_checkpoint"u8);
            writer.WriteStringValue(FineTunedModelCheckpoint);
            writer.WritePropertyName("step_number"u8);
            writer.WriteNumberValue(StepNumber);
            writer.WritePropertyName("metrics"u8);
            writer.WriteObjectValue(Metrics, options);
            writer.WritePropertyName("fine_tuning_job_id"u8);
            writer.WriteStringValue(FineTuningJobId);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
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

        InternalFineTuningJobCheckpoint IJsonModel<InternalFineTuningJobCheckpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalFineTuningJobCheckpoint JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobCheckpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuningJobCheckpoint)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFineTuningJobCheckpoint(document.RootElement, options);
        }

        internal static InternalFineTuningJobCheckpoint DeserializeInternalFineTuningJobCheckpoint(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            DateTimeOffset createdAt = default;
            string fineTunedModelCheckpoint = default;
            int stepNumber = default;
            InternalFineTuningJobCheckpointMetrics metrics = default;
            string fineTuningJobId = default;
            InternalFineTuningJobCheckpointObject @object = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("fine_tuned_model_checkpoint"u8))
                {
                    fineTunedModelCheckpoint = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("step_number"u8))
                {
                    stepNumber = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("metrics"u8))
                {
                    metrics = InternalFineTuningJobCheckpointMetrics.DeserializeInternalFineTuningJobCheckpointMetrics(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("fine_tuning_job_id"u8))
                {
                    fineTuningJobId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalFineTuningJobCheckpointObject(prop.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalFineTuningJobCheckpoint(
                id,
                createdAt,
                fineTunedModelCheckpoint,
                stepNumber,
                metrics,
                fineTuningJobId,
                @object,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalFineTuningJobCheckpoint>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobCheckpoint>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuningJobCheckpoint)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFineTuningJobCheckpoint IPersistableModel<InternalFineTuningJobCheckpoint>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalFineTuningJobCheckpoint PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobCheckpoint>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalFineTuningJobCheckpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuningJobCheckpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFineTuningJobCheckpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalFineTuningJobCheckpoint internalFineTuningJobCheckpoint)
        {
            return BinaryContent.Create(internalFineTuningJobCheckpoint, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalFineTuningJobCheckpoint(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalFineTuningJobCheckpoint(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
