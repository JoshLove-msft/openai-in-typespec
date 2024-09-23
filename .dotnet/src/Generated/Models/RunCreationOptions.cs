// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class RunCreationOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal RunCreationOptions(string assistantId, InternalCreateRunRequestModel? model, string instructions, string additionalInstructions, IList<MessageCreationOptions> additionalMessages, IList<ToolDefinition> tools, IDictionary<string, string> metadata, float? temperature, float? topP, bool? stream, int? maxPromptTokens, int? maxCompletionTokens, RunTruncationStrategy truncationStrategy, BinaryData toolChoice, bool? parallelToolCalls, BinaryData responseFormat, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            AssistantId = assistantId;
            Model = model;
            Instructions = instructions;
            AdditionalInstructions = additionalInstructions;
            AdditionalMessages = additionalMessages;
            Tools = tools;
            Metadata = metadata;
            Temperature = temperature;
            TopP = topP;
            Stream = stream;
            MaxPromptTokens = maxPromptTokens;
            MaxCompletionTokens = maxCompletionTokens;
            TruncationStrategy = truncationStrategy;
            ToolChoice = toolChoice;
            ParallelToolCalls = parallelToolCalls;
            ResponseFormat = responseFormat;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }
    }
}
