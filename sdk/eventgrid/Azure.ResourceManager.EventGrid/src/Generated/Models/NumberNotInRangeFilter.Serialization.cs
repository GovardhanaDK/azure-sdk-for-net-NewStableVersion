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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class NumberNotInRangeFilter : IUtf8JsonSerializable, IJsonModel<NumberNotInRangeFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NumberNotInRangeFilter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NumberNotInRangeFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumberNotInRangeFilter)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteNumberValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
        }

        NumberNotInRangeFilter IJsonModel<NumberNotInRangeFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumberNotInRangeFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNumberNotInRangeFilter(document.RootElement, options);
        }

        internal static NumberNotInRangeFilter DeserializeNumberNotInRangeFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IList<double>> values = default;
            FilterOperatorType operatorType = default;
            string key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<double>> array = new List<IList<double>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<double> array0 = new List<double>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetDouble());
                            }
                            array.Add(array0);
                        }
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new FilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NumberNotInRangeFilter(operatorType, key, serializedAdditionalRawData, values ?? new ChangeTrackingList<IList<double>>());
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Values), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  values: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Values))
                {
                    if (Values.Any())
                    {
                        builder.Append("  values: ");
                        builder.AppendLine("[");
                        foreach (var item in Values)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item)
                            {
                                builder.AppendLine($"    '{item0.ToString()}'");
                            }
                            builder.AppendLine("  ]");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OperatorType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  operatorType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  operatorType: ");
                builder.AppendLine($"'{OperatorType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Key), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  key: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Key))
                {
                    builder.Append("  key: ");
                    if (Key.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Key}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Key}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NumberNotInRangeFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NumberNotInRangeFilter)} does not support writing '{options.Format}' format.");
            }
        }

        NumberNotInRangeFilter IPersistableModel<NumberNotInRangeFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNumberNotInRangeFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NumberNotInRangeFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NumberNotInRangeFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
