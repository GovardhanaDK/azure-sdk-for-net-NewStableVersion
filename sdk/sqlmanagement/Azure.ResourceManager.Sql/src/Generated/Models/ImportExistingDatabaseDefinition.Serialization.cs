// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ImportExistingDatabaseDefinition : IUtf8JsonSerializable, IJsonModel<ImportExistingDatabaseDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportExistingDatabaseDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ImportExistingDatabaseDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportExistingDatabaseDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportExistingDatabaseDefinition)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("storageKeyType"u8);
            writer.WriteStringValue(StorageKeyType.ToString());
            writer.WritePropertyName("storageKey"u8);
            writer.WriteStringValue(StorageKey);
            writer.WritePropertyName("storageUri"u8);
            writer.WriteStringValue(StorageUri.AbsoluteUri);
            writer.WritePropertyName("administratorLogin"u8);
            writer.WriteStringValue(AdministratorLogin);
            writer.WritePropertyName("administratorLoginPassword"u8);
            writer.WriteStringValue(AdministratorLoginPassword);
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType);
            }
            if (Optional.IsDefined(NetworkIsolation))
            {
                writer.WritePropertyName("networkIsolation"u8);
                writer.WriteObjectValue(NetworkIsolation, options);
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

        ImportExistingDatabaseDefinition IJsonModel<ImportExistingDatabaseDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportExistingDatabaseDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportExistingDatabaseDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportExistingDatabaseDefinition(document.RootElement, options);
        }

        internal static ImportExistingDatabaseDefinition DeserializeImportExistingDatabaseDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageKeyType storageKeyType = default;
            string storageKey = default;
            Uri storageUri = default;
            string administratorLogin = default;
            string administratorLoginPassword = default;
            string authenticationType = default;
            NetworkIsolationSettings networkIsolation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageKeyType"u8))
                {
                    storageKeyType = new StorageKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageKey"u8))
                {
                    storageKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageUri"u8))
                {
                    storageUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("administratorLogin"u8))
                {
                    administratorLogin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("administratorLoginPassword"u8))
                {
                    administratorLoginPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkIsolation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkIsolation = NetworkIsolationSettings.DeserializeNetworkIsolationSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ImportExistingDatabaseDefinition(
                storageKeyType,
                storageKey,
                storageUri,
                administratorLogin,
                administratorLoginPassword,
                authenticationType,
                networkIsolation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportExistingDatabaseDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportExistingDatabaseDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImportExistingDatabaseDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        ImportExistingDatabaseDefinition IPersistableModel<ImportExistingDatabaseDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportExistingDatabaseDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeImportExistingDatabaseDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImportExistingDatabaseDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImportExistingDatabaseDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
