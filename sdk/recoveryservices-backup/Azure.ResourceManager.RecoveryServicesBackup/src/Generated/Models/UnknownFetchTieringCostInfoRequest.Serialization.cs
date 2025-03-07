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
    internal partial class UnknownFetchTieringCostInfoRequest : IUtf8JsonSerializable, IJsonModel<FetchTieringCostInfoContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FetchTieringCostInfoContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FetchTieringCostInfoContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostInfoContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FetchTieringCostInfoContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        FetchTieringCostInfoContent IJsonModel<FetchTieringCostInfoContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostInfoContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FetchTieringCostInfoContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFetchTieringCostInfoContent(document.RootElement, options);
        }

        internal static UnknownFetchTieringCostInfoRequest DeserializeUnknownFetchTieringCostInfoRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryPointTierType sourceTierType = default;
            RecoveryPointTierType targetTierType = default;
            string objectType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceTierType"u8))
                {
                    sourceTierType = property.Value.GetString().ToRecoveryPointTierType();
                    continue;
                }
                if (property.NameEquals("targetTierType"u8))
                {
                    targetTierType = property.Value.GetString().ToRecoveryPointTierType();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownFetchTieringCostInfoRequest(sourceTierType, targetTierType, objectType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FetchTieringCostInfoContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostInfoContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FetchTieringCostInfoContent)} does not support writing '{options.Format}' format.");
            }
        }

        FetchTieringCostInfoContent IPersistableModel<FetchTieringCostInfoContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostInfoContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFetchTieringCostInfoContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FetchTieringCostInfoContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FetchTieringCostInfoContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
