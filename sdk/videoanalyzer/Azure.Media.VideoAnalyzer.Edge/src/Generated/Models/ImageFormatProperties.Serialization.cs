// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ImageFormatProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static ImageFormatProperties DeserializeImageFormatProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.ImageFormatBmp": return ImageFormatBmp.DeserializeImageFormatBmp(element);
                    case "#Microsoft.VideoAnalyzer.ImageFormatJpeg": return ImageFormatJpeg.DeserializeImageFormatJpeg(element);
                    case "#Microsoft.VideoAnalyzer.ImageFormatPng": return ImageFormatPng.DeserializeImageFormatPng(element);
                    case "#Microsoft.VideoAnalyzer.ImageFormatRaw": return ImageFormatRaw.DeserializeImageFormatRaw(element);
                }
            }
            return UnknownImageFormatProperties.DeserializeUnknownImageFormatProperties(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageFormatProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeImageFormatProperties(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
