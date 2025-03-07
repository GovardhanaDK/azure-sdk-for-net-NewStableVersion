// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleSchedule : IUtf8JsonSerializable, IJsonModel<HDInsightAutoScaleSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAutoScaleSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightAutoScaleSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleSchedule)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Days))
            {
                writer.WritePropertyName("days"u8);
                writer.WriteStartArray();
                foreach (var item in Days)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimeAndCapacity))
            {
                writer.WritePropertyName("timeAndCapacity"u8);
                writer.WriteObjectValue(TimeAndCapacity, options);
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

        HDInsightAutoScaleSchedule IJsonModel<HDInsightAutoScaleSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAutoScaleSchedule(document.RootElement, options);
        }

        internal static HDInsightAutoScaleSchedule DeserializeHDInsightAutoScaleSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<HDInsightDayOfWeek> days = default;
            HDInsightAutoScaleTimeAndCapacity timeAndCapacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("days"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightDayOfWeek> array = new List<HDInsightDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new HDInsightDayOfWeek(item.GetString()));
                    }
                    days = array;
                    continue;
                }
                if (property.NameEquals("timeAndCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeAndCapacity = HDInsightAutoScaleTimeAndCapacity.DeserializeHDInsightAutoScaleTimeAndCapacity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightAutoScaleSchedule(days ?? new ChangeTrackingList<HDInsightDayOfWeek>(), timeAndCapacity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAutoScaleSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightAutoScaleSchedule IPersistableModel<HDInsightAutoScaleSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightAutoScaleSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAutoScaleSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
