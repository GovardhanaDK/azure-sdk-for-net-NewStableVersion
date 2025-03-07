// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class FileshareProtectedItemExtendedInfo : IUtf8JsonSerializable, IJsonModel<FileshareProtectedItemExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileshareProtectedItemExtendedInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FileshareProtectedItemExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileshareProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileshareProtectedItemExtendedInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OldestRecoverOn))
            {
                writer.WritePropertyName("oldestRecoveryPoint"u8);
                writer.WriteStringValue(OldestRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointCount))
            {
                writer.WritePropertyName("recoveryPointCount"u8);
                writer.WriteNumberValue(RecoveryPointCount.Value);
            }
            if (Optional.IsDefined(PolicyState))
            {
                writer.WritePropertyName("policyState"u8);
                writer.WriteStringValue(PolicyState);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceStateSyncOn))
            {
                writer.WritePropertyName("resourceStateSyncTime"u8);
                writer.WriteStringValue(ResourceStateSyncOn.Value, "O");
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

        FileshareProtectedItemExtendedInfo IJsonModel<FileshareProtectedItemExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileshareProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileshareProtectedItemExtendedInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileshareProtectedItemExtendedInfo(document.RootElement, options);
        }

        internal static FileshareProtectedItemExtendedInfo DeserializeFileshareProtectedItemExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? oldestRecoveryPoint = default;
            int? recoveryPointCount = default;
            string policyState = default;
            string resourceState = default;
            DateTimeOffset? resourceStateSyncTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oldestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyState"u8))
                {
                    policyState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceState"u8))
                {
                    resourceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceStateSyncTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceStateSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FileshareProtectedItemExtendedInfo(
                oldestRecoveryPoint,
                recoveryPointCount,
                policyState,
                resourceState,
                resourceStateSyncTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FileshareProtectedItemExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileshareProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileshareProtectedItemExtendedInfo)} does not support writing '{options.Format}' format.");
            }
        }

        FileshareProtectedItemExtendedInfo IPersistableModel<FileshareProtectedItemExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileshareProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFileshareProtectedItemExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileshareProtectedItemExtendedInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileshareProtectedItemExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
