// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedVirtualNetworkSettings : IUtf8JsonSerializable, IJsonModel<SynapseManagedVirtualNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseManagedVirtualNetworkSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseManagedVirtualNetworkSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PreventDataExfiltration))
            {
                writer.WritePropertyName("preventDataExfiltration"u8);
                writer.WriteBooleanValue(PreventDataExfiltration.Value);
            }
            if (Optional.IsDefined(EnableLinkedAccessCheckOnTargetResource))
            {
                writer.WritePropertyName("linkedAccessCheckOnTargetResource"u8);
                writer.WriteBooleanValue(EnableLinkedAccessCheckOnTargetResource.Value);
            }
            if (Optional.IsCollectionDefined(AllowedAadTenantIdsForLinking))
            {
                writer.WritePropertyName("allowedAadTenantIdsForLinking"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedAadTenantIdsForLinking)
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

        SynapseManagedVirtualNetworkSettings IJsonModel<SynapseManagedVirtualNetworkSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedVirtualNetworkSettings(document.RootElement, options);
        }

        internal static SynapseManagedVirtualNetworkSettings DeserializeSynapseManagedVirtualNetworkSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? preventDataExfiltration = default;
            bool? linkedAccessCheckOnTargetResource = default;
            IList<string> allowedAadTenantIdsForLinking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preventDataExfiltration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preventDataExfiltration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linkedAccessCheckOnTargetResource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedAccessCheckOnTargetResource = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedAadTenantIdsForLinking"u8))
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
                    allowedAadTenantIdsForLinking = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseManagedVirtualNetworkSettings(preventDataExfiltration, linkedAccessCheckOnTargetResource, allowedAadTenantIdsForLinking ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseManagedVirtualNetworkSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseManagedVirtualNetworkSettings IPersistableModel<SynapseManagedVirtualNetworkSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedVirtualNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseManagedVirtualNetworkSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseManagedVirtualNetworkSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
