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
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class EventGridSubscriptionData : IUtf8JsonSerializable, IJsonModel<EventGridSubscriptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridSubscriptionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventGridSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridSubscriptionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Topic))
            {
                writer.WritePropertyName("topic"u8);
                writer.WriteStringValue(Topic);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination, options);
            }
            if (Optional.IsDefined(DeliveryWithResourceIdentity))
            {
                writer.WritePropertyName("deliveryWithResourceIdentity"u8);
                writer.WriteObjectValue(DeliveryWithResourceIdentity, options);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter, options);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeUtc"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(EventDeliverySchema))
            {
                writer.WritePropertyName("eventDeliverySchema"u8);
                writer.WriteStringValue(EventDeliverySchema.Value.ToString());
            }
            if (Optional.IsDefined(RetryPolicy))
            {
                writer.WritePropertyName("retryPolicy"u8);
                writer.WriteObjectValue(RetryPolicy, options);
            }
            if (Optional.IsDefined(DeadLetterDestination))
            {
                writer.WritePropertyName("deadLetterDestination"u8);
                writer.WriteObjectValue(DeadLetterDestination, options);
            }
            if (Optional.IsDefined(DeadLetterWithResourceIdentity))
            {
                writer.WritePropertyName("deadLetterWithResourceIdentity"u8);
                writer.WriteObjectValue(DeadLetterWithResourceIdentity, options);
            }
            writer.WriteEndObject();
        }

        EventGridSubscriptionData IJsonModel<EventGridSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridSubscriptionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridSubscriptionData(document.RootElement, options);
        }

        internal static EventGridSubscriptionData DeserializeEventGridSubscriptionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string topic = default;
            EventSubscriptionProvisioningState? provisioningState = default;
            EventSubscriptionDestination destination = default;
            DeliveryWithResourceIdentity deliveryWithResourceIdentity = default;
            EventSubscriptionFilter filter = default;
            IList<string> labels = default;
            DateTimeOffset? expirationTimeUtc = default;
            EventDeliverySchema? eventDeliverySchema = default;
            EventSubscriptionRetryPolicy retryPolicy = default;
            DeadLetterDestination deadLetterDestination = default;
            DeadLetterWithResourceIdentity deadLetterWithResourceIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("topic"u8))
                        {
                            topic = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new EventSubscriptionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("destination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            destination = EventSubscriptionDestination.DeserializeEventSubscriptionDestination(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("deliveryWithResourceIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryWithResourceIdentity = DeliveryWithResourceIdentity.DeserializeDeliveryWithResourceIdentity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("filter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filter = EventSubscriptionFilter.DeserializeEventSubscriptionFilter(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
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
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("expirationTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("eventDeliverySchema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventDeliverySchema = new EventDeliverySchema(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("retryPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retryPolicy = EventSubscriptionRetryPolicy.DeserializeEventSubscriptionRetryPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("deadLetterDestination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deadLetterDestination = DeadLetterDestination.DeserializeDeadLetterDestination(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("deadLetterWithResourceIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deadLetterWithResourceIdentity = DeadLetterWithResourceIdentity.DeserializeDeadLetterWithResourceIdentity(property0.Value, options);
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
            return new EventGridSubscriptionData(
                id,
                name,
                type,
                systemData,
                topic,
                provisioningState,
                destination,
                deliveryWithResourceIdentity,
                filter,
                labels ?? new ChangeTrackingList<string>(),
                expirationTimeUtc,
                eventDeliverySchema,
                retryPolicy,
                deadLetterDestination,
                deadLetterWithResourceIdentity,
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Topic), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    topic: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Topic))
                {
                    builder.Append("    topic: ");
                    if (Topic.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Topic}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Topic}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Destination), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    destination: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Destination))
                {
                    builder.Append("    destination: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Destination, options, 4, false, "    destination: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeliveryWithResourceIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deliveryWithResourceIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeliveryWithResourceIdentity))
                {
                    builder.Append("    deliveryWithResourceIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DeliveryWithResourceIdentity, options, 4, false, "    deliveryWithResourceIdentity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Filter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    filter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Filter))
                {
                    builder.Append("    filter: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Filter, options, 4, false, "    filter: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Labels), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    labels: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Labels))
                {
                    if (Labels.Any())
                    {
                        builder.Append("    labels: ");
                        builder.AppendLine("[");
                        foreach (var item in Labels)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpireOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    expirationTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpireOn))
                {
                    builder.Append("    expirationTimeUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ExpireOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventDeliverySchema), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    eventDeliverySchema: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EventDeliverySchema))
                {
                    builder.Append("    eventDeliverySchema: ");
                    builder.AppendLine($"'{EventDeliverySchema.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RetryPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    retryPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RetryPolicy))
                {
                    builder.Append("    retryPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RetryPolicy, options, 4, false, "    retryPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeadLetterDestination), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deadLetterDestination: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeadLetterDestination))
                {
                    builder.Append("    deadLetterDestination: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DeadLetterDestination, options, 4, false, "    deadLetterDestination: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeadLetterWithResourceIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deadLetterWithResourceIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeadLetterWithResourceIdentity))
                {
                    builder.Append("    deadLetterWithResourceIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DeadLetterWithResourceIdentity, options, 4, false, "    deadLetterWithResourceIdentity: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EventGridSubscriptionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventGridSubscriptionData)} does not support writing '{options.Format}' format.");
            }
        }

        EventGridSubscriptionData IPersistableModel<EventGridSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEventGridSubscriptionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridSubscriptionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
