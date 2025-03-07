// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ResourceGuardProperties : IUtf8JsonSerializable, IJsonModel<ResourceGuardProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceGuardProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceGuardProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsAutoApprovalsAllowed))
            {
                writer.WritePropertyName("allowAutoApprovals"u8);
                writer.WriteBooleanValue(IsAutoApprovalsAllowed.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ResourceGuardOperations))
            {
                writer.WritePropertyName("resourceGuardOperations"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VaultCriticalOperationExclusionList))
            {
                writer.WritePropertyName("vaultCriticalOperationExclusionList"u8);
                writer.WriteStartArray();
                foreach (var item in VaultCriticalOperationExclusionList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        ResourceGuardProperties IJsonModel<ResourceGuardProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceGuardProperties(document.RootElement, options);
        }

        internal static ResourceGuardProperties DeserializeResourceGuardProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupProvisioningState? provisioningState = default;
            bool? allowAutoApprovals = default;
            IReadOnlyList<ResourceGuardOperationDetails> resourceGuardOperations = default;
            IList<string> vaultCriticalOperationExclusionList = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataProtectionBackupProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowAutoApprovals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowAutoApprovals = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceGuardOperationDetails> array = new List<ResourceGuardOperationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceGuardOperationDetails.DeserializeResourceGuardOperationDetails(item, options));
                    }
                    resourceGuardOperations = array;
                    continue;
                }
                if (property.NameEquals("vaultCriticalOperationExclusionList"u8))
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
                    vaultCriticalOperationExclusionList = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceGuardProperties(
                provisioningState,
                allowAutoApprovals,
                resourceGuardOperations ?? new ChangeTrackingList<ResourceGuardOperationDetails>(),
                vaultCriticalOperationExclusionList ?? new ChangeTrackingList<string>(),
                description,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceGuardProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceGuardProperties IPersistableModel<ResourceGuardProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceGuardProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceGuardProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
