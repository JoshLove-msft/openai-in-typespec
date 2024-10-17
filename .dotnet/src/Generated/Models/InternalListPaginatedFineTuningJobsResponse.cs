// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.FineTuning
{
    internal partial class InternalListPaginatedFineTuningJobsResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListPaginatedFineTuningJobsResponse(IEnumerable<FineTuningJob> data, bool hasMore)
        {
            Data = data.ToList();
            HasMore = hasMore;
        }

        internal InternalListPaginatedFineTuningJobsResponse(IList<FineTuningJob> data, bool hasMore, InternalListPaginatedFineTuningJobsResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Data = data;
            HasMore = hasMore;
            Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<FineTuningJob> Data { get; }

        public bool HasMore { get; }

        public InternalListPaginatedFineTuningJobsResponseObject Object { get; } = "list";
    }
}
