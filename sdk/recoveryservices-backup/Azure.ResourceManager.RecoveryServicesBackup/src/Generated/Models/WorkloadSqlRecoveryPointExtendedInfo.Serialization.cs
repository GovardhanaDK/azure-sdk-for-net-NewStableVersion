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
    public partial class WorkloadSqlRecoveryPointExtendedInfo : IUtf8JsonSerializable, IJsonModel<WorkloadSqlRecoveryPointExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadSqlRecoveryPointExtendedInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkloadSqlRecoveryPointExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRecoveryPointExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlRecoveryPointExtendedInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DataDirectoryInfoCapturedOn))
            {
                writer.WritePropertyName("dataDirectoryTimeInUTC"u8);
                writer.WriteStringValue(DataDirectoryInfoCapturedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(DataDirectoryPaths))
            {
                writer.WritePropertyName("dataDirectoryPaths"u8);
                writer.WriteStartArray();
                foreach (var item in DataDirectoryPaths)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        WorkloadSqlRecoveryPointExtendedInfo IJsonModel<WorkloadSqlRecoveryPointExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRecoveryPointExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlRecoveryPointExtendedInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSqlRecoveryPointExtendedInfo(document.RootElement, options);
        }

        internal static WorkloadSqlRecoveryPointExtendedInfo DeserializeWorkloadSqlRecoveryPointExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? dataDirectoryTimeInUTC = default;
            IList<SqlDataDirectory> dataDirectoryPaths = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDirectoryTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataDirectoryTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dataDirectoryPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlDataDirectory> array = new List<SqlDataDirectory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDataDirectory.DeserializeSqlDataDirectory(item, options));
                    }
                    dataDirectoryPaths = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkloadSqlRecoveryPointExtendedInfo(dataDirectoryTimeInUTC, dataDirectoryPaths ?? new ChangeTrackingList<SqlDataDirectory>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkloadSqlRecoveryPointExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRecoveryPointExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlRecoveryPointExtendedInfo)} does not support writing '{options.Format}' format.");
            }
        }

        WorkloadSqlRecoveryPointExtendedInfo IPersistableModel<WorkloadSqlRecoveryPointExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRecoveryPointExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWorkloadSqlRecoveryPointExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlRecoveryPointExtendedInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadSqlRecoveryPointExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
