// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class PackageCarrierInfo : IUtf8JsonSerializable, IJsonModel<PackageCarrierInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PackageCarrierInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PackageCarrierInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageCarrierInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CarrierName))
            {
                writer.WritePropertyName("carrierName"u8);
                writer.WriteStringValue(CarrierName);
            }
            if (Optional.IsDefined(TrackingId))
            {
                writer.WritePropertyName("trackingId"u8);
                writer.WriteStringValue(TrackingId);
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

        PackageCarrierInfo IJsonModel<PackageCarrierInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageCarrierInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePackageCarrierInfo(document.RootElement, options);
        }

        internal static PackageCarrierInfo DeserializePackageCarrierInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string carrierName = default;
            string trackingId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("carrierName"u8))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PackageCarrierInfo(carrierName, trackingId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PackageCarrierInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PackageCarrierInfo)} does not support writing '{options.Format}' format.");
            }
        }

        PackageCarrierInfo IPersistableModel<PackageCarrierInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePackageCarrierInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PackageCarrierInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PackageCarrierInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
