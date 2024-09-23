// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageContentImageUrlObjectImageUrl
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalMessageContentImageUrlObjectImageUrl(Uri url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
        }

        internal InternalMessageContentImageUrlObjectImageUrl(Uri url, InternalMessageContentImageUrlObjectImageUrlDetail? detail, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Url = url;
            Detail = detail;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public Uri Url { get; set; }
    }
}
