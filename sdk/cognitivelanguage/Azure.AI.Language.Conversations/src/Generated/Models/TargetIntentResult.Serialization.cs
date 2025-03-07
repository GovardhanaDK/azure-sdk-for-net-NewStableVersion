// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    [PersistableModelProxy(typeof(UnknownTargetIntentResult))]
    public partial class TargetIntentResult : IUtf8JsonSerializable, IJsonModel<TargetIntentResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TargetIntentResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TargetIntentResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetIntentResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetIntentResult)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("targetProjectKind"u8);
            writer.WriteStringValue(TargetProjectKind.ToString());
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WritePropertyName("confidenceScore"u8);
            writer.WriteNumberValue(Confidence);
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

        TargetIntentResult IJsonModel<TargetIntentResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetIntentResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetIntentResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetIntentResult(document.RootElement, options);
        }

        internal static TargetIntentResult DeserializeTargetIntentResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("targetProjectKind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Conversation": return ConversationTargetIntentResult.DeserializeConversationTargetIntentResult(element, options);
                    case "Luis": return LuisTargetIntentResult.DeserializeLuisTargetIntentResult(element, options);
                    case "NonLinked": return NoneLinkedTargetIntentResult.DeserializeNoneLinkedTargetIntentResult(element, options);
                    case "QuestionAnswering": return QuestionAnsweringTargetIntentResult.DeserializeQuestionAnsweringTargetIntentResult(element, options);
                }
            }
            return UnknownTargetIntentResult.DeserializeUnknownTargetIntentResult(element, options);
        }

        BinaryData IPersistableModel<TargetIntentResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetIntentResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TargetIntentResult)} does not support writing '{options.Format}' format.");
            }
        }

        TargetIntentResult IPersistableModel<TargetIntentResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetIntentResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTargetIntentResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TargetIntentResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TargetIntentResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TargetIntentResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTargetIntentResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
