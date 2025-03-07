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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StampCapacity : IUtf8JsonSerializable, IJsonModel<StampCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StampCapacity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StampCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StampCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StampCapacity)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AvailableCapacity))
            {
                writer.WritePropertyName("availableCapacity"u8);
                writer.WriteNumberValue(AvailableCapacity.Value);
            }
            if (Optional.IsDefined(TotalCapacity))
            {
                writer.WritePropertyName("totalCapacity"u8);
                writer.WriteNumberValue(TotalCapacity.Value);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(ComputeMode))
            {
                writer.WritePropertyName("computeMode"u8);
                writer.WriteStringValue(ComputeMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(WorkerSize))
            {
                writer.WritePropertyName("workerSize"u8);
                writer.WriteStringValue(WorkerSize.Value.ToSerialString());
            }
            if (Optional.IsDefined(WorkerSizeId))
            {
                writer.WritePropertyName("workerSizeId"u8);
                writer.WriteNumberValue(WorkerSizeId.Value);
            }
            if (Optional.IsDefined(ExcludeFromCapacityAllocation))
            {
                writer.WritePropertyName("excludeFromCapacityAllocation"u8);
                writer.WriteBooleanValue(ExcludeFromCapacityAllocation.Value);
            }
            if (Optional.IsDefined(IsApplicableForAllComputeModes))
            {
                writer.WritePropertyName("isApplicableForAllComputeModes"u8);
                writer.WriteBooleanValue(IsApplicableForAllComputeModes.Value);
            }
            if (Optional.IsDefined(SiteMode))
            {
                writer.WritePropertyName("siteMode"u8);
                writer.WriteStringValue(SiteMode);
            }
            if (Optional.IsDefined(IsLinux))
            {
                writer.WritePropertyName("isLinux"u8);
                writer.WriteBooleanValue(IsLinux.Value);
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

        StampCapacity IJsonModel<StampCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StampCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StampCapacity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStampCapacity(document.RootElement, options);
        }

        internal static StampCapacity DeserializeStampCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            long? availableCapacity = default;
            long? totalCapacity = default;
            string unit = default;
            ComputeModeOption? computeMode = default;
            WorkerSizeOption? workerSize = default;
            int? workerSizeId = default;
            bool? excludeFromCapacityAllocation = default;
            bool? isApplicableForAllComputeModes = default;
            string siteMode = default;
            bool? isLinux = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeMode = property.Value.GetString().ToComputeModeOption();
                    continue;
                }
                if (property.NameEquals("workerSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workerSize = property.Value.GetString().ToWorkerSizeOption();
                    continue;
                }
                if (property.NameEquals("workerSizeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workerSizeId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromCapacityAllocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeFromCapacityAllocation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isApplicableForAllComputeModes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isApplicableForAllComputeModes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("siteMode"u8))
                {
                    siteMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isLinux"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLinux = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StampCapacity(
                name,
                availableCapacity,
                totalCapacity,
                unit,
                computeMode,
                workerSize,
                workerSizeId,
                excludeFromCapacityAllocation,
                isApplicableForAllComputeModes,
                siteMode,
                isLinux,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AvailableCapacity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  availableCapacity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AvailableCapacity))
                {
                    builder.Append("  availableCapacity: ");
                    builder.AppendLine($"'{AvailableCapacity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TotalCapacity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  totalCapacity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TotalCapacity))
                {
                    builder.Append("  totalCapacity: ");
                    builder.AppendLine($"'{TotalCapacity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Unit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  unit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Unit))
                {
                    builder.Append("  unit: ");
                    if (Unit.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Unit}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Unit}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComputeMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  computeMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComputeMode))
                {
                    builder.Append("  computeMode: ");
                    builder.AppendLine($"'{ComputeMode.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WorkerSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  workerSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WorkerSize))
                {
                    builder.Append("  workerSize: ");
                    builder.AppendLine($"'{WorkerSize.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WorkerSizeId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  workerSizeId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WorkerSizeId))
                {
                    builder.Append("  workerSizeId: ");
                    builder.AppendLine($"{WorkerSizeId.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExcludeFromCapacityAllocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  excludeFromCapacityAllocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExcludeFromCapacityAllocation))
                {
                    builder.Append("  excludeFromCapacityAllocation: ");
                    var boolValue = ExcludeFromCapacityAllocation.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsApplicableForAllComputeModes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isApplicableForAllComputeModes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsApplicableForAllComputeModes))
                {
                    builder.Append("  isApplicableForAllComputeModes: ");
                    var boolValue = IsApplicableForAllComputeModes.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SiteMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  siteMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SiteMode))
                {
                    builder.Append("  siteMode: ");
                    if (SiteMode.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SiteMode}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SiteMode}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsLinux), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isLinux: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsLinux))
                {
                    builder.Append("  isLinux: ");
                    var boolValue = IsLinux.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StampCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StampCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StampCapacity)} does not support writing '{options.Format}' format.");
            }
        }

        StampCapacity IPersistableModel<StampCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StampCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStampCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StampCapacity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StampCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
