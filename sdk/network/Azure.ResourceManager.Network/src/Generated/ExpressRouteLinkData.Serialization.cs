// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteLinkData : IUtf8JsonSerializable, IJsonModel<ExpressRouteLinkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteLinkData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteLinkData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RouterName))
            {
                writer.WritePropertyName("routerName"u8);
                writer.WriteStringValue(RouterName);
            }
            if (options.Format != "W" && Optional.IsDefined(InterfaceName))
            {
                writer.WritePropertyName("interfaceName"u8);
                writer.WriteStringValue(InterfaceName);
            }
            if (options.Format != "W" && Optional.IsDefined(PatchPanelId))
            {
                writer.WritePropertyName("patchPanelId"u8);
                writer.WriteStringValue(PatchPanelId);
            }
            if (options.Format != "W" && Optional.IsDefined(RackId))
            {
                writer.WritePropertyName("rackId"u8);
                writer.WriteStringValue(RackId);
            }
            if (options.Format != "W" && Optional.IsDefined(ColoLocation))
            {
                writer.WritePropertyName("coloLocation"u8);
                writer.WriteStringValue(ColoLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectorType))
            {
                writer.WritePropertyName("connectorType"u8);
                writer.WriteStringValue(ConnectorType.Value.ToString());
            }
            if (Optional.IsDefined(AdminState))
            {
                writer.WritePropertyName("adminState"u8);
                writer.WriteStringValue(AdminState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(MacSecConfig))
            {
                writer.WritePropertyName("macSecConfig"u8);
                writer.WriteObjectValue(MacSecConfig, options);
            }
            writer.WriteEndObject();
        }

        ExpressRouteLinkData IJsonModel<ExpressRouteLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteLinkData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteLinkData(document.RootElement, options);
        }

        internal static ExpressRouteLinkData DeserializeExpressRouteLinkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            string routerName = default;
            string interfaceName = default;
            string patchPanelId = default;
            string rackId = default;
            string coloLocation = default;
            ExpressRouteLinkConnectorType? connectorType = default;
            ExpressRouteLinkAdminState? adminState = default;
            NetworkProvisioningState? provisioningState = default;
            ExpressRouteLinkMacSecConfig macSecConfig = default;
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("routerName"u8))
                        {
                            routerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interfaceName"u8))
                        {
                            interfaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("patchPanelId"u8))
                        {
                            patchPanelId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rackId"u8))
                        {
                            rackId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coloLocation"u8))
                        {
                            coloLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectorType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectorType = new ExpressRouteLinkConnectorType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("adminState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminState = new ExpressRouteLinkAdminState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("macSecConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            macSecConfig = ExpressRouteLinkMacSecConfig.DeserializeExpressRouteLinkMacSecConfig(property0.Value, options);
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
            return new ExpressRouteLinkData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                routerName,
                interfaceName,
                patchPanelId,
                rackId,
                coloLocation,
                connectorType,
                adminState,
                provisioningState,
                macSecConfig);
        }

        BinaryData IPersistableModel<ExpressRouteLinkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteLinkData)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteLinkData IPersistableModel<ExpressRouteLinkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExpressRouteLinkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteLinkData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
