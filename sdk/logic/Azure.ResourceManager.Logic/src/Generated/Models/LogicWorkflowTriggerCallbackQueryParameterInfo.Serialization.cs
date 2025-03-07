// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowTriggerCallbackQueryParameterInfo : IUtf8JsonSerializable, IJsonModel<LogicWorkflowTriggerCallbackQueryParameterInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowTriggerCallbackQueryParameterInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LogicWorkflowTriggerCallbackQueryParameterInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackQueryParameterInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackQueryParameterInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("api-version"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(Sp))
            {
                writer.WritePropertyName("sp"u8);
                writer.WriteStringValue(Sp);
            }
            if (Optional.IsDefined(Sv))
            {
                writer.WritePropertyName("sv"u8);
                writer.WriteStringValue(Sv);
            }
            if (Optional.IsDefined(Sig))
            {
                writer.WritePropertyName("sig"u8);
                writer.WriteStringValue(Sig);
            }
            if (Optional.IsDefined(Se))
            {
                writer.WritePropertyName("se"u8);
                writer.WriteStringValue(Se);
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

        LogicWorkflowTriggerCallbackQueryParameterInfo IJsonModel<LogicWorkflowTriggerCallbackQueryParameterInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackQueryParameterInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackQueryParameterInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(document.RootElement, options);
        }

        internal static LogicWorkflowTriggerCallbackQueryParameterInfo DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string apiVersion = default;
            string sp = default;
            string sv = default;
            string sig = default;
            string se = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api-version"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sp"u8))
                {
                    sp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sv"u8))
                {
                    sv = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sig"u8))
                {
                    sig = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("se"u8))
                {
                    se = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LogicWorkflowTriggerCallbackQueryParameterInfo(
                apiVersion,
                sp,
                sv,
                sig,
                se,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWorkflowTriggerCallbackQueryParameterInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackQueryParameterInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackQueryParameterInfo)} does not support writing '{options.Format}' format.");
            }
        }

        LogicWorkflowTriggerCallbackQueryParameterInfo IPersistableModel<LogicWorkflowTriggerCallbackQueryParameterInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowTriggerCallbackQueryParameterInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLogicWorkflowTriggerCallbackQueryParameterInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowTriggerCallbackQueryParameterInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkflowTriggerCallbackQueryParameterInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
