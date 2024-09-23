// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRequestMessageTextContent : MessageContent
    {
        public InternalRequestMessageTextContent(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
        }

        internal InternalRequestMessageTextContent(InternalMessageRequestContentTextObjectType @type, string text, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(additionalBinaryDataProperties)
        {
            Type = @type;
            Text = text;
        }

        public InternalMessageRequestContentTextObjectType Type { get; } = "text";
    }
}
