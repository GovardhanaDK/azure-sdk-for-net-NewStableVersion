// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAzureMonitorExtensionStatus : IUtf8JsonSerializable, IJsonModel<HDInsightAzureMonitorExtensionStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAzureMonitorExtensionStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightAzureMonitorExtensionStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionStatus)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsClusterMonitoringEnabled))
            {
                writer.WritePropertyName("clusterMonitoringEnabled"u8);
                writer.WriteBooleanValue(IsClusterMonitoringEnabled.Value);
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(SelectedConfigurations))
            {
                writer.WritePropertyName("selectedConfigurations"u8);
                writer.WriteObjectValue(SelectedConfigurations, options);
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

        HDInsightAzureMonitorExtensionStatus IJsonModel<HDInsightAzureMonitorExtensionStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAzureMonitorExtensionStatus(document.RootElement, options);
        }

        internal static HDInsightAzureMonitorExtensionStatus DeserializeHDInsightAzureMonitorExtensionStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? clusterMonitoringEnabled = default;
            string workspaceId = default;
            HDInsightAzureMonitorSelectedConfigurations selectedConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterMonitoringEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterMonitoringEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectedConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedConfigurations = HDInsightAzureMonitorSelectedConfigurations.DeserializeHDInsightAzureMonitorSelectedConfigurations(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightAzureMonitorExtensionStatus(clusterMonitoringEnabled, workspaceId, selectedConfigurations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAzureMonitorExtensionStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionStatus)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightAzureMonitorExtensionStatus IPersistableModel<HDInsightAzureMonitorExtensionStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightAzureMonitorExtensionStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAzureMonitorExtensionStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
