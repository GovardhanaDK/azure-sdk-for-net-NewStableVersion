// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the device capabilities for given sku. </summary>
    public partial class DeviceCapabilityContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceCapabilityContent"/>. </summary>
        public DeviceCapabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceCapabilityContent"/>. </summary>
        /// <param name="skuName"> Type of the device. </param>
        /// <param name="model"> The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceCapabilityContent(DataBoxSkuName? skuName, DeviceModelName? model, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SkuName = skuName;
            Model = model;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of the device. </summary>
        public DataBoxSkuName? SkuName { get; set; }
        /// <summary> The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025. </summary>
        public DeviceModelName? Model { get; set; }
    }
}
