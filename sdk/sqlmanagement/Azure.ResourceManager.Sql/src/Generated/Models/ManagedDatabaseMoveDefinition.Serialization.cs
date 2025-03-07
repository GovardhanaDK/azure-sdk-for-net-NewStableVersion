// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedDatabaseMoveDefinition : IUtf8JsonSerializable, IJsonModel<ManagedDatabaseMoveDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedDatabaseMoveDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedDatabaseMoveDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseMoveDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDatabaseMoveDefinition)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("destinationManagedDatabaseId"u8);
            writer.WriteStringValue(DestinationManagedDatabaseId);
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

        ManagedDatabaseMoveDefinition IJsonModel<ManagedDatabaseMoveDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseMoveDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDatabaseMoveDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedDatabaseMoveDefinition(document.RootElement, options);
        }

        internal static ManagedDatabaseMoveDefinition DeserializeManagedDatabaseMoveDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier destinationManagedDatabaseId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationManagedDatabaseId"u8))
                {
                    destinationManagedDatabaseId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedDatabaseMoveDefinition(destinationManagedDatabaseId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedDatabaseMoveDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseMoveDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedDatabaseMoveDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedDatabaseMoveDefinition IPersistableModel<ManagedDatabaseMoveDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseMoveDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedDatabaseMoveDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedDatabaseMoveDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedDatabaseMoveDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
