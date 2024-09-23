// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Files
{
    public partial class OpenAIFileInfoCollection
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal OpenAIFileInfoCollection(IList<OpenAIFileInfo> data, InternalListFilesResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Data = data;
            Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }
    }
}
