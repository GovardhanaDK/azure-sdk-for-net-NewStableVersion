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

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationNavigation : IUtf8JsonSerializable, IJsonModel<GuestConfigurationNavigation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestConfigurationNavigation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GuestConfigurationNavigation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Kind))
            {
                if (Kind != null)
                {
                    writer.WritePropertyName("kind"u8);
                    writer.WriteStringValue(Kind.Value.ToString());
                }
                else
                {
                    writer.WriteNull("kind");
                }
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(ContentUri))
            {
                writer.WritePropertyName("contentUri"u8);
                writer.WriteStringValue(ContentUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ContentHash))
            {
                writer.WritePropertyName("contentHash"u8);
                writer.WriteStringValue(ContentHash);
            }
            if (Optional.IsDefined(ContentManagedIdentity))
            {
                writer.WritePropertyName("contentManagedIdentity"u8);
                writer.WriteStringValue(ContentManagedIdentity);
            }
            if (Optional.IsDefined(AssignmentType))
            {
                if (AssignmentType != null)
                {
                    writer.WritePropertyName("assignmentType"u8);
                    writer.WriteStringValue(AssignmentType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("assignmentType");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(AssignmentSource))
            {
                if (AssignmentSource != null)
                {
                    writer.WritePropertyName("assignmentSource"u8);
                    writer.WriteStringValue(AssignmentSource);
                }
                else
                {
                    writer.WriteNull("assignmentSource");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ContentType))
            {
                if (ContentType != null)
                {
                    writer.WritePropertyName("contentType"u8);
                    writer.WriteStringValue(ContentType);
                }
                else
                {
                    writer.WriteNull("contentType");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationParameters))
            {
                writer.WritePropertyName("configurationParameter"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationParameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedParameters))
            {
                writer.WritePropertyName("configurationProtectedParameter"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationProtectedParameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationSetting))
            {
                if (ConfigurationSetting != null)
                {
                    writer.WritePropertyName("configurationSetting"u8);
                    writer.WriteObjectValue(ConfigurationSetting, options);
                }
                else
                {
                    writer.WriteNull("configurationSetting");
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

        GuestConfigurationNavigation IJsonModel<GuestConfigurationNavigation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationNavigation(document.RootElement, options);
        }

        internal static GuestConfigurationNavigation DeserializeGuestConfigurationNavigation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GuestConfigurationKind? kind = default;
            string name = default;
            string version = default;
            Uri contentUri = default;
            string contentHash = default;
            string contentManagedIdentity = default;
            GuestConfigurationAssignmentType? assignmentType = default;
            string assignmentSource = default;
            string contentType = default;
            IList<GuestConfigurationParameter> configurationParameter = default;
            IList<GuestConfigurationParameter> configurationProtectedParameter = default;
            LcmConfigurationSetting configurationSetting = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        kind = null;
                        continue;
                    }
                    kind = new GuestConfigurationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentHash"u8))
                {
                    contentHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentManagedIdentity"u8))
                {
                    contentManagedIdentity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignmentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentType = null;
                        continue;
                    }
                    assignmentType = new GuestConfigurationAssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignmentSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentSource = null;
                        continue;
                    }
                    assignmentSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contentType = null;
                        continue;
                    }
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GuestConfigurationParameter> array = new List<GuestConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestConfigurationParameter.DeserializeGuestConfigurationParameter(item, options));
                    }
                    configurationParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationProtectedParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GuestConfigurationParameter> array = new List<GuestConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestConfigurationParameter.DeserializeGuestConfigurationParameter(item, options));
                    }
                    configurationProtectedParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        configurationSetting = null;
                        continue;
                    }
                    configurationSetting = LcmConfigurationSetting.DeserializeLcmConfigurationSetting(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GuestConfigurationNavigation(
                kind,
                name,
                version,
                contentUri,
                contentHash,
                contentManagedIdentity,
                assignmentType,
                assignmentSource,
                contentType,
                configurationParameter ?? new ChangeTrackingList<GuestConfigurationParameter>(),
                configurationProtectedParameter ?? new ChangeTrackingList<GuestConfigurationParameter>(),
                configurationSetting,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    builder.AppendLine($"'{Kind.Value.ToString()}'");
                }
            }

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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Version))
                {
                    builder.Append("  version: ");
                    if (Version.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Version}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Version}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContentUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contentUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContentUri))
                {
                    builder.Append("  contentUri: ");
                    builder.AppendLine($"'{ContentUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContentHash), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contentHash: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContentHash))
                {
                    builder.Append("  contentHash: ");
                    if (ContentHash.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContentHash}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContentHash}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContentManagedIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contentManagedIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContentManagedIdentity))
                {
                    builder.Append("  contentManagedIdentity: ");
                    if (ContentManagedIdentity.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContentManagedIdentity}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContentManagedIdentity}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignmentType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  assignmentType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AssignmentType))
                {
                    builder.Append("  assignmentType: ");
                    builder.AppendLine($"'{AssignmentType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignmentSource), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  assignmentSource: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AssignmentSource))
                {
                    builder.Append("  assignmentSource: ");
                    if (AssignmentSource.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AssignmentSource}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AssignmentSource}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContentType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contentType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContentType))
                {
                    builder.Append("  contentType: ");
                    if (ContentType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContentType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContentType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConfigurationParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  configurationParameter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ConfigurationParameters))
                {
                    if (ConfigurationParameters.Any())
                    {
                        builder.Append("  configurationParameter: ");
                        builder.AppendLine("[");
                        foreach (var item in ConfigurationParameters)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  configurationParameter: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConfigurationProtectedParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  configurationProtectedParameter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ConfigurationProtectedParameters))
                {
                    if (ConfigurationProtectedParameters.Any())
                    {
                        builder.Append("  configurationProtectedParameter: ");
                        builder.AppendLine("[");
                        foreach (var item in ConfigurationProtectedParameters)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  configurationProtectedParameter: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConfigurationSetting), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  configurationSetting: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConfigurationSetting))
                {
                    builder.Append("  configurationSetting: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ConfigurationSetting, options, 2, false, "  configurationSetting: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<GuestConfigurationNavigation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support writing '{options.Format}' format.");
            }
        }

        GuestConfigurationNavigation IPersistableModel<GuestConfigurationNavigation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationNavigation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGuestConfigurationNavigation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationNavigation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestConfigurationNavigation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
