// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    internal partial class InternalCodeInterpreterToolCallDetails : IUtf8JsonSerializable, IJsonModel<InternalCodeInterpreterToolCallDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternalCodeInterpreterToolCallDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InternalCodeInterpreterToolCallDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("input"u8);
            writer.WriteStringValue(Input);
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        InternalCodeInterpreterToolCallDetails IJsonModel<InternalCodeInterpreterToolCallDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCodeInterpreterToolCallDetails(document.RootElement, options);
        }

        internal static InternalCodeInterpreterToolCallDetails DeserializeInternalCodeInterpreterToolCallDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string input = default;
            IReadOnlyList<RunStepCodeInterpreterToolCallOutput> outputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    input = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<RunStepCodeInterpreterToolCallOutput> array = new List<RunStepCodeInterpreterToolCallOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunStepCodeInterpreterToolCallOutput.DeserializeRunStepCodeInterpreterToolCallOutput(item, options));
                    }
                    outputs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalCodeInterpreterToolCallDetails(input, outputs, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalCodeInterpreterToolCallDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCodeInterpreterToolCallDetails IPersistableModel<InternalCodeInterpreterToolCallDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInternalCodeInterpreterToolCallDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterToolCallDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCodeInterpreterToolCallDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static InternalCodeInterpreterToolCallDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeInternalCodeInterpreterToolCallDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
