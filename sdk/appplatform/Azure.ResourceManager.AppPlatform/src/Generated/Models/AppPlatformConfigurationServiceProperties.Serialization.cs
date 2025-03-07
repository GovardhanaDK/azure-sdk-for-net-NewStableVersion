// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigurationServiceProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformConfigurationServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformConfigurationServiceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformConfigurationServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceRequests))
            {
                writer.WritePropertyName("resourceRequests"u8);
                writer.WriteObjectValue(ResourceRequests, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Instances))
            {
                writer.WritePropertyName("instances"u8);
                writer.WriteStartArray();
                foreach (var item in Instances)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings, options);
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

        AppPlatformConfigurationServiceProperties IJsonModel<AppPlatformConfigurationServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformConfigurationServiceProperties(document.RootElement, options);
        }

        internal static AppPlatformConfigurationServiceProperties DeserializeAppPlatformConfigurationServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AppPlatformConfigurationServiceProvisioningState? provisioningState = default;
            AppPlatformConfigurationServiceRequirements resourceRequests = default;
            IReadOnlyList<AppPlatformConfigurationServiceInstance> instances = default;
            AppPlatformConfigurationServiceSettings settings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformConfigurationServiceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformConfigurationServiceRequirements.DeserializeAppPlatformConfigurationServiceRequirements(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformConfigurationServiceInstance> array = new List<AppPlatformConfigurationServiceInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformConfigurationServiceInstance.DeserializeAppPlatformConfigurationServiceInstance(item, options));
                    }
                    instances = array;
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = AppPlatformConfigurationServiceSettings.DeserializeAppPlatformConfigurationServiceSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformConfigurationServiceProperties(provisioningState, resourceRequests, instances ?? new ChangeTrackingList<AppPlatformConfigurationServiceInstance>(), settings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformConfigurationServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformConfigurationServiceProperties IPersistableModel<AppPlatformConfigurationServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformConfigurationServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformConfigurationServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
