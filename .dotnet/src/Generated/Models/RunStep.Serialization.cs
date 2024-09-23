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
    public partial class RunStep : IJsonModel<RunStep>
    {
        internal RunStep()
        {
        }

        void IJsonModel<RunStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStep)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(object.ToString());
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
            writer.WritePropertyName("thread_id"u8);
            writer.WriteStringValue(ThreadId);
            writer.WritePropertyName("run_id"u8);
            writer.WriteStringValue(RunId);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("step_details"u8);
            writer.WriteObjectValue<RunStepDetails>(StepDetails, options);
            if (LastError != null)
            {
                writer.WritePropertyName("last_error"u8);
                writer.WriteObjectValue(LastError, options);
            }
            else
            {
                writer.WriteNull("lastError"u8);
            }
            if (ExpiredAt != null)
            {
                writer.WritePropertyName("expired_at"u8);
                writer.WriteNumberValue(ExpiredAt.Value, "U");
            }
            else
            {
                writer.WriteNull("expiredAt"u8);
            }
            if (CancelledAt != null)
            {
                writer.WritePropertyName("cancelled_at"u8);
                writer.WriteNumberValue(CancelledAt.Value, "U");
            }
            else
            {
                writer.WriteNull("cancelledAt"u8);
            }
            if (FailedAt != null)
            {
                writer.WritePropertyName("failed_at"u8);
                writer.WriteNumberValue(FailedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("failedAt"u8);
            }
            if (CompletedAt != null)
            {
                writer.WritePropertyName("completed_at"u8);
                writer.WriteNumberValue(CompletedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("completedAt"u8);
            }
            if (Metadata != null && Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNull("metadata"u8);
            }
            if (Usage != null)
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage, options);
            }
            else
            {
                writer.WriteNull("usage"u8);
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

        RunStep IJsonModel<RunStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual RunStep JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStep)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStep(document.RootElement, options);
        }

        internal static RunStep DeserializeRunStep(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            InternalRunStepObjectObject @object = default;
            DateTimeOffset createdAt = default;
            string assistantId = default;
            string threadId = default;
            string runId = default;
            RunStepType @type = default;
            RunStepStatus status = default;
            RunStepDetails stepDetails = default;
            RunStepError lastError = default;
            DateTimeOffset? expiredAt = default;
            DateTimeOffset? cancelledAt = default;
            DateTimeOffset? failedAt = default;
            DateTimeOffset? completedAt = default;
            IDictionary<string, string> metadata = default;
            RunStepTokenUsage usage = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = new InternalRunStepObjectObject(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("assistant_id"u8))
                {
                    assistantId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("thread_id"u8))
                {
                    threadId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("run_id"u8))
                {
                    runId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    @type = new RunStepType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    status = new RunStepStatus(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("step_details"u8))
                {
                    stepDetails = RunStepDetails.DeserializeRunStepDetails(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("last_error"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastError = null;
                        continue;
                    }
                    lastError = RunStepError.DeserializeRunStepError(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("expired_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        expiredAt = null;
                        continue;
                    }
                    expiredAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("cancelled_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancelledAt = null;
                        continue;
                    }
                    cancelledAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("failed_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        failedAt = null;
                        continue;
                    }
                    failedAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("completed_at"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        completedAt = null;
                        continue;
                    }
                    completedAt = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                    continue;
                }
                if (prop.NameEquals("metadata"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        if (prop0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(prop0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(prop0.Name, prop0.Value.GetString());
                        }
                    }
                    metadata = dictionary;
                    continue;
                }
                if (prop.NameEquals("usage"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        usage = null;
                        continue;
                    }
                    usage = RunStepTokenUsage.DeserializeRunStepTokenUsage(prop.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new RunStep(
                id,
                @object,
                createdAt,
                assistantId,
                threadId,
                runId,
                @type,
                status,
                stepDetails,
                lastError,
                expiredAt,
                cancelledAt,
                failedAt,
                completedAt,
                metadata,
                usage,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<RunStep>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStep)} does not support writing '{options.Format}' format.");
            }
        }

        RunStep IPersistableModel<RunStep>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual RunStep PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeRunStep(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStep)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(RunStep runStep)
        {
            return BinaryContent.Create(runStep, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator RunStep(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeRunStep(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
