// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    internal partial class GeoJsonPolygonData
    {
        internal static GeoJsonPolygonData DeserializeGeoJsonPolygonData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IList<IList<double>>> coordinates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<IList<IList<double>>> array = new List<IList<IList<double>>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<IList<double>> array0 = new List<IList<double>>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                if (item0.ValueKind == JsonValueKind.Null)
                                {
                                    array0.Add(null);
                                }
                                else
                                {
                                    List<double> array1 = new List<double>();
                                    foreach (var item1 in item0.EnumerateArray())
                                    {
                                        array1.Add(item1.GetDouble());
                                    }
                                    array0.Add(array1);
                                }
                            }
                            array.Add(array0);
                        }
                    }
                    coordinates = array;
                    continue;
                }
            }
            return new GeoJsonPolygonData(coordinates);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeoJsonPolygonData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGeoJsonPolygonData(document.RootElement);
        }
    }
}
