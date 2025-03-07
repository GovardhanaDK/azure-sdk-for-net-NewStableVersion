// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesRoleCompute : IUtf8JsonSerializable, IJsonModel<EdgeKubernetesRoleCompute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeKubernetesRoleCompute>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeKubernetesRoleCompute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleCompute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRoleCompute)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("vmProfile"u8);
            writer.WriteStringValue(VmProfile);
            if (options.Format != "W" && Optional.IsDefined(MemoryInBytes))
            {
                writer.WritePropertyName("memoryInBytes"u8);
                writer.WriteNumberValue(MemoryInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProcessorCount))
            {
                writer.WritePropertyName("processorCount"u8);
                writer.WriteNumberValue(ProcessorCount.Value);
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

        EdgeKubernetesRoleCompute IJsonModel<EdgeKubernetesRoleCompute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleCompute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesRoleCompute)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeKubernetesRoleCompute(document.RootElement, options);
        }

        internal static EdgeKubernetesRoleCompute DeserializeEdgeKubernetesRoleCompute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmProfile = default;
            long? memoryInBytes = default;
            int? processorCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmProfile"u8))
                {
                    vmProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("processorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdgeKubernetesRoleCompute(vmProfile, memoryInBytes, processorCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeKubernetesRoleCompute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleCompute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRoleCompute)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeKubernetesRoleCompute IPersistableModel<EdgeKubernetesRoleCompute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesRoleCompute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdgeKubernetesRoleCompute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesRoleCompute)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeKubernetesRoleCompute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
