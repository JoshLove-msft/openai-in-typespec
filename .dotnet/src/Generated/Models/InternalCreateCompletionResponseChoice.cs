// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.LegacyCompletions
{
    internal partial class InternalCreateCompletionResponseChoice
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalCreateCompletionResponseChoice(InternalCreateCompletionResponseChoiceFinishReason finishReason, int index, InternalCreateCompletionResponseChoiceLogprobs logprobs, string text)
        {
            FinishReason = finishReason;
            Index = index;
            Logprobs = logprobs;
            Text = text;
        }

        internal InternalCreateCompletionResponseChoice(InternalCreateCompletionResponseChoiceFinishReason finishReason, int index, InternalCreateCompletionResponseChoiceLogprobs logprobs, string text, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FinishReason = finishReason;
            Index = index;
            Logprobs = logprobs;
            Text = text;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalCreateCompletionResponseChoiceFinishReason FinishReason { get; }

        public int Index { get; }

        public InternalCreateCompletionResponseChoiceLogprobs Logprobs { get; }

        public string Text { get; }
    }
}
