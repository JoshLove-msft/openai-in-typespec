// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class ThreadMessage
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ThreadMessage(string id, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageFailureDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, IEnumerable<MessageContent> content, string assistantId, string runId, IDictionary<string, string> metadata, InternalMessageObjectObject @object, Assistants.MessageRole role, IEnumerable<MessageCreationAttachment> attachments)
        {
            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Content = content.ToList();
            AssistantId = assistantId;
            RunId = runId;
            Metadata = metadata;
            this.Object = @object;
            Role = role;
            Attachments = attachments.ToList();
        }

        internal ThreadMessage(string id, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageFailureDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, IList<MessageContent> content, string assistantId, string runId, IDictionary<string, string> metadata, InternalMessageObjectObject @object, Assistants.MessageRole role, IReadOnlyList<MessageCreationAttachment> attachments, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Content = content;
            AssistantId = assistantId;
            RunId = runId;
            Metadata = metadata;
            this.Object = @object;
            Role = role;
            Attachments = attachments;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; }

        public DateTimeOffset CreatedAt { get; }

        public string ThreadId { get; }

        public MessageStatus Status { get; }

        public MessageFailureDetails IncompleteDetails { get; }

        public DateTimeOffset? CompletedAt { get; }

        public DateTimeOffset? IncompleteAt { get; }

        public IList<MessageContent> Content { get; }

        public string AssistantId { get; }

        public string RunId { get; }

        public IDictionary<string, string> Metadata { get; }
    }
}
