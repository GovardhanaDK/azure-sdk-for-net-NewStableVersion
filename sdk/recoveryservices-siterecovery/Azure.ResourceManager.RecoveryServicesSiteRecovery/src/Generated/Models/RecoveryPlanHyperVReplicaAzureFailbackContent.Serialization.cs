// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanHyperVReplicaAzureFailbackContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanHyperVReplicaAzureFailbackContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanHyperVReplicaAzureFailbackContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPlanHyperVReplicaAzureFailbackContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailbackContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailbackContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("dataSyncOption"u8);
            writer.WriteStringValue(DataSyncOption.ToString());
            writer.WritePropertyName("recoveryVmCreationOption"u8);
            writer.WriteStringValue(RecoveryVmCreationOption.ToString());
        }

        RecoveryPlanHyperVReplicaAzureFailbackContent IJsonModel<RecoveryPlanHyperVReplicaAzureFailbackContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailbackContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailbackContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanHyperVReplicaAzureFailbackContent(document.RootElement, options);
        }

        internal static RecoveryPlanHyperVReplicaAzureFailbackContent DeserializeRecoveryPlanHyperVReplicaAzureFailbackContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SiteRecoveryDataSyncStatus dataSyncOption = default;
            AlternateLocationRecoveryOption recoveryVmCreationOption = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSyncOption"u8))
                {
                    dataSyncOption = new SiteRecoveryDataSyncStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryVmCreationOption"u8))
                {
                    recoveryVmCreationOption = new AlternateLocationRecoveryOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPlanHyperVReplicaAzureFailbackContent(instanceType, serializedAdditionalRawData, dataSyncOption, recoveryVmCreationOption);
        }

        BinaryData IPersistableModel<RecoveryPlanHyperVReplicaAzureFailbackContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailbackContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailbackContent)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPlanHyperVReplicaAzureFailbackContent IPersistableModel<RecoveryPlanHyperVReplicaAzureFailbackContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailbackContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRecoveryPlanHyperVReplicaAzureFailbackContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailbackContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanHyperVReplicaAzureFailbackContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
