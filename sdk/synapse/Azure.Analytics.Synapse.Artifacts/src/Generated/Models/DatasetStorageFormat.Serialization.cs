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
    [JsonConverter(typeof(DatasetStorageFormatConverter))]
    public partial class DatasetStorageFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                writer.WriteObjectValue<object>(Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                writer.WriteObjectValue<object>(Deserializer);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DatasetStorageFormat DeserializeDatasetStorageFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroFormat": return AvroFormat.DeserializeAvroFormat(element);
                    case "JsonFormat": return JsonFormat.DeserializeJsonFormat(element);
                    case "OrcFormat": return OrcFormat.DeserializeOrcFormat(element);
                    case "ParquetFormat": return ParquetFormat.DeserializeParquetFormat(element);
                    case "TextFormat": return TextFormat.DeserializeTextFormat(element);
                }
            }
            return UnknownDatasetStorageFormat.DeserializeUnknownDatasetStorageFormat(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatasetStorageFormat FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDatasetStorageFormat(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class DatasetStorageFormatConverter : JsonConverter<DatasetStorageFormat>
        {
            public override void Write(Utf8JsonWriter writer, DatasetStorageFormat model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override DatasetStorageFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetStorageFormat(document.RootElement);
            }
        }
    }
}
