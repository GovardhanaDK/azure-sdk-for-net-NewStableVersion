// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxScheduleAvailabilityContent : IUtf8JsonSerializable, IJsonModel<DataBoxScheduleAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxScheduleAvailabilityContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxScheduleAvailabilityContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxScheduleAvailabilityContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        DataBoxScheduleAvailabilityContent IJsonModel<DataBoxScheduleAvailabilityContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxScheduleAvailabilityContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxScheduleAvailabilityContent(document.RootElement, options);
        }

        internal static DataBoxScheduleAvailabilityContent DeserializeDataBoxScheduleAvailabilityContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation storageLocation = default;
            DataBoxSkuName skuName = default;
            string country = default;
            DeviceModelName? model = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageLocation"u8))
                {
                    storageLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("skuName"u8))
                {
                    skuName = property.Value.GetString().ToDataBoxSkuName();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    model = property.Value.GetString().ToDeviceModelName();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxScheduleAvailabilityContent(storageLocation, skuName, country, model, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxScheduleAvailabilityContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxScheduleAvailabilityContent)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxScheduleAvailabilityContent IPersistableModel<DataBoxScheduleAvailabilityContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxScheduleAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataBoxScheduleAvailabilityContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxScheduleAvailabilityContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxScheduleAvailabilityContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
