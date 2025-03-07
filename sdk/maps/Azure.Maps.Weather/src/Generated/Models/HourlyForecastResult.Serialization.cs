// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    public partial class HourlyForecastResult
    {
        internal static HourlyForecastResult DeserializeHourlyForecastResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<HourlyForecast> forecasts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forecasts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HourlyForecast> array = new List<HourlyForecast>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HourlyForecast.DeserializeHourlyForecast(item));
                    }
                    forecasts = array;
                    continue;
                }
            }
            return new HourlyForecastResult(forecasts ?? new ChangeTrackingList<HourlyForecast>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HourlyForecastResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeHourlyForecastResult(document.RootElement);
        }
    }
}
