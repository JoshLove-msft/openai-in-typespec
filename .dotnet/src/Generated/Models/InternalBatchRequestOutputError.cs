// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Batch
{
    internal partial class InternalBatchRequestOutputError
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalBatchRequestOutputError()
        {
        }

        internal InternalBatchRequestOutputError(string code, string message, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Code = code;
            Message = message;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Code { get; set; }

        public string Message { get; set; }
    }
}
