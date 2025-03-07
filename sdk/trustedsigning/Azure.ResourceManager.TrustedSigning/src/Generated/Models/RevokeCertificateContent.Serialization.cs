// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.TrustedSigning.Models
{
    public partial class RevokeCertificateContent : IUtf8JsonSerializable, IJsonModel<RevokeCertificateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RevokeCertificateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RevokeCertificateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RevokeCertificateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RevokeCertificateContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("serialNumber"u8);
            writer.WriteStringValue(SerialNumber);
            writer.WritePropertyName("thumbprint"u8);
            writer.WriteStringValue(Thumbprint);
            writer.WritePropertyName("effectiveAt"u8);
            writer.WriteStringValue(EffectiveOn, "O");
            writer.WritePropertyName("reason"u8);
            writer.WriteStringValue(Reason);
            if (Optional.IsDefined(Remarks))
            {
                writer.WritePropertyName("remarks"u8);
                writer.WriteStringValue(Remarks);
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

        RevokeCertificateContent IJsonModel<RevokeCertificateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RevokeCertificateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RevokeCertificateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRevokeCertificateContent(document.RootElement, options);
        }

        internal static RevokeCertificateContent DeserializeRevokeCertificateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serialNumber = default;
            string thumbprint = default;
            DateTimeOffset effectiveAt = default;
            string reason = default;
            string remarks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveAt"u8))
                {
                    effectiveAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remarks"u8))
                {
                    remarks = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RevokeCertificateContent(
                serialNumber,
                thumbprint,
                effectiveAt,
                reason,
                remarks,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RevokeCertificateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RevokeCertificateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RevokeCertificateContent)} does not support writing '{options.Format}' format.");
            }
        }

        RevokeCertificateContent IPersistableModel<RevokeCertificateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RevokeCertificateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRevokeCertificateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RevokeCertificateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RevokeCertificateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
