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
    public partial class AutoscaleSettingPredicativeResult : IUtf8JsonSerializable, IJsonModel<AutoscaleSettingPredicativeResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleSettingPredicativeResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutoscaleSettingPredicativeResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPredicativeResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingPredicativeResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Timespan))
            {
                writer.WritePropertyName("timespan"u8);
                writer.WriteStringValue(Timespan);
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteStringValue(Interval.Value, "P");
            }
            if (Optional.IsDefined(MetricName))
            {
                writer.WritePropertyName("metricName"u8);
                writer.WriteStringValue(MetricName);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
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

        AutoscaleSettingPredicativeResult IJsonModel<AutoscaleSettingPredicativeResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPredicativeResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingPredicativeResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleSettingPredicativeResult(document.RootElement, options);
        }

        internal static AutoscaleSettingPredicativeResult DeserializeAutoscaleSettingPredicativeResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string timespan = default;
            TimeSpan? interval = default;
            string metricName = default;
            ResourceIdentifier targetResourceId = default;
            IReadOnlyList<PredictiveValue> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timespan"u8))
                {
                    timespan = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PredictiveValue> array = new List<PredictiveValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredictiveValue.DeserializePredictiveValue(item, options));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutoscaleSettingPredicativeResult(
                timespan,
                interval,
                metricName,
                targetResourceId,
                data ?? new ChangeTrackingList<PredictiveValue>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleSettingPredicativeResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPredicativeResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingPredicativeResult)} does not support writing '{options.Format}' format.");
            }
        }

        AutoscaleSettingPredicativeResult IPersistableModel<AutoscaleSettingPredicativeResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingPredicativeResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutoscaleSettingPredicativeResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingPredicativeResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleSettingPredicativeResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
