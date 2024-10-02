// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.RealtimeConversation
{
    internal partial class UnknownRealtimeResponseItem : IJsonModel<InternalRealtimeResponseItem>
    {
        void IJsonModel<InternalRealtimeResponseItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("id") != true)
            {
                if (Id != null)
                {
                    writer.WritePropertyName("id"u8);
                    writer.WriteStringValue(Id);
                }
                else
                {
                    writer.WriteNull("id");
                }
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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
            writer.WriteEndObject();
        }

        InternalRealtimeResponseItem IJsonModel<InternalRealtimeResponseItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeResponseItem(document.RootElement, options);
        }

        internal static UnknownRealtimeResponseItem DeserializeUnknownRealtimeResponseItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeResponseItemObject @object = default;
            InternalRealtimeRequestItemType type = "Unknown";
            string id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = new InternalRealtimeResponseItemObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new InternalRealtimeRequestItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownRealtimeResponseItem(@object, type, id, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalRealtimeResponseItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseItem)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeResponseItem IPersistableModel<InternalRealtimeResponseItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRealtimeResponseItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeResponseItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new UnknownRealtimeResponseItem FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownRealtimeResponseItem(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create<InternalRealtimeResponseItem>(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
