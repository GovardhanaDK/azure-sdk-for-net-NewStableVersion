// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    [PersistableModelProxy(typeof(UnknownConfigurationGroupValuePropertiesFormat))]
    public partial class ConfigurationGroupValuePropertiesFormat : IUtf8JsonSerializable, IJsonModel<ConfigurationGroupValuePropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationGroupValuePropertiesFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfigurationGroupValuePropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherScope))
            {
                writer.WritePropertyName("publisherScope"u8);
                writer.WriteStringValue(PublisherScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaName))
            {
                writer.WritePropertyName("configurationGroupSchemaName"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaName);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaOfferingLocation))
            {
                writer.WritePropertyName("configurationGroupSchemaOfferingLocation"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaOfferingLocation);
            }
            if (Optional.IsDefined(ConfigurationGroupSchemaResourceReference))
            {
                writer.WritePropertyName("configurationGroupSchemaResourceReference"u8);
                writer.WriteObjectValue(ConfigurationGroupSchemaResourceReference, options);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        ConfigurationGroupValuePropertiesFormat IJsonModel<ConfigurationGroupValuePropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
        }

        internal static ConfigurationGroupValuePropertiesFormat DeserializeConfigurationGroupValuePropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("configurationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Open": return ConfigurationValueWithoutSecrets.DeserializeConfigurationValueWithoutSecrets(element, options);
                    case "Secret": return ConfigurationValueWithSecrets.DeserializeConfigurationValueWithSecrets(element, options);
                }
            }
            return UnknownConfigurationGroupValuePropertiesFormat.DeserializeUnknownConfigurationGroupValuePropertiesFormat(element, options);
        }

        BinaryData IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigurationGroupValuePropertiesFormat IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationGroupValuePropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
