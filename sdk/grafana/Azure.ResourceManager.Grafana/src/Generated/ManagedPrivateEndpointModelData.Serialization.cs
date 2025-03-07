// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Grafana.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Grafana
{
    public partial class ManagedPrivateEndpointModelData : IUtf8JsonSerializable, IJsonModel<ManagedPrivateEndpointModelData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedPrivateEndpointModelData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedPrivateEndpointModelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointModelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedPrivateEndpointModelData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                writer.WritePropertyName("privateLinkResourceId"u8);
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (Optional.IsDefined(PrivateLinkResourceRegion))
            {
                writer.WritePropertyName("privateLinkResourceRegion"u8);
                writer.WriteStringValue(PrivateLinkResourceRegion);
            }
            if (Optional.IsCollectionDefined(GroupIds))
            {
                writer.WritePropertyName("groupIds"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage"u8);
                writer.WriteStringValue(RequestMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteObjectValue(ConnectionState, options);
            }
            if (Optional.IsDefined(PrivateLinkServiceUri))
            {
                writer.WritePropertyName("privateLinkServiceUrl"u8);
                writer.WriteStringValue(PrivateLinkServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateLinkServicePrivateIP))
            {
                writer.WritePropertyName("privateLinkServicePrivateIP"u8);
                writer.WriteStringValue(PrivateLinkServicePrivateIP);
            }
            writer.WriteEndObject();
        }

        ManagedPrivateEndpointModelData IJsonModel<ManagedPrivateEndpointModelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointModelData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedPrivateEndpointModelData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedPrivateEndpointModelData(document.RootElement, options);
        }

        internal static ManagedPrivateEndpointModelData DeserializeManagedPrivateEndpointModelData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            GrafanaProvisioningState? provisioningState = default;
            ResourceIdentifier privateLinkResourceId = default;
            string privateLinkResourceRegion = default;
            IList<string> groupIds = default;
            string requestMessage = default;
            ManagedPrivateEndpointConnectionState connectionState = default;
            Uri privateLinkServiceUrl = default;
            string privateLinkServicePrivateIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new GrafanaProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkResourceRegion"u8))
                        {
                            privateLinkResourceRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("groupIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            groupIds = array;
                            continue;
                        }
                        if (property0.NameEquals("requestMessage"u8))
                        {
                            requestMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionState = ManagedPrivateEndpointConnectionState.DeserializeManagedPrivateEndpointConnectionState(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServicePrivateIP"u8))
                        {
                            privateLinkServicePrivateIP = property0.Value.GetString();
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
            return new ManagedPrivateEndpointModelData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                provisioningState,
                privateLinkResourceId,
                privateLinkResourceRegion,
                groupIds ?? new ChangeTrackingList<string>(),
                requestMessage,
                connectionState,
                privateLinkServiceUrl,
                privateLinkServicePrivateIP,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedPrivateEndpointModelData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointModelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedPrivateEndpointModelData)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedPrivateEndpointModelData IPersistableModel<ManagedPrivateEndpointModelData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedPrivateEndpointModelData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedPrivateEndpointModelData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedPrivateEndpointModelData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedPrivateEndpointModelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
