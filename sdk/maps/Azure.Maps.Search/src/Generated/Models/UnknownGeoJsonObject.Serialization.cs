// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    internal partial class UnknownGeoJsonObject
    {
        internal static UnknownGeoJsonObject DeserializeUnknownGeoJsonObject(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GeoJsonObjectType type = "Unknown";
            IReadOnlyList<double> boundingBox = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new GeoJsonObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("boundingBox"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    boundingBox = array;
                    continue;
                }
            }
            return new UnknownGeoJsonObject(type, boundingBox ?? new ChangeTrackingList<double>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownGeoJsonObject FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeUnknownGeoJsonObject(document.RootElement);
        }
    }
}
