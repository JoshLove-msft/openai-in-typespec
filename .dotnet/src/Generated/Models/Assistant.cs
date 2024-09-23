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

        internal Assistant(string id, InternalAssistantObjectObject @object, DateTimeOffset createdAt, string name, string description, string model, string instructions, IList<ToolDefinition> tools, ToolResources toolResources, IDictionary<string, string> metadata, float? temperature, float? topP, BinaryData responseFormat, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            Name = name;
            Description = description;
            Model = model;
            Instructions = instructions;
            Tools = tools;
            ToolResources = toolResources;
            Metadata = metadata;
            Temperature = temperature;
            TopP = topP;
            ResponseFormat = responseFormat;
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
