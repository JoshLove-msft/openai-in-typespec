// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class AssistantModificationOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public AssistantModificationOptions()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
            DefaultTools = new ChangeTrackingList<ToolDefinition>();
        }

        internal AssistantModificationOptions(string name, string description, string instructions, IDictionary<string, string> metadata, float? temperature, IList<ToolDefinition> defaultTools, ToolResources toolResources, AssistantResponseFormat responseFormat, float? nucleusSamplingFactor, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            Description = description;
            Instructions = instructions;
            Metadata = metadata;
            Temperature = temperature;
            DefaultTools = defaultTools;
            ToolResources = toolResources;
            ResponseFormat = responseFormat;
            NucleusSamplingFactor = nucleusSamplingFactor;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Instructions { get; set; }

        public IDictionary<string, string> Metadata { get; set; }

        public float? Temperature { get; set; }
    }
}
