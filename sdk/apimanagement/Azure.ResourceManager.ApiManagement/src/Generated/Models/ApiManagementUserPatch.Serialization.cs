// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementUserPatch : IUtf8JsonSerializable, IJsonModel<ApiManagementUserPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementUserPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiManagementUserPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Note))
            {
                writer.WritePropertyName("note"u8);
                writer.WriteStringValue(Note);
            }
            if (Optional.IsCollectionDefined(Identities))
            {
                writer.WritePropertyName("identities"u8);
                writer.WriteStartArray();
                foreach (var item in Identities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(FirstName))
            {
                writer.WritePropertyName("firstName"u8);
                writer.WriteStringValue(FirstName);
            }
            if (Optional.IsDefined(LastName))
            {
                writer.WritePropertyName("lastName"u8);
                writer.WriteStringValue(LastName);
            }
            writer.WriteEndObject();
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

        ApiManagementUserPatch IJsonModel<ApiManagementUserPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementUserPatch(document.RootElement, options);
        }

        internal static ApiManagementUserPatch DeserializeApiManagementUserPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApiManagementUserState? state = default;
            string note = default;
            IList<UserIdentityContract> identities = default;
            string email = default;
            string password = default;
            string firstName = default;
            string lastName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new ApiManagementUserState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("note"u8))
                        {
                            note = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<UserIdentityContract> array = new List<UserIdentityContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UserIdentityContract.DeserializeUserIdentityContract(item, options));
                            }
                            identities = array;
                            continue;
                        }
                        if (property0.NameEquals("email"u8))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firstName"u8))
                        {
                            firstName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastName"u8))
                        {
                            lastName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiManagementUserPatch(
                state,
                note,
                identities ?? new ChangeTrackingList<UserIdentityContract>(),
                email,
                password,
                firstName,
                lastName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementUserPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementUserPatch IPersistableModel<ApiManagementUserPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiManagementUserPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementUserPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
