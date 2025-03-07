// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    public partial class AirQuality
    {
        internal static AirQuality DeserializeAirQuality(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? dateTime = default;
            float? index = default;
            float? globalIndex = default;
            DominantPollutant? dominantPollutant = default;
            string category = default;
            string categoryColor = default;
            string description = default;
            IReadOnlyList<Pollutant> pollutants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    index = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("globalIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    globalIndex = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("dominantPollutant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dominantPollutant = new DominantPollutant(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categoryColor"u8))
                {
                    categoryColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pollutants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Pollutant> array = new List<Pollutant>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Pollutant.DeserializePollutant(item));
                    }
                    pollutants = array;
                    continue;
                }
            }
            return new AirQuality(
                dateTime,
                index,
                globalIndex,
                dominantPollutant,
                category,
                categoryColor,
                description,
                pollutants ?? new ChangeTrackingList<Pollutant>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AirQuality FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAirQuality(document.RootElement);
        }
    }
}
