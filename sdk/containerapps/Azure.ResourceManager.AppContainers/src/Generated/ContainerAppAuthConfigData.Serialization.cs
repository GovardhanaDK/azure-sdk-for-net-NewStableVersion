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
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppAuthConfigData : IUtf8JsonSerializable, IJsonModel<ContainerAppAuthConfigData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppAuthConfigData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppAuthConfigData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAuthConfigData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAuthConfigData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteObjectValue(Platform, options);
            }
            if (Optional.IsDefined(GlobalValidation))
            {
                writer.WritePropertyName("globalValidation"u8);
                writer.WriteObjectValue(GlobalValidation, options);
            }
            if (Optional.IsDefined(IdentityProviders))
            {
                writer.WritePropertyName("identityProviders"u8);
                writer.WriteObjectValue(IdentityProviders, options);
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue(Login, options);
            }
            if (Optional.IsDefined(HttpSettings))
            {
                writer.WritePropertyName("httpSettings"u8);
                writer.WriteObjectValue(HttpSettings, options);
            }
            if (Optional.IsDefined(EncryptionSettings))
            {
                writer.WritePropertyName("encryptionSettings"u8);
                writer.WriteObjectValue(EncryptionSettings, options);
            }
            writer.WriteEndObject();
        }

        ContainerAppAuthConfigData IJsonModel<ContainerAppAuthConfigData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAuthConfigData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAuthConfigData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAuthConfigData(document.RootElement, options);
        }

        internal static ContainerAppAuthConfigData DeserializeContainerAppAuthConfigData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ContainerAppAuthPlatform platform = default;
            ContainerAppGlobalValidation globalValidation = default;
            ContainerAppIdentityProvidersConfiguration identityProviders = default;
            ContainerAppLogin login = default;
            ContainerAppHttpSettings httpSettings = default;
            EncryptionSettings encryptionSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("platform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platform = ContainerAppAuthPlatform.DeserializeContainerAppAuthPlatform(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("globalValidation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            globalValidation = ContainerAppGlobalValidation.DeserializeContainerAppGlobalValidation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("identityProviders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identityProviders = ContainerAppIdentityProvidersConfiguration.DeserializeContainerAppIdentityProvidersConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("login"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            login = ContainerAppLogin.DeserializeContainerAppLogin(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("httpSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpSettings = ContainerAppHttpSettings.DeserializeContainerAppHttpSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryptionSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionSettings = EncryptionSettings.DeserializeEncryptionSettings(property0.Value, options);
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
            return new ContainerAppAuthConfigData(
                id,
                name,
                type,
                systemData,
                platform,
                globalValidation,
                identityProviders,
                login,
                httpSettings,
                encryptionSettings,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Platform), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    platform: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Platform))
                {
                    builder.Append("    platform: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Platform, options, 4, false, "    platform: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GlobalValidation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    globalValidation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GlobalValidation))
                {
                    builder.Append("    globalValidation: ");
                    BicepSerializationHelpers.AppendChildObject(builder, GlobalValidation, options, 4, false, "    globalValidation: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdentityProviders), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    identityProviders: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IdentityProviders))
                {
                    builder.Append("    identityProviders: ");
                    BicepSerializationHelpers.AppendChildObject(builder, IdentityProviders, options, 4, false, "    identityProviders: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Login), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    login: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Login))
                {
                    builder.Append("    login: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Login, options, 4, false, "    login: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    httpSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HttpSettings))
                {
                    builder.Append("    httpSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, HttpSettings, options, 4, false, "    httpSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EncryptionSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    encryptionSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EncryptionSettings))
                {
                    builder.Append("    encryptionSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EncryptionSettings, options, 4, false, "    encryptionSettings: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppAuthConfigData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAuthConfigData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAuthConfigData)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppAuthConfigData IPersistableModel<ContainerAppAuthConfigData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAuthConfigData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppAuthConfigData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAuthConfigData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppAuthConfigData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
