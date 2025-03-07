// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class ModelCopyAuthorization : IUtf8JsonSerializable, IJsonModel<ModelCopyAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelCopyAuthorization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ModelCopyAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelCopyAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelCopyAuthorization)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("targetResourceId"u8);
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("targetResourceRegion"u8);
            writer.WriteStringValue(TargetResourceRegion);
            writer.WritePropertyName("targetModelId"u8);
            writer.WriteStringValue(TargetModelId);
            writer.WritePropertyName("targetModelLocation"u8);
            writer.WriteStringValue(TargetModelLocation.AbsoluteUri);
            writer.WritePropertyName("accessToken"u8);
            writer.WriteStringValue(AccessToken);
            writer.WritePropertyName("expirationDateTime"u8);
            writer.WriteStringValue(ExpiresOn, "O");
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ModelCopyAuthorization IJsonModel<ModelCopyAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelCopyAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelCopyAuthorization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelCopyAuthorization(document.RootElement, options);
        }

        internal static ModelCopyAuthorization DeserializeModelCopyAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetResourceId = default;
            string targetResourceRegion = default;
            string targetModelId = default;
            Uri targetModelLocation = default;
            string accessToken = default;
            DateTimeOffset expirationDateTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"u8))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceRegion"u8))
                {
                    targetResourceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetModelId"u8))
                {
                    targetModelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetModelLocation"u8))
                {
                    targetModelLocation = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ModelCopyAuthorization(
                targetResourceId,
                targetResourceRegion,
                targetModelId,
                targetModelLocation,
                accessToken,
                expirationDateTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ModelCopyAuthorization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelCopyAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelCopyAuthorization)} does not support writing '{options.Format}' format.");
            }
        }

        ModelCopyAuthorization IPersistableModel<ModelCopyAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelCopyAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeModelCopyAuthorization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelCopyAuthorization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelCopyAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ModelCopyAuthorization FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeModelCopyAuthorization(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
