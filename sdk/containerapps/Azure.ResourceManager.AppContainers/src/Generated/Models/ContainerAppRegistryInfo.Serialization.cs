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
    public partial class ContainerAppRegistryInfo : IUtf8JsonSerializable, IJsonModel<ContainerAppRegistryInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppRegistryInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppRegistryInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RegistryServer))
            {
                writer.WritePropertyName("registryUrl"u8);
                writer.WriteStringValue(RegistryServer);
            }
            if (Optional.IsDefined(RegistryUserName))
            {
                writer.WritePropertyName("registryUserName"u8);
                writer.WriteStringValue(RegistryUserName);
            }
            if (Optional.IsDefined(RegistryPassword))
            {
                writer.WritePropertyName("registryPassword"u8);
                writer.WriteStringValue(RegistryPassword);
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

        ContainerAppRegistryInfo IJsonModel<ContainerAppRegistryInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppRegistryInfo(document.RootElement, options);
        }

        internal static ContainerAppRegistryInfo DeserializeContainerAppRegistryInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string registryUrl = default;
            string registryUserName = default;
            string registryPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registryUrl"u8))
                {
                    registryUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryUserName"u8))
                {
                    registryUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryPassword"u8))
                {
                    registryPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppRegistryInfo(registryUrl, registryUserName, registryPassword, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RegistryServer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  registryUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RegistryServer))
                {
                    builder.Append("  registryUrl: ");
                    if (RegistryServer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RegistryServer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RegistryServer}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RegistryUserName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  registryUserName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RegistryUserName))
                {
                    builder.Append("  registryUserName: ");
                    if (RegistryUserName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RegistryUserName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RegistryUserName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RegistryPassword), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  registryPassword: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RegistryPassword))
                {
                    builder.Append("  registryPassword: ");
                    if (RegistryPassword.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RegistryPassword}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RegistryPassword}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppRegistryInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppRegistryInfo IPersistableModel<ContainerAppRegistryInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppRegistryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppRegistryInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppRegistryInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppRegistryInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
