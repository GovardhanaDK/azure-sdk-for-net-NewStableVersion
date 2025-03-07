// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class WeightedAllocationWorkerSelectorAttachment : IUtf8JsonSerializable, IJsonModel<WeightedAllocationWorkerSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WeightedAllocationWorkerSelectorAttachment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WeightedAllocationWorkerSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeightedAllocationWorkerSelectorAttachment)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("allocations"u8);
            writer.WriteStartArray();
            foreach (var item in Allocations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
        }

        WeightedAllocationWorkerSelectorAttachment IJsonModel<WeightedAllocationWorkerSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeightedAllocationWorkerSelectorAttachment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWeightedAllocationWorkerSelectorAttachment(document.RootElement, options);
        }

        internal static WeightedAllocationWorkerSelectorAttachment DeserializeWeightedAllocationWorkerSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<WorkerWeightedAllocation> allocations = default;
            WorkerSelectorAttachmentKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocations"u8))
                {
                    List<WorkerWeightedAllocation> array = new List<WorkerWeightedAllocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerWeightedAllocation.DeserializeWorkerWeightedAllocation(item, options));
                    }
                    allocations = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new WorkerSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WeightedAllocationWorkerSelectorAttachment(kind, serializedAdditionalRawData, allocations);
        }

        BinaryData IPersistableModel<WeightedAllocationWorkerSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WeightedAllocationWorkerSelectorAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        WeightedAllocationWorkerSelectorAttachment IPersistableModel<WeightedAllocationWorkerSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWeightedAllocationWorkerSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WeightedAllocationWorkerSelectorAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WeightedAllocationWorkerSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WeightedAllocationWorkerSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeWeightedAllocationWorkerSelectorAttachment(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
