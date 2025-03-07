// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class ResourceQueryRequestOptions : IUtf8JsonSerializable, IJsonModel<ResourceQueryRequestOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceQueryRequestOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceQueryRequestOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SkipToken))
            {
                writer.WritePropertyName("$skipToken"u8);
                writer.WriteStringValue(SkipToken);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("$top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            if (Optional.IsDefined(Skip))
            {
                writer.WritePropertyName("$skip"u8);
                writer.WriteNumberValue(Skip.Value);
            }
            if (Optional.IsDefined(ResultFormat))
            {
                writer.WritePropertyName("resultFormat"u8);
                writer.WriteStringValue(ResultFormat.Value.ToSerialString());
            }
            if (Optional.IsDefined(AllowPartialScopes))
            {
                writer.WritePropertyName("allowPartialScopes"u8);
                writer.WriteBooleanValue(AllowPartialScopes.Value);
            }
            if (Optional.IsDefined(AuthorizationScopeFilter))
            {
                writer.WritePropertyName("authorizationScopeFilter"u8);
                writer.WriteStringValue(AuthorizationScopeFilter.Value.ToSerialString());
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

        ResourceQueryRequestOptions IJsonModel<ResourceQueryRequestOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceQueryRequestOptions(document.RootElement, options);
        }

        internal static ResourceQueryRequestOptions DeserializeResourceQueryRequestOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string skipToken = default;
            int? top = default;
            int? skip = default;
            ResultFormat? resultFormat = default;
            bool? allowPartialScopes = default;
            AuthorizationScopeFilter? authorizationScopeFilter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("$skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("$top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("$skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resultFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultFormat = property.Value.GetString().ToResultFormat();
                    continue;
                }
                if (property.NameEquals("allowPartialScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowPartialScopes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("authorizationScopeFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationScopeFilter = property.Value.GetString().ToAuthorizationScopeFilter();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceQueryRequestOptions(
                skipToken,
                top,
                skip,
                resultFormat,
                allowPartialScopes,
                authorizationScopeFilter,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceQueryRequestOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceQueryRequestOptions IPersistableModel<ResourceQueryRequestOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceQueryRequestOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceQueryRequestOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
