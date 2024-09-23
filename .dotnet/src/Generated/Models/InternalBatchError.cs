// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Batch
{
    internal partial class InternalBatchError
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalBatchError()
        {
        }

        internal InternalBatchError(string code, string message, string @param, int? line, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Code = code;
            Message = message;
            Param = @param;
            Line = line;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Code { get; set; }

        public string Message { get; set; }

        public string Param { get; set; }

        public int? Line { get; set; }
    }
}
