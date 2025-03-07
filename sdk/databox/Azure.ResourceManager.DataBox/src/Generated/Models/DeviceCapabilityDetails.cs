// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Device capability details for a given sku for a given region. </summary>
    public partial class DeviceCapabilityDetails
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

        /// <summary> Initializes a new instance of <see cref="DeviceCapabilityDetails"/>. </summary>
        internal DeviceCapabilityDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceCapabilityDetails"/>. </summary>
        /// <param name="hardwareEncryption"> Hardware encryption support for a given sku for a given region. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceCapabilityDetails(HardwareEncryption? hardwareEncryption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HardwareEncryption = hardwareEncryption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Hardware encryption support for a given sku for a given region. </summary>
        public HardwareEncryption? HardwareEncryption { get; }
    }
}
