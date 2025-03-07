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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DomainAvailabilityCheckResult : IUtf8JsonSerializable, IJsonModel<DomainAvailabilityCheckResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DomainAvailabilityCheckResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DomainAvailabilityCheckResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAvailabilityCheckResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainAvailabilityCheckResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IsAvailable))
            {
                writer.WritePropertyName("available"u8);
                writer.WriteBooleanValue(IsAvailable.Value);
            }
            if (Optional.IsDefined(DomainType))
            {
                writer.WritePropertyName("domainType"u8);
                writer.WriteStringValue(DomainType.Value.ToSerialString());
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

        DomainAvailabilityCheckResult IJsonModel<DomainAvailabilityCheckResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAvailabilityCheckResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainAvailabilityCheckResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainAvailabilityCheckResult(document.RootElement, options);
        }

        internal static DomainAvailabilityCheckResult DeserializeDomainAvailabilityCheckResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            bool? available = default;
            AppServiceDomainType? domainType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("available"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    available = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("domainType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainType = property.Value.GetString().ToAppServiceDomainType();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DomainAvailabilityCheckResult(name, available, domainType, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAvailable), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  available: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAvailable))
                {
                    builder.Append("  available: ");
                    var boolValue = IsAvailable.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DomainType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  domainType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DomainType))
                {
                    builder.Append("  domainType: ");
                    builder.AppendLine($"'{DomainType.Value.ToSerialString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DomainAvailabilityCheckResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAvailabilityCheckResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DomainAvailabilityCheckResult)} does not support writing '{options.Format}' format.");
            }
        }

        DomainAvailabilityCheckResult IPersistableModel<DomainAvailabilityCheckResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainAvailabilityCheckResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDomainAvailabilityCheckResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DomainAvailabilityCheckResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DomainAvailabilityCheckResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
