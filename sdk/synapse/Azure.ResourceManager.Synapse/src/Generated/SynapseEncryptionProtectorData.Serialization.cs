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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseEncryptionProtectorData : IUtf8JsonSerializable, IJsonModel<SynapseEncryptionProtectorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseEncryptionProtectorData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseEncryptionProtectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEncryptionProtectorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseEncryptionProtectorData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Subregion))
            {
                writer.WritePropertyName("subregion"u8);
                writer.WriteStringValue(Subregion);
            }
            if (Optional.IsDefined(ServerKeyName))
            {
                writer.WritePropertyName("serverKeyName"u8);
                writer.WriteStringValue(ServerKeyName);
            }
            if (Optional.IsDefined(ServerKeyType))
            {
                writer.WritePropertyName("serverKeyType"u8);
                writer.WriteStringValue(ServerKeyType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
                using (JsonDocument document = JsonDocument.Parse(Thumbprint, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        SynapseEncryptionProtectorData IJsonModel<SynapseEncryptionProtectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEncryptionProtectorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseEncryptionProtectorData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseEncryptionProtectorData(document.RootElement, options);
        }

        internal static SynapseEncryptionProtectorData DeserializeSynapseEncryptionProtectorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string subregion = default;
            string serverKeyName = default;
            SynapseServerKeyType? serverKeyType = default;
            Uri uri = default;
            BinaryData thumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("subregion"u8))
                        {
                            subregion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverKeyName"u8))
                        {
                            serverKeyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverKeyType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverKeyType = new SynapseServerKeyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            thumbprint = BinaryData.FromString(property0.Value.GetRawText());
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
            return new SynapseEncryptionProtectorData(
                id,
                name,
                type,
                systemData,
                kind,
                location,
                subregion,
                serverKeyName,
                serverKeyType,
                uri,
                thumbprint,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseEncryptionProtectorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEncryptionProtectorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseEncryptionProtectorData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseEncryptionProtectorData IPersistableModel<SynapseEncryptionProtectorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEncryptionProtectorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseEncryptionProtectorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseEncryptionProtectorData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseEncryptionProtectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
