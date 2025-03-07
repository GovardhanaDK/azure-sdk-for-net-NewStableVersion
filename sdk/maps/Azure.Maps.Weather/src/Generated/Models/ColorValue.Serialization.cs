// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    public partial class ColorValue
    {
        internal static ColorValue DeserializeColorValue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? red = default;
            int? green = default;
            int? blue = default;
            string hex = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("red"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    red = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("green"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    green = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("blue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hex"u8))
                {
                    hex = property.Value.GetString();
                    continue;
                }
            }
            return new ColorValue(red, green, blue, hex);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ColorValue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeColorValue(document.RootElement);
        }
    }
}
