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

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlStorageProfile : IUtf8JsonSerializable, IJsonModel<PostgreSqlStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlStorageProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PostgreSqlStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlStorageProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BackupRetentionDays))
            {
                writer.WritePropertyName("backupRetentionDays"u8);
                writer.WriteNumberValue(BackupRetentionDays.Value);
            }
            if (Optional.IsDefined(GeoRedundantBackup))
            {
                writer.WritePropertyName("geoRedundantBackup"u8);
                writer.WriteStringValue(GeoRedundantBackup.Value.ToString());
            }
            if (Optional.IsDefined(StorageInMB))
            {
                writer.WritePropertyName("storageMB"u8);
                writer.WriteNumberValue(StorageInMB.Value);
            }
            if (Optional.IsDefined(StorageAutogrow))
            {
                writer.WritePropertyName("storageAutogrow"u8);
                writer.WriteStringValue(StorageAutogrow.Value.ToString());
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

        PostgreSqlStorageProfile IJsonModel<PostgreSqlStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlStorageProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlStorageProfile(document.RootElement, options);
        }

        internal static PostgreSqlStorageProfile DeserializePostgreSqlStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? backupRetentionDays = default;
            PostgreSqlGeoRedundantBackup? geoRedundantBackup = default;
            int? storageMB = default;
            PostgreSqlStorageAutogrow? storageAutogrow = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("geoRedundantBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoRedundantBackup = new PostgreSqlGeoRedundantBackup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAutogrow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAutogrow = new PostgreSqlStorageAutogrow(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PostgreSqlStorageProfile(backupRetentionDays, geoRedundantBackup, storageMB, storageAutogrow, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupRetentionDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  backupRetentionDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BackupRetentionDays))
                {
                    builder.Append("  backupRetentionDays: ");
                    builder.AppendLine($"{BackupRetentionDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeoRedundantBackup), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  geoRedundantBackup: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GeoRedundantBackup))
                {
                    builder.Append("  geoRedundantBackup: ");
                    builder.AppendLine($"'{GeoRedundantBackup.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageInMB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storageMB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageInMB))
                {
                    builder.Append("  storageMB: ");
                    builder.AppendLine($"{StorageInMB.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAutogrow), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storageAutogrow: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAutogrow))
                {
                    builder.Append("  storageAutogrow: ");
                    builder.AppendLine($"'{StorageAutogrow.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PostgreSqlStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlStorageProfile)} does not support writing '{options.Format}' format.");
            }
        }

        PostgreSqlStorageProfile IPersistableModel<PostgreSqlStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePostgreSqlStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlStorageProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
