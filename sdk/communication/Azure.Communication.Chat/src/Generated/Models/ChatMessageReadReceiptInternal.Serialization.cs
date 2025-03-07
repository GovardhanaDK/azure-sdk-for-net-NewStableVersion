// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Communication.Chat
{
    internal partial class ChatMessageReadReceiptInternal
    {
        internal static ChatMessageReadReceiptInternal DeserializeChatMessageReadReceiptInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel senderCommunicationIdentifier = default;
            string chatMessageId = default;
            DateTimeOffset readOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderCommunicationIdentifier"u8))
                {
                    senderCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("chatMessageId"u8))
                {
                    chatMessageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOn"u8))
                {
                    readOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ChatMessageReadReceiptInternal(senderCommunicationIdentifier, chatMessageId, readOn);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatMessageReadReceiptInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeChatMessageReadReceiptInternal(document.RootElement);
        }
    }
}
