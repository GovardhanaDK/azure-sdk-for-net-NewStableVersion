// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.ShortCodes.Models
{
    internal partial class CommunicationErrorResponse
    {
        internal static CommunicationErrorResponse DeserializeCommunicationErrorResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    error = CommunicationError.DeserializeCommunicationError(property.Value);
                    continue;
                }
            }
            return new CommunicationErrorResponse(error);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CommunicationErrorResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCommunicationErrorResponse(document.RootElement);
        }
    }
}
