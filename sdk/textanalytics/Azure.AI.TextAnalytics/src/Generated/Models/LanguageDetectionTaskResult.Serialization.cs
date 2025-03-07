// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class LanguageDetectionTaskResult
    {
        internal static LanguageDetectionTaskResult DeserializeLanguageDetectionTaskResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LanguageDetectionResult results = default;
            AnalyzeTextTaskResultsKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = LanguageDetectionResult.DeserializeLanguageDetectionResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextTaskResultsKind(property.Value.GetString());
                    continue;
                }
            }
            return new LanguageDetectionTaskResult(kind, results);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LanguageDetectionTaskResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLanguageDetectionTaskResult(document.RootElement);
        }
    }
}
