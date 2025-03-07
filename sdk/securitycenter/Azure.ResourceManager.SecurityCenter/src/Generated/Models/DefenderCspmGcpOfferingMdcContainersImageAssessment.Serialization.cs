// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmGcpOfferingMdcContainersImageAssessment : IUtf8JsonSerializable, IJsonModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersImageAssessment)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
            }
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
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

        DefenderCspmGcpOfferingMdcContainersImageAssessment IJsonModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersImageAssessment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmGcpOfferingMdcContainersImageAssessment(document.RootElement, options);
        }

        internal static DefenderCspmGcpOfferingMdcContainersImageAssessment DeserializeDefenderCspmGcpOfferingMdcContainersImageAssessment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            string workloadIdentityProviderId = default;
            string serviceAccountEmailAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderCspmGcpOfferingMdcContainersImageAssessment(enabled, workloadIdentityProviderId, serviceAccountEmailAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersImageAssessment)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderCspmGcpOfferingMdcContainersImageAssessment IPersistableModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDefenderCspmGcpOfferingMdcContainersImageAssessment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingMdcContainersImageAssessment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmGcpOfferingMdcContainersImageAssessment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
