// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading;
using OpenAI.Assistants;
using OpenAI.Audio;
using OpenAI.Batch;
using OpenAI.Chat;
using OpenAI.Embeddings;
using OpenAI.Files;
using OpenAI.FineTuning;
using OpenAI.Images;
using OpenAI.LegacyCompletions;
using OpenAI.Models;
using OpenAI.Moderations;
using OpenAI.VectorStores;

namespace OpenAI
{
    public partial class OpenAIClient
    {
        private readonly Uri _endpoint;
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private AudioClient _cachedAudioClient;
        private AssistantClient _cachedAssistantClient;
        private BatchClient _cachedBatchClient;
        private ChatClient _cachedChatClient;
        private LegacyCompletionClient _cachedLegacyCompletionClient;
        private EmbeddingClient _cachedEmbeddingClient;
        private FileClient _cachedFileClient;
        private FineTuningClient _cachedFineTuningClient;
        private ImageClient _cachedImageClient;
        private InternalAssistantMessageClient _cachedInternalAssistantMessageClient;
        private ModelClient _cachedModelClient;
        private ModerationClient _cachedModerationClient;
        private InternalAssistantThreadClient _cachedInternalAssistantThreadClient;
        private InternalAssistantRunClient _cachedInternalAssistantRunClient;
        private VectorStoreClient _cachedVectorStoreClient;
        private InternalUploadsClient _cachedInternalUploadsClient;

        protected OpenAIClient()
        {
        }

        public ClientPipeline Pipeline { get; }

        public virtual AudioClient GetAudioClientClient()
        {
            return Volatile.Read(ref _cachedAudioClient) ?? Interlocked.CompareExchange(ref _cachedAudioClient, new AudioClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedAudioClient;
        }

        public virtual AssistantClient GetAssistantClientClient()
        {
            return Volatile.Read(ref _cachedAssistantClient) ?? Interlocked.CompareExchange(ref _cachedAssistantClient, new AssistantClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedAssistantClient;
        }

        public virtual BatchClient GetBatchClientClient()
        {
            return Volatile.Read(ref _cachedBatchClient) ?? Interlocked.CompareExchange(ref _cachedBatchClient, new BatchClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedBatchClient;
        }

        public virtual ChatClient GetChatClientClient()
        {
            return Volatile.Read(ref _cachedChatClient) ?? Interlocked.CompareExchange(ref _cachedChatClient, new ChatClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedChatClient;
        }

        public virtual LegacyCompletionClient GetLegacyCompletionClientClient()
        {
            return Volatile.Read(ref _cachedLegacyCompletionClient) ?? Interlocked.CompareExchange(ref _cachedLegacyCompletionClient, new LegacyCompletionClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedLegacyCompletionClient;
        }

        public virtual EmbeddingClient GetEmbeddingClientClient()
        {
            return Volatile.Read(ref _cachedEmbeddingClient) ?? Interlocked.CompareExchange(ref _cachedEmbeddingClient, new EmbeddingClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedEmbeddingClient;
        }

        public virtual FileClient GetFileClientClient()
        {
            return Volatile.Read(ref _cachedFileClient) ?? Interlocked.CompareExchange(ref _cachedFileClient, new FileClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedFileClient;
        }

        public virtual FineTuningClient GetFineTuningClientClient()
        {
            return Volatile.Read(ref _cachedFineTuningClient) ?? Interlocked.CompareExchange(ref _cachedFineTuningClient, new FineTuningClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedFineTuningClient;
        }

        public virtual ImageClient GetImageClientClient()
        {
            return Volatile.Read(ref _cachedImageClient) ?? Interlocked.CompareExchange(ref _cachedImageClient, new ImageClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedImageClient;
        }

        public virtual InternalAssistantMessageClient GetInternalAssistantMessageClientClient()
        {
            return Volatile.Read(ref _cachedInternalAssistantMessageClient) ?? Interlocked.CompareExchange(ref _cachedInternalAssistantMessageClient, new InternalAssistantMessageClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedInternalAssistantMessageClient;
        }

        public virtual ModelClient GetModelClientClient()
        {
            return Volatile.Read(ref _cachedModelClient) ?? Interlocked.CompareExchange(ref _cachedModelClient, new ModelClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedModelClient;
        }

        public virtual ModerationClient GetModerationClientClient()
        {
            return Volatile.Read(ref _cachedModerationClient) ?? Interlocked.CompareExchange(ref _cachedModerationClient, new ModerationClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedModerationClient;
        }

        public virtual InternalAssistantThreadClient GetInternalAssistantThreadClientClient()
        {
            return Volatile.Read(ref _cachedInternalAssistantThreadClient) ?? Interlocked.CompareExchange(ref _cachedInternalAssistantThreadClient, new InternalAssistantThreadClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedInternalAssistantThreadClient;
        }

        public virtual InternalAssistantRunClient GetInternalAssistantRunClientClient()
        {
            return Volatile.Read(ref _cachedInternalAssistantRunClient) ?? Interlocked.CompareExchange(ref _cachedInternalAssistantRunClient, new InternalAssistantRunClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedInternalAssistantRunClient;
        }

        public virtual VectorStoreClient GetVectorStoreClientClient()
        {
            return Volatile.Read(ref _cachedVectorStoreClient) ?? Interlocked.CompareExchange(ref _cachedVectorStoreClient, new VectorStoreClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedVectorStoreClient;
        }

        public virtual InternalUploadsClient GetInternalUploadsClientClient()
        {
            return Volatile.Read(ref _cachedInternalUploadsClient) ?? Interlocked.CompareExchange(ref _cachedInternalUploadsClient, new InternalUploadsClient(Pipeline, _keyCredential, _endpoint), null) ?? _cachedInternalUploadsClient;
        }
    }
}
