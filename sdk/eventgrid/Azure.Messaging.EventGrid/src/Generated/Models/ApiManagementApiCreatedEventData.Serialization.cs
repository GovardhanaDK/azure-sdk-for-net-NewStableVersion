// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementApiCreatedEventDataConverter))]
    public partial class ApiManagementApiCreatedEventData
    {
        internal static ApiManagementApiCreatedEventData DeserializeApiManagementApiCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementApiCreatedEventData(resourceUri);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ApiManagementApiCreatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeApiManagementApiCreatedEventData(document.RootElement);
        }

        internal partial class ApiManagementApiCreatedEventDataConverter : JsonConverter<ApiManagementApiCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementApiCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ApiManagementApiCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementApiCreatedEventData(document.RootElement);
            }
        }
    }
}
