// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    public partial class AppConfigurationStorePatch : IUtf8JsonSerializable, IJsonModel<AppConfigurationStorePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppConfigurationStorePatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppConfigurationStorePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStorePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationStorePatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(EnablePurgeProtection))
            {
                writer.WritePropertyName("enablePurgeProtection"u8);
                writer.WriteBooleanValue(EnablePurgeProtection.Value);
            }
            if (Optional.IsDefined(DataPlaneProxy))
            {
                writer.WritePropertyName("dataPlaneProxy"u8);
                writer.WriteObjectValue(DataPlaneProxy, options);
            }
            writer.WriteEndObject();
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

        AppConfigurationStorePatch IJsonModel<AppConfigurationStorePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStorePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationStorePatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppConfigurationStorePatch(document.RootElement, options);
        }

        internal static AppConfigurationStorePatch DeserializeAppConfigurationStorePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            AppConfigurationSku sku = default;
            IDictionary<string, string> tags = default;
            AppConfigurationStoreEncryptionProperties encryption = default;
            bool? disableLocalAuth = default;
            AppConfigurationPublicNetworkAccess? publicNetworkAccess = default;
            bool? enablePurgeProtection = default;
            AppConfigurationDataPlaneProxyProperties dataPlaneProxy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = AppConfigurationSku.DeserializeAppConfigurationSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = AppConfigurationStoreEncryptionProperties.DeserializeAppConfigurationStoreEncryptionProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new AppConfigurationPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enablePurgeProtection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePurgeProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataPlaneProxy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataPlaneProxy = AppConfigurationDataPlaneProxyProperties.DeserializeAppConfigurationDataPlaneProxyProperties(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppConfigurationStorePatch(
                identity,
                sku,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                encryption,
                disableLocalAuth,
                publicNetworkAccess,
                enablePurgeProtection,
                dataPlaneProxy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppConfigurationStorePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStorePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationStorePatch)} does not support writing '{options.Format}' format.");
            }
        }

        AppConfigurationStorePatch IPersistableModel<AppConfigurationStorePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStorePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppConfigurationStorePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationStorePatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppConfigurationStorePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
