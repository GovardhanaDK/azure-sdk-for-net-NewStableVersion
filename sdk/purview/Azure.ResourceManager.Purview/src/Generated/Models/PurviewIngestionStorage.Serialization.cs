// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewIngestionStorage : IUtf8JsonSerializable, IJsonModel<PurviewIngestionStorage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurviewIngestionStorage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PurviewIngestionStorage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewIngestionStorage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewIngestionStorage)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryEndpoint))
            {
                writer.WritePropertyName("primaryEndpoint"u8);
                writer.WriteStringValue(PrimaryEndpoint);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        PurviewIngestionStorage IJsonModel<PurviewIngestionStorage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewIngestionStorage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewIngestionStorage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurviewIngestionStorage(document.RootElement, options);
        }

        internal static PurviewIngestionStorage DeserializePurviewIngestionStorage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string primaryEndpoint = default;
            PurviewPublicNetworkAccess? publicNetworkAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryEndpoint"u8))
                {
                    primaryEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PurviewPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PurviewIngestionStorage(id, primaryEndpoint, publicNetworkAccess, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurviewIngestionStorage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewIngestionStorage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PurviewIngestionStorage)} does not support writing '{options.Format}' format.");
            }
        }

        PurviewIngestionStorage IPersistableModel<PurviewIngestionStorage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewIngestionStorage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePurviewIngestionStorage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PurviewIngestionStorage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurviewIngestionStorage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
