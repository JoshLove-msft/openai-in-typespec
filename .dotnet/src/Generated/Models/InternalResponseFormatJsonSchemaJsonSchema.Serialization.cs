// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Internal
{
    internal partial class InternalResponseFormatJsonSchemaJsonSchema : IJsonModel<InternalResponseFormatJsonSchemaJsonSchema>
    {
        internal InternalResponseFormatJsonSchemaJsonSchema()
        {
        }

        void IJsonModel<InternalResponseFormatJsonSchemaJsonSchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseFormatJsonSchemaJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponseFormatJsonSchemaJsonSchema)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue<InternalResponseFormatJsonSchemaSchema>(Schema, options);
            }
            if (Optional.IsDefined(Strict))
            {
                if (Strict != null)
                {
                    writer.WritePropertyName("strict"u8);
                    writer.WriteBooleanValue(Strict.Value);
                }
                else
                {
                    writer.WriteNull("strict"u8);
                }
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalResponseFormatJsonSchemaJsonSchema IJsonModel<InternalResponseFormatJsonSchemaJsonSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalResponseFormatJsonSchemaJsonSchema JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseFormatJsonSchemaJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponseFormatJsonSchemaJsonSchema)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponseFormatJsonSchemaJsonSchema(document.RootElement, options);
        }

        internal static InternalResponseFormatJsonSchemaJsonSchema DeserializeInternalResponseFormatJsonSchemaJsonSchema(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            string name = default;
            InternalResponseFormatJsonSchemaSchema schema = default;
            bool? strict = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("description"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("schema"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        schema = null;
                        continue;
                    }
                    schema = InternalResponseFormatJsonSchemaSchema.DeserializeInternalResponseFormatJsonSchemaSchema(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("strict"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        strict = null;
                        continue;
                    }
                    strict = prop.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalResponseFormatJsonSchemaJsonSchema(description, name, schema, strict, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalResponseFormatJsonSchemaJsonSchema>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseFormatJsonSchemaJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponseFormatJsonSchemaJsonSchema)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponseFormatJsonSchemaJsonSchema IPersistableModel<InternalResponseFormatJsonSchemaJsonSchema>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalResponseFormatJsonSchemaJsonSchema PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseFormatJsonSchemaJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponseFormatJsonSchemaJsonSchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponseFormatJsonSchemaJsonSchema)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponseFormatJsonSchemaJsonSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponseFormatJsonSchemaJsonSchema internalResponseFormatJsonSchemaJsonSchema)
        {
            return BinaryContent.Create(internalResponseFormatJsonSchemaJsonSchema, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponseFormatJsonSchemaJsonSchema(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponseFormatJsonSchemaJsonSchema(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
