// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class MessageDeletionResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal MessageDeletionResult(bool deleted, string messageId, InternalDeleteMessageResponseObject @object)
        {
            Deleted = deleted;
            MessageId = messageId;
            Object = @object;
        }

        internal MessageDeletionResult(bool deleted, string messageId, InternalDeleteMessageResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Deleted = deleted;
            MessageId = messageId;
            Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public bool Deleted { get; set; }
    }
}
