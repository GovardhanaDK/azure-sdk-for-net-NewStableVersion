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
    public partial class DevTestLabCustomImageData : IUtf8JsonSerializable, IJsonModel<DevTestLabCustomImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabCustomImageData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabCustomImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Vm))
            {
                writer.WritePropertyName("vm"u8);
                writer.WriteObjectValue(Vm, options);
            }
            if (Optional.IsDefined(Vhd))
            {
                writer.WritePropertyName("vhd"u8);
                writer.WriteObjectValue(Vhd, options);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ManagedImageId))
            {
                writer.WritePropertyName("managedImageId"u8);
                writer.WriteStringValue(ManagedImageId);
            }
            if (Optional.IsDefined(ManagedSnapshotId))
            {
                writer.WritePropertyName("managedSnapshotId"u8);
                writer.WriteStringValue(ManagedSnapshotId);
            }
            if (Optional.IsCollectionDefined(DataDiskStorageInfo))
            {
                writer.WritePropertyName("dataDiskStorageInfo"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskStorageInfo)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CustomImagePlan))
            {
                writer.WritePropertyName("customImagePlan"u8);
                writer.WriteObjectValue(CustomImagePlan, options);
            }
            if (Optional.IsDefined(IsPlanAuthorized))
            {
                writer.WritePropertyName("isPlanAuthorized"u8);
                writer.WriteBooleanValue(IsPlanAuthorized.Value);
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

        DevTestLabCustomImageData IJsonModel<DevTestLabCustomImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCustomImageData(document.RootElement, options);
        }

        internal static DevTestLabCustomImageData DeserializeDevTestLabCustomImageData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DevTestLabCustomImageVm vm = default;
            DevTestLabCustomImageVhd vhd = default;
            string description = default;
            string author = default;
            DateTimeOffset? creationDate = default;
            string managedImageId = default;
            string managedSnapshotId = default;
            IList<DevTestLabDataDiskStorageTypeInfo> dataDiskStorageInfo = default;
            DevTestLabCustomImagePlan customImagePlan = default;
            bool? isPlanAuthorized = default;
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
                        if (property0.NameEquals("vm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vm = DevTestLabCustomImageVm.DeserializeDevTestLabCustomImageVm(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vhd"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vhd = DevTestLabCustomImageVhd.DeserializeDevTestLabCustomImageVhd(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author"u8))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("managedImageId"u8))
                        {
                            managedImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedSnapshotId"u8))
                        {
                            managedSnapshotId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskStorageInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabDataDiskStorageTypeInfo> array = new List<DevTestLabDataDiskStorageTypeInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabDataDiskStorageTypeInfo.DeserializeDevTestLabDataDiskStorageTypeInfo(item, options));
                            }
                            dataDiskStorageInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("customImagePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customImagePlan = DevTestLabCustomImagePlan.DeserializeDevTestLabCustomImagePlan(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isPlanAuthorized"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPlanAuthorized = property0.Value.GetBoolean();
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
            return new DevTestLabCustomImageData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                vm,
                vhd,
                description,
                author,
                creationDate,
                managedImageId,
                managedSnapshotId,
                dataDiskStorageInfo ?? new ChangeTrackingList<DevTestLabDataDiskStorageTypeInfo>(),
                customImagePlan,
                isPlanAuthorized,
                provisioningState,
                uniqueIdentifier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabCustomImageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabCustomImageData IPersistableModel<DevTestLabCustomImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabCustomImageData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabCustomImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
