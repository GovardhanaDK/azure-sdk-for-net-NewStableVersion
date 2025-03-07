// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchPublicIPAddressConfiguration : IUtf8JsonSerializable, IJsonModel<BatchPublicIPAddressConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchPublicIPAddressConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchPublicIPAddressConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPublicIPAddressConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Provision))
            {
                writer.WritePropertyName("provision"u8);
                writer.WriteStringValue(Provision.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(IPAddressIds))
            {
                writer.WritePropertyName("ipAddressIds"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddressIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
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

        BatchPublicIPAddressConfiguration IJsonModel<BatchPublicIPAddressConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPublicIPAddressConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchPublicIPAddressConfiguration(document.RootElement, options);
        }

        internal static BatchPublicIPAddressConfiguration DeserializeBatchPublicIPAddressConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchIPAddressProvisioningType? provision = default;
            IList<ResourceIdentifier> ipAddressIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provision = property.Value.GetString().ToBatchIPAddressProvisioningType();
                    continue;
                }
                if (property.NameEquals("ipAddressIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    ipAddressIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchPublicIPAddressConfiguration(provision, ipAddressIds ?? new ChangeTrackingList<ResourceIdentifier>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchPublicIPAddressConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchPublicIPAddressConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        BatchPublicIPAddressConfiguration IPersistableModel<BatchPublicIPAddressConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBatchPublicIPAddressConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchPublicIPAddressConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchPublicIPAddressConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
