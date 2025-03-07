// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class TemplateDeploymentPolicy : IUtf8JsonSerializable, IJsonModel<TemplateDeploymentPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TemplateDeploymentPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TemplateDeploymentPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemplateDeploymentPolicy)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("capabilities"u8);
            writer.WriteStringValue(Capabilities.ToString());
            writer.WritePropertyName("preflightOptions"u8);
            writer.WriteStringValue(PreflightOptions.ToString());
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

        TemplateDeploymentPolicy IJsonModel<TemplateDeploymentPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemplateDeploymentPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTemplateDeploymentPolicy(document.RootElement, options);
        }

        internal static TemplateDeploymentPolicy DeserializeTemplateDeploymentPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TemplateDeploymentCapability capabilities = default;
            TemplateDeploymentPreflightOption preflightOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capabilities"u8))
                {
                    capabilities = new TemplateDeploymentCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preflightOptions"u8))
                {
                    preflightOptions = new TemplateDeploymentPreflightOption(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TemplateDeploymentPolicy(capabilities, preflightOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TemplateDeploymentPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TemplateDeploymentPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        TemplateDeploymentPolicy IPersistableModel<TemplateDeploymentPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateDeploymentPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTemplateDeploymentPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TemplateDeploymentPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TemplateDeploymentPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
