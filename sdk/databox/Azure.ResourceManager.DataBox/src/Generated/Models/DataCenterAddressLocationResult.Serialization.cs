// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataCenterAddressLocationResult : IUtf8JsonSerializable, IJsonModel<DataCenterAddressLocationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCenterAddressLocationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataCenterAddressLocationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressLocationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCenterAddressLocationResult)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ContactPersonName))
            {
                writer.WritePropertyName("contactPersonName"u8);
                writer.WriteStringValue(ContactPersonName);
            }
            if (options.Format != "W" && Optional.IsDefined(Company))
            {
                writer.WritePropertyName("company"u8);
                writer.WriteStringValue(Company);
            }
            if (options.Format != "W" && Optional.IsDefined(Street1))
            {
                writer.WritePropertyName("street1"u8);
                writer.WriteStringValue(Street1);
            }
            if (options.Format != "W" && Optional.IsDefined(Street2))
            {
                writer.WritePropertyName("street2"u8);
                writer.WriteStringValue(Street2);
            }
            if (options.Format != "W" && Optional.IsDefined(Street3))
            {
                writer.WritePropertyName("street3"u8);
                writer.WriteStringValue(Street3);
            }
            if (options.Format != "W" && Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && Optional.IsDefined(Zip))
            {
                writer.WritePropertyName("zip"u8);
                writer.WriteStringValue(Zip);
            }
            if (options.Format != "W" && Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            if (options.Format != "W" && Optional.IsDefined(Phone))
            {
                writer.WritePropertyName("phone"u8);
                writer.WriteStringValue(Phone);
            }
            if (options.Format != "W" && Optional.IsDefined(PhoneExtension))
            {
                writer.WritePropertyName("phoneExtension"u8);
                writer.WriteStringValue(PhoneExtension);
            }
            if (options.Format != "W" && Optional.IsDefined(AddressType))
            {
                writer.WritePropertyName("addressType"u8);
                writer.WriteStringValue(AddressType);
            }
            if (options.Format != "W" && Optional.IsDefined(AdditionalShippingInformation))
            {
                writer.WritePropertyName("additionalShippingInformation"u8);
                writer.WriteStringValue(AdditionalShippingInformation);
            }
        }

        DataCenterAddressLocationResult IJsonModel<DataCenterAddressLocationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressLocationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCenterAddressLocationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCenterAddressLocationResult(document.RootElement, options);
        }

        internal static DataCenterAddressLocationResult DeserializeDataCenterAddressLocationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contactPersonName = default;
            string company = default;
            string street1 = default;
            string street2 = default;
            string street3 = default;
            string city = default;
            string state = default;
            string zip = default;
            string country = default;
            string phone = default;
            string phoneExtension = default;
            string addressType = default;
            string additionalShippingInformation = default;
            DataCenterAddressType dataCenterAddressType = default;
            IReadOnlyList<string> supportedCarriersForReturnShipment = default;
            AzureLocation? dataCenterAzureLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactPersonName"u8))
                {
                    contactPersonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("company"u8))
                {
                    company = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street1"u8))
                {
                    street1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street2"u8))
                {
                    street2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("street3"u8))
                {
                    street3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zip"u8))
                {
                    zip = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneExtension"u8))
                {
                    phoneExtension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressType"u8))
                {
                    addressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalShippingInformation"u8))
                {
                    additionalShippingInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datacenterAddressType"u8))
                {
                    dataCenterAddressType = property.Value.GetString().ToDataCenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAzureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataCenterAddressLocationResult(
                dataCenterAddressType,
                supportedCarriersForReturnShipment ?? new ChangeTrackingList<string>(),
                dataCenterAzureLocation,
                serializedAdditionalRawData,
                contactPersonName,
                company,
                street1,
                street2,
                street3,
                city,
                state,
                zip,
                country,
                phone,
                phoneExtension,
                addressType,
                additionalShippingInformation);
        }

        BinaryData IPersistableModel<DataCenterAddressLocationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressLocationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCenterAddressLocationResult)} does not support writing '{options.Format}' format.");
            }
        }

        DataCenterAddressLocationResult IPersistableModel<DataCenterAddressLocationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressLocationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataCenterAddressLocationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCenterAddressLocationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCenterAddressLocationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
