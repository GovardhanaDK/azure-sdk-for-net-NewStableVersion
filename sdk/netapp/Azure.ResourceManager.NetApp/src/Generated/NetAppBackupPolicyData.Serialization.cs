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
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppBackupPolicyData : IUtf8JsonSerializable, IJsonModel<NetAppBackupPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppBackupPolicyData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppBackupPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppBackupPolicyData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(BackupPolicyId))
            {
                writer.WritePropertyName("backupPolicyId"u8);
                writer.WriteStringValue(BackupPolicyId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(DailyBackupsToKeep))
            {
                writer.WritePropertyName("dailyBackupsToKeep"u8);
                writer.WriteNumberValue(DailyBackupsToKeep.Value);
            }
            if (Optional.IsDefined(WeeklyBackupsToKeep))
            {
                writer.WritePropertyName("weeklyBackupsToKeep"u8);
                writer.WriteNumberValue(WeeklyBackupsToKeep.Value);
            }
            if (Optional.IsDefined(MonthlyBackupsToKeep))
            {
                writer.WritePropertyName("monthlyBackupsToKeep"u8);
                writer.WriteNumberValue(MonthlyBackupsToKeep.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(VolumesAssigned))
            {
                writer.WritePropertyName("volumesAssigned"u8);
                writer.WriteNumberValue(VolumesAssigned.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VolumeBackups))
            {
                writer.WritePropertyName("volumeBackups"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeBackups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        NetAppBackupPolicyData IJsonModel<NetAppBackupPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppBackupPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppBackupPolicyData(document.RootElement, options);
        }

        internal static NetAppBackupPolicyData DeserializeNetAppBackupPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier backupPolicyId = default;
            string provisioningState = default;
            int? dailyBackupsToKeep = default;
            int? weeklyBackupsToKeep = default;
            int? monthlyBackupsToKeep = default;
            int? volumesAssigned = default;
            bool? enabled = default;
            IReadOnlyList<NetAppVolumeBackupDetail> volumeBackups = default;
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
                        if (property0.NameEquals("backupPolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupPolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dailyBackupsToKeep"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailyBackupsToKeep = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weeklyBackupsToKeep"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weeklyBackupsToKeep = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("monthlyBackupsToKeep"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monthlyBackupsToKeep = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("volumesAssigned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            volumesAssigned = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("volumeBackups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetAppVolumeBackupDetail> array = new List<NetAppVolumeBackupDetail>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetAppVolumeBackupDetail.DeserializeNetAppVolumeBackupDetail(item, options));
                            }
                            volumeBackups = array;
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
            return new NetAppBackupPolicyData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                etag,
                backupPolicyId,
                provisioningState,
                dailyBackupsToKeep,
                weeklyBackupsToKeep,
                monthlyBackupsToKeep,
                volumesAssigned,
                enabled,
                volumeBackups ?? new ChangeTrackingList<NetAppVolumeBackupDetail>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppBackupPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppBackupPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppBackupPolicyData IPersistableModel<NetAppBackupPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppBackupPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetAppBackupPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppBackupPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppBackupPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
