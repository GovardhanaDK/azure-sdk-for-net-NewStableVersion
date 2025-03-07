// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupServerContainer : IUtf8JsonSerializable, IJsonModel<BackupServerContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupServerContainer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupServerContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupServerContainer)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        BackupServerContainer IJsonModel<BackupServerContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupServerContainer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupServerContainer(document.RootElement, options);
        }

        internal static BackupServerContainer DeserializeBackupServerContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? canReRegister = default;
            string containerId = default;
            long? protectedItemCount = default;
            string dpmAgentVersion = default;
            IList<string> dpmServers = default;
            bool? upgradeAvailable = default;
            string protectionStatus = default;
            DpmContainerExtendedInfo extendedInfo = default;
            string friendlyName = default;
            BackupManagementType? backupManagementType = default;
            string registrationStatus = default;
            string healthStatus = default;
            ProtectableContainerType containerType = default;
            string protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canReRegister"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    containerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dpmAgentVersion"u8))
                {
                    dpmAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dpmServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dpmServers = array;
                    continue;
                }
                if (property.NameEquals("upgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = DpmContainerExtendedInfo.DeserializeDpmContainerExtendedInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupServerContainer(
                friendlyName,
                backupManagementType,
                registrationStatus,
                healthStatus,
                containerType,
                protectableObjectType,
                serializedAdditionalRawData,
                canReRegister,
                containerId,
                protectedItemCount,
                dpmAgentVersion,
                dpmServers ?? new ChangeTrackingList<string>(),
                upgradeAvailable,
                protectionStatus,
                extendedInfo);
        }

        BinaryData IPersistableModel<BackupServerContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupServerContainer)} does not support writing '{options.Format}' format.");
            }
        }

        BackupServerContainer IPersistableModel<BackupServerContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBackupServerContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupServerContainer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupServerContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
