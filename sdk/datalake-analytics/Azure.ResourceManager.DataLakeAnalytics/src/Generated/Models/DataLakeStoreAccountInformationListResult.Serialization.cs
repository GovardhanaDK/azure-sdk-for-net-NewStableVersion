// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    internal partial class DataLakeStoreAccountInformationListResult : IUtf8JsonSerializable, IJsonModel<DataLakeStoreAccountInformationListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeStoreAccountInformationListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataLakeStoreAccountInformationListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountInformationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountInformationListResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        DataLakeStoreAccountInformationListResult IJsonModel<DataLakeStoreAccountInformationListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountInformationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountInformationListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountInformationListResult(document.RootElement, options);
        }

        internal static DataLakeStoreAccountInformationListResult DeserializeDataLakeStoreAccountInformationListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataLakeStoreAccountInformationData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataLakeStoreAccountInformationData> array = new List<DataLakeStoreAccountInformationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataLakeStoreAccountInformationListResult(value ?? new ChangeTrackingList<DataLakeStoreAccountInformationData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeStoreAccountInformationListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountInformationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountInformationListResult)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeStoreAccountInformationListResult IPersistableModel<DataLakeStoreAccountInformationListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountInformationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataLakeStoreAccountInformationListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountInformationListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeStoreAccountInformationListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
