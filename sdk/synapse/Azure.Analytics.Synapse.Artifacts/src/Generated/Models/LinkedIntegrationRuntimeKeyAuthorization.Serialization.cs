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
    [JsonConverter(typeof(LinkedIntegrationRuntimeKeyAuthorizationConverter))]
    public partial class LinkedIntegrationRuntimeKeyAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteObjectValue(Key);
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
            writer.WriteEndObject();
        }

        internal static LinkedIntegrationRuntimeKeyAuthorization DeserializeLinkedIntegrationRuntimeKeyAuthorization(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecureString key = default;
            string authorizationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = SecureString.DeserializeSecureString(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedIntegrationRuntimeKeyAuthorization(authorizationType, key);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LinkedIntegrationRuntimeKeyAuthorization FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLinkedIntegrationRuntimeKeyAuthorization(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class LinkedIntegrationRuntimeKeyAuthorizationConverter : JsonConverter<LinkedIntegrationRuntimeKeyAuthorization>
        {
            public override void Write(Utf8JsonWriter writer, LinkedIntegrationRuntimeKeyAuthorization model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override LinkedIntegrationRuntimeKeyAuthorization Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedIntegrationRuntimeKeyAuthorization(document.RootElement);
            }
        }
    }
}
