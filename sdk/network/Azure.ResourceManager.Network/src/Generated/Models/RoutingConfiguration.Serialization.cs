// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RoutingConfiguration : IUtf8JsonSerializable, IJsonModel<RoutingConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoutingConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AssociatedRouteTable))
            {
                writer.WritePropertyName("associatedRouteTable"u8);
                JsonSerializer.Serialize(writer, AssociatedRouteTable);
            }
            if (Optional.IsDefined(PropagatedRouteTables))
            {
                writer.WritePropertyName("propagatedRouteTables"u8);
                writer.WriteObjectValue(PropagatedRouteTables, options);
            }
            if (Optional.IsDefined(VnetRoutes))
            {
                writer.WritePropertyName("vnetRoutes"u8);
                writer.WriteObjectValue(VnetRoutes, options);
            }
            if (Optional.IsDefined(InboundRouteMap))
            {
                writer.WritePropertyName("inboundRouteMap"u8);
                JsonSerializer.Serialize(writer, InboundRouteMap);
            }
            if (Optional.IsDefined(OutboundRouteMap))
            {
                writer.WritePropertyName("outboundRouteMap"u8);
                JsonSerializer.Serialize(writer, OutboundRouteMap);
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

        RoutingConfiguration IJsonModel<RoutingConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingConfiguration(document.RootElement, options);
        }

        internal static RoutingConfiguration DeserializeRoutingConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource associatedRouteTable = default;
            PropagatedRouteTable propagatedRouteTables = default;
            VnetRoute vnetRoutes = default;
            WritableSubResource inboundRouteMap = default;
            WritableSubResource outboundRouteMap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("associatedRouteTable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    associatedRouteTable = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("propagatedRouteTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propagatedRouteTables = PropagatedRouteTable.DeserializePropagatedRouteTable(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vnetRoutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetRoutes = VnetRoute.DeserializeVnetRoute(property.Value, options);
                    continue;
                }
                if (property.NameEquals("inboundRouteMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inboundRouteMap = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("outboundRouteMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundRouteMap = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoutingConfiguration(
                associatedRouteTable,
                propagatedRouteTables,
                vnetRoutes,
                inboundRouteMap,
                outboundRouteMap,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoutingConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        RoutingConfiguration IPersistableModel<RoutingConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRoutingConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
