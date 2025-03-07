// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRouterWorkerOfferIssuedEventData : IUtf8JsonSerializable, IJsonModel<AcsRouterWorkerOfferIssuedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsRouterWorkerOfferIssuedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsRouterWorkerOfferIssuedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferIssuedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsRouterWorkerOfferIssuedEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId"u8);
                writer.WriteStringValue(QueueId);
            }
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (Optional.IsDefined(JobPriority))
            {
                writer.WritePropertyName("jobPriority"u8);
                writer.WriteNumberValue(JobPriority.Value);
            }
            writer.WritePropertyName("workerLabels"u8);
            writer.WriteStartObject();
            foreach (var item in WorkerLabels)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            if (Optional.IsDefined(OfferedOn))
            {
                writer.WritePropertyName("offeredOn"u8);
                writer.WriteStringValue(OfferedOn.Value, "O");
            }
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expiresOn"u8);
                writer.WriteStringValue(ExpiresOn.Value, "O");
            }
            writer.WritePropertyName("workerTags"u8);
            writer.WriteStartObject();
            foreach (var item in WorkerTags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("jobLabels"u8);
            writer.WriteStartObject();
            foreach (var item in JobLabels)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("jobTags"u8);
            writer.WriteStartObject();
            foreach (var item in JobTags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
        }

        AcsRouterWorkerOfferIssuedEventData IJsonModel<AcsRouterWorkerOfferIssuedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferIssuedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsRouterWorkerOfferIssuedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRouterWorkerOfferIssuedEventData(document.RootElement, options);
        }

        internal static AcsRouterWorkerOfferIssuedEventData DeserializeAcsRouterWorkerOfferIssuedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queueId = default;
            string offerId = default;
            int? jobPriority = default;
            IReadOnlyDictionary<string, string> workerLabels = default;
            DateTimeOffset? offeredOn = default;
            DateTimeOffset? expiresOn = default;
            IReadOnlyDictionary<string, string> workerTags = default;
            IReadOnlyDictionary<string, string> jobLabels = default;
            IReadOnlyDictionary<string, string> jobTags = default;
            string workerId = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobPriority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("workerLabels"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    workerLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("offeredOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offeredOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiresOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("workerTags"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    workerTags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobLabels"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    jobLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("jobTags"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    jobTags = dictionary;
                    continue;
                }
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AcsRouterWorkerOfferIssuedEventData(
                jobId,
                channelReference,
                channelId,
                serializedAdditionalRawData,
                workerId,
                queueId,
                offerId,
                jobPriority,
                workerLabels,
                offeredOn,
                expiresOn,
                workerTags,
                jobLabels,
                jobTags);
        }

        BinaryData IPersistableModel<AcsRouterWorkerOfferIssuedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferIssuedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcsRouterWorkerOfferIssuedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        AcsRouterWorkerOfferIssuedEventData IPersistableModel<AcsRouterWorkerOfferIssuedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferIssuedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAcsRouterWorkerOfferIssuedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsRouterWorkerOfferIssuedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsRouterWorkerOfferIssuedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsRouterWorkerOfferIssuedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsRouterWorkerOfferIssuedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
