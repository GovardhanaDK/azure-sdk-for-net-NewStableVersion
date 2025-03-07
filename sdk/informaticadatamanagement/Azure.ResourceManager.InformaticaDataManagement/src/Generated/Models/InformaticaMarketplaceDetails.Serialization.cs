// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    public partial class InformaticaMarketplaceDetails : IUtf8JsonSerializable, IJsonModel<InformaticaMarketplaceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InformaticaMarketplaceDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InformaticaMarketplaceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaMarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaMarketplaceDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MarketplaceSubscriptionId))
            {
                writer.WritePropertyName("marketplaceSubscriptionId"u8);
                writer.WriteStringValue(MarketplaceSubscriptionId);
            }
            writer.WritePropertyName("offerDetails"u8);
            writer.WriteObjectValue(OfferDetails, options);
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

        InformaticaMarketplaceDetails IJsonModel<InformaticaMarketplaceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaMarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaMarketplaceDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInformaticaMarketplaceDetails(document.RootElement, options);
        }

        internal static InformaticaMarketplaceDetails DeserializeInformaticaMarketplaceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string marketplaceSubscriptionId = default;
            InformaticaOfferDetails offerDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplaceSubscriptionId"u8))
                {
                    marketplaceSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerDetails"u8))
                {
                    offerDetails = InformaticaOfferDetails.DeserializeInformaticaOfferDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InformaticaMarketplaceDetails(marketplaceSubscriptionId, offerDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InformaticaMarketplaceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaMarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InformaticaMarketplaceDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InformaticaMarketplaceDetails IPersistableModel<InformaticaMarketplaceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaMarketplaceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInformaticaMarketplaceDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InformaticaMarketplaceDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InformaticaMarketplaceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
