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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class StorageQueueEventSubscriptionDestination : IUtf8JsonSerializable, IJsonModel<StorageQueueEventSubscriptionDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageQueueEventSubscriptionDestination>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageQueueEventSubscriptionDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageQueueEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageQueueEventSubscriptionDestination)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(QueueName))
            {
                writer.WritePropertyName("queueName"u8);
                writer.WriteStringValue(QueueName);
            }
            if (Optional.IsDefined(QueueMessageTimeToLiveInSeconds))
            {
                writer.WritePropertyName("queueMessageTimeToLiveInSeconds"u8);
                writer.WriteNumberValue(QueueMessageTimeToLiveInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        StorageQueueEventSubscriptionDestination IJsonModel<StorageQueueEventSubscriptionDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageQueueEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageQueueEventSubscriptionDestination)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageQueueEventSubscriptionDestination(document.RootElement, options);
        }

        internal static StorageQueueEventSubscriptionDestination DeserializeStorageQueueEventSubscriptionDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointType endpointType = default;
            ResourceIdentifier resourceId = default;
            string queueName = default;
            long? queueMessageTimeToLiveInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
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
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("queueName"u8))
                        {
                            queueName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queueMessageTimeToLiveInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queueMessageTimeToLiveInSeconds = property0.Value.GetInt64();
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
            return new StorageQueueEventSubscriptionDestination(endpointType, serializedAdditionalRawData, resourceId, queueName, queueMessageTimeToLiveInSeconds);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  endpointType: ");
                builder.AppendLine($"'{EndpointType.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceId))
                {
                    builder.Append("    resourceId: ");
                    builder.AppendLine($"'{ResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueueName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    queueName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueueName))
                {
                    builder.Append("    queueName: ");
                    if (QueueName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueueName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueueName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueueMessageTimeToLiveInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    queueMessageTimeToLiveInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueueMessageTimeToLiveInSeconds))
                {
                    builder.Append("    queueMessageTimeToLiveInSeconds: ");
                    builder.AppendLine($"'{QueueMessageTimeToLiveInSeconds.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageQueueEventSubscriptionDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageQueueEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageQueueEventSubscriptionDestination)} does not support writing '{options.Format}' format.");
            }
        }

        StorageQueueEventSubscriptionDestination IPersistableModel<StorageQueueEventSubscriptionDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageQueueEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageQueueEventSubscriptionDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageQueueEventSubscriptionDestination)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageQueueEventSubscriptionDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
