// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ClusterContinueUpdateVersionContent : IUtf8JsonSerializable, IJsonModel<ClusterContinueUpdateVersionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterContinueUpdateVersionContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterContinueUpdateVersionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterContinueUpdateVersionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterContinueUpdateVersionContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MachineGroupTargetingMode))
            {
                writer.WritePropertyName("machineGroupTargetingMode"u8);
                writer.WriteStringValue(MachineGroupTargetingMode.Value.ToString());
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

        ClusterContinueUpdateVersionContent IJsonModel<ClusterContinueUpdateVersionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterContinueUpdateVersionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterContinueUpdateVersionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterContinueUpdateVersionContent(document.RootElement, options);
        }

        internal static ClusterContinueUpdateVersionContent DeserializeClusterContinueUpdateVersionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClusterContinueUpdateVersionMachineGroupTargetingMode? machineGroupTargetingMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("machineGroupTargetingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    machineGroupTargetingMode = new ClusterContinueUpdateVersionMachineGroupTargetingMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterContinueUpdateVersionContent(machineGroupTargetingMode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterContinueUpdateVersionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterContinueUpdateVersionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterContinueUpdateVersionContent)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterContinueUpdateVersionContent IPersistableModel<ClusterContinueUpdateVersionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterContinueUpdateVersionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClusterContinueUpdateVersionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterContinueUpdateVersionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterContinueUpdateVersionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
