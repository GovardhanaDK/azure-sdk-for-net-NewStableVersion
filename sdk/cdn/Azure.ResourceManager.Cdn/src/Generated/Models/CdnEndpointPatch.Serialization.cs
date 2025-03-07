// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnEndpointPatch : IUtf8JsonSerializable, IJsonModel<CdnEndpointPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnEndpointPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CdnEndpointPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OriginPath))
            {
                writer.WritePropertyName("originPath"u8);
                writer.WriteStringValue(OriginPath);
            }
            if (Optional.IsCollectionDefined(ContentTypesToCompress))
            {
                writer.WritePropertyName("contentTypesToCompress"u8);
                writer.WriteStartArray();
                foreach (var item in ContentTypesToCompress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(IsCompressionEnabled))
            {
                writer.WritePropertyName("isCompressionEnabled"u8);
                writer.WriteBooleanValue(IsCompressionEnabled.Value);
            }
            if (Optional.IsDefined(IsHttpAllowed))
            {
                writer.WritePropertyName("isHttpAllowed"u8);
                writer.WriteBooleanValue(IsHttpAllowed.Value);
            }
            if (Optional.IsDefined(IsHttpsAllowed))
            {
                writer.WritePropertyName("isHttpsAllowed"u8);
                writer.WriteBooleanValue(IsHttpsAllowed.Value);
            }
            if (Optional.IsDefined(QueryStringCachingBehavior))
            {
                writer.WritePropertyName("queryStringCachingBehavior"u8);
                writer.WriteStringValue(QueryStringCachingBehavior.Value.ToSerialString());
            }
            if (Optional.IsDefined(OptimizationType))
            {
                if (OptimizationType != null)
                {
                    writer.WritePropertyName("optimizationType"u8);
                    writer.WriteStringValue(OptimizationType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("optimizationType");
                }
            }
            if (Optional.IsDefined(ProbePath))
            {
                writer.WritePropertyName("probePath"u8);
                writer.WriteStringValue(ProbePath);
            }
            if (Optional.IsCollectionDefined(GeoFilters))
            {
                writer.WritePropertyName("geoFilters"u8);
                writer.WriteStartArray();
                foreach (var item in GeoFilters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultOriginGroup))
            {
                if (DefaultOriginGroup != null)
                {
                    writer.WritePropertyName("defaultOriginGroup"u8);
                    writer.WriteObjectValue(DefaultOriginGroup, options);
                }
                else
                {
                    writer.WriteNull("defaultOriginGroup");
                }
            }
            if (Optional.IsCollectionDefined(UriSigningKeys))
            {
                if (UriSigningKeys != null)
                {
                    writer.WritePropertyName("urlSigningKeys"u8);
                    writer.WriteStartArray();
                    foreach (var item in UriSigningKeys)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("urlSigningKeys");
                }
            }
            if (Optional.IsDefined(DeliveryPolicy))
            {
                if (DeliveryPolicy != null)
                {
                    writer.WritePropertyName("deliveryPolicy"u8);
                    writer.WriteObjectValue(DeliveryPolicy, options);
                }
                else
                {
                    writer.WriteNull("deliveryPolicy");
                }
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                if (WebApplicationFirewallPolicyLink != null)
                {
                    writer.WritePropertyName("webApplicationFirewallPolicyLink"u8);
                    writer.WriteObjectValue(WebApplicationFirewallPolicyLink, options);
                }
                else
                {
                    writer.WriteNull("webApplicationFirewallPolicyLink");
                }
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

        CdnEndpointPatch IJsonModel<CdnEndpointPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnEndpointPatch(document.RootElement, options);
        }

        internal static CdnEndpointPatch DeserializeCdnEndpointPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string originPath = default;
            IList<string> contentTypesToCompress = default;
            string originHostHeader = default;
            bool? isCompressionEnabled = default;
            bool? isHttpAllowed = default;
            bool? isHttpsAllowed = default;
            QueryStringCachingBehavior? queryStringCachingBehavior = default;
            OptimizationType? optimizationType = default;
            string probePath = default;
            IList<GeoFilter> geoFilters = default;
            EndpointPropertiesUpdateParametersDefaultOriginGroup defaultOriginGroup = default;
            IList<UriSigningKey> uriSigningKeys = default;
            EndpointDeliveryPolicy deliveryPolicy = default;
            EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink webApplicationFirewallPolicyLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("originPath"u8))
                        {
                            originPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentTypesToCompress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            contentTypesToCompress = array;
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCompressionEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCompressionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHttpAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpsAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHttpsAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queryStringCachingBehavior"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryStringCachingBehavior = property0.Value.GetString().ToQueryStringCachingBehavior();
                            continue;
                        }
                        if (property0.NameEquals("optimizationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                optimizationType = null;
                                continue;
                            }
                            optimizationType = new OptimizationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("probePath"u8))
                        {
                            probePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geoFilters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GeoFilter> array = new List<GeoFilter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GeoFilter.DeserializeGeoFilter(item, options));
                            }
                            geoFilters = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultOriginGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                defaultOriginGroup = null;
                                continue;
                            }
                            defaultOriginGroup = EndpointPropertiesUpdateParametersDefaultOriginGroup.DeserializeEndpointPropertiesUpdateParametersDefaultOriginGroup(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("urlSigningKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                uriSigningKeys = null;
                                continue;
                            }
                            List<UriSigningKey> array = new List<UriSigningKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UriSigningKey.DeserializeUriSigningKey(item, options));
                            }
                            uriSigningKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("deliveryPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                deliveryPolicy = null;
                                continue;
                            }
                            deliveryPolicy = EndpointDeliveryPolicy.DeserializeEndpointDeliveryPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                webApplicationFirewallPolicyLink = null;
                                continue;
                            }
                            webApplicationFirewallPolicyLink = EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink.DeserializeEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(property0.Value, options);
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
            return new CdnEndpointPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                originPath,
                contentTypesToCompress ?? new ChangeTrackingList<string>(),
                originHostHeader,
                isCompressionEnabled,
                isHttpAllowed,
                isHttpsAllowed,
                queryStringCachingBehavior,
                optimizationType,
                probePath,
                geoFilters ?? new ChangeTrackingList<GeoFilter>(),
                defaultOriginGroup,
                uriSigningKeys ?? new ChangeTrackingList<UriSigningKey>(),
                deliveryPolicy,
                webApplicationFirewallPolicyLink,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnEndpointPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support writing '{options.Format}' format.");
            }
        }

        CdnEndpointPatch IPersistableModel<CdnEndpointPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCdnEndpointPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnEndpointPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
