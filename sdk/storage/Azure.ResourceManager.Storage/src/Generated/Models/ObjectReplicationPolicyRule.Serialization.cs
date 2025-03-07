// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ObjectReplicationPolicyRule : IUtf8JsonSerializable, IJsonModel<ObjectReplicationPolicyRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ObjectReplicationPolicyRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ObjectReplicationPolicyRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ObjectReplicationPolicyRule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RuleId))
            {
                writer.WritePropertyName("ruleId"u8);
                writer.WriteStringValue(RuleId);
            }
            writer.WritePropertyName("sourceContainer"u8);
            writer.WriteStringValue(SourceContainer);
            writer.WritePropertyName("destinationContainer"u8);
            writer.WriteStringValue(DestinationContainer);
            if (Optional.IsDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteObjectValue(Filters, options);
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

        ObjectReplicationPolicyRule IJsonModel<ObjectReplicationPolicyRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ObjectReplicationPolicyRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeObjectReplicationPolicyRule(document.RootElement, options);
        }

        internal static ObjectReplicationPolicyRule DeserializeObjectReplicationPolicyRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleId = default;
            string sourceContainer = default;
            string destinationContainer = default;
            ObjectReplicationPolicyFilter filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"u8))
                {
                    ruleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceContainer"u8))
                {
                    sourceContainer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationContainer"u8))
                {
                    destinationContainer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filters = ObjectReplicationPolicyFilter.DeserializeObjectReplicationPolicyFilter(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ObjectReplicationPolicyRule(ruleId, sourceContainer, destinationContainer, filters, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuleId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ruleId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RuleId))
                {
                    builder.Append("  ruleId: ");
                    if (RuleId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RuleId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RuleId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceContainer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceContainer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceContainer))
                {
                    builder.Append("  sourceContainer: ");
                    if (SourceContainer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceContainer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceContainer}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DestinationContainer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  destinationContainer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DestinationContainer))
                {
                    builder.Append("  destinationContainer: ");
                    if (DestinationContainer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DestinationContainer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DestinationContainer}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Filters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  filters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Filters))
                {
                    builder.Append("  filters: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Filters, options, 2, false, "  filters: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ObjectReplicationPolicyRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ObjectReplicationPolicyRule)} does not support writing '{options.Format}' format.");
            }
        }

        ObjectReplicationPolicyRule IPersistableModel<ObjectReplicationPolicyRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeObjectReplicationPolicyRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ObjectReplicationPolicyRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ObjectReplicationPolicyRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
