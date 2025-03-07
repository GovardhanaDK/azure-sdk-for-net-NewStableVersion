// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request to validate preference of transport and data center. </summary>
    public partial class PreferencesValidationContent : DataBoxValidationInputContent
    {
        /// <summary> Initializes a new instance of <see cref="PreferencesValidationContent"/>. </summary>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        public PreferencesValidationContent(DataBoxSkuName deviceType)
        {
            DeviceType = deviceType;
            ValidationType = DataBoxValidationInputDiscriminator.ValidatePreferences;
        }

        /// <summary> Initializes a new instance of <see cref="PreferencesValidationContent"/>. </summary>
        /// <param name="validationType"> Identifies the type of validation request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="preference"> Preference of transport and data center. </param>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        /// <param name="model"> The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025. </param>
        internal PreferencesValidationContent(DataBoxValidationInputDiscriminator validationType, IDictionary<string, BinaryData> serializedAdditionalRawData, DataBoxOrderPreferences preference, DataBoxSkuName deviceType, ModelName? model) : base(validationType, serializedAdditionalRawData)
        {
            Preference = preference;
            DeviceType = deviceType;
            Model = model;
            ValidationType = validationType;
        }

        /// <summary> Initializes a new instance of <see cref="PreferencesValidationContent"/> for deserialization. </summary>
        internal PreferencesValidationContent()
        {
        }

        /// <summary> Preference of transport and data center. </summary>
        public DataBoxOrderPreferences Preference { get; set; }
        /// <summary> Device type to be used for the job. </summary>
        public DataBoxSkuName DeviceType { get; }
        /// <summary> The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025. </summary>
        public ModelName? Model { get; set; }
    }
}
