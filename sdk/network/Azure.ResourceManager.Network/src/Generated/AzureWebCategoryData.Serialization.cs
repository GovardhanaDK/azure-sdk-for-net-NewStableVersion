// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Network
{
    public partial class AzureWebCategoryData : IUtf8JsonSerializable, IJsonModel<AzureWebCategoryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureWebCategoryData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureWebCategoryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureWebCategoryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureWebCategoryData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group);
            }
            writer.WriteEndObject();
        }

        AzureWebCategoryData IJsonModel<AzureWebCategoryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureWebCategoryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureWebCategoryData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureWebCategoryData(document.RootElement, options);
        }

        internal static AzureWebCategoryData DeserializeAzureWebCategoryData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string group = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("group"u8))
                        {
                            group = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureWebCategoryData(
                id,
                name,
                type,
                systemData,
                etag,
                group,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureWebCategoryData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureWebCategoryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureWebCategoryData)} does not support writing '{options.Format}' format.");
            }
        }

        AzureWebCategoryData IPersistableModel<AzureWebCategoryData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureWebCategoryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureWebCategoryData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureWebCategoryData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureWebCategoryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
