// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareToAzStackHciPlannedFailoverModelCustomProperties : IUtf8JsonSerializable, IJsonModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciPlannedFailoverModelCustomProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("shutdownSourceVM"u8);
            writer.WriteBooleanValue(ShutdownSourceVm);
        }

        VMwareToAzStackHciPlannedFailoverModelCustomProperties IJsonModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciPlannedFailoverModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareToAzStackHciPlannedFailoverModelCustomProperties(document.RootElement, options);
        }

        internal static VMwareToAzStackHciPlannedFailoverModelCustomProperties DeserializeVMwareToAzStackHciPlannedFailoverModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool shutdownSourceVm = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shutdownSourceVM"u8))
                {
                    shutdownSourceVm = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareToAzStackHciPlannedFailoverModelCustomProperties(instanceType, serializedAdditionalRawData, shutdownSourceVm);
        }

        BinaryData IPersistableModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciPlannedFailoverModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareToAzStackHciPlannedFailoverModelCustomProperties IPersistableModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVMwareToAzStackHciPlannedFailoverModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciPlannedFailoverModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareToAzStackHciPlannedFailoverModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
