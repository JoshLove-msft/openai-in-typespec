// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionResponseChoiceLogprobs
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalCreateChatCompletionResponseChoiceLogprobs()
        {
            Content = new ChangeTrackingList<ChatTokenLogProbabilityDetails>();
            Refusal = new ChangeTrackingList<ChatTokenLogProbabilityDetails>();
        }

        internal InternalCreateChatCompletionResponseChoiceLogprobs(IReadOnlyList<ChatTokenLogProbabilityDetails> content, IReadOnlyList<ChatTokenLogProbabilityDetails> refusal, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Content = content;
            Refusal = refusal;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IReadOnlyList<ChatTokenLogProbabilityDetails> Content { get; }

        public IReadOnlyList<ChatTokenLogProbabilityDetails> Refusal { get; }
    }
}
