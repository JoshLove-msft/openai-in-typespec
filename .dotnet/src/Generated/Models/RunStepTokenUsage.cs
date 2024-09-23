// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class RunStepTokenUsage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal RunStepTokenUsage(int completionTokens, int promptTokens, int totalTokens)
        {
            CompletionTokens = completionTokens;
            PromptTokens = promptTokens;
            TotalTokens = totalTokens;
        }

        internal RunStepTokenUsage(int completionTokens, int promptTokens, int totalTokens, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            CompletionTokens = completionTokens;
            PromptTokens = promptTokens;
            TotalTokens = totalTokens;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public int CompletionTokens { get; set; }

        public int PromptTokens { get; set; }

        public int TotalTokens { get; set; }
    }
}
