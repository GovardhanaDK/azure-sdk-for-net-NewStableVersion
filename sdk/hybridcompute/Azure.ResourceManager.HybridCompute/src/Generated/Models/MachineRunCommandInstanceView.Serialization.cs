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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineRunCommandInstanceView : IUtf8JsonSerializable, IJsonModel<MachineRunCommandInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineRunCommandInstanceView>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineRunCommandInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineRunCommandInstanceView)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ExecutionState))
            {
                writer.WritePropertyName("executionState"u8);
                writer.WriteStringValue(ExecutionState.Value.ToString());
            }
            if (Optional.IsDefined(ExecutionMessage))
            {
                writer.WritePropertyName("executionMessage"u8);
                writer.WriteStringValue(ExecutionMessage);
            }
            if (Optional.IsDefined(ExitCode))
            {
                writer.WritePropertyName("exitCode"u8);
                writer.WriteNumberValue(ExitCode.Value);
            }
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStringValue(Output);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
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

        MachineRunCommandInstanceView IJsonModel<MachineRunCommandInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineRunCommandInstanceView)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineRunCommandInstanceView(document.RootElement, options);
        }

        internal static MachineRunCommandInstanceView DeserializeMachineRunCommandInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HybridComputeExecutionState? executionState = default;
            string executionMessage = default;
            int? exitCode = default;
            string output = default;
            string error = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IReadOnlyList<ExtensionsResourceStatus> statuses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("executionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionState = new HybridComputeExecutionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("executionMessage"u8))
                {
                    executionMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exitCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exitCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    output = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtensionsResourceStatus> array = new List<ExtensionsResourceStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtensionsResourceStatus.DeserializeExtensionsResourceStatus(item, options));
                    }
                    statuses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineRunCommandInstanceView(
                executionState,
                executionMessage,
                exitCode,
                output,
                error,
                startTime,
                endTime,
                statuses ?? new ChangeTrackingList<ExtensionsResourceStatus>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExecutionState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  executionState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExecutionState))
                {
                    builder.Append("  executionState: ");
                    builder.AppendLine($"'{ExecutionState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExecutionMessage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  executionMessage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExecutionMessage))
                {
                    builder.Append("  executionMessage: ");
                    if (ExecutionMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ExecutionMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ExecutionMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExitCode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  exitCode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExitCode))
                {
                    builder.Append("  exitCode: ");
                    builder.AppendLine($"{ExitCode.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Output), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  output: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Output))
                {
                    builder.Append("  output: ");
                    if (Output.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Output}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Output}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Error), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  error: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Error))
                {
                    builder.Append("  error: ");
                    if (Error.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Error}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Error}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartOn))
                {
                    builder.Append("  startTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndOn))
                {
                    builder.Append("  endTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EndOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Statuses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  statuses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Statuses))
                {
                    if (Statuses.Any())
                    {
                        builder.Append("  statuses: ");
                        builder.AppendLine("[");
                        foreach (var item in Statuses)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  statuses: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineRunCommandInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineRunCommandInstanceView)} does not support writing '{options.Format}' format.");
            }
        }

        MachineRunCommandInstanceView IPersistableModel<MachineRunCommandInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineRunCommandInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineRunCommandInstanceView)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineRunCommandInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
