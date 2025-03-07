// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ChaosTargetQuerySelector : IUtf8JsonSerializable, IJsonModel<ChaosTargetQuerySelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosTargetQuerySelector>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChaosTargetQuerySelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetQuerySelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetQuerySelector)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("queryString"u8);
            writer.WriteStringValue(QueryString);
            writer.WritePropertyName("subscriptionIds"u8);
            writer.WriteStartArray();
            foreach (var item in SubscriptionIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        ChaosTargetQuerySelector IJsonModel<ChaosTargetQuerySelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetQuerySelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetQuerySelector)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosTargetQuerySelector(document.RootElement, options);
        }

        internal static ChaosTargetQuerySelector DeserializeChaosTargetQuerySelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queryString = default;
            IList<string> subscriptionIds = default;
            SelectorType type = default;
            string id = default;
            ChaosTargetFilter filter = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryString"u8))
                {
                    queryString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionIds"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subscriptionIds = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SelectorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = ChaosTargetFilter.DeserializeChaosTargetFilter(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ChaosTargetQuerySelector(
                type,
                id,
                filter,
                additionalProperties,
                queryString,
                subscriptionIds);
        }

        BinaryData IPersistableModel<ChaosTargetQuerySelector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetQuerySelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetQuerySelector)} does not support writing '{options.Format}' format.");
            }
        }

        ChaosTargetQuerySelector IPersistableModel<ChaosTargetQuerySelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetQuerySelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeChaosTargetQuerySelector(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetQuerySelector)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosTargetQuerySelector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
