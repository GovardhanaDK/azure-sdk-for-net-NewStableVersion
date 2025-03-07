// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FhirR4Annotation : IUtf8JsonSerializable, IJsonModel<FhirR4Annotation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4Annotation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FhirR4Annotation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Annotation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Annotation)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(AuthorString))
            {
                writer.WritePropertyName("authorString"u8);
                writer.WriteStringValue(AuthorString);
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time);
            }
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
        }

        FhirR4Annotation IJsonModel<FhirR4Annotation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Annotation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Annotation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4Annotation(document.RootElement, options);
        }

        internal static FhirR4Annotation DeserializeFhirR4Annotation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authorString = default;
            string time = default;
            string text = default;
            string id = default;
            IList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorString"u8))
                {
                    authorString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"u8))
                {
                    time = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extension.DeserializeFhirR4Extension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FhirR4Annotation(
                id,
                extension ?? new ChangeTrackingList<FhirR4Extension>(),
                serializedAdditionalRawData,
                authorString,
                time,
                text);
        }

        BinaryData IPersistableModel<FhirR4Annotation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Annotation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirR4Annotation)} does not support writing '{options.Format}' format.");
            }
        }

        FhirR4Annotation IPersistableModel<FhirR4Annotation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Annotation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFhirR4Annotation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4Annotation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4Annotation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new FhirR4Annotation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeFhirR4Annotation(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
