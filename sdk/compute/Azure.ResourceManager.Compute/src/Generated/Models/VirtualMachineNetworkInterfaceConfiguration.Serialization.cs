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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineNetworkInterfaceConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualMachineNetworkInterfaceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineNetworkInterfaceConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineNetworkInterfaceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineNetworkInterfaceConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Primary))
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(Primary.Value);
            }
            if (Optional.IsDefined(DeleteOption))
            {
                writer.WritePropertyName("deleteOption"u8);
                writer.WriteStringValue(DeleteOption.Value.ToString());
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                writer.WritePropertyName("enableAcceleratedNetworking"u8);
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
            }
            if (Optional.IsDefined(IsTcpStateTrackingDisabled))
            {
                writer.WritePropertyName("disableTcpStateTracking"u8);
                writer.WriteBooleanValue(IsTcpStateTrackingDisabled.Value);
            }
            if (Optional.IsDefined(EnableFpga))
            {
                writer.WritePropertyName("enableFpga"u8);
                writer.WriteBooleanValue(EnableFpga.Value);
            }
            if (Optional.IsDefined(EnableIPForwarding))
            {
                writer.WritePropertyName("enableIPForwarding"u8);
                writer.WriteBooleanValue(EnableIPForwarding.Value);
            }
            if (Optional.IsDefined(NetworkSecurityGroup))
            {
                writer.WritePropertyName("networkSecurityGroup"u8);
                JsonSerializer.Serialize(writer, NetworkSecurityGroup);
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings, options);
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DscpConfiguration))
            {
                writer.WritePropertyName("dscpConfiguration"u8);
                JsonSerializer.Serialize(writer, DscpConfiguration);
            }
            if (Optional.IsDefined(AuxiliaryMode))
            {
                writer.WritePropertyName("auxiliaryMode"u8);
                writer.WriteStringValue(AuxiliaryMode.Value.ToString());
            }
            if (Optional.IsDefined(AuxiliarySku))
            {
                writer.WritePropertyName("auxiliarySku"u8);
                writer.WriteStringValue(AuxiliarySku.Value.ToString());
            }
            writer.WriteEndObject();
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

        VirtualMachineNetworkInterfaceConfiguration IJsonModel<VirtualMachineNetworkInterfaceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineNetworkInterfaceConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineNetworkInterfaceConfiguration(document.RootElement, options);
        }

        internal static VirtualMachineNetworkInterfaceConfiguration DeserializeVirtualMachineNetworkInterfaceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            bool? primary = default;
            ComputeDeleteOption? deleteOption = default;
            bool? enableAcceleratedNetworking = default;
            bool? disableTcpStateTracking = default;
            bool? enableFpga = default;
            bool? enableIPForwarding = default;
            WritableSubResource networkSecurityGroup = default;
            VirtualMachineNetworkInterfaceDnsSettingsConfiguration dnsSettings = default;
            IList<VirtualMachineNetworkInterfaceIPConfiguration> ipConfigurations = default;
            WritableSubResource dscpConfiguration = default;
            ComputeNetworkInterfaceAuxiliaryMode? auxiliaryMode = default;
            ComputeNetworkInterfaceAuxiliarySku? auxiliarySku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("primary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deleteOption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteOption = new ComputeDeleteOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableAcceleratedNetworking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAcceleratedNetworking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableTcpStateTracking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableTcpStateTracking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableFpga"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableFpga = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableIPForwarding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableIPForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = VirtualMachineNetworkInterfaceDnsSettingsConfiguration.DeserializeVirtualMachineNetworkInterfaceDnsSettingsConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualMachineNetworkInterfaceIPConfiguration> array = new List<VirtualMachineNetworkInterfaceIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualMachineNetworkInterfaceIPConfiguration.DeserializeVirtualMachineNetworkInterfaceIPConfiguration(item, options));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("dscpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dscpConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("auxiliaryMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            auxiliaryMode = new ComputeNetworkInterfaceAuxiliaryMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("auxiliarySku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            auxiliarySku = new ComputeNetworkInterfaceAuxiliarySku(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineNetworkInterfaceConfiguration(
                name,
                primary,
                deleteOption,
                enableAcceleratedNetworking,
                disableTcpStateTracking,
                enableFpga,
                enableIPForwarding,
                networkSecurityGroup,
                dnsSettings,
                ipConfigurations ?? new ChangeTrackingList<VirtualMachineNetworkInterfaceIPConfiguration>(),
                dscpConfiguration,
                auxiliaryMode,
                auxiliarySku,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineNetworkInterfaceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineNetworkInterfaceConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineNetworkInterfaceConfiguration IPersistableModel<VirtualMachineNetworkInterfaceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVirtualMachineNetworkInterfaceConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineNetworkInterfaceConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineNetworkInterfaceConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
