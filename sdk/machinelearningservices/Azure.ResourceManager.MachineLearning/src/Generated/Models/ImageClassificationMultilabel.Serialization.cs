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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageClassificationMultilabel : IUtf8JsonSerializable, IJsonModel<ImageClassificationMultilabel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageClassificationMultilabel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ImageClassificationMultilabel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageClassificationMultilabel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageClassificationMultilabel)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(ModelSettings))
            {
                if (ModelSettings != null)
                {
                    writer.WritePropertyName("modelSettings"u8);
                    writer.WriteObjectValue(ModelSettings, options);
                }
                else
                {
                    writer.WriteNull("modelSettings");
                }
            }
            if (Optional.IsCollectionDefined(SearchSpace))
            {
                if (SearchSpace != null)
                {
                    writer.WritePropertyName("searchSpace"u8);
                    writer.WriteStartArray();
                    foreach (var item in SearchSpace)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("searchSpace");
                }
            }
            writer.WritePropertyName("limitSettings"u8);
            writer.WriteObjectValue(LimitSettings, options);
            if (Optional.IsDefined(SweepSettings))
            {
                if (SweepSettings != null)
                {
                    writer.WritePropertyName("sweepSettings"u8);
                    writer.WriteObjectValue(SweepSettings, options);
                }
                else
                {
                    writer.WriteNull("sweepSettings");
                }
            }
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData, options);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (Optional.IsDefined(ValidationDataSize))
            {
                if (ValidationDataSize != null)
                {
                    writer.WritePropertyName("validationDataSize"u8);
                    writer.WriteNumberValue(ValidationDataSize.Value);
                }
                else
                {
                    writer.WriteNull("validationDataSize");
                }
            }
        }

        ImageClassificationMultilabel IJsonModel<ImageClassificationMultilabel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageClassificationMultilabel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageClassificationMultilabel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageClassificationMultilabel(document.RootElement, options);
        }

        internal static ImageClassificationMultilabel DeserializeImageClassificationMultilabel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClassificationMultilabelPrimaryMetric? primaryMetric = default;
            ImageModelSettingsClassification modelSettings = default;
            IList<ImageModelDistributionSettingsClassification> searchSpace = default;
            ImageLimitSettings limitSettings = default;
            ImageSweepSettings sweepSettings = default;
            MachineLearningTableJobInput validationData = default;
            double? validationDataSize = default;
            TaskType taskType = default;
            MachineLearningLogVerbosity? logVerbosity = default;
            MachineLearningTableJobInput trainingData = default;
            string targetColumnName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new ClassificationMultilabelPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelSettings = null;
                        continue;
                    }
                    modelSettings = ImageModelSettingsClassification.DeserializeImageModelSettingsClassification(property.Value, options);
                    continue;
                }
                if (property.NameEquals("searchSpace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchSpace = null;
                        continue;
                    }
                    List<ImageModelDistributionSettingsClassification> array = new List<ImageModelDistributionSettingsClassification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageModelDistributionSettingsClassification.DeserializeImageModelDistributionSettingsClassification(item, options));
                    }
                    searchSpace = array;
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    limitSettings = ImageLimitSettings.DeserializeImageLimitSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sweepSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sweepSettings = null;
                        continue;
                    }
                    sweepSettings = ImageSweepSettings.DeserializeImageSweepSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationDataSize = null;
                        continue;
                    }
                    validationDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ImageClassificationMultilabel(
                taskType,
                logVerbosity,
                trainingData,
                targetColumnName,
                serializedAdditionalRawData,
                primaryMetric,
                modelSettings,
                searchSpace ?? new ChangeTrackingList<ImageModelDistributionSettingsClassification>(),
                limitSettings,
                sweepSettings,
                validationData,
                validationDataSize);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryMetric), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryMetric: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryMetric))
                {
                    builder.Append("  primaryMetric: ");
                    builder.AppendLine($"'{PrimaryMetric.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ModelSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  modelSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ModelSettings))
                {
                    builder.Append("  modelSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ModelSettings, options, 2, false, "  modelSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SearchSpace), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  searchSpace: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SearchSpace))
                {
                    if (SearchSpace.Any())
                    {
                        builder.Append("  searchSpace: ");
                        builder.AppendLine("[");
                        foreach (var item in SearchSpace)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  searchSpace: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LimitSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  limitSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LimitSettings))
                {
                    builder.Append("  limitSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LimitSettings, options, 2, false, "  limitSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SweepSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sweepSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SweepSettings))
                {
                    builder.Append("  sweepSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SweepSettings, options, 2, false, "  sweepSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidationData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validationData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValidationData))
                {
                    builder.Append("  validationData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ValidationData, options, 2, false, "  validationData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidationDataSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validationDataSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValidationDataSize))
                {
                    builder.Append("  validationDataSize: ");
                    builder.AppendLine($"'{ValidationDataSize.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TaskType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  taskType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  taskType: ");
                builder.AppendLine($"'{TaskType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogVerbosity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logVerbosity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogVerbosity))
                {
                    builder.Append("  logVerbosity: ");
                    builder.AppendLine($"'{LogVerbosity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrainingData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trainingData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TrainingData))
                {
                    builder.Append("  trainingData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TrainingData, options, 2, false, "  trainingData: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetColumnName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetColumnName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetColumnName))
                {
                    builder.Append("  targetColumnName: ");
                    if (TargetColumnName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TargetColumnName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TargetColumnName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ImageClassificationMultilabel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageClassificationMultilabel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ImageClassificationMultilabel)} does not support writing '{options.Format}' format.");
            }
        }

        ImageClassificationMultilabel IPersistableModel<ImageClassificationMultilabel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageClassificationMultilabel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeImageClassificationMultilabel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageClassificationMultilabel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageClassificationMultilabel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
