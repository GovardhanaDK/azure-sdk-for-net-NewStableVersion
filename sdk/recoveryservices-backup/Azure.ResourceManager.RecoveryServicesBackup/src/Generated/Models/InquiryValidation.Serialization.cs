// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class InquiryValidation : IUtf8JsonSerializable, IJsonModel<InquiryValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InquiryValidation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InquiryValidation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InquiryValidation)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(ErrorDetail))
            {
                writer.WritePropertyName("errorDetail"u8);
                writer.WriteObjectValue(ErrorDetail, options);
            }
            if (options.Format != "W" && Optional.IsDefined(AdditionalDetail))
            {
                writer.WritePropertyName("additionalDetail"u8);
                writer.WriteStringValue(AdditionalDetail);
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectableItemCount))
            {
                writer.WritePropertyName("protectableItemCount"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectableItemCount);
#else
                using (JsonDocument document = JsonDocument.Parse(ProtectableItemCount, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        InquiryValidation IJsonModel<InquiryValidation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InquiryValidation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInquiryValidation(document.RootElement, options);
        }

        internal static InquiryValidation DeserializeInquiryValidation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            BackupErrorDetail errorDetail = default;
            string additionalDetail = default;
            BinaryData protectableItemCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorDetail = BackupErrorDetail.DeserializeBackupErrorDetail(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalDetail"u8))
                {
                    additionalDetail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectableItemCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InquiryValidation(status, errorDetail, additionalDetail, protectableItemCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InquiryValidation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InquiryValidation)} does not support writing '{options.Format}' format.");
            }
        }

        InquiryValidation IPersistableModel<InquiryValidation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInquiryValidation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InquiryValidation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InquiryValidation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
