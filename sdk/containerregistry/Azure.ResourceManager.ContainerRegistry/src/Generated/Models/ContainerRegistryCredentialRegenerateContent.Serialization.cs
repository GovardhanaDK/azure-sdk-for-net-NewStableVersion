// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryCredentialRegenerateContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryCredentialRegenerateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryCredentialRegenerateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryCredentialRegenerateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryCredentialRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryCredentialRegenerateContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToSerialString());
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

        ContainerRegistryCredentialRegenerateContent IJsonModel<ContainerRegistryCredentialRegenerateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryCredentialRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryCredentialRegenerateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryCredentialRegenerateContent(document.RootElement, options);
        }

        internal static ContainerRegistryCredentialRegenerateContent DeserializeContainerRegistryCredentialRegenerateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerRegistryPasswordName name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString().ToContainerRegistryPasswordName();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerRegistryCredentialRegenerateContent(name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryCredentialRegenerateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryCredentialRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryCredentialRegenerateContent)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryCredentialRegenerateContent IPersistableModel<ContainerRegistryCredentialRegenerateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryCredentialRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerRegistryCredentialRegenerateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryCredentialRegenerateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryCredentialRegenerateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
