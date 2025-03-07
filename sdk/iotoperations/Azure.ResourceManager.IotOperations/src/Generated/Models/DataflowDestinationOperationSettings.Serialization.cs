// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class DataflowDestinationOperationSettings : IUtf8JsonSerializable, IJsonModel<DataflowDestinationOperationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowDestinationOperationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowDestinationOperationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowDestinationOperationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowDestinationOperationSettings)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("endpointRef"u8);
            writer.WriteStringValue(EndpointRef);
            writer.WritePropertyName("dataDestination"u8);
            writer.WriteStringValue(DataDestination);
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

        DataflowDestinationOperationSettings IJsonModel<DataflowDestinationOperationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowDestinationOperationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowDestinationOperationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowDestinationOperationSettings(document.RootElement, options);
        }

        internal static DataflowDestinationOperationSettings DeserializeDataflowDestinationOperationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpointRef = default;
            string dataDestination = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointRef"u8))
                {
                    endpointRef = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDestination"u8))
                {
                    dataDestination = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowDestinationOperationSettings(endpointRef, dataDestination, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowDestinationOperationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowDestinationOperationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowDestinationOperationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowDestinationOperationSettings IPersistableModel<DataflowDestinationOperationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowDestinationOperationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataflowDestinationOperationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowDestinationOperationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowDestinationOperationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
