// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabData : IUtf8JsonSerializable, IJsonModel<DevTestLabData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DefaultStorageAccount))
            {
                writer.WritePropertyName("defaultStorageAccount"u8);
                writer.WriteStringValue(DefaultStorageAccount);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultPremiumStorageAccount))
            {
                writer.WritePropertyName("defaultPremiumStorageAccount"u8);
                writer.WriteStringValue(DefaultPremiumStorageAccount);
            }
            if (options.Format != "W" && Optional.IsDefined(ArtifactsStorageAccount))
            {
                writer.WritePropertyName("artifactsStorageAccount"u8);
                writer.WriteStringValue(ArtifactsStorageAccount);
            }
            if (options.Format != "W" && Optional.IsDefined(PremiumDataDiskStorageAccount))
            {
                writer.WritePropertyName("premiumDataDiskStorageAccount"u8);
                writer.WriteStringValue(PremiumDataDiskStorageAccount);
            }
            if (options.Format != "W" && Optional.IsDefined(VaultName))
            {
                writer.WritePropertyName("vaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (Optional.IsDefined(LabStorageType))
            {
                writer.WritePropertyName("labStorageType"u8);
                writer.WriteStringValue(LabStorageType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MandatoryArtifactsResourceIdsLinux))
            {
                writer.WritePropertyName("mandatoryArtifactsResourceIdsLinux"u8);
                writer.WriteStartArray();
                foreach (var item in MandatoryArtifactsResourceIdsLinux)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MandatoryArtifactsResourceIdsWindows))
            {
                writer.WritePropertyName("mandatoryArtifactsResourceIdsWindows"u8);
                writer.WriteStartArray();
                foreach (var item in MandatoryArtifactsResourceIdsWindows)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(PremiumDataDisks))
            {
                writer.WritePropertyName("premiumDataDisks"u8);
                writer.WriteStringValue(PremiumDataDisks.Value.ToString());
            }
            if (Optional.IsDefined(EnvironmentPermission))
            {
                writer.WritePropertyName("environmentPermission"u8);
                writer.WriteStringValue(EnvironmentPermission.Value.ToString());
            }
            if (Optional.IsDefined(Announcement))
            {
                writer.WritePropertyName("announcement"u8);
                writer.WriteObjectValue(Announcement, options);
            }
            if (Optional.IsDefined(Support))
            {
                writer.WritePropertyName("support"u8);
                writer.WriteObjectValue(Support, options);
            }
            if (options.Format != "W" && Optional.IsDefined(VmCreationResourceGroup))
            {
                writer.WritePropertyName("vmCreationResourceGroup"u8);
                writer.WriteStringValue(VmCreationResourceGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(PublicIPId))
            {
                writer.WritePropertyName("publicIpId"u8);
                writer.WriteStringValue(PublicIPId);
            }
            if (options.Format != "W" && Optional.IsDefined(LoadBalancerId))
            {
                writer.WritePropertyName("loadBalancerId"u8);
                writer.WriteStringValue(LoadBalancerId);
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkSecurityGroupId))
            {
                writer.WritePropertyName("networkSecurityGroupId"u8);
                writer.WriteStringValue(NetworkSecurityGroupId);
            }
            if (Optional.IsCollectionDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtendedProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueIdentifier))
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
            }
            writer.WriteEndObject();
        }

        DevTestLabData IJsonModel<DevTestLabData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabData(document.RootElement, options);
        }

        internal static DevTestLabData DeserializeDevTestLabData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string defaultStorageAccount = default;
            string defaultPremiumStorageAccount = default;
            string artifactsStorageAccount = default;
            string premiumDataDiskStorageAccount = default;
            string vaultName = default;
            DevTestLabStorageType? labStorageType = default;
            IList<string> mandatoryArtifactsResourceIdsLinux = default;
            IList<string> mandatoryArtifactsResourceIdsWindows = default;
            DateTimeOffset? createdDate = default;
            DevTestLabPremiumDataDisk? premiumDataDisks = default;
            DevTestLabEnvironmentPermission? environmentPermission = default;
            DevTestLabAnnouncement announcement = default;
            DevTestLabSupport support = default;
            string vmCreationResourceGroup = default;
            string publicIPId = default;
            string loadBalancerId = default;
            string networkSecurityGroupId = default;
            IDictionary<string, string> extendedProperties = default;
            string provisioningState = default;
            Guid? uniqueIdentifier = default;
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
                        if (property0.NameEquals("defaultStorageAccount"u8))
                        {
                            defaultStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultPremiumStorageAccount"u8))
                        {
                            defaultPremiumStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("artifactsStorageAccount"u8))
                        {
                            artifactsStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("premiumDataDiskStorageAccount"u8))
                        {
                            premiumDataDiskStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vaultName"u8))
                        {
                            vaultName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labStorageType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labStorageType = new DevTestLabStorageType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mandatoryArtifactsResourceIdsLinux"u8))
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
                            mandatoryArtifactsResourceIdsLinux = array;
                            continue;
                        }
                        if (property0.NameEquals("mandatoryArtifactsResourceIdsWindows"u8))
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
                            mandatoryArtifactsResourceIdsWindows = array;
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("premiumDataDisks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            premiumDataDisks = new DevTestLabPremiumDataDisk(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("environmentPermission"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentPermission = new DevTestLabEnvironmentPermission(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("announcement"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            announcement = DevTestLabAnnouncement.DeserializeDevTestLabAnnouncement(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("support"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            support = DevTestLabSupport.DeserializeDevTestLabSupport(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmCreationResourceGroup"u8))
                        {
                            vmCreationResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicIpId"u8))
                        {
                            publicIPId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerId"u8))
                        {
                            loadBalancerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroupId"u8))
                        {
                            networkSecurityGroupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extendedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            extendedProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
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
            return new DevTestLabData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                defaultStorageAccount,
                defaultPremiumStorageAccount,
                artifactsStorageAccount,
                premiumDataDiskStorageAccount,
                vaultName,
                labStorageType,
                mandatoryArtifactsResourceIdsLinux ?? new ChangeTrackingList<string>(),
                mandatoryArtifactsResourceIdsWindows ?? new ChangeTrackingList<string>(),
                createdDate,
                premiumDataDisks,
                environmentPermission,
                announcement,
                support,
                vmCreationResourceGroup,
                publicIPId,
                loadBalancerId,
                networkSecurityGroupId,
                extendedProperties ?? new ChangeTrackingDictionary<string, string>(),
                provisioningState,
                uniqueIdentifier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabData)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabData IPersistableModel<DevTestLabData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
