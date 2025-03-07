// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AddDataFlowToDebugSessionResponseConverter))]
    public partial class AddDataFlowToDebugSessionResponse
    {
        internal static AddDataFlowToDebugSessionResponse DeserializeAddDataFlowToDebugSessionResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobVersion"u8))
                {
                    jobVersion = property.Value.GetString();
                    continue;
                }
            }
            return new AddDataFlowToDebugSessionResponse(jobVersion);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AddDataFlowToDebugSessionResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAddDataFlowToDebugSessionResponse(document.RootElement);
        }

        internal partial class AddDataFlowToDebugSessionResponseConverter : JsonConverter<AddDataFlowToDebugSessionResponse>
        {
            public override void Write(Utf8JsonWriter writer, AddDataFlowToDebugSessionResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AddDataFlowToDebugSessionResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAddDataFlowToDebugSessionResponse(document.RootElement);
            }
        }
    }
}
