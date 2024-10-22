// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationOutputTokenUsageDetails
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ConversationOutputTokenUsageDetails(int textTokens, int audioTokens)
        {
            TextTokens = textTokens;
            AudioTokens = audioTokens;
        }

        internal ConversationOutputTokenUsageDetails(int textTokens, int audioTokens, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            TextTokens = textTokens;
            AudioTokens = audioTokens;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public int TextTokens { get; }

        public int AudioTokens { get; }
    }
}
