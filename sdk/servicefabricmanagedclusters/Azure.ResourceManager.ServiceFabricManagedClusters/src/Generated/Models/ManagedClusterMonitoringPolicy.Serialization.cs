// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterMonitoringPolicy : IUtf8JsonSerializable, IJsonModel<ManagedClusterMonitoringPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterMonitoringPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterMonitoringPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterMonitoringPolicy)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("healthCheckWaitDuration"u8);
            writer.WriteStringValue(HealthCheckWaitDuration, "c");
            writer.WritePropertyName("healthCheckStableDuration"u8);
            writer.WriteStringValue(HealthCheckStableDuration, "c");
            writer.WritePropertyName("healthCheckRetryTimeout"u8);
            writer.WriteStringValue(HealthCheckRetryTimeout);
            writer.WritePropertyName("upgradeTimeout"u8);
            writer.WriteStringValue(UpgradeTimeout);
            writer.WritePropertyName("upgradeDomainTimeout"u8);
            writer.WriteStringValue(UpgradeDomainTimeout);
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

        ManagedClusterMonitoringPolicy IJsonModel<ManagedClusterMonitoringPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterMonitoringPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterMonitoringPolicy(document.RootElement, options);
        }

        internal static ManagedClusterMonitoringPolicy DeserializeManagedClusterMonitoringPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan healthCheckWaitDuration = default;
            TimeSpan healthCheckStableDuration = default;
            string healthCheckRetryTimeout = default;
            string upgradeTimeout = default;
            string upgradeDomainTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthCheckWaitDuration"u8))
                {
                    healthCheckWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"u8))
                {
                    healthCheckStableDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"u8))
                {
                    healthCheckRetryTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"u8))
                {
                    upgradeTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"u8))
                {
                    upgradeDomainTimeout = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterMonitoringPolicy(
                healthCheckWaitDuration,
                healthCheckStableDuration,
                healthCheckRetryTimeout,
                upgradeTimeout,
                upgradeDomainTimeout,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterMonitoringPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterMonitoringPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterMonitoringPolicy IPersistableModel<ManagedClusterMonitoringPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedClusterMonitoringPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterMonitoringPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterMonitoringPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
