// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    internal partial class GeoJsonLineString
    {
        internal static GeoJsonLineString DeserializeGeoJsonLineString(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IList<double>> coordinates = default;
            GeoJsonObjectType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<IList<double>> array = new List<IList<double>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<double> array0 = new List<double>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetDouble());
                            }
                            array.Add(array0);
                        }
                    }
                    coordinates = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
            }
            return new GeoJsonLineString(type, coordinates);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new GeoJsonLineString FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGeoJsonLineString(document.RootElement);
        }
    }
}
