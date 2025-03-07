// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StandbyPool.Models
{
    public partial class StandbyContainerGroupPoolRuntimeViewProperties : IUtf8JsonSerializable, IJsonModel<StandbyContainerGroupPoolRuntimeViewProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StandbyContainerGroupPoolRuntimeViewProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StandbyContainerGroupPoolRuntimeViewProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolRuntimeViewProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyContainerGroupPoolRuntimeViewProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("instanceCountSummary"u8);
                writer.WriteStartArray();
                foreach (var item in InstanceCountSummary)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        StandbyContainerGroupPoolRuntimeViewProperties IJsonModel<StandbyContainerGroupPoolRuntimeViewProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolRuntimeViewProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyContainerGroupPoolRuntimeViewProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStandbyContainerGroupPoolRuntimeViewProperties(document.RootElement, options);
        }

        internal static StandbyContainerGroupPoolRuntimeViewProperties DeserializeStandbyContainerGroupPoolRuntimeViewProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerGroupInstanceCountSummary> instanceCountSummary = default;
            StandbyProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceCountSummary"u8))
                {
                    List<ContainerGroupInstanceCountSummary> array = new List<ContainerGroupInstanceCountSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerGroupInstanceCountSummary.DeserializeContainerGroupInstanceCountSummary(item, options));
                    }
                    instanceCountSummary = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new StandbyProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StandbyContainerGroupPoolRuntimeViewProperties(instanceCountSummary, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StandbyContainerGroupPoolRuntimeViewProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolRuntimeViewProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StandbyContainerGroupPoolRuntimeViewProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StandbyContainerGroupPoolRuntimeViewProperties IPersistableModel<StandbyContainerGroupPoolRuntimeViewProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolRuntimeViewProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStandbyContainerGroupPoolRuntimeViewProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StandbyContainerGroupPoolRuntimeViewProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StandbyContainerGroupPoolRuntimeViewProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
