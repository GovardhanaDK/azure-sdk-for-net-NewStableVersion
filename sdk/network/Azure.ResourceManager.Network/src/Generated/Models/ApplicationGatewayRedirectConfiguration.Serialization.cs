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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRedirectConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayRedirectConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayRedirectConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationGatewayRedirectConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRedirectConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RedirectType))
            {
                writer.WritePropertyName("redirectType"u8);
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (Optional.IsDefined(TargetListener))
            {
                writer.WritePropertyName("targetListener"u8);
                JsonSerializer.Serialize(writer, TargetListener);
            }
            if (Optional.IsDefined(TargetUri))
            {
                writer.WritePropertyName("targetUrl"u8);
                writer.WriteStringValue(TargetUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IncludePath))
            {
                writer.WritePropertyName("includePath"u8);
                writer.WriteBooleanValue(IncludePath.Value);
            }
            if (Optional.IsDefined(IncludeQueryString))
            {
                writer.WritePropertyName("includeQueryString"u8);
                writer.WriteBooleanValue(IncludeQueryString.Value);
            }
            if (Optional.IsCollectionDefined(RequestRoutingRules))
            {
                writer.WritePropertyName("requestRoutingRules"u8);
                writer.WriteStartArray();
                foreach (var item in RequestRoutingRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UrlPathMaps))
            {
                writer.WritePropertyName("urlPathMaps"u8);
                writer.WriteStartArray();
                foreach (var item in UrlPathMaps)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PathRules))
            {
                writer.WritePropertyName("pathRules"u8);
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        ApplicationGatewayRedirectConfiguration IJsonModel<ApplicationGatewayRedirectConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRedirectConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayRedirectConfiguration(document.RootElement, options);
        }

        internal static ApplicationGatewayRedirectConfiguration DeserializeApplicationGatewayRedirectConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            ApplicationGatewayRedirectType? redirectType = default;
            WritableSubResource targetListener = default;
            Uri targetUrl = default;
            bool? includePath = default;
            bool? includeQueryString = default;
            IList<WritableSubResource> requestRoutingRules = default;
            IList<WritableSubResource> urlPathMaps = default;
            IList<WritableSubResource> pathRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("redirectType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redirectType = new ApplicationGatewayRedirectType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetListener"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetListener = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("targetUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("includePath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            includePath = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("includeQueryString"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            includeQueryString = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requestRoutingRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            requestRoutingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("urlPathMaps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            urlPathMaps = array;
                            continue;
                        }
                        if (property0.NameEquals("pathRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            pathRules = array;
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
            return new ApplicationGatewayRedirectConfiguration(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                redirectType,
                targetListener,
                targetUrl,
                includePath,
                includeQueryString,
                requestRoutingRules ?? new ChangeTrackingList<WritableSubResource>(),
                urlPathMaps ?? new ChangeTrackingList<WritableSubResource>(),
                pathRules ?? new ChangeTrackingList<WritableSubResource>());
        }

        BinaryData IPersistableModel<ApplicationGatewayRedirectConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRedirectConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayRedirectConfiguration IPersistableModel<ApplicationGatewayRedirectConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationGatewayRedirectConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRedirectConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayRedirectConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
