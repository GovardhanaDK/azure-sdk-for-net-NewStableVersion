// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class AIServicesAccountIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            else
            {
                writer.WriteNull("identity");
            }
            writer.WritePropertyName("subdomainUrl"u8);
            writer.WriteStringValue(SubdomainUrl);
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static AIServicesAccountIdentity DeserializeAIServicesAccountIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SearchIndexerDataIdentity identity = default;
            string subdomainUrl = default;
            string odataType = default;
            string description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("subdomainUrl"u8))
                {
                    subdomainUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new AIServicesAccountIdentity(odataType, description, identity, subdomainUrl);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AIServicesAccountIdentity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAIServicesAccountIdentity(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
