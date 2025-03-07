// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.MixedReality.RemoteRendering
{
    internal partial class ConversionList
    {
        internal static ConversionList DeserializeConversionList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AssetConversion> conversions = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conversions"u8))
                {
                    List<AssetConversion> array = new List<AssetConversion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssetConversion.DeserializeAssetConversion(item));
                    }
                    conversions = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ConversionList(conversions, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConversionList FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeConversionList(document.RootElement);
        }
    }
}
