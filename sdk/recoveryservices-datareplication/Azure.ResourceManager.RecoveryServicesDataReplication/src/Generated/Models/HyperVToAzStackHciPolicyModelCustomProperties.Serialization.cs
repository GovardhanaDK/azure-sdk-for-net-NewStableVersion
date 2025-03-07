// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVToAzStackHciPolicyModelCustomProperties : IUtf8JsonSerializable, IJsonModel<HyperVToAzStackHciPolicyModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVToAzStackHciPolicyModelCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HyperVToAzStackHciPolicyModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciPolicyModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVToAzStackHciPolicyModelCustomProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("recoveryPointHistoryInMinutes"u8);
            writer.WriteNumberValue(RecoveryPointHistoryInMinutes);
            writer.WritePropertyName("crashConsistentFrequencyInMinutes"u8);
            writer.WriteNumberValue(CrashConsistentFrequencyInMinutes);
            writer.WritePropertyName("appConsistentFrequencyInMinutes"u8);
            writer.WriteNumberValue(AppConsistentFrequencyInMinutes);
        }

        HyperVToAzStackHciPolicyModelCustomProperties IJsonModel<HyperVToAzStackHciPolicyModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciPolicyModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVToAzStackHciPolicyModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVToAzStackHciPolicyModelCustomProperties(document.RootElement, options);
        }

        internal static HyperVToAzStackHciPolicyModelCustomProperties DeserializeHyperVToAzStackHciPolicyModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int recoveryPointHistoryInMinutes = default;
            int crashConsistentFrequencyInMinutes = default;
            int appConsistentFrequencyInMinutes = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointHistoryInMinutes"u8))
                {
                    recoveryPointHistoryInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("crashConsistentFrequencyInMinutes"u8))
                {
                    crashConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appConsistentFrequencyInMinutes"u8))
                {
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HyperVToAzStackHciPolicyModelCustomProperties(instanceType, serializedAdditionalRawData, recoveryPointHistoryInMinutes, crashConsistentFrequencyInMinutes, appConsistentFrequencyInMinutes);
        }

        BinaryData IPersistableModel<HyperVToAzStackHciPolicyModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciPolicyModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVToAzStackHciPolicyModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HyperVToAzStackHciPolicyModelCustomProperties IPersistableModel<HyperVToAzStackHciPolicyModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciPolicyModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHyperVToAzStackHciPolicyModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVToAzStackHciPolicyModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVToAzStackHciPolicyModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
