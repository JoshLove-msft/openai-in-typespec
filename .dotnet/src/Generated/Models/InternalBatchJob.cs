// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Batch
{
    internal partial class InternalBatchJob
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalBatchJob(string id, string endpoint, string inputFileId, string completionWindow, InternalBatchStatus status, DateTimeOffset createdAt)
        {
            Id = id;
            Endpoint = endpoint;
            InputFileId = inputFileId;
            CompletionWindow = completionWindow;
            Status = status;
            CreatedAt = createdAt;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal InternalBatchJob(string id, InternalBatchObject @object, string endpoint, InternalBatchErrors errors, string inputFileId, string completionWindow, InternalBatchStatus status, string outputFileId, string errorFileId, DateTimeOffset createdAt, DateTimeOffset? inProgressAt, DateTimeOffset? expiresAt, DateTimeOffset? finalizingAt, DateTimeOffset? completedAt, DateTimeOffset? failedAt, DateTimeOffset? expiredAt, DateTimeOffset? cancellingAt, DateTimeOffset? cancelledAt, InternalBatchRequestCounts requestCounts, IDictionary<string, string> metadata, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Object = @object;
            Endpoint = endpoint;
            Errors = errors;
            InputFileId = inputFileId;
            CompletionWindow = completionWindow;
            Status = status;
            OutputFileId = outputFileId;
            ErrorFileId = errorFileId;
            CreatedAt = createdAt;
            InProgressAt = inProgressAt;
            ExpiresAt = expiresAt;
            FinalizingAt = finalizingAt;
            CompletedAt = completedAt;
            FailedAt = failedAt;
            ExpiredAt = expiredAt;
            CancellingAt = cancellingAt;
            CancelledAt = cancelledAt;
            RequestCounts = requestCounts;
            Metadata = metadata;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; set; }

        public InternalBatchObject Object { get; } = "batch";

        public string Endpoint { get; set; }

        public InternalBatchErrors Errors { get; set; }

        public string InputFileId { get; set; }

        public string CompletionWindow { get; set; }

        public InternalBatchStatus Status { get; set; }

        public string OutputFileId { get; set; }

        public string ErrorFileId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? InProgressAt { get; set; }

        public DateTimeOffset? ExpiresAt { get; set; }

        public DateTimeOffset? FinalizingAt { get; set; }

        public DateTimeOffset? CompletedAt { get; set; }

        public DateTimeOffset? FailedAt { get; set; }

        public DateTimeOffset? ExpiredAt { get; set; }

        public DateTimeOffset? CancellingAt { get; set; }

        public DateTimeOffset? CancelledAt { get; set; }

        public InternalBatchRequestCounts RequestCounts { get; set; }

        public IDictionary<string, string> Metadata { get; set; }
    }
}
