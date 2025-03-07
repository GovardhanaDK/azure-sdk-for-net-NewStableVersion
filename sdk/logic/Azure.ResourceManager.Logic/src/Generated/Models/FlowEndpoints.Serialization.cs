// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class FlowEndpoints : IUtf8JsonSerializable, IJsonModel<FlowEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FlowEndpoints>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FlowEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlowEndpoints)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(OutgoingIPAddresses))
            {
                writer.WritePropertyName("outgoingIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in OutgoingIPAddresses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AccessEndpointIPAddresses))
            {
                writer.WritePropertyName("accessEndpointIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AccessEndpointIPAddresses)
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

        FlowEndpoints IJsonModel<FlowEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlowEndpoints)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFlowEndpoints(document.RootElement, options);
        }

        internal static FlowEndpoints DeserializeFlowEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FlowEndpointIPAddress> outgoingIPAddresses = default;
            IList<FlowEndpointIPAddress> accessEndpointIPAddresses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outgoingIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FlowEndpointIPAddress> array = new List<FlowEndpointIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FlowEndpointIPAddress.DeserializeFlowEndpointIPAddress(item, options));
                    }
                    outgoingIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("accessEndpointIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FlowEndpointIPAddress> array = new List<FlowEndpointIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FlowEndpointIPAddress.DeserializeFlowEndpointIPAddress(item, options));
                    }
                    accessEndpointIPAddresses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FlowEndpoints(outgoingIPAddresses ?? new ChangeTrackingList<FlowEndpointIPAddress>(), accessEndpointIPAddresses ?? new ChangeTrackingList<FlowEndpointIPAddress>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FlowEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FlowEndpoints)} does not support writing '{options.Format}' format.");
            }
        }

        FlowEndpoints IPersistableModel<FlowEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlowEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFlowEndpoints(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FlowEndpoints)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FlowEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
