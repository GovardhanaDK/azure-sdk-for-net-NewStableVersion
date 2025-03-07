// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyLicense : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyPlayReadyLicense>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyPlayReadyLicense>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContentKeyPolicyPlayReadyLicense>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyLicense>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyLicense)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("allowTestDevices"u8);
            writer.WriteBooleanValue(AllowTestDevices);
            if (Optional.IsDefined(SecurityLevel))
            {
                writer.WritePropertyName("securityLevel"u8);
                writer.WriteStringValue(SecurityLevel.Value.ToString());
            }
            if (Optional.IsDefined(BeginOn))
            {
                writer.WritePropertyName("beginDate"u8);
                writer.WriteStringValue(BeginOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(RelativeBeginDate))
            {
                writer.WritePropertyName("relativeBeginDate"u8);
                writer.WriteStringValue(RelativeBeginDate.Value, "P");
            }
            if (Optional.IsDefined(RelativeExpirationDate))
            {
                writer.WritePropertyName("relativeExpirationDate"u8);
                writer.WriteStringValue(RelativeExpirationDate.Value, "P");
            }
            if (Optional.IsDefined(GracePeriod))
            {
                writer.WritePropertyName("gracePeriod"u8);
                writer.WriteStringValue(GracePeriod.Value, "P");
            }
            if (Optional.IsDefined(PlayRight))
            {
                writer.WritePropertyName("playRight"u8);
                writer.WriteObjectValue(PlayRight, options);
            }
            writer.WritePropertyName("licenseType"u8);
            writer.WriteStringValue(LicenseType.ToString());
            writer.WritePropertyName("contentKeyLocation"u8);
            writer.WriteObjectValue(ContentKeyLocation, options);
            writer.WritePropertyName("contentType"u8);
            writer.WriteStringValue(ContentType.ToString());
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

        ContentKeyPolicyPlayReadyLicense IJsonModel<ContentKeyPolicyPlayReadyLicense>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyLicense>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyLicense)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyLicense(document.RootElement, options);
        }

        internal static ContentKeyPolicyPlayReadyLicense DeserializeContentKeyPolicyPlayReadyLicense(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool allowTestDevices = default;
            PlayReadySecurityLevel? securityLevel = default;
            DateTimeOffset? beginDate = default;
            DateTimeOffset? expirationDate = default;
            TimeSpan? relativeBeginDate = default;
            TimeSpan? relativeExpirationDate = default;
            TimeSpan? gracePeriod = default;
            ContentKeyPolicyPlayReadyPlayRight playRight = default;
            ContentKeyPolicyPlayReadyLicenseType licenseType = default;
            ContentKeyPolicyPlayReadyContentKeyLocation contentKeyLocation = default;
            ContentKeyPolicyPlayReadyContentType contentType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowTestDevices"u8))
                {
                    allowTestDevices = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("securityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityLevel = new PlayReadySecurityLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("beginDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    beginDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("relativeBeginDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relativeBeginDate = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("relativeExpirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relativeExpirationDate = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("gracePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gracePeriod = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("playRight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playRight = ContentKeyPolicyPlayReadyPlayRight.DeserializeContentKeyPolicyPlayReadyPlayRight(property.Value, options);
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = new ContentKeyPolicyPlayReadyLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentKeyLocation"u8))
                {
                    contentKeyLocation = ContentKeyPolicyPlayReadyContentKeyLocation.DeserializeContentKeyPolicyPlayReadyContentKeyLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = new ContentKeyPolicyPlayReadyContentType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContentKeyPolicyPlayReadyLicense(
                allowTestDevices,
                securityLevel,
                beginDate,
                expirationDate,
                relativeBeginDate,
                relativeExpirationDate,
                gracePeriod,
                playRight,
                licenseType,
                contentKeyLocation,
                contentType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContentKeyPolicyPlayReadyLicense>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyLicense>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyLicense)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicyPlayReadyLicense IPersistableModel<ContentKeyPolicyPlayReadyLicense>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyLicense>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContentKeyPolicyPlayReadyLicense(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyLicense)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyPlayReadyLicense>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
