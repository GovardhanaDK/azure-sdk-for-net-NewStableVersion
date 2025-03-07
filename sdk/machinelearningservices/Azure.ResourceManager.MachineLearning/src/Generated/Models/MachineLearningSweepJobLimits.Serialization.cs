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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSweepJobLimits : IUtf8JsonSerializable, IJsonModel<MachineLearningSweepJobLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSweepJobLimits>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningSweepJobLimits>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(MaxTotalTrials))
            {
                if (MaxTotalTrials != null)
                {
                    writer.WritePropertyName("maxTotalTrials"u8);
                    writer.WriteNumberValue(MaxTotalTrials.Value);
                }
                else
                {
                    writer.WriteNull("maxTotalTrials");
                }
            }
            if (Optional.IsDefined(MaxConcurrentTrials))
            {
                if (MaxConcurrentTrials != null)
                {
                    writer.WritePropertyName("maxConcurrentTrials"u8);
                    writer.WriteNumberValue(MaxConcurrentTrials.Value);
                }
                else
                {
                    writer.WriteNull("maxConcurrentTrials");
                }
            }
            if (Optional.IsDefined(TrialTimeout))
            {
                if (TrialTimeout != null)
                {
                    writer.WritePropertyName("trialTimeout"u8);
                    writer.WriteStringValue(TrialTimeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("trialTimeout");
                }
            }
        }

        MachineLearningSweepJobLimits IJsonModel<MachineLearningSweepJobLimits>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSweepJobLimits(document.RootElement, options);
        }

        internal static MachineLearningSweepJobLimits DeserializeMachineLearningSweepJobLimits(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxTotalTrials = default;
            int? maxConcurrentTrials = default;
            TimeSpan? trialTimeout = default;
            JobLimitsType jobLimitsType = default;
            TimeSpan? timeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTotalTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxTotalTrials = null;
                        continue;
                    }
                    maxTotalTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxConcurrentTrials = null;
                        continue;
                    }
                    maxConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trialTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trialTimeout = null;
                        continue;
                    }
                    trialTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("jobLimitsType"u8))
                {
                    jobLimitsType = new JobLimitsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningSweepJobLimits(
                jobLimitsType,
                timeout,
                serializedAdditionalRawData,
                maxTotalTrials,
                maxConcurrentTrials,
                trialTimeout);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxTotalTrials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxTotalTrials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxTotalTrials))
                {
                    builder.Append("  maxTotalTrials: ");
                    builder.AppendLine($"{MaxTotalTrials.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxConcurrentTrials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxConcurrentTrials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxConcurrentTrials))
                {
                    builder.Append("  maxConcurrentTrials: ");
                    builder.AppendLine($"{MaxConcurrentTrials.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrialTimeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trialTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TrialTimeout))
                {
                    builder.Append("  trialTimeout: ");
                    var formattedTimeSpan = TypeFormatters.ToString(TrialTimeout.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobLimitsType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobLimitsType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  jobLimitsType: ");
                builder.AppendLine($"'{JobLimitsType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timeout))
                {
                    builder.Append("  timeout: ");
                    var formattedTimeSpan = TypeFormatters.ToString(Timeout.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningSweepJobLimits>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningSweepJobLimits IPersistableModel<MachineLearningSweepJobLimits>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningSweepJobLimits(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSweepJobLimits)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSweepJobLimits>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
