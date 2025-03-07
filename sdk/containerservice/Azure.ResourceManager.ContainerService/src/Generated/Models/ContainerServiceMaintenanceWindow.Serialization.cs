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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceWindow : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceWindow>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceMaintenanceWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("schedule"u8);
            writer.WriteObjectValue(Schedule, options);
            writer.WritePropertyName("durationHours"u8);
            writer.WriteNumberValue(DurationHours);
            if (Optional.IsDefined(UtcOffset))
            {
                writer.WritePropertyName("utcOffset"u8);
                writer.WriteStringValue(UtcOffset);
            }
            if (Optional.IsDefined(StartDate))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartDate);
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime);
            if (Optional.IsCollectionDefined(NotAllowedDates))
            {
                writer.WritePropertyName("notAllowedDates"u8);
                writer.WriteStartArray();
                foreach (var item in NotAllowedDates)
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

        ContainerServiceMaintenanceWindow IJsonModel<ContainerServiceMaintenanceWindow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceWindow(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceWindow DeserializeContainerServiceMaintenanceWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerServiceMaintenanceSchedule schedule = default;
            int durationHours = default;
            string utcOffset = default;
            string startDate = default;
            string startTime = default;
            IList<ContainerServiceDateSpan> notAllowedDates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schedule"u8))
                {
                    schedule = ContainerServiceMaintenanceSchedule.DeserializeContainerServiceMaintenanceSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("durationHours"u8))
                {
                    durationHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("utcOffset"u8))
                {
                    utcOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    startDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notAllowedDates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceDateSpan> array = new List<ContainerServiceDateSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceDateSpan.DeserializeContainerServiceDateSpan(item, options));
                    }
                    notAllowedDates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerServiceMaintenanceWindow(
                schedule,
                durationHours,
                utcOffset,
                startDate,
                startTime,
                notAllowedDates ?? new ChangeTrackingList<ContainerServiceDateSpan>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Schedule), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  schedule: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Schedule))
                {
                    builder.Append("  schedule: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Schedule, options, 2, false, "  schedule: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DurationHours), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  durationHours: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  durationHours: ");
                builder.AppendLine($"{DurationHours}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UtcOffset), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  utcOffset: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UtcOffset))
                {
                    builder.Append("  utcOffset: ");
                    if (UtcOffset.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UtcOffset}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UtcOffset}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartDate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartDate))
                {
                    builder.Append("  startDate: ");
                    if (StartDate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StartDate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StartDate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartTime))
                {
                    builder.Append("  startTime: ");
                    if (StartTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StartTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StartTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotAllowedDates), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notAllowedDates: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NotAllowedDates))
                {
                    if (NotAllowedDates.Any())
                    {
                        builder.Append("  notAllowedDates: ");
                        builder.AppendLine("[");
                        foreach (var item in NotAllowedDates)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  notAllowedDates: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceWindow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceWindow IPersistableModel<ContainerServiceMaintenanceWindow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerServiceMaintenanceWindow(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceWindow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
