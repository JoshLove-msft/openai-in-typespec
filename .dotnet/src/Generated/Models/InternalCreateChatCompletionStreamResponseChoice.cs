// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionStreamResponseChoice
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalCreateChatCompletionStreamResponseChoice(InternalChatCompletionStreamResponseDelta delta, InternalCreateChatCompletionStreamResponseChoiceFinishReason? finishReason, int index)
        {
            Delta = delta;
            FinishReason = finishReason;
            Index = index;
        }

        internal InternalCreateChatCompletionStreamResponseChoice(InternalChatCompletionStreamResponseDelta delta, InternalCreateChatCompletionStreamResponseChoiceLogprobs logprobs, InternalCreateChatCompletionStreamResponseChoiceFinishReason? finishReason, int index, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Delta = delta;
            Logprobs = logprobs;
            FinishReason = finishReason;
            Index = index;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalChatCompletionStreamResponseDelta Delta { get; set; }

        public InternalCreateChatCompletionStreamResponseChoiceLogprobs Logprobs { get; set; }

        public int Index { get; set; }
    }
}
