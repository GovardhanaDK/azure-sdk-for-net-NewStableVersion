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
    public partial class UdpReceiver : IUtf8JsonSerializable, IJsonModel<UdpReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UdpReceiver>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UdpReceiver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UdpReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UdpReceiver)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(Endpoint);
            if (Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteStringValue(Encoding.Value.ToString());
            }
            if (Optional.IsDefined(ReadQueueLength))
            {
                writer.WritePropertyName("readQueueLength"u8);
                writer.WriteNumberValue(ReadQueueLength.Value);
            }
            if (Optional.IsDefined(JsonArrayMapper))
            {
                writer.WritePropertyName("jsonArrayMapper"u8);
                writer.WriteObjectValue(JsonArrayMapper, options);
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

        UdpReceiver IJsonModel<UdpReceiver>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UdpReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UdpReceiver)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUdpReceiver(document.RootElement, options);
        }

        internal static UdpReceiver DeserializeUdpReceiver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpoint = default;
            StreamEncodingType? encoding = default;
            int? readQueueLength = default;
            PipelineGroupJsonArrayMapper jsonArrayMapper = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encoding = new StreamEncodingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readQueueLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readQueueLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("jsonArrayMapper"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jsonArrayMapper = PipelineGroupJsonArrayMapper.DeserializePipelineGroupJsonArrayMapper(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UdpReceiver(endpoint, encoding, readQueueLength, jsonArrayMapper, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UdpReceiver>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UdpReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UdpReceiver)} does not support writing '{options.Format}' format.");
            }
        }

        UdpReceiver IPersistableModel<UdpReceiver>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UdpReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUdpReceiver(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UdpReceiver)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UdpReceiver>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
