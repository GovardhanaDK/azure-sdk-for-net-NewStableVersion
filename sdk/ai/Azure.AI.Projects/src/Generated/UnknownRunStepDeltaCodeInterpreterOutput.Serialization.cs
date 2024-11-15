// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    internal partial class UnknownRunStepDeltaCodeInterpreterOutput : IUtf8JsonSerializable, IJsonModel<RunStepDeltaCodeInterpreterOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunStepDeltaCodeInterpreterOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RunStepDeltaCodeInterpreterOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepDeltaCodeInterpreterOutput)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        RunStepDeltaCodeInterpreterOutput IJsonModel<RunStepDeltaCodeInterpreterOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepDeltaCodeInterpreterOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepDeltaCodeInterpreterOutput(document.RootElement, options);
        }

        internal static UnknownRunStepDeltaCodeInterpreterOutput DeserializeUnknownRunStepDeltaCodeInterpreterOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int index = default;
            string type = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownRunStepDeltaCodeInterpreterOutput(index, type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunStepDeltaCodeInterpreterOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStepDeltaCodeInterpreterOutput)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepDeltaCodeInterpreterOutput IPersistableModel<RunStepDeltaCodeInterpreterOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaCodeInterpreterOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunStepDeltaCodeInterpreterOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepDeltaCodeInterpreterOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepDeltaCodeInterpreterOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownRunStepDeltaCodeInterpreterOutput FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownRunStepDeltaCodeInterpreterOutput(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<RunStepDeltaCodeInterpreterOutput>(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
