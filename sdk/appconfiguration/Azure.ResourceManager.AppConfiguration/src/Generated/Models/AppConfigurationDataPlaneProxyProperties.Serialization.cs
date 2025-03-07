// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    public partial class AppConfigurationDataPlaneProxyProperties : IUtf8JsonSerializable, IJsonModel<AppConfigurationDataPlaneProxyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppConfigurationDataPlaneProxyProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppConfigurationDataPlaneProxyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationDataPlaneProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationDataPlaneProxyProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkDelegation))
            {
                writer.WritePropertyName("privateLinkDelegation"u8);
                writer.WriteStringValue(PrivateLinkDelegation.Value.ToString());
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

        AppConfigurationDataPlaneProxyProperties IJsonModel<AppConfigurationDataPlaneProxyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationDataPlaneProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationDataPlaneProxyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppConfigurationDataPlaneProxyProperties(document.RootElement, options);
        }

        internal static AppConfigurationDataPlaneProxyProperties DeserializeAppConfigurationDataPlaneProxyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataPlaneProxyAuthenticationMode? authenticationMode = default;
            DataPlaneProxyPrivateLinkDelegation? privateLinkDelegation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMode = new DataPlaneProxyAuthenticationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateLinkDelegation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkDelegation = new DataPlaneProxyPrivateLinkDelegation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppConfigurationDataPlaneProxyProperties(authenticationMode, privateLinkDelegation, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthenticationMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authenticationMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AuthenticationMode))
                {
                    builder.Append("  authenticationMode: ");
                    builder.AppendLine($"'{AuthenticationMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateLinkDelegation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  privateLinkDelegation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateLinkDelegation))
                {
                    builder.Append("  privateLinkDelegation: ");
                    builder.AppendLine($"'{PrivateLinkDelegation.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppConfigurationDataPlaneProxyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationDataPlaneProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationDataPlaneProxyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppConfigurationDataPlaneProxyProperties IPersistableModel<AppConfigurationDataPlaneProxyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationDataPlaneProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppConfigurationDataPlaneProxyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationDataPlaneProxyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppConfigurationDataPlaneProxyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
