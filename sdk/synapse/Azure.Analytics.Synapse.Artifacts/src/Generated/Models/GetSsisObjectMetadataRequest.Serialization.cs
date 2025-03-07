// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(GetSsisObjectMetadataRequestConverter))]
    public partial class GetSsisObjectMetadataRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MetadataPath))
            {
                writer.WritePropertyName("metadataPath"u8);
                writer.WriteStringValue(MetadataPath);
            }
            writer.WriteEndObject();
        }

        internal static GetSsisObjectMetadataRequest DeserializeGetSsisObjectMetadataRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metadataPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataPath"u8))
                {
                    metadataPath = property.Value.GetString();
                    continue;
                }
            }
            return new GetSsisObjectMetadataRequest(metadataPath);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GetSsisObjectMetadataRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGetSsisObjectMetadataRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class GetSsisObjectMetadataRequestConverter : JsonConverter<GetSsisObjectMetadataRequest>
        {
            public override void Write(Utf8JsonWriter writer, GetSsisObjectMetadataRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override GetSsisObjectMetadataRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGetSsisObjectMetadataRequest(document.RootElement);
            }
        }
    }
}
