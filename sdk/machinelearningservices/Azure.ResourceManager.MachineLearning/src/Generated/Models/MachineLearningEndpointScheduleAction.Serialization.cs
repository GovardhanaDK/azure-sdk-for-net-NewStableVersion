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
    public partial class MachineLearningEndpointScheduleAction : IUtf8JsonSerializable, IJsonModel<MachineLearningEndpointScheduleAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEndpointScheduleAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningEndpointScheduleAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointScheduleAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointScheduleAction)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("endpointInvocationDefinition"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EndpointInvocationDefinition);
#else
            using (JsonDocument document = JsonDocument.Parse(EndpointInvocationDefinition, ModelSerializationExtensions.JsonDocumentOptions))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
        }

        MachineLearningEndpointScheduleAction IJsonModel<MachineLearningEndpointScheduleAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointScheduleAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEndpointScheduleAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEndpointScheduleAction(document.RootElement, options);
        }

        internal static MachineLearningEndpointScheduleAction DeserializeMachineLearningEndpointScheduleAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData endpointInvocationDefinition = default;
            ScheduleActionType actionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointInvocationDefinition"u8))
                {
                    endpointInvocationDefinition = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ScheduleActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningEndpointScheduleAction(actionType, serializedAdditionalRawData, endpointInvocationDefinition);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointInvocationDefinition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointInvocationDefinition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndpointInvocationDefinition))
                {
                    builder.Append("  endpointInvocationDefinition: ");
                    builder.AppendLine($"'{EndpointInvocationDefinition.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  actionType: ");
                builder.AppendLine($"'{ActionType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningEndpointScheduleAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointScheduleAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEndpointScheduleAction)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningEndpointScheduleAction IPersistableModel<MachineLearningEndpointScheduleAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEndpointScheduleAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningEndpointScheduleAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEndpointScheduleAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningEndpointScheduleAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
