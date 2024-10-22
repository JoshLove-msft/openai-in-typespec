// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class ChatCompletion
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ChatCompletion(string id, string model, IEnumerable<InternalCreateChatCompletionResponseChoice> choices, DateTimeOffset createdAt)
        {
            Id = id;
            Model = model;
            Choices = choices.ToList();
            CreatedAt = createdAt;
        }

        internal ChatCompletion(string id, string model, string systemFingerprint, ChatTokenUsage usage, InternalCreateChatCompletionResponseObject @object, InternalCreateChatCompletionResponseServiceTier? serviceTier, IReadOnlyList<InternalCreateChatCompletionResponseChoice> choices, DateTimeOffset createdAt, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Model = model;
            SystemFingerprint = systemFingerprint;
            Usage = usage;
            this.Object = @object;
            ServiceTier = serviceTier;
            Choices = choices;
            CreatedAt = createdAt;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; }

        public string Model { get; }

        public string SystemFingerprint { get; }

        public ChatTokenUsage Usage { get; }
    }
}
