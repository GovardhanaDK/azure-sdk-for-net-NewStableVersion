// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Communication.PhoneNumbers
{
    public partial class PurchasedPhoneNumber
    {
        internal static PurchasedPhoneNumber DeserializePurchasedPhoneNumber(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string phoneNumber = default;
            string countryCode = default;
            PhoneNumberType phoneNumberType = default;
            PhoneNumberCapabilities capabilities = default;
            PhoneNumberAssignmentType assignmentType = default;
            DateTimeOffset purchaseDate = default;
            PhoneNumberCost cost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumberType"u8))
                {
                    phoneNumberType = new PhoneNumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    capabilities = PhoneNumberCapabilities.DeserializePhoneNumberCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("assignmentType"u8))
                {
                    assignmentType = new PhoneNumberAssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("purchaseDate"u8))
                {
                    purchaseDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cost"u8))
                {
                    cost = PhoneNumberCost.DeserializePhoneNumberCost(property.Value);
                    continue;
                }
            }
            return new PurchasedPhoneNumber(
                id,
                phoneNumber,
                countryCode,
                phoneNumberType,
                capabilities,
                assignmentType,
                purchaseDate,
                cost);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PurchasedPhoneNumber FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePurchasedPhoneNumber(document.RootElement);
        }
    }
}
