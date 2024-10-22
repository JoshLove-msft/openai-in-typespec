// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class FineTuningOptions
    {
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public FineTuningOptions(InternalCreateFineTuningJobRequestModel model, string trainingFile)
        {
            Argument.AssertNotNull(trainingFile, nameof(trainingFile));

            Model = model;
            TrainingFile = trainingFile;
            Integrations = new ChangeTrackingList<FineTuningIntegration>();
        }

        internal FineTuningOptions(InternalCreateFineTuningJobRequestModel model, string trainingFile, HyperparameterOptions hyperparameters, string suffix, string validationFile, IList<FineTuningIntegration> integrations, int? seed, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Model = model;
            TrainingFile = trainingFile;
            Hyperparameters = hyperparameters;
            Suffix = suffix;
            ValidationFile = validationFile;
            Integrations = integrations;
            Seed = seed;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalCreateFineTuningJobRequestModel Model { get; set; }

        public string TrainingFile { get; set; }

        public HyperparameterOptions Hyperparameters { get; set; }

        public string Suffix { get; set; }

        public string ValidationFile { get; set; }

        public IList<FineTuningIntegration> Integrations { get; set; }

        public int? Seed { get; set; }
    }
}
