// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class EventGridMqttClientDeletedEventData : IUtf8JsonSerializable, IJsonModel<EventGridMqttClientDeletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridMqttClientDeletedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventGridMqttClientDeletedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridMqttClientDeletedEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        EventGridMqttClientDeletedEventData IJsonModel<EventGridMqttClientDeletedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridMqttClientDeletedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridMqttClientDeletedEventData(document.RootElement, options);
        }

        internal static EventGridMqttClientDeletedEventData DeserializeEventGridMqttClientDeletedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientAuthenticationName = default;
            string clientName = default;
            string namespaceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientAuthenticationName"u8))
                {
                    clientAuthenticationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientName"u8))
                {
                    clientName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventGridMqttClientDeletedEventData(clientAuthenticationName, clientName, namespaceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventGridMqttClientDeletedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridMqttClientDeletedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        EventGridMqttClientDeletedEventData IPersistableModel<EventGridMqttClientDeletedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEventGridMqttClientDeletedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridMqttClientDeletedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridMqttClientDeletedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new EventGridMqttClientDeletedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeEventGridMqttClientDeletedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
