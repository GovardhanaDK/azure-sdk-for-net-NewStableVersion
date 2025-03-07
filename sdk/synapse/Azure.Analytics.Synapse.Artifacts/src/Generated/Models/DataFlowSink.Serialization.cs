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
    [JsonConverter(typeof(DataFlowSinkConverter))]
    public partial class DataFlowSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaLinkedService))
            {
                writer.WritePropertyName("schemaLinkedService"u8);
                writer.WriteObjectValue(SchemaLinkedService);
            }
            if (Optional.IsDefined(RejectedDataLinkedService))
            {
                writer.WritePropertyName("rejectedDataLinkedService"u8);
                writer.WriteObjectValue(RejectedDataLinkedService);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteObjectValue(Dataset);
            }
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                writer.WriteObjectValue(LinkedService);
            }
            if (Optional.IsDefined(Flowlet))
            {
                writer.WritePropertyName("flowlet"u8);
                writer.WriteObjectValue(Flowlet);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowSink DeserializeDataFlowSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference schemaLinkedService = default;
            LinkedServiceReference rejectedDataLinkedService = default;
            string name = default;
            string description = default;
            DatasetReference dataset = default;
            LinkedServiceReference linkedService = default;
            DataFlowReference flowlet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("rejectedDataLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectedDataLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataset = DatasetReference.DeserializeDatasetReference(property.Value);
                    continue;
                }
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("flowlet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flowlet = DataFlowReference.DeserializeDataFlowReference(property.Value);
                    continue;
                }
            }
            return new DataFlowSink(
                name,
                description,
                dataset,
                linkedService,
                flowlet,
                schemaLinkedService,
                rejectedDataLinkedService);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new DataFlowSink FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDataFlowSink(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class DataFlowSinkConverter : JsonConverter<DataFlowSink>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override DataFlowSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowSink(document.RootElement);
            }
        }
    }
}
