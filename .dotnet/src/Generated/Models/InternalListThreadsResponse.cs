// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalListThreadsResponse
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListThreadsResponse(string firstId, string lastId, bool hasMore)
        {
            Data = new ChangeTrackingList<AssistantThread>();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        internal InternalListThreadsResponse(InternalListThreadsResponseObject @object, IReadOnlyList<AssistantThread> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Object = @object;
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalListThreadsResponseObject Object { get; } = "list";

        public IReadOnlyList<AssistantThread> Data { get; }

        public string FirstId { get; }

        public string LastId { get; }

        public bool HasMore { get; }
    }
}
