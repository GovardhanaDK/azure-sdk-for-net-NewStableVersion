// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.Attestation
{
    internal partial class JsonWebKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Alg))
            {
                writer.WritePropertyName("alg"u8);
                writer.WriteStringValue(Alg);
            }
            if (Optional.IsDefined(Crv))
            {
                writer.WritePropertyName("crv"u8);
                writer.WriteStringValue(Crv);
            }
            if (Optional.IsDefined(D))
            {
                writer.WritePropertyName("d"u8);
                writer.WriteStringValue(D);
            }
            if (Optional.IsDefined(Dp))
            {
                writer.WritePropertyName("dp"u8);
                writer.WriteStringValue(Dp);
            }
            if (Optional.IsDefined(Dq))
            {
                writer.WritePropertyName("dq"u8);
                writer.WriteStringValue(Dq);
            }
            if (Optional.IsDefined(E))
            {
                writer.WritePropertyName("e"u8);
                writer.WriteStringValue(E);
            }
            if (Optional.IsDefined(K))
            {
                writer.WritePropertyName("k"u8);
                writer.WriteStringValue(K);
            }
            if (Optional.IsDefined(Kid))
            {
                writer.WritePropertyName("kid"u8);
                writer.WriteStringValue(Kid);
            }
            writer.WritePropertyName("kty"u8);
            writer.WriteStringValue(Kty);
            if (Optional.IsDefined(N))
            {
                writer.WritePropertyName("n"u8);
                writer.WriteStringValue(N);
            }
            if (Optional.IsDefined(P))
            {
                writer.WritePropertyName("p"u8);
                writer.WriteStringValue(P);
            }
            if (Optional.IsDefined(Q))
            {
                writer.WritePropertyName("q"u8);
                writer.WriteStringValue(Q);
            }
            if (Optional.IsDefined(Qi))
            {
                writer.WritePropertyName("qi"u8);
                writer.WriteStringValue(Qi);
            }
            if (Optional.IsDefined(Use))
            {
                writer.WritePropertyName("use"u8);
                writer.WriteStringValue(Use);
            }
            if (Optional.IsDefined(X))
            {
                writer.WritePropertyName("x"u8);
                writer.WriteStringValue(X);
            }
            if (Optional.IsCollectionDefined(X5C))
            {
                writer.WritePropertyName("x5c"u8);
                writer.WriteStartArray();
                foreach (var item in X5C)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Y))
            {
                writer.WritePropertyName("y"u8);
                writer.WriteStringValue(Y);
            }
            writer.WriteEndObject();
        }

        internal static JsonWebKey DeserializeJsonWebKey(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string alg = default;
            string crv = default;
            string d = default;
            string dp = default;
            string dq = default;
            string e = default;
            string k = default;
            string kid = default;
            string kty = default;
            string n = default;
            string p = default;
            string q = default;
            string qi = default;
            string use = default;
            string x = default;
            IList<string> x5c = default;
            string y = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alg"u8))
                {
                    alg = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crv"u8))
                {
                    crv = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("d"u8))
                {
                    d = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dp"u8))
                {
                    dp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dq"u8))
                {
                    dq = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("e"u8))
                {
                    e = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("k"u8))
                {
                    k = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kid"u8))
                {
                    kid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kty"u8))
                {
                    kty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("n"u8))
                {
                    n = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("p"u8))
                {
                    p = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("q"u8))
                {
                    q = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qi"u8))
                {
                    qi = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("use"u8))
                {
                    use = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x"u8))
                {
                    x = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x5c"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    x5c = array;
                    continue;
                }
                if (property.NameEquals("y"u8))
                {
                    y = property.Value.GetString();
                    continue;
                }
            }
            return new JsonWebKey(
                alg,
                crv,
                d,
                dp,
                dq,
                e,
                k,
                kid,
                kty,
                n,
                p,
                q,
                qi,
                use,
                x,
                x5c ?? new ChangeTrackingList<string>(),
                y);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static JsonWebKey FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeJsonWebKey(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
