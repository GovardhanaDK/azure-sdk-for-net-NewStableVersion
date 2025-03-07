// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownDataAccountDetails))]
    public partial class DataAccountDetails : IUtf8JsonSerializable, IJsonModel<DataAccountDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataAccountDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataAccountDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataAccountDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("dataAccountType"u8);
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(SharePassword))
            {
                writer.WritePropertyName("sharePassword"u8);
                writer.WriteStringValue(SharePassword);
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

        DataAccountDetails IJsonModel<DataAccountDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataAccountDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataAccountDetails(document.RootElement, options);
        }

        internal static DataAccountDetails DeserializeDataAccountDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("dataAccountType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ManagedDisk": return ManagedDiskDetails.DeserializeManagedDiskDetails(element, options);
                    case "StorageAccount": return DataBoxStorageAccountDetails.DeserializeDataBoxStorageAccountDetails(element, options);
                }
            }
            return UnknownDataAccountDetails.DeserializeUnknownDataAccountDetails(element, options);
        }

        BinaryData IPersistableModel<DataAccountDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataAccountDetails)} does not support writing '{options.Format}' format.");
            }
        }

        DataAccountDetails IPersistableModel<DataAccountDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataAccountDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataAccountDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataAccountDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
