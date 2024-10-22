// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class Assistant
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal Assistant(string id, DateTimeOffset createdAt, string name, string description, string model, string instructions, IEnumerable<ToolDefinition> tools, IDictionary<string, string> metadata)
        {
            Id = id;
            CreatedAt = createdAt;
            Name = name;
            Description = description;
            Model = model;
            Instructions = instructions;
            Tools = tools.ToList();
            Metadata = metadata;
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

        public string Id { get; }

        public DateTimeOffset CreatedAt { get; }

        public string Name { get; }

        public string Description { get; }

        public string Model { get; }

        public string Instructions { get; }

        public IList<ToolDefinition> Tools { get; }

        public ToolResources ToolResources { get; }

        public IDictionary<string, string> Metadata { get; }

        public float? Temperature { get; }
    }
}
