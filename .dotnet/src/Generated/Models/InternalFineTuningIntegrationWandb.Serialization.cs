// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningIntegrationWandb : IJsonModel<InternalFineTuningIntegrationWandb>
    {
        internal InternalFineTuningIntegrationWandb()
        {
        }

        void IJsonModel<InternalFineTuningIntegrationWandb>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuningIntegrationWandb)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("wandb"u8);
            writer.WriteObjectValue(Wandb, options);
        }

        InternalFineTuningIntegrationWandb IJsonModel<InternalFineTuningIntegrationWandb>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalFineTuningIntegrationWandb)JsonModelCreateCore(ref reader, options);

        protected override InternalFineTuningIntegration JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuningIntegrationWandb)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFineTuningIntegrationWandb(document.RootElement, options);
        }

        internal static InternalFineTuningIntegrationWandb DeserializeInternalFineTuningIntegrationWandb(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FineTuningIntegrationWandbWandb wandb = default;
            string @type = "wandb";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("wandb"u8))
                {
                    wandb = FineTuningIntegrationWandbWandb.DeserializeFineTuningIntegrationWandbWandb(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalFineTuningIntegrationWandb(wandb, @type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalFineTuningIntegrationWandb>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuningIntegrationWandb)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFineTuningIntegrationWandb IPersistableModel<InternalFineTuningIntegrationWandb>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalFineTuningIntegrationWandb)PersistableModelCreateCore(data, options);

        protected override InternalFineTuningIntegration PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalFineTuningIntegrationWandb(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuningIntegrationWandb)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFineTuningIntegrationWandb>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalFineTuningIntegrationWandb internalFineTuningIntegrationWandb)
        {
            return BinaryContent.Create(internalFineTuningIntegrationWandb, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalFineTuningIntegrationWandb(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalFineTuningIntegrationWandb(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
