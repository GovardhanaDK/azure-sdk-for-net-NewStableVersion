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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class LogCollectionSession : IUtf8JsonSerializable, IJsonModel<LogCollectionSession>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogCollectionSession>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LogCollectionSession>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogCollectionSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogCollectionSession)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(LogStartOn))
            {
                writer.WritePropertyName("logStartTime"u8);
                writer.WriteStringValue(LogStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LogEndOn))
            {
                writer.WritePropertyName("logEndTime"u8);
                writer.WriteStringValue(LogEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCollected))
            {
                writer.WritePropertyName("timeCollected"u8);
                writer.WriteStringValue(TimeCollected.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LogSize))
            {
                writer.WritePropertyName("logSize"u8);
                writer.WriteNumberValue(LogSize.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LogCollectionStatus))
            {
                writer.WritePropertyName("logCollectionStatus"u8);
                writer.WriteStringValue(LogCollectionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LogCollectionJobType))
            {
                writer.WritePropertyName("logCollectionJobType"u8);
                writer.WriteStringValue(LogCollectionJobType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (options.Format != "W" && Optional.IsDefined(EndTimeCollected))
            {
                writer.WritePropertyName("endTimeCollected"u8);
                writer.WriteStringValue(EndTimeCollected.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LogCollectionError))
            {
                writer.WritePropertyName("logCollectionError"u8);
                writer.WriteObjectValue(LogCollectionError, options);
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

        LogCollectionSession IJsonModel<LogCollectionSession>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogCollectionSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogCollectionSession)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogCollectionSession(document.RootElement, options);
        }

        internal static LogCollectionSession DeserializeLogCollectionSession(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? logStartTime = default;
            DateTimeOffset? logEndTime = default;
            DateTimeOffset? timeCollected = default;
            long? logSize = default;
            LogCollectionStatus? logCollectionStatus = default;
            LogCollectionJobType? logCollectionJobType = default;
            string correlationId = default;
            DateTimeOffset? endTimeCollected = default;
            LogCollectionError logCollectionError = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("logEndTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeCollected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCollected = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("logSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logCollectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logCollectionStatus = new LogCollectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logCollectionJobType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logCollectionJobType = new LogCollectionJobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTimeCollected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTimeCollected = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("logCollectionError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logCollectionError = LogCollectionError.DeserializeLogCollectionError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LogCollectionSession(
                logStartTime,
                logEndTime,
                timeCollected,
                logSize,
                logCollectionStatus,
                logCollectionJobType,
                correlationId,
                endTimeCollected,
                logCollectionError,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogStartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logStartTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogStartOn))
                {
                    builder.Append("  logStartTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LogStartOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogEndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logEndTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogEndOn))
                {
                    builder.Append("  logEndTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LogEndOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeCollected), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeCollected: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeCollected))
                {
                    builder.Append("  timeCollected: ");
                    var formattedDateTimeString = TypeFormatters.ToString(TimeCollected.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogSize))
                {
                    builder.Append("  logSize: ");
                    builder.AppendLine($"'{LogSize.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogCollectionStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logCollectionStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogCollectionStatus))
                {
                    builder.Append("  logCollectionStatus: ");
                    builder.AppendLine($"'{LogCollectionStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogCollectionJobType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logCollectionJobType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogCollectionJobType))
                {
                    builder.Append("  logCollectionJobType: ");
                    builder.AppendLine($"'{LogCollectionJobType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CorrelationId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  correlationId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CorrelationId))
                {
                    builder.Append("  correlationId: ");
                    if (CorrelationId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CorrelationId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CorrelationId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndTimeCollected), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTimeCollected: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndTimeCollected))
                {
                    builder.Append("  endTimeCollected: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EndTimeCollected.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogCollectionError), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logCollectionError: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogCollectionError))
                {
                    builder.Append("  logCollectionError: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LogCollectionError, options, 2, false, "  logCollectionError: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<LogCollectionSession>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogCollectionSession>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LogCollectionSession)} does not support writing '{options.Format}' format.");
            }
        }

        LogCollectionSession IPersistableModel<LogCollectionSession>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogCollectionSession>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLogCollectionSession(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogCollectionSession)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogCollectionSession>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
