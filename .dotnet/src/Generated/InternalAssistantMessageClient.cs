// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class InternalAssistantMessageClient
    {
        private readonly Uri _endpoint;
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";

        protected InternalAssistantMessageClient()
        {
        }

        public ClientPipeline Pipeline { get; }

        public virtual ClientResult ListMessages(string threadId, int? limit, string order, string after, string before, RequestOptions options)
        {
            Argument.AssertNotNull(threadId, nameof(threadId));

            using PipelineMessage message = CreateListMessagesRequest(threadId, limit, order, after, before, options);
            return ClientResult.FromResponse(Pipeline.ProcessMessage(message, options));
        }

        public virtual async Task<ClientResult> ListMessagesAsync(string threadId, int? limit, string order, string after, string before, RequestOptions options)
        {
            Argument.AssertNotNull(threadId, nameof(threadId));

            using PipelineMessage message = CreateListMessagesRequest(threadId, limit, order, after, before, options);
            return ClientResult.FromResponse(await Pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        public virtual ClientResult<InternalListMessagesResponse> ListMessages(string threadId, int? limit, MessageCollectionOrder? order, string after, string before)
        {
            Argument.AssertNotNull(threadId, nameof(threadId));

            ClientResult result = ListMessages(threadId, limit, order.ToString(), after, before, null);
            return ClientResult.FromValue((InternalListMessagesResponse)result, result.GetRawResponse());
        }

        public virtual async Task<ClientResult<InternalListMessagesResponse>> ListMessagesAsync(string threadId, int? limit, MessageCollectionOrder? order, string after, string before)
        {
            Argument.AssertNotNull(threadId, nameof(threadId));

            ClientResult result = await ListMessagesAsync(threadId, limit, order.ToString(), after, before, null).ConfigureAwait(false);
            return ClientResult.FromValue((InternalListMessagesResponse)result, result.GetRawResponse());
        }
    }
}
