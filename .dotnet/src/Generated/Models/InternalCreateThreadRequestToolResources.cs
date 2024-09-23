// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateThreadRequestToolResources
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalCreateThreadRequestToolResources()
        {
        }

        internal InternalCreateThreadRequestToolResources(InternalCreateThreadRequestToolResourcesCodeInterpreter codeInterpreter, FileSearchToolResources fileSearch, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalCreateThreadRequestToolResourcesCodeInterpreter CodeInterpreter { get; set; }

        public FileSearchToolResources FileSearch { get; set; }
    }
}
