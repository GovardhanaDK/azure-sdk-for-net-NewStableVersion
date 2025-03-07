// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceEnvironmentInfo : IUtf8JsonSerializable, IJsonModel<DynatraceEnvironmentInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceEnvironmentInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DynatraceEnvironmentInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceEnvironmentInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceEnvironmentInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsDefined(IngestionKey))
            {
                writer.WritePropertyName("ingestionKey"u8);
                writer.WriteStringValue(IngestionKey);
            }
            if (Optional.IsDefined(LogsIngestionEndpoint))
            {
                writer.WritePropertyName("logsIngestionEndpoint"u8);
                writer.WriteStringValue(LogsIngestionEndpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(LandingUri))
            {
                writer.WritePropertyName("landingURL"u8);
                writer.WriteStringValue(LandingUri.AbsoluteUri);
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

        DynatraceEnvironmentInfo IJsonModel<DynatraceEnvironmentInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceEnvironmentInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceEnvironmentInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceEnvironmentInfo(document.RootElement, options);
        }

        internal static DynatraceEnvironmentInfo DeserializeDynatraceEnvironmentInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string environmentId = default;
            string ingestionKey = default;
            Uri logsIngestionEndpoint = default;
            Uri landingUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentId"u8))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ingestionKey"u8))
                {
                    ingestionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logsIngestionEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logsIngestionEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("landingURL"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    landingUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DynatraceEnvironmentInfo(environmentId, ingestionKey, logsIngestionEndpoint, landingUri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceEnvironmentInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceEnvironmentInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceEnvironmentInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DynatraceEnvironmentInfo IPersistableModel<DynatraceEnvironmentInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceEnvironmentInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDynatraceEnvironmentInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceEnvironmentInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceEnvironmentInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
