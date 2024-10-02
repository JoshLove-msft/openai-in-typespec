// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenAI.Batch
{
    // Data plane generated sub-client.
    public partial class BatchClient
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        protected BatchClient()
        {
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });

        public ClientPipeline Pipeline { get; }

        public virtual ClientResult ListBatches(string after, int? limit, RequestOptions options)
        {
            using PipelineMessage message = CreateListBatchesRequest(after, limit, options);
            return ClientResult.FromResponse(Pipeline.ProcessMessage(message, options));
        }

        public virtual async Task<ClientResult> ListBatchesAsync(string after, int? limit, RequestOptions options)
        {
            using PipelineMessage message = CreateListBatchesRequest(after, limit, options);
            return ClientResult.FromResponse(await Pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        public virtual ClientResult<InternalListBatchesResponse> ListBatches(string after, int? limit)
        {
            ClientResult result = ListBatches(after, limit, null);
            return ClientResult.FromValue((InternalListBatchesResponse)result, result.GetRawResponse());
        }

        public virtual async Task<ClientResult<InternalListBatchesResponse>> ListBatchesAsync(string after, int? limit)
        {
            ClientResult result = await ListBatchesAsync(after, limit, null).ConfigureAwait(false);
            return ClientResult.FromValue((InternalListBatchesResponse)result, result.GetRawResponse());
        }
    }
}
