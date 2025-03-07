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

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationEnabledResourceType : IUtf8JsonSerializable, IJsonModel<CustomLocationEnabledResourceType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomLocationEnabledResourceType>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomLocationEnabledResourceType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterExtensionId))
            {
                writer.WritePropertyName("clusterExtensionId"u8);
                writer.WriteStringValue(ClusterExtensionId);
            }
            if (Optional.IsDefined(ExtensionType))
            {
                writer.WritePropertyName("extensionType"u8);
                writer.WriteStringValue(ExtensionType);
            }
            if (Optional.IsCollectionDefined(TypesMetadata))
            {
                writer.WritePropertyName("typesMetadata"u8);
                writer.WriteStartArray();
                foreach (var item in TypesMetadata)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        CustomLocationEnabledResourceType IJsonModel<CustomLocationEnabledResourceType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomLocationEnabledResourceType(document.RootElement, options);
        }

        internal static CustomLocationEnabledResourceType DeserializeCustomLocationEnabledResourceType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier clusterExtensionId = default;
            string extensionType = default;
            IList<CustomLocationEnabledResourceTypeMetadata> typesMetadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("clusterExtensionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterExtensionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extensionType"u8))
                        {
                            extensionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typesMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CustomLocationEnabledResourceTypeMetadata> array = new List<CustomLocationEnabledResourceTypeMetadata>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CustomLocationEnabledResourceTypeMetadata.DeserializeCustomLocationEnabledResourceTypeMetadata(item, options));
                            }
                            typesMetadata = array;
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
            return new CustomLocationEnabledResourceType(
                id,
                name,
                type,
                systemData,
                clusterExtensionId,
                extensionType,
                typesMetadata ?? new ChangeTrackingList<CustomLocationEnabledResourceTypeMetadata>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomLocationEnabledResourceType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support writing '{options.Format}' format.");
            }
        }

        CustomLocationEnabledResourceType IPersistableModel<CustomLocationEnabledResourceType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCustomLocationEnabledResourceType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomLocationEnabledResourceType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
