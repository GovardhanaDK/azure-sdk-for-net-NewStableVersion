// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Quantum.Jobs.Models
{
    public partial class QuantumJobQuota
    {
        internal static QuantumJobQuota DeserializeQuantumJobQuota(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dimension = default;
            DimensionScope? scope = default;
            string providerId = default;
            float? utilization = default;
            float? holds = default;
            float? limit = default;
            MeterPeriod? period = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimension"u8))
                {
                    dimension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = new DimensionScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerId"u8))
                {
                    providerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("utilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    utilization = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("holds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    holds = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("period"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    period = new MeterPeriod(property.Value.GetString());
                    continue;
                }
            }
            return new QuantumJobQuota(
                dimension,
                scope,
                providerId,
                utilization,
                holds,
                limit,
                period);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static QuantumJobQuota FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeQuantumJobQuota(document.RootElement);
        }
    }
}
