// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal partial class TasksStateTasksEntityRecognitionTasksItem
    {
        internal static TasksStateTasksEntityRecognitionTasksItem DeserializeTasksStateTasksEntityRecognitionTasksItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntitiesResult results = default;
            DateTimeOffset lastUpdateDateTime = default;
            string taskName = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = EntitiesResult.DeserializeEntitiesResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
            }
            return new TasksStateTasksEntityRecognitionTasksItem(lastUpdateDateTime, taskName, status, results);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TasksStateTasksEntityRecognitionTasksItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTasksStateTasksEntityRecognitionTasksItem(document.RootElement);
        }
    }
}
