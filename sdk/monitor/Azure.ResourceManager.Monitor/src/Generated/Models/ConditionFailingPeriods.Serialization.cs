// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ConditionFailingPeriods : IUtf8JsonSerializable, IJsonModel<ConditionFailingPeriods>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConditionFailingPeriods>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConditionFailingPeriods>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConditionFailingPeriods)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NumberOfEvaluationPeriods))
            {
                writer.WritePropertyName("numberOfEvaluationPeriods"u8);
                writer.WriteNumberValue(NumberOfEvaluationPeriods.Value);
            }
            if (Optional.IsDefined(MinFailingPeriodsToAlert))
            {
                writer.WritePropertyName("minFailingPeriodsToAlert"u8);
                writer.WriteNumberValue(MinFailingPeriodsToAlert.Value);
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

        ConditionFailingPeriods IJsonModel<ConditionFailingPeriods>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConditionFailingPeriods)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConditionFailingPeriods(document.RootElement, options);
        }

        internal static ConditionFailingPeriods DeserializeConditionFailingPeriods(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? numberOfEvaluationPeriods = default;
            long? minFailingPeriodsToAlert = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfEvaluationPeriods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfEvaluationPeriods = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minFailingPeriodsToAlert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minFailingPeriodsToAlert = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConditionFailingPeriods(numberOfEvaluationPeriods, minFailingPeriodsToAlert, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConditionFailingPeriods>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConditionFailingPeriods)} does not support writing '{options.Format}' format.");
            }
        }

        ConditionFailingPeriods IPersistableModel<ConditionFailingPeriods>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionFailingPeriods>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConditionFailingPeriods(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConditionFailingPeriods)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConditionFailingPeriods>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
