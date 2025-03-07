// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    public partial class MaintenanceConfigurationAssignmentFilter : IUtf8JsonSerializable, IJsonModel<MaintenanceConfigurationAssignmentFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaintenanceConfigurationAssignmentFilter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MaintenanceConfigurationAssignmentFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceConfigurationAssignmentFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceConfigurationAssignmentFilter)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceGroups))
            {
                writer.WritePropertyName("resourceGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OSTypes))
            {
                writer.WritePropertyName("osTypes"u8);
                writer.WriteStartArray();
                foreach (var item in OSTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TagSettings))
            {
                writer.WritePropertyName("tagSettings"u8);
                writer.WriteObjectValue(TagSettings, options);
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

        MaintenanceConfigurationAssignmentFilter IJsonModel<MaintenanceConfigurationAssignmentFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceConfigurationAssignmentFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceConfigurationAssignmentFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceConfigurationAssignmentFilter(document.RootElement, options);
        }

        internal static MaintenanceConfigurationAssignmentFilter DeserializeMaintenanceConfigurationAssignmentFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceType> resourceTypes = default;
            IList<string> resourceGroups = default;
            IList<string> osTypes = default;
            IList<AzureLocation> locations = default;
            VmTagSettings tagSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceType> array = new List<ResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ResourceType(item.GetString()));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("resourceGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGroups = array;
                    continue;
                }
                if (property.NameEquals("osTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    osTypes = array;
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("tagSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagSettings = VmTagSettings.DeserializeVmTagSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MaintenanceConfigurationAssignmentFilter(
                resourceTypes ?? new ChangeTrackingList<ResourceType>(),
                resourceGroups ?? new ChangeTrackingList<string>(),
                osTypes ?? new ChangeTrackingList<string>(),
                locations ?? new ChangeTrackingList<AzureLocation>(),
                tagSettings,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaintenanceConfigurationAssignmentFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceConfigurationAssignmentFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaintenanceConfigurationAssignmentFilter)} does not support writing '{options.Format}' format.");
            }
        }

        MaintenanceConfigurationAssignmentFilter IPersistableModel<MaintenanceConfigurationAssignmentFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceConfigurationAssignmentFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMaintenanceConfigurationAssignmentFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaintenanceConfigurationAssignmentFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaintenanceConfigurationAssignmentFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
