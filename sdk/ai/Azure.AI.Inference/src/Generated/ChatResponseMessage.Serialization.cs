// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Inference
{
    public partial class ChatResponseMessage : IUtf8JsonSerializable, IJsonModel<ChatResponseMessage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatResponseMessage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChatResponseMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatResponseMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatResponseMessage)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role.ToString());
            if (Content != null)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            else
            {
                writer.WriteNull("content");
            }
            if (Optional.IsCollectionDefined(ToolCalls))
            {
                writer.WritePropertyName("tool_calls"u8);
                writer.WriteStartArray();
                foreach (var item in ToolCalls)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ChatResponseMessage IJsonModel<ChatResponseMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatResponseMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatResponseMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatResponseMessage(document.RootElement, options);
        }

        internal static ChatResponseMessage DeserializeChatResponseMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChatRole role = default;
            string content = default;
            IReadOnlyList<ChatCompletionsToolCall> toolCalls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("role"u8))
                {
                    role = new ChatRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        content = null;
                        continue;
                    }
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tool_calls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatCompletionsToolCall> array = new List<ChatCompletionsToolCall>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatCompletionsToolCall.DeserializeChatCompletionsToolCall(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChatResponseMessage(role, content, toolCalls ?? new ChangeTrackingList<ChatCompletionsToolCall>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatResponseMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatResponseMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatResponseMessage)} does not support writing '{options.Format}' format.");
            }
        }

        ChatResponseMessage IPersistableModel<ChatResponseMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatResponseMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeChatResponseMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatResponseMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatResponseMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatResponseMessage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeChatResponseMessage(document.RootElement);
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
