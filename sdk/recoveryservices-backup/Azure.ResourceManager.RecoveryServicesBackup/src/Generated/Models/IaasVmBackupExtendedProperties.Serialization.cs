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
    public partial class IaasVmBackupExtendedProperties : IUtf8JsonSerializable, IJsonModel<IaasVmBackupExtendedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmBackupExtendedProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IaasVmBackupExtendedProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmBackupExtendedProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DiskExclusionProperties))
            {
                writer.WritePropertyName("diskExclusionProperties"u8);
                writer.WriteObjectValue(DiskExclusionProperties, options);
            }
            if (Optional.IsDefined(LinuxVmApplicationName))
            {
                writer.WritePropertyName("linuxVmApplicationName"u8);
                writer.WriteStringValue(LinuxVmApplicationName);
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

        IaasVmBackupExtendedProperties IJsonModel<IaasVmBackupExtendedProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmBackupExtendedProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmBackupExtendedProperties(document.RootElement, options);
        }

        internal static IaasVmBackupExtendedProperties DeserializeIaasVmBackupExtendedProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DiskExclusionProperties diskExclusionProperties = default;
            string linuxVmApplicationName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskExclusionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskExclusionProperties = DiskExclusionProperties.DeserializeDiskExclusionProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxVmApplicationName"u8))
                {
                    linuxVmApplicationName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IaasVmBackupExtendedProperties(diskExclusionProperties, linuxVmApplicationName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IaasVmBackupExtendedProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmBackupExtendedProperties)} does not support writing '{options.Format}' format.");
            }
        }

        IaasVmBackupExtendedProperties IPersistableModel<IaasVmBackupExtendedProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmBackupExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIaasVmBackupExtendedProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IaasVmBackupExtendedProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmBackupExtendedProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
