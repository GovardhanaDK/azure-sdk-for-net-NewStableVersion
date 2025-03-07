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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryRegistrationConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OpenIdIssuer))
            {
                writer.WritePropertyName("openIdIssuer"u8);
                writer.WriteStringValue(OpenIdIssuer);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName"u8);
                writer.WriteStringValue(ClientSecretSettingName);
            }
            if (Optional.IsDefined(ClientSecretCertificateThumbprint))
            {
                writer.WritePropertyName("clientSecretCertificateThumbprint"u8);
                writer.WriteStringValue(ClientSecretCertificateThumbprint);
            }
            if (Optional.IsDefined(ClientSecretCertificateSubjectAlternativeName))
            {
                writer.WritePropertyName("clientSecretCertificateSubjectAlternativeName"u8);
                writer.WriteStringValue(ClientSecretCertificateSubjectAlternativeName);
            }
            if (Optional.IsDefined(ClientSecretCertificateIssuer))
            {
                writer.WritePropertyName("clientSecretCertificateIssuer"u8);
                writer.WriteStringValue(ClientSecretCertificateIssuer);
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

        ContainerAppAzureActiveDirectoryRegistrationConfiguration IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(document.RootElement, options);
        }

        internal static ContainerAppAzureActiveDirectoryRegistrationConfiguration DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string openIdIssuer = default;
            string clientId = default;
            string clientSecretSettingName = default;
            string clientSecretCertificateThumbprint = default;
            string clientSecretCertificateSubjectAlternativeName = default;
            string clientSecretCertificateIssuer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("openIdIssuer"u8))
                {
                    openIdIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"u8))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateThumbprint"u8))
                {
                    clientSecretCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateSubjectAlternativeName"u8))
                {
                    clientSecretCertificateSubjectAlternativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateIssuer"u8))
                {
                    clientSecretCertificateIssuer = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppAzureActiveDirectoryRegistrationConfiguration(
                openIdIssuer,
                clientId,
                clientSecretSettingName,
                clientSecretCertificateThumbprint,
                clientSecretCertificateSubjectAlternativeName,
                clientSecretCertificateIssuer,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OpenIdIssuer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  openIdIssuer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OpenIdIssuer))
                {
                    builder.Append("  openIdIssuer: ");
                    if (OpenIdIssuer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OpenIdIssuer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OpenIdIssuer}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientId))
                {
                    builder.Append("  clientId: ");
                    if (ClientId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientSecretSettingName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientSecretSettingName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientSecretSettingName))
                {
                    builder.Append("  clientSecretSettingName: ");
                    if (ClientSecretSettingName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientSecretSettingName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientSecretSettingName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientSecretCertificateThumbprint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientSecretCertificateThumbprint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientSecretCertificateThumbprint))
                {
                    builder.Append("  clientSecretCertificateThumbprint: ");
                    if (ClientSecretCertificateThumbprint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientSecretCertificateThumbprint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientSecretCertificateThumbprint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientSecretCertificateSubjectAlternativeName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientSecretCertificateSubjectAlternativeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientSecretCertificateSubjectAlternativeName))
                {
                    builder.Append("  clientSecretCertificateSubjectAlternativeName: ");
                    if (ClientSecretCertificateSubjectAlternativeName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientSecretCertificateSubjectAlternativeName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientSecretCertificateSubjectAlternativeName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientSecretCertificateIssuer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientSecretCertificateIssuer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientSecretCertificateIssuer))
                {
                    builder.Append("  clientSecretCertificateIssuer: ");
                    if (ClientSecretCertificateIssuer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientSecretCertificateIssuer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientSecretCertificateIssuer}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppAzureActiveDirectoryRegistrationConfiguration IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
