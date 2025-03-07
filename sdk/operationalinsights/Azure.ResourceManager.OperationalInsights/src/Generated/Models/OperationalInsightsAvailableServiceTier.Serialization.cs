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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsAvailableServiceTier : IUtf8JsonSerializable, IJsonModel<OperationalInsightsAvailableServiceTier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsAvailableServiceTier>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OperationalInsightsAvailableServiceTier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ServiceTier))
            {
                writer.WritePropertyName("serviceTier"u8);
                writer.WriteStringValue(ServiceTier.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MinimumRetention))
            {
                writer.WritePropertyName("minimumRetention"u8);
                writer.WriteNumberValue(MinimumRetention.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaximumRetention))
            {
                writer.WritePropertyName("maximumRetention"u8);
                writer.WriteNumberValue(MaximumRetention.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultRetention))
            {
                writer.WritePropertyName("defaultRetention"u8);
                writer.WriteNumberValue(DefaultRetention.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CapacityReservationLevel))
            {
                writer.WritePropertyName("capacityReservationLevel"u8);
                writer.WriteNumberValue(CapacityReservationLevel.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSkuUpdatedOn))
            {
                writer.WritePropertyName("lastSkuUpdate"u8);
                writer.WriteStringValue(LastSkuUpdatedOn.Value, "O");
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

        OperationalInsightsAvailableServiceTier IJsonModel<OperationalInsightsAvailableServiceTier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsAvailableServiceTier(document.RootElement, options);
        }

        internal static OperationalInsightsAvailableServiceTier DeserializeOperationalInsightsAvailableServiceTier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OperationalInsightsSkuName? serviceTier = default;
            bool? enabled = default;
            long? minimumRetention = default;
            long? maximumRetention = default;
            long? defaultRetention = default;
            long? capacityReservationLevel = default;
            DateTimeOffset? lastSkuUpdate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceTier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTier = new OperationalInsightsSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minimumRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximumRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("capacityReservationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityReservationLevel = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastSkuUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSkuUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OperationalInsightsAvailableServiceTier(
                serviceTier,
                enabled,
                minimumRetention,
                maximumRetention,
                defaultRetention,
                capacityReservationLevel,
                lastSkuUpdate,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceTier), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serviceTier: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServiceTier))
                {
                    builder.Append("  serviceTier: ");
                    builder.AppendLine($"'{ServiceTier.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("  enabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinimumRetention), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minimumRetention: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MinimumRetention))
                {
                    builder.Append("  minimumRetention: ");
                    builder.AppendLine($"'{MinimumRetention.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaximumRetention), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maximumRetention: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaximumRetention))
                {
                    builder.Append("  maximumRetention: ");
                    builder.AppendLine($"'{MaximumRetention.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultRetention), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaultRetention: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultRetention))
                {
                    builder.Append("  defaultRetention: ");
                    builder.AppendLine($"'{DefaultRetention.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CapacityReservationLevel), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  capacityReservationLevel: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CapacityReservationLevel))
                {
                    builder.Append("  capacityReservationLevel: ");
                    builder.AppendLine($"'{CapacityReservationLevel.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastSkuUpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastSkuUpdate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastSkuUpdatedOn))
                {
                    builder.Append("  lastSkuUpdate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastSkuUpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OperationalInsightsAvailableServiceTier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support writing '{options.Format}' format.");
            }
        }

        OperationalInsightsAvailableServiceTier IPersistableModel<OperationalInsightsAvailableServiceTier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOperationalInsightsAvailableServiceTier(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsAvailableServiceTier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
