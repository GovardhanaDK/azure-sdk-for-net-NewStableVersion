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
    public partial class DnsSettings : IUtf8JsonSerializable, IJsonModel<DnsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DnsSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DnsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Servers))
            {
                writer.WritePropertyName("servers"u8);
                writer.WriteStartArray();
                foreach (var item in Servers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableProxy))
            {
                writer.WritePropertyName("enableProxy"u8);
                writer.WriteBooleanValue(EnableProxy.Value);
            }
            if (Optional.IsDefined(RequireProxyForNetworkRules))
            {
                if (RequireProxyForNetworkRules != null)
                {
                    writer.WritePropertyName("requireProxyForNetworkRules"u8);
                    writer.WriteBooleanValue(RequireProxyForNetworkRules.Value);
                }
                else
                {
                    writer.WriteNull("requireProxyForNetworkRules");
                }
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

        DnsSettings IJsonModel<DnsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDnsSettings(document.RootElement, options);
        }

        internal static DnsSettings DeserializeDnsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> servers = default;
            bool? enableProxy = default;
            bool? requireProxyForNetworkRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("servers"u8))
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
                    servers = array;
                    continue;
                }
                if (property.NameEquals("enableProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requireProxyForNetworkRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requireProxyForNetworkRules = null;
                        continue;
                    }
                    requireProxyForNetworkRules = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DnsSettings(servers ?? new ChangeTrackingList<string>(), enableProxy, requireProxyForNetworkRules, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DnsSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DnsSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DnsSettings IPersistableModel<DnsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDnsSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DnsSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DnsSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
