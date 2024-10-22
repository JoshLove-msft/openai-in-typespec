// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Moderations
{
    public partial class ModerationResult
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ModerationResult(bool flagged)
        {
            Flagged = flagged;
        }

        internal ModerationResult(bool flagged, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Flagged = flagged;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public bool Flagged { get; }
    }
}
