// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CommunityGalleryInfo : IUtf8JsonSerializable, IJsonModel<CommunityGalleryInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunityGalleryInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CommunityGalleryInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PublisherUriString))
            {
                writer.WritePropertyName("publisherUri"u8);
                writer.WriteStringValue(PublisherUriString);
            }
            if (Optional.IsDefined(PublisherContact))
            {
                writer.WritePropertyName("publisherContact"u8);
                writer.WriteStringValue(PublisherContact);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula"u8);
                writer.WriteStringValue(Eula);
            }
            if (Optional.IsDefined(PublicNamePrefix))
            {
                writer.WritePropertyName("publicNamePrefix"u8);
                writer.WriteStringValue(PublicNamePrefix);
            }
            if (options.Format != "W" && Optional.IsDefined(CommunityGalleryEnabled))
            {
                writer.WritePropertyName("communityGalleryEnabled"u8);
                writer.WriteBooleanValue(CommunityGalleryEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PublicNames))
            {
                writer.WritePropertyName("publicNames"u8);
                writer.WriteStartArray();
                foreach (var item in PublicNames)
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

        CommunityGalleryInfo IJsonModel<CommunityGalleryInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunityGalleryInfo(document.RootElement, options);
        }

        internal static CommunityGalleryInfo DeserializeCommunityGalleryInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string publisherUri = default;
            string publisherContact = default;
            string eula = default;
            string publicNamePrefix = default;
            bool? communityGalleryEnabled = default;
            IReadOnlyList<string> publicNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherUri"u8))
                {
                    publisherUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherContact"u8))
                {
                    publisherContact = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eula"u8))
                {
                    eula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicNamePrefix"u8))
                {
                    publicNamePrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityGalleryEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communityGalleryEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publicNames"u8))
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
                    publicNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CommunityGalleryInfo(
                publisherUri,
                publisherContact,
                eula,
                publicNamePrefix,
                communityGalleryEnabled,
                publicNames ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommunityGalleryInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support writing '{options.Format}' format.");
            }
        }

        CommunityGalleryInfo IPersistableModel<CommunityGalleryInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCommunityGalleryInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunityGalleryInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
