// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    public partial class DigitalTwinsPrivateLinkResourceData : IUtf8JsonSerializable, IJsonModel<DigitalTwinsPrivateLinkResourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DigitalTwinsPrivateLinkResourceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DigitalTwinsPrivateLinkResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsPrivateLinkResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsPrivateLinkResourceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties, options);
        }

        DigitalTwinsPrivateLinkResourceData IJsonModel<DigitalTwinsPrivateLinkResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsPrivateLinkResourceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsPrivateLinkResourceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsPrivateLinkResourceData(document.RootElement, options);
        }

        internal static DigitalTwinsPrivateLinkResourceData DeserializeDigitalTwinsPrivateLinkResourceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DigitalTwinsPrivateLinkResourceProperties properties = default;
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
                    properties = DigitalTwinsPrivateLinkResourceProperties.DeserializeDigitalTwinsPrivateLinkResourceProperties(property.Value, options);
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
            return new DigitalTwinsPrivateLinkResourceData(
                id,
                name,
                type,
                systemData,
                properties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DigitalTwinsPrivateLinkResourceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsPrivateLinkResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsPrivateLinkResourceData)} does not support writing '{options.Format}' format.");
            }
        }

        DigitalTwinsPrivateLinkResourceData IPersistableModel<DigitalTwinsPrivateLinkResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsPrivateLinkResourceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDigitalTwinsPrivateLinkResourceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsPrivateLinkResourceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DigitalTwinsPrivateLinkResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
