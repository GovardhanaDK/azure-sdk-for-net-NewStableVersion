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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class IncludedQuantityUtilizationSummary : IUtf8JsonSerializable, IJsonModel<IncludedQuantityUtilizationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IncludedQuantityUtilizationSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IncludedQuantityUtilizationSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IncludedQuantityUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IncludedQuantityUtilizationSummary)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ArmSkuName))
            {
                writer.WritePropertyName("armSkuName"u8);
                writer.WriteStringValue(ArmSkuName);
            }
            if (options.Format != "W" && Optional.IsDefined(BenefitId))
            {
                writer.WritePropertyName("benefitId"u8);
                writer.WriteStringValue(BenefitId);
            }
            if (options.Format != "W" && Optional.IsDefined(BenefitOrderId))
            {
                writer.WritePropertyName("benefitOrderId"u8);
                writer.WriteStringValue(BenefitOrderId);
            }
            if (Optional.IsDefined(BenefitType))
            {
                writer.WritePropertyName("benefitType"u8);
                writer.WriteStringValue(BenefitType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(UsageOn))
            {
                writer.WritePropertyName("usageDate"u8);
                writer.WriteStringValue(UsageOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UtilizationPercentage))
            {
                writer.WritePropertyName("utilizationPercentage"u8);
                writer.WriteNumberValue(UtilizationPercentage.Value);
            }
            writer.WriteEndObject();
        }

        IncludedQuantityUtilizationSummary IJsonModel<IncludedQuantityUtilizationSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IncludedQuantityUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IncludedQuantityUtilizationSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIncludedQuantityUtilizationSummary(document.RootElement, options);
        }

        internal static IncludedQuantityUtilizationSummary DeserializeIncludedQuantityUtilizationSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingAccountBenefitKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string armSkuName = default;
            string benefitId = default;
            string benefitOrderId = default;
            BillingAccountBenefitKind? benefitType = default;
            DateTimeOffset? usageDate = default;
            decimal? utilizationPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new BillingAccountBenefitKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("armSkuName"u8))
                        {
                            armSkuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitId"u8))
                        {
                            benefitId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitOrderId"u8))
                        {
                            benefitOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            benefitType = new BillingAccountBenefitKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usageDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("utilizationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            utilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IncludedQuantityUtilizationSummary(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                armSkuName,
                benefitId,
                benefitOrderId,
                benefitType,
                usageDate,
                utilizationPercentage);
        }

        BinaryData IPersistableModel<IncludedQuantityUtilizationSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IncludedQuantityUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IncludedQuantityUtilizationSummary)} does not support writing '{options.Format}' format.");
            }
        }

        IncludedQuantityUtilizationSummary IPersistableModel<IncludedQuantityUtilizationSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IncludedQuantityUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIncludedQuantityUtilizationSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IncludedQuantityUtilizationSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IncludedQuantityUtilizationSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
