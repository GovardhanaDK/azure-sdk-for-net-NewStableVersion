// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WorkItemCreateConfiguration : IUtf8JsonSerializable, IJsonModel<WorkItemCreateConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkItemCreateConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkItemCreateConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkItemCreateConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkItemCreateConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ConnectorId))
            {
                writer.WritePropertyName("ConnectorId"u8);
                writer.WriteStringValue(ConnectorId);
            }
            if (Optional.IsDefined(ConnectorDataConfiguration))
            {
                writer.WritePropertyName("ConnectorDataConfiguration"u8);
                writer.WriteStringValue(ConnectorDataConfiguration);
            }
            if (Optional.IsDefined(IsValidateOnly))
            {
                writer.WritePropertyName("ValidateOnly"u8);
                writer.WriteBooleanValue(IsValidateOnly.Value);
            }
            if (Optional.IsCollectionDefined(WorkItemProperties))
            {
                writer.WritePropertyName("WorkItemProperties"u8);
                writer.WriteStartObject();
                foreach (var item in WorkItemProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        WorkItemCreateConfiguration IJsonModel<WorkItemCreateConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkItemCreateConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkItemCreateConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkItemCreateConfiguration(document.RootElement, options);
        }

        internal static WorkItemCreateConfiguration DeserializeWorkItemCreateConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string connectorId = default;
            string connectorDataConfiguration = default;
            bool? validateOnly = default;
            IDictionary<string, string> workItemProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ConnectorId"u8))
                {
                    connectorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ConnectorDataConfiguration"u8))
                {
                    connectorDataConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ValidateOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("WorkItemProperties"u8))
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
                    workItemProperties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkItemCreateConfiguration(connectorId, connectorDataConfiguration, validateOnly, workItemProperties ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkItemCreateConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkItemCreateConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkItemCreateConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        WorkItemCreateConfiguration IPersistableModel<WorkItemCreateConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkItemCreateConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWorkItemCreateConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkItemCreateConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkItemCreateConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
