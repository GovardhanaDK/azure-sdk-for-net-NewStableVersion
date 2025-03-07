// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    [PersistableModelProxy(typeof(UnknownSsisObjectMetadata))]
    public partial class SynapseSsisObjectMetadata : IUtf8JsonSerializable, IJsonModel<SynapseSsisObjectMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSsisObjectMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseSsisObjectMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisObjectMetadata)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(MetadataType.ToString());
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
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

        SynapseSsisObjectMetadata IJsonModel<SynapseSsisObjectMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisObjectMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSsisObjectMetadata(document.RootElement, options);
        }

        internal static SynapseSsisObjectMetadata DeserializeSynapseSsisObjectMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Environment": return SynapseSsisEnvironment.DeserializeSynapseSsisEnvironment(element, options);
                    case "Folder": return SynapseSsisFolder.DeserializeSynapseSsisFolder(element, options);
                    case "Package": return SynapseSsisPackage.DeserializeSynapseSsisPackage(element, options);
                    case "Project": return SynapseSsisProject.DeserializeSynapseSsisProject(element, options);
                }
            }
            return UnknownSsisObjectMetadata.DeserializeUnknownSsisObjectMetadata(element, options);
        }

        BinaryData IPersistableModel<SynapseSsisObjectMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisObjectMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseSsisObjectMetadata IPersistableModel<SynapseSsisObjectMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisObjectMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseSsisObjectMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisObjectMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSsisObjectMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
