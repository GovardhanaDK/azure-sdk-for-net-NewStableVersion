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
    [PersistableModelProxy(typeof(UnknownResourceElementTemplate))]
    public partial class ResourceElementTemplate : IUtf8JsonSerializable, IJsonModel<ResourceElementTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceElementTemplate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceElementTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceElementTemplate)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceElementType.ToString());
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile, options);
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

        ResourceElementTemplate IJsonModel<ResourceElementTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceElementTemplate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceElementTemplate(document.RootElement, options);
        }

        internal static ResourceElementTemplate DeserializeResourceElementTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ArmResourceDefinition": return ArmResourceDefinitionResourceElementTemplateDetails.DeserializeArmResourceDefinitionResourceElementTemplateDetails(element, options);
                    case "NetworkFunctionDefinition": return NetworkFunctionDefinitionResourceElementTemplateDetails.DeserializeNetworkFunctionDefinitionResourceElementTemplateDetails(element, options);
                }
            }
            return UnknownResourceElementTemplate.DeserializeUnknownResourceElementTemplate(element, options);
        }

        BinaryData IPersistableModel<ResourceElementTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceElementTemplate)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceElementTemplate IPersistableModel<ResourceElementTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceElementTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceElementTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceElementTemplate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceElementTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
