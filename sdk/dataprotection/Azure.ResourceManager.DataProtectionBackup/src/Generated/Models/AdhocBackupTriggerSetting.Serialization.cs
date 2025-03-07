// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class AdhocBackupTriggerSetting : IUtf8JsonSerializable, IJsonModel<AdhocBackupTriggerSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdhocBackupTriggerSetting>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AdhocBackupTriggerSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupTriggerSetting)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RetentionTagOverride))
            {
                writer.WritePropertyName("retentionTagOverride"u8);
                writer.WriteStringValue(RetentionTagOverride);
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

        AdhocBackupTriggerSetting IJsonModel<AdhocBackupTriggerSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupTriggerSetting)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdhocBackupTriggerSetting(document.RootElement, options);
        }

        internal static AdhocBackupTriggerSetting DeserializeAdhocBackupTriggerSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string retentionTagOverride = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionTagOverride"u8))
                {
                    retentionTagOverride = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AdhocBackupTriggerSetting(retentionTagOverride, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdhocBackupTriggerSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupTriggerSetting)} does not support writing '{options.Format}' format.");
            }
        }

        AdhocBackupTriggerSetting IPersistableModel<AdhocBackupTriggerSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAdhocBackupTriggerSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupTriggerSetting)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdhocBackupTriggerSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
