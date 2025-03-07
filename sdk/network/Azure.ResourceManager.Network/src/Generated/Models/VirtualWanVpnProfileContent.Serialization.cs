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
    public partial class VirtualWanVpnProfileContent : IUtf8JsonSerializable, IJsonModel<VirtualWanVpnProfileContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualWanVpnProfileContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualWanVpnProfileContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanVpnProfileContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualWanVpnProfileContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(VpnServerConfigurationResourceId))
            {
                writer.WritePropertyName("vpnServerConfigurationResourceId"u8);
                writer.WriteStringValue(VpnServerConfigurationResourceId);
            }
            if (Optional.IsDefined(AuthenticationMethod))
            {
                writer.WritePropertyName("authenticationMethod"u8);
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
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

        VirtualWanVpnProfileContent IJsonModel<VirtualWanVpnProfileContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanVpnProfileContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualWanVpnProfileContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualWanVpnProfileContent(document.RootElement, options);
        }

        internal static VirtualWanVpnProfileContent DeserializeVirtualWanVpnProfileContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vpnServerConfigurationResourceId = default;
            NetworkAuthenticationMethod? authenticationMethod = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnServerConfigurationResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vpnServerConfigurationResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authenticationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMethod = new NetworkAuthenticationMethod(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualWanVpnProfileContent(vpnServerConfigurationResourceId, authenticationMethod, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualWanVpnProfileContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanVpnProfileContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualWanVpnProfileContent)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualWanVpnProfileContent IPersistableModel<VirtualWanVpnProfileContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanVpnProfileContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVirtualWanVpnProfileContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualWanVpnProfileContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualWanVpnProfileContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
