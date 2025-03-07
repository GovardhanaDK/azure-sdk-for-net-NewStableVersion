// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.Chat
{
    internal partial class ChatMessagesCollection
    {
        internal static ChatMessagesCollection DeserializeChatMessagesCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ChatMessageInternal> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ChatMessageInternal> array = new List<ChatMessageInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatMessageInternal.DeserializeChatMessageInternal(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ChatMessagesCollection(value, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatMessagesCollection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeChatMessagesCollection(document.RootElement);
        }
    }
}
