// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class GeometryCopyright
    {
        internal static GeometryCopyright DeserializeGeometryCopyright(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceName = default;
            string copyright = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceName"u8))
                {
                    sourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyright"u8))
                {
                    copyright = property.Value.GetString();
                    continue;
                }
            }
            return new GeometryCopyright(sourceName, copyright);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeometryCopyright FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGeometryCopyright(document.RootElement);
        }
    }
}
