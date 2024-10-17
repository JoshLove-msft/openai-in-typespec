// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class ThreadDeletionResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ThreadDeletionResult(bool deleted, string threadId, InternalDeleteThreadResponseObject @object)
        {
            Deleted = deleted;
            ThreadId = threadId;
            this.Object = @object;
        }

        internal ThreadDeletionResult(bool deleted, string threadId, InternalDeleteThreadResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Deleted = deleted;
            ThreadId = threadId;
            this.Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public bool Deleted { get; }
    }
}
