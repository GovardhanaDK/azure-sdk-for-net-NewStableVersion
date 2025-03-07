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
    [JsonConverter(typeof(BigDataPoolReferenceConverter))]
    public partial class BigDataPoolReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName"u8);
            writer.WriteStringValue(ReferenceName);
            writer.WriteEndObject();
        }

        internal static BigDataPoolReference DeserializeBigDataPoolReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BigDataPoolReferenceType type = default;
            string referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new BigDataPoolReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
            }
            return new BigDataPoolReference(type, referenceName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BigDataPoolReference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBigDataPoolReference(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class BigDataPoolReferenceConverter : JsonConverter<BigDataPoolReference>
        {
            public override void Write(Utf8JsonWriter writer, BigDataPoolReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override BigDataPoolReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeBigDataPoolReference(document.RootElement);
            }
        }
    }
}
