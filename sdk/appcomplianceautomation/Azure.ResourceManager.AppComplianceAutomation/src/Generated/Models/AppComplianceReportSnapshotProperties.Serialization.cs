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

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class AppComplianceReportSnapshotProperties : IUtf8JsonSerializable, IJsonModel<AppComplianceReportSnapshotProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppComplianceReportSnapshotProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppComplianceReportSnapshotProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppComplianceReportSnapshotProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(SnapshotName))
            {
                writer.WritePropertyName("snapshotName"u8);
                writer.WriteStringValue(SnapshotName);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReportProperties))
            {
                writer.WritePropertyName("reportProperties"u8);
                writer.WriteObjectValue(ReportProperties, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ReportSystemData))
            {
                writer.WritePropertyName("reportSystemData"u8);
                JsonSerializer.Serialize(writer, ReportSystemData);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ComplianceResults))
            {
                writer.WritePropertyName("complianceResults"u8);
                writer.WriteStartArray();
                foreach (var item in ComplianceResults)
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

        AppComplianceReportSnapshotProperties IJsonModel<AppComplianceReportSnapshotProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppComplianceReportSnapshotProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppComplianceReportSnapshotProperties(document.RootElement, options);
        }

        internal static AppComplianceReportSnapshotProperties DeserializeAppComplianceReportSnapshotProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string snapshotName = default;
            DateTimeOffset? createdAt = default;
            AppComplianceProvisioningState? provisioningState = default;
            AppComplianceReportProperties reportProperties = default;
            SystemData reportSystemData = default;
            IReadOnlyList<AppComplianceResult> complianceResults = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotName"u8))
                {
                    snapshotName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppComplianceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportProperties = AppComplianceReportProperties.DeserializeAppComplianceReportProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reportSystemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportSystemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("complianceResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppComplianceResult> array = new List<AppComplianceResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppComplianceResult.DeserializeAppComplianceResult(item, options));
                    }
                    complianceResults = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppComplianceReportSnapshotProperties(
                snapshotName,
                createdAt,
                provisioningState,
                reportProperties,
                reportSystemData,
                complianceResults ?? new ChangeTrackingList<AppComplianceResult>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppComplianceReportSnapshotProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppComplianceReportSnapshotProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppComplianceReportSnapshotProperties IPersistableModel<AppComplianceReportSnapshotProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportSnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppComplianceReportSnapshotProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppComplianceReportSnapshotProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppComplianceReportSnapshotProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
