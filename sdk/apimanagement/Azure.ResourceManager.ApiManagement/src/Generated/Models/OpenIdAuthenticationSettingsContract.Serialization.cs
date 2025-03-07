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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class OpenIdAuthenticationSettingsContract : IUtf8JsonSerializable, IJsonModel<OpenIdAuthenticationSettingsContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenIdAuthenticationSettingsContract>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OpenIdAuthenticationSettingsContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdAuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenIdAuthenticationSettingsContract)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OpenIdProviderId))
            {
                writer.WritePropertyName("openidProviderId"u8);
                writer.WriteStringValue(OpenIdProviderId);
            }
            if (Optional.IsCollectionDefined(BearerTokenSendingMethods))
            {
                writer.WritePropertyName("bearerTokenSendingMethods"u8);
                writer.WriteStartArray();
                foreach (var item in BearerTokenSendingMethods)
                {
                    writer.WriteStringValue(item.ToString());
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

        OpenIdAuthenticationSettingsContract IJsonModel<OpenIdAuthenticationSettingsContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdAuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenIdAuthenticationSettingsContract)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenIdAuthenticationSettingsContract(document.RootElement, options);
        }

        internal static OpenIdAuthenticationSettingsContract DeserializeOpenIdAuthenticationSettingsContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string openidProviderId = default;
            IList<BearerTokenSendingMethod> bearerTokenSendingMethods = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("openidProviderId"u8))
                {
                    openidProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bearerTokenSendingMethods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BearerTokenSendingMethod> array = new List<BearerTokenSendingMethod>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new BearerTokenSendingMethod(item.GetString()));
                    }
                    bearerTokenSendingMethods = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OpenIdAuthenticationSettingsContract(openidProviderId, bearerTokenSendingMethods ?? new ChangeTrackingList<BearerTokenSendingMethod>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OpenIdProviderId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  openidProviderId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OpenIdProviderId))
                {
                    builder.Append("  openidProviderId: ");
                    if (OpenIdProviderId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OpenIdProviderId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OpenIdProviderId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BearerTokenSendingMethods), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  bearerTokenSendingMethods: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BearerTokenSendingMethods))
                {
                    if (BearerTokenSendingMethods.Any())
                    {
                        builder.Append("  bearerTokenSendingMethods: ");
                        builder.AppendLine("[");
                        foreach (var item in BearerTokenSendingMethods)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OpenIdAuthenticationSettingsContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdAuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OpenIdAuthenticationSettingsContract)} does not support writing '{options.Format}' format.");
            }
        }

        OpenIdAuthenticationSettingsContract IPersistableModel<OpenIdAuthenticationSettingsContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdAuthenticationSettingsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOpenIdAuthenticationSettingsContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenIdAuthenticationSettingsContract)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenIdAuthenticationSettingsContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
