// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class StorageApplianceEnableRemoteVendorManagementContent : IUtf8JsonSerializable, IJsonModel<StorageApplianceEnableRemoteVendorManagementContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageApplianceEnableRemoteVendorManagementContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageApplianceEnableRemoteVendorManagementContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceEnableRemoteVendorManagementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageApplianceEnableRemoteVendorManagementContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(SupportEndpoints))
            {
                writer.WritePropertyName("supportEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in SupportEndpoints)
                {
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

        StorageApplianceEnableRemoteVendorManagementContent IJsonModel<StorageApplianceEnableRemoteVendorManagementContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceEnableRemoteVendorManagementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageApplianceEnableRemoteVendorManagementContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageApplianceEnableRemoteVendorManagementContent(document.RootElement, options);
        }

        internal static StorageApplianceEnableRemoteVendorManagementContent DeserializeStorageApplianceEnableRemoteVendorManagementContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> supportEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportEndpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageApplianceEnableRemoteVendorManagementContent(supportEndpoints ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageApplianceEnableRemoteVendorManagementContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceEnableRemoteVendorManagementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageApplianceEnableRemoteVendorManagementContent)} does not support writing '{options.Format}' format.");
            }
        }

        StorageApplianceEnableRemoteVendorManagementContent IPersistableModel<StorageApplianceEnableRemoteVendorManagementContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceEnableRemoteVendorManagementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageApplianceEnableRemoteVendorManagementContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageApplianceEnableRemoteVendorManagementContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageApplianceEnableRemoteVendorManagementContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
