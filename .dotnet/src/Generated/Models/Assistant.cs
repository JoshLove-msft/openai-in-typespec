// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class Assistant
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal Assistant(string id, DateTimeOffset createdAt, string name, string description, string model, string instructions, IEnumerable<ToolDefinition> tools, IDictionary<string, string> metadata, InternalAssistantObjectObject @object)
        {
            Id = id;
            CreatedAt = createdAt;
            Name = name;
            Description = description;
            Model = model;
            Instructions = instructions;
            Tools = tools.ToList();
            Metadata = metadata;
            this.Object = @object;
        }

        internal Assistant(string id, DateTimeOffset createdAt, string name, string description, string model, string instructions, IList<ToolDefinition> tools, ToolResources toolResources, IDictionary<string, string> metadata, float? temperature, InternalAssistantObjectObject @object, AssistantResponseFormat responseFormat, float? nucleusSamplingFactor, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            CreatedAt = createdAt;
            Name = name;
            Description = description;
            Model = model;
            Instructions = instructions;
            Tools = tools;
            ToolResources = toolResources;
            Metadata = metadata;
            Temperature = temperature;
            this.Object = @object;
            ResponseFormat = responseFormat;
            NucleusSamplingFactor = nucleusSamplingFactor;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public string Instructions { get; set; }

        public IList<ToolDefinition> Tools { get; }

        public ToolResources ToolResources { get; set; }

        public IDictionary<string, string> Metadata { get; set; }

        public float? Temperature { get; set; }
    }
}
