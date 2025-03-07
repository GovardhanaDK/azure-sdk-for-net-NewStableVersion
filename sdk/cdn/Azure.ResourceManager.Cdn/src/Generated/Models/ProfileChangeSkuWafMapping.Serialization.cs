// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ProfileChangeSkuWafMapping : IUtf8JsonSerializable, IJsonModel<ProfileChangeSkuWafMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProfileChangeSkuWafMapping>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProfileChangeSkuWafMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileChangeSkuWafMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProfileChangeSkuWafMapping)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("securityPolicyName"u8);
            writer.WriteStringValue(SecurityPolicyName);
            writer.WritePropertyName("changeToWafPolicy"u8);
            JsonSerializer.Serialize(writer, ChangeToWafPolicy);
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

        ProfileChangeSkuWafMapping IJsonModel<ProfileChangeSkuWafMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileChangeSkuWafMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProfileChangeSkuWafMapping)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProfileChangeSkuWafMapping(document.RootElement, options);
        }

        internal static ProfileChangeSkuWafMapping DeserializeProfileChangeSkuWafMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string securityPolicyName = default;
            WritableSubResource changeToWafPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("securityPolicyName"u8))
                {
                    securityPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changeToWafPolicy"u8))
                {
                    changeToWafPolicy = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProfileChangeSkuWafMapping(securityPolicyName, changeToWafPolicy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProfileChangeSkuWafMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileChangeSkuWafMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProfileChangeSkuWafMapping)} does not support writing '{options.Format}' format.");
            }
        }

        ProfileChangeSkuWafMapping IPersistableModel<ProfileChangeSkuWafMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileChangeSkuWafMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeProfileChangeSkuWafMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProfileChangeSkuWafMapping)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProfileChangeSkuWafMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
