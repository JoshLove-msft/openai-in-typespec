// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalListRunStepsResponse
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListRunStepsResponse(string firstId, string lastId, bool hasMore)
        {
            Data = new ChangeTrackingList<RunStep>();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        internal InternalListRunStepsResponse(InternalListRunStepsResponseObject @object, IReadOnlyList<RunStep> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Object = @object;
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalListRunStepsResponseObject Object { get; } = "list";

        public IReadOnlyList<RunStep> Data { get; }

        public string FirstId { get; }

        public string LastId { get; }

        public bool HasMore { get; }
    }
}
