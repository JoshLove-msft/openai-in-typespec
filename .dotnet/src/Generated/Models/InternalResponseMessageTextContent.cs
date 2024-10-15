// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalResponseMessageTextContent : MessageContent
    {
        public InternalResponseMessageTextContent(string @type, InternalMessageContentTextObjectText text)
        {
            Argument.AssertNotNull(@type, nameof(@type));
            Argument.AssertNotNull(text, nameof(text));

        }

        internal InternalResponseMessageTextContent(string @type, InternalMessageContentTextObjectText text, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(additionalBinaryDataProperties)
        {
        }
    }
}
