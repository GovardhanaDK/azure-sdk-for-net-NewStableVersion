// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HealthDataAIServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthDataAIServices
{
    public partial class HealthDataAIServicesPrivateEndpointConnectionResourceData : IUtf8JsonSerializable, IJsonModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthDataAIServicesPrivateEndpointConnectionResourceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
            }
        }

        HealthDataAIServicesPrivateEndpointConnectionResourceData IJsonModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthDataAIServicesPrivateEndpointConnectionResourceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthDataAIServicesPrivateEndpointConnectionResourceData(document.RootElement, options);
        }

        internal static HealthDataAIServicesPrivateEndpointConnectionResourceData DeserializeHealthDataAIServicesPrivateEndpointConnectionResourceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PrivateEndpointConnectionProperties properties = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = PrivateEndpointConnectionProperties.DeserializePrivateEndpointConnectionProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthDataAIServicesPrivateEndpointConnectionResourceData(
                id,
                name,
                type,
                systemData,
                properties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthDataAIServicesPrivateEndpointConnectionResourceData)} does not support writing '{options.Format}' format.");
            }
        }

        HealthDataAIServicesPrivateEndpointConnectionResourceData IPersistableModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHealthDataAIServicesPrivateEndpointConnectionResourceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthDataAIServicesPrivateEndpointConnectionResourceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthDataAIServicesPrivateEndpointConnectionResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
