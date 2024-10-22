// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class ChatTokenLogProbabilityDetails
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ChatTokenLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes, IEnumerable<ChatTokenTopLogProbabilityDetails> topLogProbabilities)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8Bytes = utf8Bytes;
            TopLogProbabilities = topLogProbabilities.ToList();
        }

        internal ChatTokenLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes, IReadOnlyList<ChatTokenTopLogProbabilityDetails> topLogProbabilities, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8Bytes = utf8Bytes;
            TopLogProbabilities = topLogProbabilities;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Token { get; }
    }
}
