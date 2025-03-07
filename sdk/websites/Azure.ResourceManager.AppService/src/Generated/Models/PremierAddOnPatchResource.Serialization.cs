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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PremierAddOnPatchResource : IUtf8JsonSerializable, IJsonModel<PremierAddOnPatchResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PremierAddOnPatchResource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PremierAddOnPatchResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (Optional.IsDefined(MarketplacePublisher))
            {
                writer.WritePropertyName("marketplacePublisher"u8);
                writer.WriteStringValue(MarketplacePublisher);
            }
            if (Optional.IsDefined(MarketplaceOffer))
            {
                writer.WritePropertyName("marketplaceOffer"u8);
                writer.WriteStringValue(MarketplaceOffer);
            }
            writer.WriteEndObject();
        }

        PremierAddOnPatchResource IJsonModel<PremierAddOnPatchResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePremierAddOnPatchResource(document.RootElement, options);
        }

        internal static PremierAddOnPatchResource DeserializePremierAddOnPatchResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string sku = default;
            string product = default;
            string vendor = default;
            string marketplacePublisher = default;
            string marketplaceOffer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplacePublisher"u8))
                        {
                            marketplacePublisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceOffer"u8))
                        {
                            marketplaceOffer = property0.Value.GetString();
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
            return new PremierAddOnPatchResource(
                id,
                name,
                type,
                systemData,
                sku,
                product,
                vendor,
                marketplacePublisher,
                marketplaceOffer,
                kind,
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
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sku), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sku: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("    sku: ");
                    if (Sku.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Sku}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Sku}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Product), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    product: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Product))
                {
                    builder.Append("    product: ");
                    if (Product.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Product}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Product}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Vendor), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vendor: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Vendor))
                {
                    builder.Append("    vendor: ");
                    if (Vendor.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Vendor}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Vendor}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MarketplacePublisher), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    marketplacePublisher: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MarketplacePublisher))
                {
                    builder.Append("    marketplacePublisher: ");
                    if (MarketplacePublisher.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MarketplacePublisher}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MarketplacePublisher}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MarketplaceOffer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    marketplaceOffer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MarketplaceOffer))
                {
                    builder.Append("    marketplaceOffer: ");
                    if (MarketplaceOffer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MarketplaceOffer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MarketplaceOffer}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PremierAddOnPatchResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support writing '{options.Format}' format.");
            }
        }

        PremierAddOnPatchResource IPersistableModel<PremierAddOnPatchResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePremierAddOnPatchResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PremierAddOnPatchResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
