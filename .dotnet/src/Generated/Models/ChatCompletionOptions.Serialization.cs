// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    public partial class ChatCompletionOptions : IJsonModel<ChatCompletionOptions>
    {
        void IJsonModel<ChatCompletionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatCompletionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionOptions)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(FrequencyPenalty))
            {
                if (FrequencyPenalty != null)
                {
                    writer.WritePropertyName("frequency_penalty"u8);
                    writer.WriteNumberValue(FrequencyPenalty.Value);
                }
                else
                {
                    writer.WriteNull("frequencyPenalty"u8);
                }
            }
            if (Optional.IsDefined(PresencePenalty))
            {
                if (PresencePenalty != null)
                {
                    writer.WritePropertyName("presence_penalty"u8);
                    writer.WriteNumberValue(PresencePenalty.Value);
                }
                else
                {
                    writer.WriteNull("presencePenalty"u8);
                }
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteObjectValue(ResponseFormat, options);
            }
            if (Optional.IsDefined(ServiceTier))
            {
                if (ServiceTier != null)
                {
                    writer.WritePropertyName("service_tier"u8);
                    writer.WriteStringValue(ServiceTier.Value.ToString());
                }
                else
                {
                    writer.WriteNull("serviceTier"u8);
                }
            }
            if (Optional.IsDefined(Temperature))
            {
                if (Temperature != null)
                {
                    writer.WritePropertyName("temperature"u8);
                    writer.WriteNumberValue(Temperature.Value);
                }
                else
                {
                    writer.WriteNull("temperature"u8);
                }
            }
            if (Optional.IsDefined(TopP))
            {
                if (TopP != null)
                {
                    writer.WritePropertyName("top_p"u8);
                    writer.WriteNumberValue(TopP.Value);
                }
                else
                {
                    writer.WriteNull("topP"u8);
                }
            }
            if (Optional.IsCollectionDefined(Tools))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (ChatTool item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("messages"u8);
            writer.WriteStartArray();
            foreach (ChatMessage item in Messages)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("model"u8);
            writer.WriteObjectValue<InternalCreateChatCompletionRequestModel>(Model, options);
            if (Optional.IsDefined(N))
            {
                if (N != null)
                {
                    writer.WritePropertyName("n"u8);
                    writer.WriteNumberValue(N.Value);
                }
                else
                {
                    writer.WriteNull("n"u8);
                }
            }
            if (Optional.IsDefined(Stream))
            {
                if (Stream != null)
                {
                    writer.WritePropertyName("stream"u8);
                    writer.WriteBooleanValue(Stream.Value);
                }
                else
                {
                    writer.WriteNull("stream"u8);
                }
            }
            if (Optional.IsDefined(StreamOptions))
            {
                if (StreamOptions != null)
                {
                    writer.WritePropertyName("stream_options"u8);
                    writer.WriteObjectValue<InternalChatCompletionStreamOptions>(StreamOptions, options);
                }
                else
                {
                    writer.WriteNull("streamOptions"u8);
                }
            }
            if (Optional.IsDefined(IncludeLogProbabilities))
            {
                if (IncludeLogProbabilities != null)
                {
                    writer.WritePropertyName("logprobs"u8);
                    writer.WriteBooleanValue(IncludeLogProbabilities.Value);
                }
                else
                {
                    writer.WriteNull("logprobs"u8);
                }
            }
            if (Optional.IsDefined(TopLogProbabilityCount))
            {
                if (TopLogProbabilityCount != null)
                {
                    writer.WritePropertyName("top_logprobs"u8);
                    writer.WriteNumberValue(TopLogProbabilityCount.Value);
                }
                else
                {
                    writer.WriteNull("topLogprobs"u8);
                }
            }
            if (Optional.IsCollectionDefined(StopSequences))
            {
                if (StopSequences != null)
                {
                    writer.WritePropertyName("stop"u8);
                    writer.WriteStartArray();
                    foreach (string item in StopSequences)
                    {
                        if (item == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("stop"u8);
                }
            }
            if (Optional.IsCollectionDefined(LogitBiases))
            {
                if (LogitBiases != null)
                {
                    writer.WritePropertyName("logit_bias"u8);
                    writer.WriteStartObject();
                    foreach (var item in LogitBiases)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteNumberValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("logitBias"u8);
                }
            }
            if (Optional.IsDefined(ToolChoice))
            {
                writer.WritePropertyName("tool_choice"u8);
                writer.WriteObjectValue<ChatToolChoice>(ToolChoice, options);
            }
            if (Optional.IsDefined(FunctionChoice))
            {
                writer.WritePropertyName("function_call"u8);
                writer.WriteObjectValue<ChatFunctionChoice>(FunctionChoice, options);
            }
            if (Optional.IsDefined(ParallelToolCallsEnabled))
            {
                writer.WritePropertyName("parallel_tool_calls"u8);
                writer.WriteBooleanValue(ParallelToolCallsEnabled.Value);
            }
            if (Optional.IsDefined(EndUserId))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(EndUserId);
            }
            if (Optional.IsDefined(_deprecatedMaxTokens))
            {
                if (_deprecatedMaxTokens != null)
                {
                    writer.WritePropertyName("max_tokens"u8);
                    writer.WriteNumberValue(_deprecatedMaxTokens.Value);
                }
                else
                {
                    writer.WriteNull("maxTokens"u8);
                }
            }
            if (Optional.IsDefined(MaxOutputTokenCount))
            {
                if (MaxOutputTokenCount != null)
                {
                    writer.WritePropertyName("max_completion_tokens"u8);
                    writer.WriteNumberValue(MaxOutputTokenCount.Value);
                }
                else
                {
                    writer.WriteNull("maxCompletionTokens"u8);
                }
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

        ChatCompletionOptions IJsonModel<ChatCompletionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ChatCompletionOptions JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatCompletionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionOptions)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionOptions(document.RootElement, options);
        }

        internal static ChatCompletionOptions DeserializeChatCompletionOptions(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? frequencyPenalty = default;
            float? presencePenalty = default;
            ChatResponseFormat responseFormat = default;
            InternalCreateChatCompletionRequestServiceTier? serviceTier = default;
            float? temperature = default;
            float? topP = default;
            IList<ChatTool> tools = default;
            IList<ChatMessage> messages = default;
            InternalCreateChatCompletionRequestModel model = default;
            int? n = default;
            bool? stream = default;
            InternalChatCompletionStreamOptions streamOptions = default;
            bool? includeLogProbabilities = default;
            int? topLogProbabilityCount = default;
            IList<string> stopSequences = default;
            IDictionary<int, int> logitBiases = default;
            ChatToolChoice toolChoice = default;
            ChatFunctionChoice functionChoice = default;
            bool? parallelToolCallsEnabled = default;
            string endUserId = default;
            int? deprecatedMaxTokens = default;
            int? maxOutputTokenCount = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("frequency_penalty"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        frequencyPenalty = null;
                        continue;
                    }
                    frequencyPenalty = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("presence_penalty"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        presencePenalty = null;
                        continue;
                    }
                    presencePenalty = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("response_format"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        responseFormat = null;
                        continue;
                    }
                    responseFormat = ChatResponseFormat.DeserializeChatResponseFormat(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("service_tier"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        serviceTier = null;
                        continue;
                    }
                    serviceTier = new InternalCreateChatCompletionRequestServiceTier(prop.Value.GetString());
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
                if (prop.NameEquals("top_p"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        topP = null;
                        continue;
                    }
                    topP = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("tools"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatTool> array = new List<ChatTool>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ChatTool.DeserializeChatTool(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (prop.NameEquals("messages"u8))
                {
                    List<ChatMessage> array = new List<ChatMessage>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ChatMessage.DeserializeChatMessage(item, options));
                    }
                    messages = array;
                    continue;
                }
                if (prop.NameEquals("model"u8))
                {
                    model = InternalCreateChatCompletionRequestModel.DeserializeInternalCreateChatCompletionRequestModel(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("n"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        n = null;
                        continue;
                    }
                    n = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("stream"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        stream = null;
                        continue;
                    }
                    stream = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("stream_options"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    streamOptions = InternalChatCompletionStreamOptions.DeserializeInternalChatCompletionStreamOptions(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("logprobs"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        includeLogProbabilities = null;
                        continue;
                    }
                    includeLogProbabilities = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("top_logprobs"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        topLogProbabilityCount = null;
                        continue;
                    }
                    topLogProbabilityCount = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("stop"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    stopSequences = array;
                    continue;
                }
                if (prop.NameEquals("logit_bias"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<int, int> dictionary = new Dictionary<int, int>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        dictionary.Add(prop0.Name, prop0.Value.GetInt32());
                    }
                    logitBiases = dictionary;
                    continue;
                }
                if (prop.NameEquals("tool_choice"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toolChoice = ChatToolChoice.DeserializeChatToolChoice(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("function_call"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionChoice = ChatFunctionChoice.DeserializeChatFunctionChoice(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("parallel_tool_calls"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        parallelToolCallsEnabled = null;
                        continue;
                    }
                    parallelToolCallsEnabled = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("user"u8))
                {
                    endUserId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("max_tokens"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        deprecatedMaxTokens = null;
                        continue;
                    }
                    deprecatedMaxTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("max_completion_tokens"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxOutputTokenCount = null;
                        continue;
                    }
                    maxOutputTokenCount = prop.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ChatCompletionOptions(
                frequencyPenalty,
                presencePenalty,
                responseFormat,
                serviceTier,
                temperature,
                topP,
                tools ?? new ChangeTrackingList<ChatTool>(),
                messages,
                model,
                n,
                stream,
                streamOptions,
                includeLogProbabilities,
                topLogProbabilityCount,
                stopSequences ?? new ChangeTrackingList<string>(),
                logitBiases ?? new ChangeTrackingDictionary<int, int>(),
                toolChoice,
                functionChoice,
                parallelToolCallsEnabled,
                endUserId,
                deprecatedMaxTokens,
                maxOutputTokenCount,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ChatCompletionOptions>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatCompletionOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionOptions)} does not support writing '{options.Format}' format.");
            }
        }

        ChatCompletionOptions IPersistableModel<ChatCompletionOptions>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ChatCompletionOptions PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatCompletionOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeChatCompletionOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ChatCompletionOptions chatCompletionOptions)
        {
            return BinaryContent.Create(chatCompletionOptions, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ChatCompletionOptions(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionOptions(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
