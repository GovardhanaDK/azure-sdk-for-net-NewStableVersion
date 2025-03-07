// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnServerConfigurationPolicyGroupMember : IUtf8JsonSerializable, IJsonModel<VpnServerConfigurationPolicyGroupMember>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnServerConfigurationPolicyGroupMember>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VpnServerConfigurationPolicyGroupMember>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationPolicyGroupMember>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnServerConfigurationPolicyGroupMember)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AttributeType))
            {
                writer.WritePropertyName("attributeType"u8);
                writer.WriteStringValue(AttributeType.Value.ToString());
            }
            if (Optional.IsDefined(AttributeValue))
            {
                writer.WritePropertyName("attributeValue"u8);
                writer.WriteStringValue(AttributeValue);
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

        VpnServerConfigurationPolicyGroupMember IJsonModel<VpnServerConfigurationPolicyGroupMember>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationPolicyGroupMember>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnServerConfigurationPolicyGroupMember)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnServerConfigurationPolicyGroupMember(document.RootElement, options);
        }

        internal static VpnServerConfigurationPolicyGroupMember DeserializeVpnServerConfigurationPolicyGroupMember(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            VpnPolicyMemberAttributeType? attributeType = default;
            string attributeValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributeType = new VpnPolicyMemberAttributeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attributeValue"u8))
                {
                    attributeValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VpnServerConfigurationPolicyGroupMember(name, attributeType, attributeValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnServerConfigurationPolicyGroupMember>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationPolicyGroupMember>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnServerConfigurationPolicyGroupMember)} does not support writing '{options.Format}' format.");
            }
        }

        VpnServerConfigurationPolicyGroupMember IPersistableModel<VpnServerConfigurationPolicyGroupMember>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationPolicyGroupMember>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVpnServerConfigurationPolicyGroupMember(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnServerConfigurationPolicyGroupMember)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnServerConfigurationPolicyGroupMember>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
