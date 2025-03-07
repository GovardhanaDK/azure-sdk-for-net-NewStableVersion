// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CheckNameAvailabilitySpecifications : IUtf8JsonSerializable, IJsonModel<CheckNameAvailabilitySpecifications>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckNameAvailabilitySpecifications>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CheckNameAvailabilitySpecifications>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckNameAvailabilitySpecifications>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckNameAvailabilitySpecifications)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsDefaultValidationEnabled))
            {
                writer.WritePropertyName("enableDefaultValidation"u8);
                writer.WriteBooleanValue(IsDefaultValidationEnabled.Value);
            }
            if (Optional.IsCollectionDefined(ResourceTypesWithCustomValidation))
            {
                writer.WritePropertyName("resourceTypesWithCustomValidation"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypesWithCustomValidation)
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

        CheckNameAvailabilitySpecifications IJsonModel<CheckNameAvailabilitySpecifications>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckNameAvailabilitySpecifications>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckNameAvailabilitySpecifications)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckNameAvailabilitySpecifications(document.RootElement, options);
        }

        internal static CheckNameAvailabilitySpecifications DeserializeCheckNameAvailabilitySpecifications(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableDefaultValidation = default;
            IList<string> resourceTypesWithCustomValidation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDefaultValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDefaultValidation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceTypesWithCustomValidation"u8))
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
                    resourceTypesWithCustomValidation = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CheckNameAvailabilitySpecifications(enableDefaultValidation, resourceTypesWithCustomValidation ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckNameAvailabilitySpecifications>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckNameAvailabilitySpecifications>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckNameAvailabilitySpecifications)} does not support writing '{options.Format}' format.");
            }
        }

        CheckNameAvailabilitySpecifications IPersistableModel<CheckNameAvailabilitySpecifications>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckNameAvailabilitySpecifications>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCheckNameAvailabilitySpecifications(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckNameAvailabilitySpecifications)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckNameAvailabilitySpecifications>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
