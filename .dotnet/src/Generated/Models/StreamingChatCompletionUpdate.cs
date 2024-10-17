// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class StreamingChatCompletionUpdate
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal StreamingChatCompletionUpdate(string model, InternalCreateChatCompletionStreamResponseObject @object, string completionId, IEnumerable<InternalCreateChatCompletionStreamResponseChoice> choices, DateTimeOffset createdAt)
        {
            Model = model;
            this.Object = @object;
            CompletionId = completionId;
            Choices = choices.ToList();
            CreatedAt = createdAt;
        }

        internal StreamingChatCompletionUpdate(string model, string systemFingerprint, InternalCreateChatCompletionStreamResponseObject @object, string completionId, InternalCreateChatCompletionStreamResponseServiceTier? serviceTier, IReadOnlyList<InternalCreateChatCompletionStreamResponseChoice> choices, DateTimeOffset createdAt, ChatTokenUsage usage, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Model = model;
            SystemFingerprint = systemFingerprint;
            this.Object = @object;
            CompletionId = completionId;
            ServiceTier = serviceTier;
            Choices = choices;
            CreatedAt = createdAt;
            Usage = usage;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Model { get; }

        public string SystemFingerprint { get; }
    }
}
