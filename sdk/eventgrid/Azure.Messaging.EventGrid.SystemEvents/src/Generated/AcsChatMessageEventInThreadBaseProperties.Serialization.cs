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
    public partial class AcsChatMessageEventInThreadBaseProperties : IUtf8JsonSerializable, IJsonModel<AcsChatMessageEventInThreadBaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsChatMessageEventInThreadBaseProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsChatMessageEventInThreadBaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEventInThreadBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsChatMessageEventInThreadBaseProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            writer.WritePropertyName("senderCommunicationIdentifier"u8);
            writer.WriteObjectValue(SenderCommunicationIdentifier, options);
            if (Optional.IsDefined(SenderDisplayName))
            {
                writer.WritePropertyName("senderDisplayName"u8);
                writer.WriteStringValue(SenderDisplayName);
            }
            if (Optional.IsDefined(ComposeTime))
            {
                writer.WritePropertyName("composeTime"u8);
                writer.WriteStringValue(ComposeTime.Value, "O");
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
        }

        AcsChatMessageEventInThreadBaseProperties IJsonModel<AcsChatMessageEventInThreadBaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEventInThreadBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsChatMessageEventInThreadBaseProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsChatMessageEventInThreadBaseProperties(document.RootElement, options);
        }

        internal static AcsChatMessageEventInThreadBaseProperties DeserializeAcsChatMessageEventInThreadBaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            CommunicationIdentifierModel senderCommunicationIdentifier = default;
            string senderDisplayName = default;
            DateTimeOffset? composeTime = default;
            string type = default;
            long? version = default;
            string transactionId = default;
            string threadId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderCommunicationIdentifier"u8))
                {
                    senderCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("senderDisplayName"u8))
                {
                    senderDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("composeTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    composeTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AcsChatMessageEventInThreadBaseProperties(
                transactionId,
                threadId,
                serializedAdditionalRawData,
                messageId,
                senderCommunicationIdentifier,
                senderDisplayName,
                composeTime,
                type,
                version);
        }

        BinaryData IPersistableModel<AcsChatMessageEventInThreadBaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEventInThreadBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcsChatMessageEventInThreadBaseProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AcsChatMessageEventInThreadBaseProperties IPersistableModel<AcsChatMessageEventInThreadBaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEventInThreadBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAcsChatMessageEventInThreadBaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsChatMessageEventInThreadBaseProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsChatMessageEventInThreadBaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsChatMessageEventInThreadBaseProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsChatMessageEventInThreadBaseProperties(document.RootElement);
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
