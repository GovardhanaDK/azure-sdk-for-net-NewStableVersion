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
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class HciClusterUpdateRunData : IUtf8JsonSerializable, IJsonModel<HciClusterUpdateRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciClusterUpdateRunData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciClusterUpdateRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterUpdateRunData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(TimeStarted))
            {
                writer.WritePropertyName("timeStarted"u8);
                writer.WriteStringValue(TimeStarted.Value, "O");
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WritePropertyName("progress"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NamePropertiesProgressName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamePropertiesProgressName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTimeUtc"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTimeUtc"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(LastCompletedOn))
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastCompletedOn.Value, "O");
            }
            if (Optional.IsDefined(ExpectedExecutionTime))
            {
                writer.WritePropertyName("expectedExecutionTime"u8);
                writer.WriteStringValue(ExpectedExecutionTime);
            }
            if (Optional.IsCollectionDefined(Steps))
            {
                writer.WritePropertyName("steps"u8);
                writer.WriteStartArray();
                foreach (var item in Steps)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        HciClusterUpdateRunData IJsonModel<HciClusterUpdateRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciClusterUpdateRunData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterUpdateRunData(document.RootElement, options);
        }

        internal static HciClusterUpdateRunData DeserializeHciClusterUpdateRunData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            HciProvisioningState? provisioningState = default;
            DateTimeOffset? timeStarted = default;
            DateTimeOffset? lastUpdatedTime = default;
            string duration = default;
            UpdateRunPropertiesState? state = default;
            string name0 = default;
            string description = default;
            string errorMessage = default;
            string status = default;
            DateTimeOffset? startTimeUtc = default;
            DateTimeOffset? endTimeUtc = default;
            DateTimeOffset? lastUpdatedTimeUtc = default;
            string expectedExecutionTime = default;
            IList<HciUpdateStep> steps = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeStarted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeStarted = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("duration"u8))
                        {
                            duration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new UpdateRunPropertiesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("progress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("name"u8))
                                {
                                    name0 = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("description"u8))
                                {
                                    description = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("errorMessage"u8))
                                {
                                    errorMessage = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("status"u8))
                                {
                                    status = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("startTimeUtc"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    startTimeUtc = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("endTimeUtc"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    endTimeUtc = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("lastUpdatedTimeUtc"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    lastUpdatedTimeUtc = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("expectedExecutionTime"u8))
                                {
                                    expectedExecutionTime = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("steps"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<HciUpdateStep> array = new List<HciUpdateStep>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(HciUpdateStep.DeserializeHciUpdateStep(item, options));
                                    }
                                    steps = array;
                                    continue;
                                }
                            }
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
            return new HciClusterUpdateRunData(
                id,
                name,
                type,
                systemData,
                location,
                provisioningState,
                timeStarted,
                lastUpdatedTime,
                duration,
                state,
                name0,
                description,
                errorMessage,
                status,
                startTimeUtc,
                endTimeUtc,
                lastUpdatedTimeUtc,
                expectedExecutionTime,
                steps ?? new ChangeTrackingList<HciUpdateStep>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Location))
                {
                    builder.Append("  location: ");
                    builder.AppendLine($"'{Location.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeStarted), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    timeStarted: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeStarted))
                {
                    builder.Append("    timeStarted: ");
                    var formattedDateTimeString = TypeFormatters.ToString(TimeStarted.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastUpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastUpdatedTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastUpdatedOn))
                {
                    builder.Append("    lastUpdatedTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Duration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    duration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Duration))
                {
                    builder.Append("    duration: ");
                    if (Duration.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Duration}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Duration}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(State), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    state: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(State))
                {
                    builder.Append("    state: ");
                    builder.AppendLine($"'{State.Value.ToString()}'");
                }
            }

            builder.Append("    progress:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NamePropertiesProgressName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NamePropertiesProgressName))
                {
                    builder.Append("      name: ");
                    if (NamePropertiesProgressName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NamePropertiesProgressName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NamePropertiesProgressName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("      description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorMessage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      errorMessage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ErrorMessage))
                {
                    builder.Append("      errorMessage: ");
                    if (ErrorMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ErrorMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ErrorMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("      status: ");
                    if (Status.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Status}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Status}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      startTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartOn))
                {
                    builder.Append("      startTimeUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      endTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndOn))
                {
                    builder.Append("      endTimeUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EndOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastCompletedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      lastUpdatedTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastCompletedOn))
                {
                    builder.Append("      lastUpdatedTimeUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastCompletedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpectedExecutionTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      expectedExecutionTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpectedExecutionTime))
                {
                    builder.Append("      expectedExecutionTime: ");
                    if (ExpectedExecutionTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ExpectedExecutionTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ExpectedExecutionTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Steps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      steps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Steps))
                {
                    if (Steps.Any())
                    {
                        builder.Append("      steps: ");
                        builder.AppendLine("[");
                        foreach (var item in Steps)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 8, true, "      steps: ");
                        }
                        builder.AppendLine("      ]");
                    }
                }
            }

            builder.AppendLine("    }");
            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HciClusterUpdateRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HciClusterUpdateRunData)} does not support writing '{options.Format}' format.");
            }
        }

        HciClusterUpdateRunData IPersistableModel<HciClusterUpdateRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciClusterUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHciClusterUpdateRunData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciClusterUpdateRunData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciClusterUpdateRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
