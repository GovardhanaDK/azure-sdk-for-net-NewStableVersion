// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TeradataImportCommand : IUtf8JsonSerializable, IJsonModel<TeradataImportCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TeradataImportCommand>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TeradataImportCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeradataImportCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TeradataImportCommand)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(AdditionalFormatOptions))
            {
                writer.WritePropertyName("additionalFormatOptions"u8);
                JsonSerializer.Serialize(writer, AdditionalFormatOptions);
            }
            foreach (var item in AdditionalProperties)
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

        TeradataImportCommand IJsonModel<TeradataImportCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeradataImportCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TeradataImportCommand)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTeradataImportCommand(document.RootElement, options);
        }

        internal static TeradataImportCommand DeserializeTeradataImportCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<IDictionary<string, string>> additionalFormatOptions = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalFormatOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalFormatOptions = JsonSerializer.Deserialize<DataFactoryElement<IDictionary<string, string>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TeradataImportCommand(type, additionalProperties, additionalFormatOptions);
        }

        BinaryData IPersistableModel<TeradataImportCommand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeradataImportCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TeradataImportCommand)} does not support writing '{options.Format}' format.");
            }
        }

        TeradataImportCommand IPersistableModel<TeradataImportCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeradataImportCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTeradataImportCommand(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TeradataImportCommand)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TeradataImportCommand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
