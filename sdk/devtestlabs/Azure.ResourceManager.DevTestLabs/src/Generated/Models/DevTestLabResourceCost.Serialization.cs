// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabResourceCost : IUtf8JsonSerializable, IJsonModel<DevTestLabResourceCost>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabResourceCost>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabResourceCost>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabResourceCost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabResourceCost)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourcename"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (Optional.IsDefined(ResourceUniqueId))
            {
                writer.WritePropertyName("resourceUId"u8);
                writer.WriteStringValue(ResourceUniqueId);
            }
            if (Optional.IsDefined(ResourceCost))
            {
                writer.WritePropertyName("resourceCost"u8);
                writer.WriteNumberValue(ResourceCost.Value);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (Optional.IsDefined(ResourceOwner))
            {
                writer.WritePropertyName("resourceOwner"u8);
                writer.WriteStringValue(ResourceOwner);
            }
            if (Optional.IsDefined(ResourcePricingTier))
            {
                writer.WritePropertyName("resourcePricingTier"u8);
                writer.WriteStringValue(ResourcePricingTier);
            }
            if (Optional.IsDefined(ResourceStatus))
            {
                writer.WritePropertyName("resourceStatus"u8);
                writer.WriteStringValue(ResourceStatus);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ExternalResourceId))
            {
                writer.WritePropertyName("externalResourceId"u8);
                writer.WriteStringValue(ExternalResourceId);
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

        DevTestLabResourceCost IJsonModel<DevTestLabResourceCost>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabResourceCost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabResourceCost)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabResourceCost(document.RootElement, options);
        }

        internal static DevTestLabResourceCost DeserializeDevTestLabResourceCost(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourcename = default;
            string resourceUId = default;
            double? resourceCost = default;
            string resourceType = default;
            string resourceOwner = default;
            string resourcePricingTier = default;
            string resourceStatus = default;
            string resourceId = default;
            string externalResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourcename"u8))
                {
                    resourcename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUId"u8))
                {
                    resourceUId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceCost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceOwner"u8))
                {
                    resourceOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourcePricingTier"u8))
                {
                    resourcePricingTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceStatus"u8))
                {
                    resourceStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalResourceId"u8))
                {
                    externalResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabResourceCost(
                resourcename,
                resourceUId,
                resourceCost,
                resourceType,
                resourceOwner,
                resourcePricingTier,
                resourceStatus,
                resourceId,
                externalResourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabResourceCost>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabResourceCost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabResourceCost)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabResourceCost IPersistableModel<DevTestLabResourceCost>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabResourceCost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabResourceCost(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabResourceCost)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabResourceCost>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
