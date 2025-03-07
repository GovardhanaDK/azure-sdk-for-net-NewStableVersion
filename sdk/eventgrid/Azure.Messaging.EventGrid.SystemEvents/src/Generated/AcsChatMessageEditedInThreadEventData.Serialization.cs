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
    public partial class AcsChatMessageEditedInThreadEventData : IUtf8JsonSerializable, IJsonModel<AcsChatMessageEditedInThreadEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsChatMessageEditedInThreadEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsChatMessageEditedInThreadEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEditedInThreadEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsChatMessageEditedInThreadEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(MessageBody))
            {
                writer.WritePropertyName("messageBody"u8);
                writer.WriteStringValue(MessageBody);
            }
            writer.WritePropertyName("metadata"u8);
            writer.WriteStartObject();
            foreach (var item in Metadata)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            if (Optional.IsDefined(EditTime))
            {
                writer.WritePropertyName("editTime"u8);
                writer.WriteStringValue(EditTime.Value, "O");
            }
        }

        AcsChatMessageEditedInThreadEventData IJsonModel<AcsChatMessageEditedInThreadEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEditedInThreadEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsChatMessageEditedInThreadEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsChatMessageEditedInThreadEventData(document.RootElement, options);
        }

        internal static AcsChatMessageEditedInThreadEventData DeserializeAcsChatMessageEditedInThreadEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageBody = default;
            IReadOnlyDictionary<string, string> metadata = default;
            DateTimeOffset? editTime = default;
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
                if (property.NameEquals("messageBody"u8))
                {
                    messageBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("editTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    editTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
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
            return new AcsChatMessageEditedInThreadEventData(
                transactionId,
                threadId,
                serializedAdditionalRawData,
                messageId,
                senderCommunicationIdentifier,
                senderDisplayName,
                composeTime,
                type,
                version,
                messageBody,
                metadata,
                editTime);
        }

        BinaryData IPersistableModel<AcsChatMessageEditedInThreadEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEditedInThreadEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcsChatMessageEditedInThreadEventData)} does not support writing '{options.Format}' format.");
            }
        }

        AcsChatMessageEditedInThreadEventData IPersistableModel<AcsChatMessageEditedInThreadEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatMessageEditedInThreadEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAcsChatMessageEditedInThreadEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsChatMessageEditedInThreadEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsChatMessageEditedInThreadEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsChatMessageEditedInThreadEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsChatMessageEditedInThreadEventData(document.RootElement);
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
