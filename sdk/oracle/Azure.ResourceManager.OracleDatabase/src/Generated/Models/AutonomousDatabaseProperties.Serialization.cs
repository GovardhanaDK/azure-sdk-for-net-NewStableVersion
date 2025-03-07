// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class AutonomousDatabaseProperties : IUtf8JsonSerializable, IJsonModel<AutonomousDatabaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutonomousDatabaseProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutonomousDatabaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutonomousDatabaseProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        AutonomousDatabaseProperties IJsonModel<AutonomousDatabaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutonomousDatabaseProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutonomousDatabaseProperties(document.RootElement, options);
        }

        internal static AutonomousDatabaseProperties DeserializeAutonomousDatabaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adminPassword = default;
            OracleDataBaseType dataBaseType = default;
            AutonomousMaintenanceScheduleType? autonomousMaintenanceScheduleType = default;
            string characterSet = default;
            float? computeCount = default;
            AutonomousDatabaseComputeModel? computeModel = default;
            int? cpuCoreCount = default;
            IList<OracleCustomerContact> customerContacts = default;
            int? dataStorageSizeInTbs = default;
            int? dataStorageSizeInGbs = default;
            string dbVersion = default;
            AutonomousDatabaseWorkloadType? dbWorkload = default;
            string displayName = default;
            bool? isAutoScalingEnabled = default;
            bool? isAutoScalingForStorageEnabled = default;
            IReadOnlyList<string> peerDBIds = default;
            string peerDBId = default;
            bool? isLocalDataGuardEnabled = default;
            bool? isRemoteDataGuardEnabled = default;
            DisasterRecoveryType? localDisasterRecoveryType = default;
            AutonomousDatabaseStandbySummary localStandbyDB = default;
            int? failedDataRecoveryInSeconds = default;
            bool? isMtlsConnectionRequired = default;
            bool? isPreviewVersionWithServiceTermsAccepted = default;
            OracleLicenseModel? licenseModel = default;
            string ncharacterSet = default;
            string lifecycleDetails = default;
            OracleDatabaseProvisioningState? provisioningState = default;
            AutonomousDatabaseLifecycleState? lifecycleState = default;
            ScheduledOperationsType scheduledOperations = default;
            string privateEndpointIP = default;
            string privateEndpointLabel = default;
            Uri ociUrl = default;
            ResourceIdentifier subnetId = default;
            ResourceIdentifier vnetId = default;
            DateTimeOffset? timeCreated = default;
            DateTimeOffset? timeMaintenanceBegin = default;
            DateTimeOffset? timeMaintenanceEnd = default;
            double? actualUsedDataStorageSizeInTbs = default;
            double? allocatedStorageSizeInTbs = default;
            OracleApexDetailsType apexDetails = default;
            IReadOnlyList<string> availableUpgradeVersions = default;
            AutonomousDatabaseConnectionStrings connectionStrings = default;
            AutonomousDatabaseConnectionUrls connectionUrls = default;
            DataSafeStatusType? dataSafeStatus = default;
            OracleDatabaseEditionType? databaseEdition = default;
            ResourceIdentifier autonomousDatabaseId = default;
            int? inMemoryAreaInGbs = default;
            DateTimeOffset? nextLongTermBackupTimeStamp = default;
            LongTermBackUpScheduleDetails longTermBackupSchedule = default;
            bool? isPreview = default;
            int? localAdgAutoFailoverMaxDataLossLimit = default;
            int? memoryPerOracleComputeUnitInGbs = default;
            AutonomousDatabaseModeType? openMode = default;
            OperationsInsightsStatusType? operationsInsightsStatus = default;
            AutonomousDatabasePermissionLevelType? permissionLevel = default;
            string privateEndpoint = default;
            IReadOnlyList<int> provisionableCpus = default;
            DataGuardRoleType? role = default;
            Uri serviceConsoleUrl = default;
            Uri sqlWebDeveloperUrl = default;
            IReadOnlyList<string> supportedRegionsToCloneTo = default;
            DateTimeOffset? timeDataGuardRoleChanged = default;
            DateTimeOffset? timeDeletionOfFreeAutonomousDatabase = default;
            string timeLocalDataGuardEnabled = default;
            DateTimeOffset? timeOfLastFailover = default;
            DateTimeOffset? timeOfLastRefresh = default;
            DateTimeOffset? timeOfLastRefreshPoint = default;
            DateTimeOffset? timeOfLastSwitchover = default;
            DateTimeOffset? timeReclamationOfFreeAutonomousDatabase = default;
            int? usedDataStorageSizeInGbs = default;
            int? usedDataStorageSizeInTbs = default;
            ResourceIdentifier ocid = default;
            int? backupRetentionPeriodInDays = default;
            IList<string> whitelistedIPs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminPassword"u8))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataBaseType"u8))
                {
                    dataBaseType = new OracleDataBaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autonomousMaintenanceScheduleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autonomousMaintenanceScheduleType = new AutonomousMaintenanceScheduleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("characterSet"u8))
                {
                    characterSet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("computeModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeModel = new AutonomousDatabaseComputeModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cpuCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customerContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OracleCustomerContact> array = new List<OracleCustomerContact>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OracleCustomerContact.DeserializeOracleCustomerContact(item, options));
                    }
                    customerContacts = array;
                    continue;
                }
                if (property.NameEquals("dataStorageSizeInTbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataStorageSizeInTbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataStorageSizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataStorageSizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbVersion"u8))
                {
                    dbVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbWorkload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbWorkload = new AutonomousDatabaseWorkloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoScalingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoScalingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAutoScalingForStorageEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoScalingForStorageEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("peerDbIds"u8))
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
                    peerDBIds = array;
                    continue;
                }
                if (property.NameEquals("peerDbId"u8))
                {
                    peerDBId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isLocalDataGuardEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLocalDataGuardEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRemoteDataGuardEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRemoteDataGuardEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("localDisasterRecoveryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localDisasterRecoveryType = new DisasterRecoveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("localStandbyDb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localStandbyDB = AutonomousDatabaseStandbySummary.DeserializeAutonomousDatabaseStandbySummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("failedDataRecoveryInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedDataRecoveryInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isMtlsConnectionRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMtlsConnectionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPreviewVersionWithServiceTermsAccepted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreviewVersionWithServiceTermsAccepted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("licenseModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseModel = new OracleLicenseModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ncharacterSet"u8))
                {
                    ncharacterSet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleDetails"u8))
                {
                    lifecycleDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new OracleDatabaseProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lifecycleState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifecycleState = new AutonomousDatabaseLifecycleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduledOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledOperations = ScheduledOperationsType.DeserializeScheduledOperationsType(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateEndpointIp"u8))
                {
                    privateEndpointIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointLabel"u8))
                {
                    privateEndpointLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ociUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ociUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeMaintenanceBegin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeMaintenanceBegin = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeMaintenanceEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeMaintenanceEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("actualUsedDataStorageSizeInTbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actualUsedDataStorageSizeInTbs = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("allocatedStorageSizeInTbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocatedStorageSizeInTbs = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("apexDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apexDetails = OracleApexDetailsType.DeserializeOracleApexDetailsType(property.Value, options);
                    continue;
                }
                if (property.NameEquals("availableUpgradeVersions"u8))
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
                    availableUpgradeVersions = array;
                    continue;
                }
                if (property.NameEquals("connectionStrings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStrings = AutonomousDatabaseConnectionStrings.DeserializeAutonomousDatabaseConnectionStrings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("connectionUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionUrls = AutonomousDatabaseConnectionUrls.DeserializeAutonomousDatabaseConnectionUrls(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataSafeStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSafeStatus = new DataSafeStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databaseEdition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseEdition = new OracleDatabaseEditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autonomousDatabaseId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autonomousDatabaseId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inMemoryAreaInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inMemoryAreaInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nextLongTermBackupTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLongTermBackupTimeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("longTermBackupSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longTermBackupSchedule = LongTermBackUpScheduleDetails.DeserializeLongTermBackUpScheduleDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("localAdgAutoFailoverMaxDataLossLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localAdgAutoFailoverMaxDataLossLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryPerOracleComputeUnitInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryPerOracleComputeUnitInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("openMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openMode = new AutonomousDatabaseModeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationsInsightsStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationsInsightsStatus = new OperationsInsightsStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("permissionLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    permissionLevel = new AutonomousDatabasePermissionLevelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpoint"u8))
                {
                    privateEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisionableCpus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    provisionableCpus = array;
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = new DataGuardRoleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceConsoleUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceConsoleUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sqlWebDeveloperUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWebDeveloperUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportedRegionsToCloneTo"u8))
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
                    supportedRegionsToCloneTo = array;
                    continue;
                }
                if (property.NameEquals("timeDataGuardRoleChanged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeDataGuardRoleChanged = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeDeletionOfFreeAutonomousDatabase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeDeletionOfFreeAutonomousDatabase = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeLocalDataGuardEnabled"u8))
                {
                    timeLocalDataGuardEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeOfLastFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfLastFailover = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeOfLastRefresh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfLastRefresh = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeOfLastRefreshPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfLastRefreshPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeOfLastSwitchover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfLastSwitchover = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeReclamationOfFreeAutonomousDatabase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeReclamationOfFreeAutonomousDatabase = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("usedDataStorageSizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedDataStorageSizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedDataStorageSizeInTbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedDataStorageSizeInTbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ocid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ocid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupRetentionPeriodInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupRetentionPeriodInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("whitelistedIps"u8))
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
                    whitelistedIPs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutonomousDatabaseProperties(
                adminPassword,
                dataBaseType,
                autonomousMaintenanceScheduleType,
                characterSet,
                computeCount,
                computeModel,
                cpuCoreCount,
                customerContacts ?? new ChangeTrackingList<OracleCustomerContact>(),
                dataStorageSizeInTbs,
                dataStorageSizeInGbs,
                dbVersion,
                dbWorkload,
                displayName,
                isAutoScalingEnabled,
                isAutoScalingForStorageEnabled,
                peerDBIds ?? new ChangeTrackingList<string>(),
                peerDBId,
                isLocalDataGuardEnabled,
                isRemoteDataGuardEnabled,
                localDisasterRecoveryType,
                localStandbyDB,
                failedDataRecoveryInSeconds,
                isMtlsConnectionRequired,
                isPreviewVersionWithServiceTermsAccepted,
                licenseModel,
                ncharacterSet,
                lifecycleDetails,
                provisioningState,
                lifecycleState,
                scheduledOperations,
                privateEndpointIP,
                privateEndpointLabel,
                ociUrl,
                subnetId,
                vnetId,
                timeCreated,
                timeMaintenanceBegin,
                timeMaintenanceEnd,
                actualUsedDataStorageSizeInTbs,
                allocatedStorageSizeInTbs,
                apexDetails,
                availableUpgradeVersions ?? new ChangeTrackingList<string>(),
                connectionStrings,
                connectionUrls,
                dataSafeStatus,
                databaseEdition,
                autonomousDatabaseId,
                inMemoryAreaInGbs,
                nextLongTermBackupTimeStamp,
                longTermBackupSchedule,
                isPreview,
                localAdgAutoFailoverMaxDataLossLimit,
                memoryPerOracleComputeUnitInGbs,
                openMode,
                operationsInsightsStatus,
                permissionLevel,
                privateEndpoint,
                provisionableCpus ?? new ChangeTrackingList<int>(),
                role,
                serviceConsoleUrl,
                sqlWebDeveloperUrl,
                supportedRegionsToCloneTo ?? new ChangeTrackingList<string>(),
                timeDataGuardRoleChanged,
                timeDeletionOfFreeAutonomousDatabase,
                timeLocalDataGuardEnabled,
                timeOfLastFailover,
                timeOfLastRefresh,
                timeOfLastRefreshPoint,
                timeOfLastSwitchover,
                timeReclamationOfFreeAutonomousDatabase,
                usedDataStorageSizeInGbs,
                usedDataStorageSizeInTbs,
                ocid,
                backupRetentionPeriodInDays,
                whitelistedIPs ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutonomousDatabaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutonomousDatabaseProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AutonomousDatabaseProperties IPersistableModel<AutonomousDatabaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutonomousDatabaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutonomousDatabaseProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutonomousDatabaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
