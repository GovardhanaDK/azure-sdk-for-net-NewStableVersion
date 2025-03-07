// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class QuotaTicketDetails : IUtf8JsonSerializable, IJsonModel<QuotaTicketDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaTicketDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<QuotaTicketDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaTicketDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaTicketDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(QuotaChangeRequestSubType))
            {
                writer.WritePropertyName("quotaChangeRequestSubType"u8);
                writer.WriteStringValue(QuotaChangeRequestSubType);
            }
            if (Optional.IsDefined(QuotaChangeRequestVersion))
            {
                writer.WritePropertyName("quotaChangeRequestVersion"u8);
                writer.WriteStringValue(QuotaChangeRequestVersion);
            }
            if (Optional.IsCollectionDefined(QuotaChangeRequests))
            {
                writer.WritePropertyName("quotaChangeRequests"u8);
                writer.WriteStartArray();
                foreach (var item in QuotaChangeRequests)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        QuotaTicketDetails IJsonModel<QuotaTicketDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaTicketDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaTicketDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaTicketDetails(document.RootElement, options);
        }

        internal static QuotaTicketDetails DeserializeQuotaTicketDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string quotaChangeRequestSubType = default;
            string quotaChangeRequestVersion = default;
            IList<SupportQuotaChangeContent> quotaChangeRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quotaChangeRequestSubType"u8))
                {
                    quotaChangeRequestSubType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaChangeRequestVersion"u8))
                {
                    quotaChangeRequestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaChangeRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SupportQuotaChangeContent> array = new List<SupportQuotaChangeContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportQuotaChangeContent.DeserializeSupportQuotaChangeContent(item, options));
                    }
                    quotaChangeRequests = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new QuotaTicketDetails(quotaChangeRequestSubType, quotaChangeRequestVersion, quotaChangeRequests ?? new ChangeTrackingList<SupportQuotaChangeContent>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaTicketDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaTicketDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaTicketDetails)} does not support writing '{options.Format}' format.");
            }
        }

        QuotaTicketDetails IPersistableModel<QuotaTicketDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaTicketDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeQuotaTicketDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaTicketDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaTicketDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
