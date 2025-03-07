// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EntityTimelineContent : IUtf8JsonSerializable, IJsonModel<EntityTimelineContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EntityTimelineContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EntityTimelineContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityTimelineContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityTimelineContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Kinds))
            {
                writer.WritePropertyName("kinds"u8);
                writer.WriteStartArray();
                foreach (var item in Kinds)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndOn, "O");
            if (Optional.IsDefined(NumberOfBucket))
            {
                writer.WritePropertyName("numberOfBucket"u8);
                writer.WriteNumberValue(NumberOfBucket.Value);
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

        EntityTimelineContent IJsonModel<EntityTimelineContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityTimelineContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityTimelineContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityTimelineContent(document.RootElement, options);
        }

        internal static EntityTimelineContent DeserializeEntityTimelineContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<EntityTimelineKind> kinds = default;
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            int? numberOfBucket = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kinds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EntityTimelineKind> array = new List<EntityTimelineKind>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new EntityTimelineKind(item.GetString()));
                    }
                    kinds = array;
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("numberOfBucket"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfBucket = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EntityTimelineContent(kinds ?? new ChangeTrackingList<EntityTimelineKind>(), startTime, endTime, numberOfBucket, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EntityTimelineContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityTimelineContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EntityTimelineContent)} does not support writing '{options.Format}' format.");
            }
        }

        EntityTimelineContent IPersistableModel<EntityTimelineContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityTimelineContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEntityTimelineContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EntityTimelineContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EntityTimelineContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
