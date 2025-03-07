// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryRecurrenceScheduleOccurrence : IUtf8JsonSerializable, IJsonModel<DataFactoryRecurrenceScheduleOccurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryRecurrenceScheduleOccurrence>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryRecurrenceScheduleOccurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryRecurrenceScheduleOccurrence)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Day))
            {
                writer.WritePropertyName("day"u8);
                writer.WriteStringValue(Day.Value.ToSerialString());
            }
            if (Optional.IsDefined(Occurrence))
            {
                writer.WritePropertyName("occurrence"u8);
                writer.WriteNumberValue(Occurrence.Value);
            }
            foreach (var item in AdditionalProperties)
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

        DataFactoryRecurrenceScheduleOccurrence IJsonModel<DataFactoryRecurrenceScheduleOccurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryRecurrenceScheduleOccurrence)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryRecurrenceScheduleOccurrence(document.RootElement, options);
        }

        internal static DataFactoryRecurrenceScheduleOccurrence DeserializeDataFactoryRecurrenceScheduleOccurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryDayOfWeek? day = default;
            int? occurrence = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("day"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    day = property.Value.GetString().ToDataFactoryDayOfWeek();
                    continue;
                }
                if (property.NameEquals("occurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    occurrence = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryRecurrenceScheduleOccurrence(day, occurrence, additionalProperties);
        }

        BinaryData IPersistableModel<DataFactoryRecurrenceScheduleOccurrence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryRecurrenceScheduleOccurrence)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryRecurrenceScheduleOccurrence IPersistableModel<DataFactoryRecurrenceScheduleOccurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataFactoryRecurrenceScheduleOccurrence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryRecurrenceScheduleOccurrence)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryRecurrenceScheduleOccurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
