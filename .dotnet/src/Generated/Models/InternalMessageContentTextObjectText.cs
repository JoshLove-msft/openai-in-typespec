// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageContentTextObjectText
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalMessageContentTextObjectText(string value, IEnumerable<InternalMessageContentTextObjectAnnotation> annotations)
        {
            Argument.AssertNotNull(value, nameof(value));
            Argument.AssertNotNull(annotations, nameof(annotations));

            Value = value;
            Annotations = annotations.ToList();
        }

        internal InternalMessageContentTextObjectText(string value, IList<InternalMessageContentTextObjectAnnotation> annotations, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Value = value;
            Annotations = annotations;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Value { get; set; }

        public IList<InternalMessageContentTextObjectAnnotation> Annotations { get; }
    }
}
