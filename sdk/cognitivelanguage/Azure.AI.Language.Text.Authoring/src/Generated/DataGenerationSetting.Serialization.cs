// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class DataGenerationSetting : IUtf8JsonSerializable, IJsonModel<DataGenerationSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataGenerationSetting>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataGenerationSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataGenerationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataGenerationSetting)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("enableDataGeneration"u8);
            writer.WriteBooleanValue(EnableDataGeneration);
            writer.WritePropertyName("dataGenerationConnectionInfo"u8);
            writer.WriteObjectValue(DataGenerationConnectionInfo, options);
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

        DataGenerationSetting IJsonModel<DataGenerationSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataGenerationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataGenerationSetting)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataGenerationSetting(document.RootElement, options);
        }

        internal static DataGenerationSetting DeserializeDataGenerationSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enableDataGeneration = default;
            DataGenerationConnectionInfo dataGenerationConnectionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDataGeneration"u8))
                {
                    enableDataGeneration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataGenerationConnectionInfo"u8))
                {
                    dataGenerationConnectionInfo = DataGenerationConnectionInfo.DeserializeDataGenerationConnectionInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataGenerationSetting(enableDataGeneration, dataGenerationConnectionInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataGenerationSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataGenerationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataGenerationSetting)} does not support writing '{options.Format}' format.");
            }
        }

        DataGenerationSetting IPersistableModel<DataGenerationSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataGenerationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataGenerationSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataGenerationSetting)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataGenerationSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataGenerationSetting FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDataGenerationSetting(document.RootElement);
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
