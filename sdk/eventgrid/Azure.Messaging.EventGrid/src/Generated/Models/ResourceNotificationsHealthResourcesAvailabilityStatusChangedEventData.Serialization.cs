// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventDataConverter))]
    public partial class ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData
    {
        internal static ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData DeserializeResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceNotificationsResourceUpdatedDetails resourceInfo = default;
            ResourceNotificationsOperationalDetails operationalInfo = default;
            string apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceInfo = ResourceNotificationsResourceUpdatedDetails.DeserializeResourceNotificationsResourceUpdatedDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("operationalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationalInfo = ResourceNotificationsOperationalDetails.DeserializeResourceNotificationsOperationalDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(resourceInfo, operationalInfo, apiVersion);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(document.RootElement);
        }

        internal partial class ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventDataConverter : JsonConverter<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(document.RootElement);
            }
        }
    }
}
