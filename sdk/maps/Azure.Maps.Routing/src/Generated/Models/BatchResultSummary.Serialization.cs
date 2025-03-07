// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Routing.Models
{
    internal partial class BatchResultSummary
    {
        internal static BatchResultSummary DeserializeBatchResultSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? successfulRequests = default;
            int? totalRequests = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("successfulRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successfulRequests = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalRequests = property.Value.GetInt32();
                    continue;
                }
            }
            return new BatchResultSummary(successfulRequests, totalRequests);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchResultSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBatchResultSummary(document.RootElement);
        }
    }
}
