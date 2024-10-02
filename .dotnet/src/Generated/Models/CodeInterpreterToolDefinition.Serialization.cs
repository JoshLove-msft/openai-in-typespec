// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class CodeInterpreterToolDefinition : IJsonModel<CodeInterpreterToolDefinition>
    {
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodeInterpreterToolDefinition)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        CodeInterpreterToolDefinition IJsonModel<CodeInterpreterToolDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (CodeInterpreterToolDefinition)JsonModelCreateCore(ref reader, options);

        protected override ToolDefinition JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodeInterpreterToolDefinition)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCodeInterpreterToolDefinition(document.RootElement, options);
        }

        internal static CodeInterpreterToolDefinition DeserializeCodeInterpreterToolDefinition(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @type = "code_interpreter";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
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
            return new CodeInterpreterToolDefinition(@type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<CodeInterpreterToolDefinition>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CodeInterpreterToolDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        CodeInterpreterToolDefinition IPersistableModel<CodeInterpreterToolDefinition>.Create(BinaryData data, ModelReaderWriterOptions options) => (CodeInterpreterToolDefinition)PersistableModelCreateCore(data, options);

        protected override ToolDefinition PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeCodeInterpreterToolDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CodeInterpreterToolDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CodeInterpreterToolDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(CodeInterpreterToolDefinition codeInterpreterToolDefinition)
        {
            return BinaryContent.Create(codeInterpreterToolDefinition, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator CodeInterpreterToolDefinition(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeCodeInterpreterToolDefinition(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
