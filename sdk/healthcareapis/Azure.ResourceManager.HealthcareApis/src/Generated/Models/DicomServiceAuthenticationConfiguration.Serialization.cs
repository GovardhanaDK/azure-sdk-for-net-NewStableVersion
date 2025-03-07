// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class DicomServiceAuthenticationConfiguration : IUtf8JsonSerializable, IJsonModel<DicomServiceAuthenticationConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DicomServiceAuthenticationConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DicomServiceAuthenticationConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DicomServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DicomServiceAuthenticationConfiguration)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Authority))
            {
                writer.WritePropertyName("authority"u8);
                writer.WriteStringValue(Authority);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Audiences))
            {
                writer.WritePropertyName("audiences"u8);
                writer.WriteStartArray();
                foreach (var item in Audiences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        DicomServiceAuthenticationConfiguration IJsonModel<DicomServiceAuthenticationConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DicomServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DicomServiceAuthenticationConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDicomServiceAuthenticationConfiguration(document.RootElement, options);
        }

        internal static DicomServiceAuthenticationConfiguration DeserializeDicomServiceAuthenticationConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authority = default;
            IReadOnlyList<string> audiences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authority"u8))
                {
                    authority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audiences"u8))
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
                    audiences = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DicomServiceAuthenticationConfiguration(authority, audiences ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DicomServiceAuthenticationConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DicomServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DicomServiceAuthenticationConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DicomServiceAuthenticationConfiguration IPersistableModel<DicomServiceAuthenticationConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DicomServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDicomServiceAuthenticationConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DicomServiceAuthenticationConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DicomServiceAuthenticationConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
