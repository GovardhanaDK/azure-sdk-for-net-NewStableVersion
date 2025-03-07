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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountPatch : IUtf8JsonSerializable, IJsonModel<CosmosDBAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBAccountPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBAccountPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountPatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConsistencyPolicy))
            {
                writer.WritePropertyName("consistencyPolicy"u8);
                writer.WriteObjectValue(ConsistencyPolicy, options);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsVirtualNetworkFilterEnabled))
            {
                writer.WritePropertyName("isVirtualNetworkFilterEnabled"u8);
                writer.WriteBooleanValue(IsVirtualNetworkFilterEnabled.Value);
            }
            if (Optional.IsDefined(EnableAutomaticFailover))
            {
                writer.WritePropertyName("enableAutomaticFailover"u8);
                writer.WriteBooleanValue(EnableAutomaticFailover.Value);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableMultipleWriteLocations))
            {
                writer.WritePropertyName("enableMultipleWriteLocations"u8);
                writer.WriteBooleanValue(EnableMultipleWriteLocations.Value);
            }
            if (Optional.IsDefined(EnableCassandraConnector))
            {
                writer.WritePropertyName("enableCassandraConnector"u8);
                writer.WriteBooleanValue(EnableCassandraConnector.Value);
            }
            if (Optional.IsDefined(ConnectorOffer))
            {
                writer.WritePropertyName("connectorOffer"u8);
                writer.WriteStringValue(ConnectorOffer.Value.ToString());
            }
            if (Optional.IsDefined(DisableKeyBasedMetadataWriteAccess))
            {
                writer.WritePropertyName("disableKeyBasedMetadataWriteAccess"u8);
                writer.WriteBooleanValue(DisableKeyBasedMetadataWriteAccess.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri"u8);
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DefaultIdentity))
            {
                writer.WritePropertyName("defaultIdentity"u8);
                writer.WriteStringValue(DefaultIdentity);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(IsFreeTierEnabled))
            {
                writer.WritePropertyName("enableFreeTier"u8);
                writer.WriteBooleanValue(IsFreeTierEnabled.Value);
            }
            if (Optional.IsDefined(ApiProperties))
            {
                writer.WritePropertyName("apiProperties"u8);
                writer.WriteObjectValue(ApiProperties, options);
            }
            if (Optional.IsDefined(IsAnalyticalStorageEnabled))
            {
                writer.WritePropertyName("enableAnalyticalStorage"u8);
                writer.WriteBooleanValue(IsAnalyticalStorageEnabled.Value);
            }
            if (Optional.IsDefined(AnalyticalStorageConfiguration))
            {
                writer.WritePropertyName("analyticalStorageConfiguration"u8);
                writer.WriteObjectValue(AnalyticalStorageConfiguration, options);
            }
            if (Optional.IsDefined(BackupPolicy))
            {
                writer.WritePropertyName("backupPolicy"u8);
                writer.WriteObjectValue(BackupPolicy, options);
            }
            if (Optional.IsCollectionDefined(Cors))
            {
                writer.WritePropertyName("cors"u8);
                writer.WriteStartArray();
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkAclBypass))
            {
                writer.WritePropertyName("networkAclBypass"u8);
                writer.WriteStringValue(NetworkAclBypass.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(NetworkAclBypassResourceIds))
            {
                writer.WritePropertyName("networkAclBypassResourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkAclBypassResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiagnosticLogSettings))
            {
                writer.WritePropertyName("diagnosticLogSettings"u8);
                writer.WriteObjectValue(DiagnosticLogSettings, options);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity, options);
            }
            if (Optional.IsDefined(CapacityMode))
            {
                writer.WritePropertyName("capacityMode"u8);
                writer.WriteStringValue(CapacityMode.Value.ToString());
            }
            if (Optional.IsDefined(EnableMaterializedViews))
            {
                writer.WritePropertyName("enableMaterializedViews"u8);
                writer.WriteBooleanValue(EnableMaterializedViews.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(KeysMetadata))
            {
                writer.WritePropertyName("keysMetadata"u8);
                writer.WriteObjectValue(KeysMetadata, options);
            }
            if (Optional.IsDefined(EnablePartitionMerge))
            {
                writer.WritePropertyName("enablePartitionMerge"u8);
                writer.WriteBooleanValue(EnablePartitionMerge.Value);
            }
            if (Optional.IsDefined(EnableBurstCapacity))
            {
                writer.WritePropertyName("enableBurstCapacity"u8);
                writer.WriteBooleanValue(EnableBurstCapacity.Value);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(CustomerManagedKeyStatus))
            {
                writer.WritePropertyName("customerManagedKeyStatus"u8);
                writer.WriteStringValue(CustomerManagedKeyStatus);
            }
            if (Optional.IsDefined(EnablePriorityBasedExecution))
            {
                writer.WritePropertyName("enablePriorityBasedExecution"u8);
                writer.WriteBooleanValue(EnablePriorityBasedExecution.Value);
            }
            if (Optional.IsDefined(DefaultPriorityLevel))
            {
                writer.WritePropertyName("defaultPriorityLevel"u8);
                writer.WriteStringValue(DefaultPriorityLevel.Value.ToString());
            }
            if (Optional.IsDefined(EnablePerRegionPerPartitionAutoscale))
            {
                writer.WritePropertyName("enablePerRegionPerPartitionAutoscale"u8);
                writer.WriteBooleanValue(EnablePerRegionPerPartitionAutoscale.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        CosmosDBAccountPatch IJsonModel<CosmosDBAccountPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountPatch(document.RootElement, options);
        }

        internal static CosmosDBAccountPatch DeserializeCosmosDBAccountPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation? location = default;
            ManagedServiceIdentity identity = default;
            ConsistencyPolicy consistencyPolicy = default;
            IList<CosmosDBAccountLocation> locations = default;
            IList<CosmosDBIPAddressOrRange> ipRules = default;
            bool? isVirtualNetworkFilterEnabled = default;
            bool? enableAutomaticFailover = default;
            IList<CosmosDBAccountCapability> capabilities = default;
            IList<CosmosDBVirtualNetworkRule> virtualNetworkRules = default;
            bool? enableMultipleWriteLocations = default;
            bool? enableCassandraConnector = default;
            ConnectorOffer? connectorOffer = default;
            bool? disableKeyBasedMetadataWriteAccess = default;
            Uri keyVaultKeyUri = default;
            string defaultIdentity = default;
            CosmosDBPublicNetworkAccess? publicNetworkAccess = default;
            bool? enableFreeTier = default;
            ApiProperties apiProperties = default;
            bool? enableAnalyticalStorage = default;
            AnalyticalStorageConfiguration analyticalStorageConfiguration = default;
            CosmosDBAccountBackupPolicy backupPolicy = default;
            IList<CosmosDBAccountCorsPolicy> cors = default;
            NetworkAclBypass? networkAclBypass = default;
            IList<ResourceIdentifier> networkAclBypassResourceIds = default;
            DiagnosticLogSettings diagnosticLogSettings = default;
            bool? disableLocalAuth = default;
            CosmosDBAccountCapacity capacity = default;
            CapacityMode? capacityMode = default;
            bool? enableMaterializedViews = default;
            DatabaseAccountKeysMetadata keysMetadata = default;
            bool? enablePartitionMerge = default;
            bool? enableBurstCapacity = default;
            CosmosDBMinimalTlsVersion? minimalTlsVersion = default;
            string customerManagedKeyStatus = default;
            bool? enablePriorityBasedExecution = default;
            DefaultPriorityLevel? defaultPriorityLevel = default;
            bool? enablePerRegionPerPartitionAutoscale = default;
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
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
                        if (property0.NameEquals("consistencyPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            consistencyPolicy = ConsistencyPolicy.DeserializeConsistencyPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("locations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountLocation> array = new List<CosmosDBAccountLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountLocation.DeserializeCosmosDBAccountLocation(item, options));
                            }
                            locations = array;
                            continue;
                        }
                        if (property0.NameEquals("ipRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBIPAddressOrRange> array = new List<CosmosDBIPAddressOrRange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBIPAddressOrRange.DeserializeCosmosDBIPAddressOrRange(item, options));
                            }
                            ipRules = array;
                            continue;
                        }
                        if (property0.NameEquals("isVirtualNetworkFilterEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isVirtualNetworkFilterEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAutomaticFailover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAutomaticFailover = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountCapability> array = new List<CosmosDBAccountCapability>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountCapability.DeserializeCosmosDBAccountCapability(item, options));
                            }
                            capabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBVirtualNetworkRule> array = new List<CosmosDBVirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBVirtualNetworkRule.DeserializeCosmosDBVirtualNetworkRule(item, options));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("enableMultipleWriteLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableMultipleWriteLocations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableCassandraConnector"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableCassandraConnector = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("connectorOffer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectorOffer = new ConnectorOffer(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disableKeyBasedMetadataWriteAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableKeyBasedMetadataWriteAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultKeyUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultKeyUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultIdentity"u8))
                        {
                            defaultIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new CosmosDBPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableFreeTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableFreeTier = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiProperties = ApiProperties.DeserializeApiProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableAnalyticalStorage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAnalyticalStorage = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("analyticalStorageConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            analyticalStorageConfiguration = AnalyticalStorageConfiguration.DeserializeAnalyticalStorageConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("backupPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupPolicy = CosmosDBAccountBackupPolicy.DeserializeCosmosDBAccountBackupPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("cors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountCorsPolicy> array = new List<CosmosDBAccountCorsPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountCorsPolicy.DeserializeCosmosDBAccountCorsPolicy(item, options));
                            }
                            cors = array;
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypass"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAclBypass = property0.Value.GetString().ToNetworkAclBypass();
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypassResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            networkAclBypassResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("diagnosticLogSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticLogSettings = DiagnosticLogSettings.DeserializeDiagnosticLogSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacity = CosmosDBAccountCapacity.DeserializeCosmosDBAccountCapacity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("capacityMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacityMode = new CapacityMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableMaterializedViews"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableMaterializedViews = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keysMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keysMetadata = DatabaseAccountKeysMetadata.DeserializeDatabaseAccountKeysMetadata(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enablePartitionMerge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePartitionMerge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableBurstCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBurstCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minimalTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimalTlsVersion = new CosmosDBMinimalTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerManagedKeyStatus"u8))
                        {
                            customerManagedKeyStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enablePriorityBasedExecution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePriorityBasedExecution = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultPriorityLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultPriorityLevel = new DefaultPriorityLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enablePerRegionPerPartitionAutoscale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePerRegionPerPartitionAutoscale = property0.Value.GetBoolean();
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
            return new CosmosDBAccountPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                consistencyPolicy,
                locations ?? new ChangeTrackingList<CosmosDBAccountLocation>(),
                ipRules ?? new ChangeTrackingList<CosmosDBIPAddressOrRange>(),
                isVirtualNetworkFilterEnabled,
                enableAutomaticFailover,
                capabilities ?? new ChangeTrackingList<CosmosDBAccountCapability>(),
                virtualNetworkRules ?? new ChangeTrackingList<CosmosDBVirtualNetworkRule>(),
                enableMultipleWriteLocations,
                enableCassandraConnector,
                connectorOffer,
                disableKeyBasedMetadataWriteAccess,
                keyVaultKeyUri,
                defaultIdentity,
                publicNetworkAccess,
                enableFreeTier,
                apiProperties,
                enableAnalyticalStorage,
                analyticalStorageConfiguration,
                backupPolicy,
                cors ?? new ChangeTrackingList<CosmosDBAccountCorsPolicy>(),
                networkAclBypass,
                networkAclBypassResourceIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                diagnosticLogSettings,
                disableLocalAuth,
                capacity,
                capacityMode,
                enableMaterializedViews,
                keysMetadata,
                enablePartitionMerge,
                enableBurstCapacity,
                minimalTlsVersion,
                customerManagedKeyStatus,
                enablePriorityBasedExecution,
                defaultPriorityLevel,
                enablePerRegionPerPartitionAutoscale,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBAccountPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountPatch)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBAccountPatch IPersistableModel<CosmosDBAccountPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCosmosDBAccountPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBAccountPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
