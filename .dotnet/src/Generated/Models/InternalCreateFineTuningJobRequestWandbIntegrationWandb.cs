// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalCreateFineTuningJobRequestWandbIntegrationWandb
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalCreateFineTuningJobRequestWandbIntegrationWandb(string project)
        {
            Argument.AssertNotNull(project, nameof(project));

            Project = project;
            Tags = new ChangeTrackingList<string>();
        }

        internal InternalCreateFineTuningJobRequestWandbIntegrationWandb(string project, string name, string entity, IList<string> tags, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Project = project;
            Name = name;
            Entity = entity;
            Tags = tags;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Name { get; set; }

        public string Entity { get; set; }

        public IList<string> Tags { get; }
    }
}
