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
    public partial class MpiDistributionConfiguration : IUtf8JsonSerializable, IJsonModel<MpiDistributionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MpiDistributionConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MpiDistributionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MpiDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MpiDistributionConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ProcessCountPerInstance))
            {
                if (ProcessCountPerInstance != null)
                {
                    writer.WritePropertyName("processCountPerInstance"u8);
                    writer.WriteNumberValue(ProcessCountPerInstance.Value);
                }
                else
                {
                    writer.WriteNull("processCountPerInstance");
                }
            }
        }

        MpiDistributionConfiguration IJsonModel<MpiDistributionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MpiDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MpiDistributionConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMpiDistributionConfiguration(document.RootElement, options);
        }

        internal static MpiDistributionConfiguration DeserializeMpiDistributionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? processCountPerInstance = default;
            DistributionType distributionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processCountPerInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        processCountPerInstance = null;
                        continue;
                    }
                    processCountPerInstance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("distributionType"u8))
                {
                    distributionType = new DistributionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MpiDistributionConfiguration(distributionType, serializedAdditionalRawData, processCountPerInstance);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProcessCountPerInstance), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  processCountPerInstance: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProcessCountPerInstance))
                {
                    builder.Append("  processCountPerInstance: ");
                    builder.AppendLine($"{ProcessCountPerInstance.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DistributionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  distributionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  distributionType: ");
                builder.AppendLine($"'{DistributionType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MpiDistributionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MpiDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MpiDistributionConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MpiDistributionConfiguration IPersistableModel<MpiDistributionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MpiDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMpiDistributionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MpiDistributionConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MpiDistributionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
