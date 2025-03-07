// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class ContinuousDtmfRecognitionToneReceived
    {
        internal static ContinuousDtmfRecognitionToneReceived DeserializeContinuousDtmfRecognitionToneReceived(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? sequenceId = default;
            DtmfTone? tone = default;
            string callConnectionId = default;
            string serverCallId = default;
            string correlationId = default;
            string operationContext = default;
            ResultInformation resultInformation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sequenceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tone = new DtmfTone(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
            }
            return new ContinuousDtmfRecognitionToneReceived(
                sequenceId,
                tone,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ContinuousDtmfRecognitionToneReceived FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeContinuousDtmfRecognitionToneReceived(document.RootElement);
        }
    }
}
