// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlMigrationSubStateDetails : IUtf8JsonSerializable, IJsonModel<PostgreSqlMigrationSubStateDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlMigrationSubStateDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PostgreSqlMigrationSubStateDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSubStateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationSubStateDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(CurrentSubState))
            {
                writer.WritePropertyName("currentSubState"u8);
                writer.WriteStringValue(CurrentSubState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DbDetails))
            {
                writer.WritePropertyName("dbDetails"u8);
                writer.WriteStartObject();
                foreach (var item in DbDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ValidationDetails))
            {
                writer.WritePropertyName("validationDetails"u8);
                writer.WriteObjectValue(ValidationDetails, options);
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

        PostgreSqlMigrationSubStateDetails IJsonModel<PostgreSqlMigrationSubStateDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSubStateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationSubStateDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationSubStateDetails(document.RootElement, options);
        }

        internal static PostgreSqlMigrationSubStateDetails DeserializePostgreSqlMigrationSubStateDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlMigrationSubState? currentSubState = default;
            IReadOnlyDictionary<string, DbMigrationStatus> dbDetails = default;
            PostgreSqlFlexibleServersValidationDetails validationDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentSubState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentSubState = new PostgreSqlMigrationSubState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dbDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DbMigrationStatus> dictionary = new Dictionary<string, DbMigrationStatus>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DbMigrationStatus.DeserializeDbMigrationStatus(property0.Value, options));
                    }
                    dbDetails = dictionary;
                    continue;
                }
                if (property.NameEquals("validationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationDetails = PostgreSqlFlexibleServersValidationDetails.DeserializePostgreSqlFlexibleServersValidationDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PostgreSqlMigrationSubStateDetails(currentSubState, dbDetails ?? new ChangeTrackingDictionary<string, DbMigrationStatus>(), validationDetails, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentSubState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  currentSubState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CurrentSubState))
                {
                    builder.Append("  currentSubState: ");
                    builder.AppendLine($"'{CurrentSubState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DbDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dbDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DbDetails))
                {
                    if (DbDetails.Any())
                    {
                        builder.Append("  dbDetails: ");
                        builder.AppendLine("{");
                        foreach (var item in DbDetails)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  dbDetails: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidationDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validationDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValidationDetails))
                {
                    builder.Append("  validationDetails: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ValidationDetails, options, 2, false, "  validationDetails: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PostgreSqlMigrationSubStateDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSubStateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationSubStateDetails)} does not support writing '{options.Format}' format.");
            }
        }

        PostgreSqlMigrationSubStateDetails IPersistableModel<PostgreSqlMigrationSubStateDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSubStateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePostgreSqlMigrationSubStateDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationSubStateDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlMigrationSubStateDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
