// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TriggerListResponseConverter))]
    internal partial class TriggerListResponse
    {
        internal static TriggerListResponse DeserializeTriggerListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TriggerResource> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<TriggerResource> array = new List<TriggerResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerResource.DeserializeTriggerResource(item));
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
            return new TriggerListResponse(value, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TriggerListResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTriggerListResponse(document.RootElement);
        }

        internal partial class TriggerListResponseConverter : JsonConverter<TriggerListResponse>
        {
            public override void Write(Utf8JsonWriter writer, TriggerListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override TriggerListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerListResponse(document.RootElement);
            }
        }
    }
}
