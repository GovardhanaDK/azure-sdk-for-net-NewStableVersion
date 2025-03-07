// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class SystemCreatedStorageAccount : IUtf8JsonSerializable, IJsonModel<SystemCreatedStorageAccount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SystemCreatedStorageAccount>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SystemCreatedStorageAccount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AllowBlobPublicAccess))
            {
                writer.WritePropertyName("allowBlobPublicAccess"u8);
                writer.WriteBooleanValue(AllowBlobPublicAccess.Value);
            }
            if (Optional.IsDefined(ArmResourceIdentifier))
            {
                if (ArmResourceIdentifier != null)
                {
                    writer.WritePropertyName("armResourceId"u8);
                    writer.WriteObjectValue(ArmResourceIdentifier, options);
                }
                else
                {
                    writer.WriteNull("armResourceId");
                }
            }
            if (Optional.IsDefined(StorageAccountHnsEnabled))
            {
                writer.WritePropertyName("storageAccountHnsEnabled"u8);
                writer.WriteBooleanValue(StorageAccountHnsEnabled.Value);
            }
            if (Optional.IsDefined(StorageAccountName))
            {
                if (StorageAccountName != null)
                {
                    writer.WritePropertyName("storageAccountName"u8);
                    writer.WriteStringValue(StorageAccountName);
                }
                else
                {
                    writer.WriteNull("storageAccountName");
                }
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                if (StorageAccountType != null)
                {
                    writer.WritePropertyName("storageAccountType"u8);
                    writer.WriteStringValue(StorageAccountType);
                }
                else
                {
                    writer.WriteNull("storageAccountType");
                }
            }
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

        SystemCreatedStorageAccount IJsonModel<SystemCreatedStorageAccount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSystemCreatedStorageAccount(document.RootElement, options);
        }

        internal static SystemCreatedStorageAccount DeserializeSystemCreatedStorageAccount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? allowBlobPublicAccess = default;
            ArmResourceId armResourceId = default;
            bool? storageAccountHnsEnabled = default;
            string storageAccountName = default;
            string storageAccountType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowBlobPublicAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowBlobPublicAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("armResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        armResourceId = null;
                        continue;
                    }
                    armResourceId = Models.ArmResourceId.DeserializeArmResourceId(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageAccountHnsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountHnsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountName = null;
                        continue;
                    }
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountType = null;
                        continue;
                    }
                    storageAccountType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SystemCreatedStorageAccount(
                allowBlobPublicAccess,
                armResourceId,
                storageAccountHnsEnabled,
                storageAccountName,
                storageAccountType,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowBlobPublicAccess), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowBlobPublicAccess: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllowBlobPublicAccess))
                {
                    builder.Append("  allowBlobPublicAccess: ");
                    var boolValue = AllowBlobPublicAccess.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ArmResourceId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  armResourceId: ");
                builder.AppendLine("{");
                builder.Append("    resourceId: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(ArmResourceIdentifier))
                {
                    builder.Append("  armResourceId: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ArmResourceIdentifier, options, 2, false, "  armResourceId: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountHnsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storageAccountHnsEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountHnsEnabled))
                {
                    builder.Append("  storageAccountHnsEnabled: ");
                    var boolValue = StorageAccountHnsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storageAccountName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountName))
                {
                    builder.Append("  storageAccountName: ");
                    if (StorageAccountName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StorageAccountName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StorageAccountName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storageAccountType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountType))
                {
                    builder.Append("  storageAccountType: ");
                    if (StorageAccountType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StorageAccountType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StorageAccountType}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SystemCreatedStorageAccount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support writing '{options.Format}' format.");
            }
        }

        SystemCreatedStorageAccount IPersistableModel<SystemCreatedStorageAccount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SystemCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSystemCreatedStorageAccount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SystemCreatedStorageAccount)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SystemCreatedStorageAccount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
