// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint> array = new List<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint.DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult(value ?? new ChangeTrackingList<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
