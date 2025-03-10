// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the configuration for the region. </summary>
    public partial class RegionConfigurationContent
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

        /// <summary> Initializes a new instance of <see cref="RegionConfigurationContent"/>. </summary>
        public RegionConfigurationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegionConfigurationContent"/>. </summary>
        /// <param name="scheduleAvailabilityRequest">
        /// Request body to get the availability for scheduling orders.
        /// Please note <see cref="ScheduleAvailabilityContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxScheduleAvailabilityContent"/>, <see cref="DiskScheduleAvailabilityContent"/> and <see cref="HeavyScheduleAvailabilityContent"/>.
        /// </param>
        /// <param name="transportAvailabilityRequest"> Request body to get the transport availability for given sku. </param>
        /// <param name="dataCenterAddressRequest"> Request body to get the datacenter address for given sku. </param>
        /// <param name="deviceCapabilityRequest"> Request body to get the device capabilities for a given sku. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegionConfigurationContent(ScheduleAvailabilityContent scheduleAvailabilityRequest, TransportAvailabilityContent transportAvailabilityRequest, DataCenterAddressContent dataCenterAddressRequest, DeviceCapabilityContent deviceCapabilityRequest, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScheduleAvailabilityRequest = scheduleAvailabilityRequest;
            TransportAvailabilityRequest = transportAvailabilityRequest;
            DataCenterAddressRequest = dataCenterAddressRequest;
            DeviceCapabilityRequest = deviceCapabilityRequest;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Request body to get the availability for scheduling orders.
        /// Please note <see cref="ScheduleAvailabilityContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxScheduleAvailabilityContent"/>, <see cref="DiskScheduleAvailabilityContent"/> and <see cref="HeavyScheduleAvailabilityContent"/>.
        /// </summary>
        public ScheduleAvailabilityContent ScheduleAvailabilityRequest { get; set; }
        /// <summary> Request body to get the transport availability for given sku. </summary>
        public TransportAvailabilityContent TransportAvailabilityRequest { get; set; }
        /// <summary> Type of the device. </summary>
        public DataBoxSkuName? TransportAvailabilityRequestSkuName
        {
            get => TransportAvailabilityRequest is null ? default : TransportAvailabilityRequest.SkuName;
            set
            {
                if (TransportAvailabilityRequest is null)
                    TransportAvailabilityRequest = new TransportAvailabilityContent();
                TransportAvailabilityRequest.SkuName = value;
            }
        }
        /// <summary> Request body to get the datacenter address for given sku. </summary>
        public DataCenterAddressContent DataCenterAddressRequest { get; set; }
        /// <summary> Request body to get the device capabilities for a given sku. </summary>
        public DeviceCapabilityContent DeviceCapabilityRequest { get; set; }
    }
}
