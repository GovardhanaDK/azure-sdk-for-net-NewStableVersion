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
    [JsonConverter(typeof(TumblingWindowTriggerDependencyReferenceConverter))]
    public partial class TumblingWindowTriggerDependencyReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Offset))
            {
                writer.WritePropertyName("offset"u8);
                writer.WriteStringValue(Offset);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            writer.WritePropertyName("referenceTrigger"u8);
            writer.WriteObjectValue(ReferenceTrigger);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static TumblingWindowTriggerDependencyReference DeserializeTumblingWindowTriggerDependencyReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offset = default;
            string size = default;
            TriggerReference referenceTrigger = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceTrigger"u8))
                {
                    referenceTrigger = TriggerReference.DeserializeTriggerReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new TumblingWindowTriggerDependencyReference(type, referenceTrigger, offset, size);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TumblingWindowTriggerDependencyReference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTumblingWindowTriggerDependencyReference(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class TumblingWindowTriggerDependencyReferenceConverter : JsonConverter<TumblingWindowTriggerDependencyReference>
        {
            public override void Write(Utf8JsonWriter writer, TumblingWindowTriggerDependencyReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override TumblingWindowTriggerDependencyReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTumblingWindowTriggerDependencyReference(document.RootElement);
            }
        }
    }
}
