// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    internal partial class InternalListMessagesResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListMessagesResponse(IEnumerable<ThreadMessage> data, string firstId, string lastId, bool hasMore)
        {
            Data = data.ToList();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        internal InternalListMessagesResponse(InternalListMessagesResponseObject @object, IList<ThreadMessage> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Object = @object;
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalListMessagesResponseObject Object { get; } = "list";

        public IList<ThreadMessage> Data { get; }

        public string FirstId { get; }

        public string LastId { get; }

        public bool HasMore { get; }
    }
}
