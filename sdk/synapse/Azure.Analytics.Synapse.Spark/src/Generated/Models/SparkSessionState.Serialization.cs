// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSessionState
    {
        internal static SparkSessionState DeserializeSparkSessionState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? notStartedAt = default;
            DateTimeOffset? startingAt = default;
            DateTimeOffset? idleAt = default;
            DateTimeOffset? deadAt = default;
            DateTimeOffset? shuttingDownAt = default;
            DateTimeOffset? killedAt = default;
            DateTimeOffset? recoveringAt = default;
            DateTimeOffset? busyAt = default;
            DateTimeOffset? errorAt = default;
            string currentState = default;
            SparkRequest jobCreationRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notStartedAt = null;
                        continue;
                    }
                    notStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startingAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startingAt = null;
                        continue;
                    }
                    startingAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("idleAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        idleAt = null;
                        continue;
                    }
                    idleAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deadAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadAt = null;
                        continue;
                    }
                    deadAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("shuttingDownAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        shuttingDownAt = null;
                        continue;
                    }
                    shuttingDownAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("killedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        killedAt = null;
                        continue;
                    }
                    killedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveringAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        recoveringAt = null;
                        continue;
                    }
                    recoveringAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("busyAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        busyAt = null;
                        continue;
                    }
                    busyAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorAt = null;
                        continue;
                    }
                    errorAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
            }
            return new SparkSessionState(
                notStartedAt,
                startingAt,
                idleAt,
                deadAt,
                shuttingDownAt,
                killedAt,
                recoveringAt,
                busyAt,
                errorAt,
                currentState,
                jobCreationRequest);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SparkSessionState FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSparkSessionState(document.RootElement);
        }
    }
}
