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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountKeyVaultProperties : IUtf8JsonSerializable, IJsonModel<StorageAccountKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountKeyVaultProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageAccountKeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyname"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyversion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyvaulturi"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentVersionedKeyIdentifier))
            {
                writer.WritePropertyName("currentVersionedKeyIdentifier"u8);
                writer.WriteStringValue(CurrentVersionedKeyIdentifier);
            }
            if (options.Format != "W" && Optional.IsDefined(LastKeyRotationTimestamp))
            {
                writer.WritePropertyName("lastKeyRotationTimestamp"u8);
                writer.WriteStringValue(LastKeyRotationTimestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentVersionedKeyExpirationTimestamp))
            {
                writer.WritePropertyName("currentVersionedKeyExpirationTimestamp"u8);
                writer.WriteStringValue(CurrentVersionedKeyExpirationTimestamp.Value, "O");
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

        StorageAccountKeyVaultProperties IJsonModel<StorageAccountKeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountKeyVaultProperties(document.RootElement, options);
        }

        internal static StorageAccountKeyVaultProperties DeserializeStorageAccountKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyname = default;
            string keyversion = default;
            Uri keyvaulturi = default;
            string currentVersionedKeyIdentifier = default;
            DateTimeOffset? lastKeyRotationTimestamp = default;
            DateTimeOffset? currentVersionedKeyExpirationTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyname"u8))
                {
                    keyname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyversion"u8))
                {
                    keyversion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyvaulturi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyvaulturi = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentVersionedKeyIdentifier"u8))
                {
                    currentVersionedKeyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastKeyRotationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastKeyRotationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentVersionedKeyExpirationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentVersionedKeyExpirationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageAccountKeyVaultProperties(
                keyname,
                keyversion,
                keyvaulturi,
                currentVersionedKeyIdentifier,
                lastKeyRotationTimestamp,
                currentVersionedKeyExpirationTimestamp,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keyname: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyName))
                {
                    builder.Append("  keyname: ");
                    if (KeyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KeyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KeyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keyversion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyVersion))
                {
                    builder.Append("  keyversion: ");
                    if (KeyVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KeyVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KeyVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyVaultUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keyvaulturi: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyVaultUri))
                {
                    builder.Append("  keyvaulturi: ");
                    builder.AppendLine($"'{KeyVaultUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentVersionedKeyIdentifier), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  currentVersionedKeyIdentifier: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CurrentVersionedKeyIdentifier))
                {
                    builder.Append("  currentVersionedKeyIdentifier: ");
                    if (CurrentVersionedKeyIdentifier.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CurrentVersionedKeyIdentifier}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CurrentVersionedKeyIdentifier}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastKeyRotationTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastKeyRotationTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastKeyRotationTimestamp))
                {
                    builder.Append("  lastKeyRotationTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastKeyRotationTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentVersionedKeyExpirationTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  currentVersionedKeyExpirationTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CurrentVersionedKeyExpirationTimestamp))
                {
                    builder.Append("  currentVersionedKeyExpirationTimestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CurrentVersionedKeyExpirationTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageAccountKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StorageAccountKeyVaultProperties IPersistableModel<StorageAccountKeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageAccountKeyVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountKeyVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
