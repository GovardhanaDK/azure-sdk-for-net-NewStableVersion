// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class TrafficDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TotalMonthlyVolume))
            {
                writer.WritePropertyName("totalMonthlyVolume"u8);
                writer.WriteNumberValue(TotalMonthlyVolume.Value);
            }
            if (Optional.IsDefined(MonthlyAverageMessagesFromUser))
            {
                writer.WritePropertyName("monthlyAverageMessagesFromUser"u8);
                writer.WriteNumberValue(MonthlyAverageMessagesFromUser.Value);
            }
            if (Optional.IsDefined(MonthlyAverageMessagesToUser))
            {
                writer.WritePropertyName("monthlyAverageMessagesToUser"u8);
                writer.WriteNumberValue(MonthlyAverageMessagesToUser.Value);
            }
            if (Optional.IsDefined(IsSpiky))
            {
                writer.WritePropertyName("isSpiky"u8);
                writer.WriteBooleanValue(IsSpiky.Value);
            }
            if (Optional.IsDefined(SpikeDetails))
            {
                writer.WritePropertyName("spikeDetails"u8);
                writer.WriteStringValue(SpikeDetails);
            }
            if (Optional.IsDefined(EstimatedRampUpTimeInDays))
            {
                writer.WritePropertyName("estimatedRampUpTimeInDays"u8);
                writer.WriteNumberValue(EstimatedRampUpTimeInDays.Value);
            }
            writer.WriteEndObject();
        }

        internal static TrafficDetails DeserializeTrafficDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? totalMonthlyVolume = default;
            int? monthlyAverageMessagesFromUser = default;
            int? monthlyAverageMessagesToUser = default;
            bool? isSpiky = default;
            string spikeDetails = default;
            int? estimatedRampUpTimeInDays = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalMonthlyVolume"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMonthlyVolume = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyAverageMessagesFromUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyAverageMessagesFromUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyAverageMessagesToUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyAverageMessagesToUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isSpiky"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSpiky = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("spikeDetails"u8))
                {
                    spikeDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("estimatedRampUpTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedRampUpTimeInDays = property.Value.GetInt32();
                    continue;
                }
            }
            return new TrafficDetails(
                totalMonthlyVolume,
                monthlyAverageMessagesFromUser,
                monthlyAverageMessagesToUser,
                isSpiky,
                spikeDetails,
                estimatedRampUpTimeInDays);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrafficDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTrafficDetails(document.RootElement);
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
