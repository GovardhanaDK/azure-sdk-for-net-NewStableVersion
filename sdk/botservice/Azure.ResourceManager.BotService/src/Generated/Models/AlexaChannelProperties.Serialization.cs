// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class AlexaChannelProperties : IUtf8JsonSerializable, IJsonModel<AlexaChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlexaChannelProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AlexaChannelProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlexaChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlexaChannelProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("alexaSkillId"u8);
            writer.WriteStringValue(AlexaSkillId);
            if (options.Format != "W" && Optional.IsDefined(UriFragment))
            {
                writer.WritePropertyName("urlFragment"u8);
                writer.WriteStringValue(UriFragment);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceEndpointUri))
            {
                writer.WritePropertyName("serviceEndpointUri"u8);
                writer.WriteStringValue(ServiceEndpointUri.AbsoluteUri);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
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

        AlexaChannelProperties IJsonModel<AlexaChannelProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlexaChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlexaChannelProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlexaChannelProperties(document.RootElement, options);
        }

        internal static AlexaChannelProperties DeserializeAlexaChannelProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string alexaSkillId = default;
            string urlFragment = default;
            Uri serviceEndpointUri = default;
            bool isEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alexaSkillId"u8))
                {
                    alexaSkillId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urlFragment"u8))
                {
                    urlFragment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceEndpointUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceEndpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AlexaChannelProperties(alexaSkillId, urlFragment, serviceEndpointUri, isEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AlexaChannelProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlexaChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlexaChannelProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AlexaChannelProperties IPersistableModel<AlexaChannelProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlexaChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAlexaChannelProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlexaChannelProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlexaChannelProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
