// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class FineTuningIntegrationWandbWandb
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal FineTuningIntegrationWandbWandb(string project)
        {
            Project = project;
            Tags = new ChangeTrackingList<string>();
        }

        internal FineTuningIntegrationWandbWandb(string project, string name, string entity, IList<string> tags, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Project = project;
            Name = name;
            Entity = entity;
            Tags = tags;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Project { get; set; }

        public string Name { get; set; }

        public string Entity { get; set; }

        public IList<string> Tags { get; }
    }
}
