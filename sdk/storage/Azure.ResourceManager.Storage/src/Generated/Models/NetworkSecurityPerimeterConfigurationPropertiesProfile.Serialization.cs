// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class NetworkSecurityPerimeterConfigurationPropertiesProfile : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AccessRulesVersion))
            {
                writer.WritePropertyName("accessRulesVersion"u8);
                writer.WriteNumberValue(AccessRulesVersion.Value);
            }
            if (Optional.IsCollectionDefined(AccessRules))
            {
                writer.WritePropertyName("accessRules"u8);
                writer.WriteStartArray();
                foreach (var item in AccessRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiagnosticSettingsVersion))
            {
                writer.WritePropertyName("diagnosticSettingsVersion"u8);
                writer.WriteNumberValue(DiagnosticSettingsVersion.Value);
            }
            if (Optional.IsCollectionDefined(EnabledLogCategories))
            {
                writer.WritePropertyName("enabledLogCategories"u8);
                writer.WriteStartArray();
                foreach (var item in EnabledLogCategories)
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

        NetworkSecurityPerimeterConfigurationPropertiesProfile IJsonModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterConfigurationPropertiesProfile(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterConfigurationPropertiesProfile DeserializeNetworkSecurityPerimeterConfigurationPropertiesProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            float? accessRulesVersion = default;
            IReadOnlyList<NspAccessRule> accessRules = default;
            float? diagnosticSettingsVersion = default;
            IReadOnlyList<string> enabledLogCategories = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessRulesVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessRulesVersion = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("accessRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NspAccessRule> array = new List<NspAccessRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NspAccessRule.DeserializeNspAccessRule(item, options));
                    }
                    accessRules = array;
                    continue;
                }
                if (property.NameEquals("diagnosticSettingsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnosticSettingsVersion = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("enabledLogCategories"u8))
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
                    enabledLogCategories = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkSecurityPerimeterConfigurationPropertiesProfile(
                name,
                accessRulesVersion,
                accessRules ?? new ChangeTrackingList<NspAccessRule>(),
                diagnosticSettingsVersion,
                enabledLogCategories ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessRulesVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accessRulesVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccessRulesVersion))
                {
                    builder.Append("  accessRulesVersion: ");
                    builder.AppendLine($"'{AccessRulesVersion.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessRules), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accessRules: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AccessRules))
                {
                    if (AccessRules.Any())
                    {
                        builder.Append("  accessRules: ");
                        builder.AppendLine("[");
                        foreach (var item in AccessRules)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  accessRules: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DiagnosticSettingsVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  diagnosticSettingsVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DiagnosticSettingsVersion))
                {
                    builder.Append("  diagnosticSettingsVersion: ");
                    builder.AppendLine($"'{DiagnosticSettingsVersion.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnabledLogCategories), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabledLogCategories: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EnabledLogCategories))
                {
                    if (EnabledLogCategories.Any())
                    {
                        builder.Append("  enabledLogCategories: ");
                        builder.AppendLine("[");
                        foreach (var item in EnabledLogCategories)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterConfigurationPropertiesProfile IPersistableModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkSecurityPerimeterConfigurationPropertiesProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationPropertiesProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterConfigurationPropertiesProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
