// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Copy activity. </summary>
    public partial class CopyActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="CopyActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="source">
        /// Copy activity source.
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="DataFactoryBlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GoogleBigQueryV2Source"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="DataFactoryHttpFileSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="LakeHouseTableSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PostgreSqlV2Source"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceServiceCloudV2Source"/>, <see cref="SalesforceSource"/>, <see cref="SalesforceV2Source"/>, <see cref="SapBWSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="ServiceNowV2Source"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SnowflakeV2Source"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WarehouseSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </param>
        /// <param name="sink">
        /// Copy activity sink.
        /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="DataFactoryBlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDBMongoDBApiSink"/>, <see cref="CosmosDBSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDBCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="IcebergSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="LakeHouseTableSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="MongoDBAtlasSink"/>, <see cref="MongoDBV2Sink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceServiceCloudV2Sink"/>, <see cref="SalesforceSink"/>, <see cref="SalesforceV2Sink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SnowflakeV2Sink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/>, <see cref="SqlSink"/>, <see cref="TeradataSink"/> and <see cref="WarehouseSink"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="source"/> or <paramref name="sink"/> is null. </exception>
        public CopyActivity(string name, CopyActivitySource source, CopySink sink) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(sink, nameof(sink));

            Inputs = new ChangeTrackingList<DatasetReference>();
            Outputs = new ChangeTrackingList<DatasetReference>();
            Source = source;
            Sink = sink;
            PreserveRules = new ChangeTrackingList<BinaryData>();
            Preserve = new ChangeTrackingList<BinaryData>();
            ActivityType = "Copy";
        }

        /// <summary> Initializes a new instance of <see cref="CopyActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="inputs"> List of inputs for the activity. </param>
        /// <param name="outputs"> List of outputs for the activity. </param>
        /// <param name="source">
        /// Copy activity source.
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="DataFactoryBlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GoogleBigQueryV2Source"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="DataFactoryHttpFileSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="LakeHouseTableSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PostgreSqlV2Source"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceServiceCloudV2Source"/>, <see cref="SalesforceSource"/>, <see cref="SalesforceV2Source"/>, <see cref="SapBWSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="ServiceNowV2Source"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SnowflakeV2Source"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WarehouseSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </param>
        /// <param name="sink">
        /// Copy activity sink.
        /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="DataFactoryBlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDBMongoDBApiSink"/>, <see cref="CosmosDBSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDBCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="IcebergSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="LakeHouseTableSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="MongoDBAtlasSink"/>, <see cref="MongoDBV2Sink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceServiceCloudV2Sink"/>, <see cref="SalesforceSink"/>, <see cref="SalesforceV2Sink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SnowflakeV2Sink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/>, <see cref="SqlSink"/>, <see cref="TeradataSink"/> and <see cref="WarehouseSink"/>.
        /// </param>
        /// <param name="translator"> Copy activity translator. If not specified, tabular translator is used. </param>
        /// <param name="enableStaging"> Specifies whether to copy data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="stagingSettings"> Specifies interim staging settings when EnableStaging is true. </param>
        /// <param name="parallelCopies"> Maximum number of concurrent sessions opened on the source or sink to avoid overloading the data store. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="dataIntegrationUnits"> Maximum number of data integration units that can be used to perform this data movement. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="enableSkipIncompatibleRow"> Whether to skip incompatible row. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="redirectIncompatibleRowSettings"> Redirect incompatible row settings when EnableSkipIncompatibleRow is true. </param>
        /// <param name="logStorageSettings"> (Deprecated. Please use LogSettings) Log storage settings customer need to provide when enabling session log. </param>
        /// <param name="logSettings"> Log settings customer needs provide when enabling log. </param>
        /// <param name="preserveRules"> Preserve Rules. </param>
        /// <param name="preserve"> Preserve rules. </param>
        /// <param name="validateDataConsistency"> Whether to enable Data Consistency validation. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="skipErrorFile"> Specify the fault tolerance for data consistency. </param>
        internal CopyActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, IList<DatasetReference> inputs, IList<DatasetReference> outputs, CopyActivitySource source, CopySink sink, BinaryData translator, DataFactoryElement<bool> enableStaging, StagingSettings stagingSettings, DataFactoryElement<int> parallelCopies, DataFactoryElement<int> dataIntegrationUnits, DataFactoryElement<bool> enableSkipIncompatibleRow, RedirectIncompatibleRowSettings redirectIncompatibleRowSettings, LogStorageSettings logStorageSettings, DataFactoryLogSettings logSettings, IList<BinaryData> preserveRules, IList<BinaryData> preserve, DataFactoryElement<bool> validateDataConsistency, SkipErrorFile skipErrorFile) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Inputs = inputs;
            Outputs = outputs;
            Source = source;
            Sink = sink;
            Translator = translator;
            EnableStaging = enableStaging;
            StagingSettings = stagingSettings;
            ParallelCopies = parallelCopies;
            DataIntegrationUnits = dataIntegrationUnits;
            EnableSkipIncompatibleRow = enableSkipIncompatibleRow;
            RedirectIncompatibleRowSettings = redirectIncompatibleRowSettings;
            LogStorageSettings = logStorageSettings;
            LogSettings = logSettings;
            PreserveRules = preserveRules;
            Preserve = preserve;
            ValidateDataConsistency = validateDataConsistency;
            SkipErrorFile = skipErrorFile;
            ActivityType = activityType ?? "Copy";
        }

        /// <summary> Initializes a new instance of <see cref="CopyActivity"/> for deserialization. </summary>
        internal CopyActivity()
        {
        }

        /// <summary> List of inputs for the activity. </summary>
        public IList<DatasetReference> Inputs { get; }
        /// <summary> List of outputs for the activity. </summary>
        public IList<DatasetReference> Outputs { get; }
        /// <summary>
        /// Copy activity source.
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="DataFactoryBlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GoogleBigQueryV2Source"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="DataFactoryHttpFileSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="LakeHouseTableSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PostgreSqlV2Source"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceServiceCloudV2Source"/>, <see cref="SalesforceSource"/>, <see cref="SalesforceV2Source"/>, <see cref="SapBWSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="ServiceNowV2Source"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SnowflakeV2Source"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WarehouseSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </summary>
        public CopyActivitySource Source { get; set; }
        /// <summary>
        /// Copy activity sink.
        /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="DataFactoryBlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDBMongoDBApiSink"/>, <see cref="CosmosDBSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDBCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="IcebergSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="LakeHouseTableSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="MongoDBAtlasSink"/>, <see cref="MongoDBV2Sink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceServiceCloudV2Sink"/>, <see cref="SalesforceSink"/>, <see cref="SalesforceV2Sink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SnowflakeV2Sink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/>, <see cref="SqlSink"/>, <see cref="TeradataSink"/> and <see cref="WarehouseSink"/>.
        /// </summary>
        public CopySink Sink { get; set; }
        /// <summary>
        /// Copy activity translator. If not specified, tabular translator is used.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Translator { get; set; }
        /// <summary> Specifies whether to copy data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableStaging { get; set; }
        /// <summary> Specifies interim staging settings when EnableStaging is true. </summary>
        public StagingSettings StagingSettings { get; set; }
        /// <summary> Maximum number of concurrent sessions opened on the source or sink to avoid overloading the data store. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> ParallelCopies { get; set; }
        /// <summary> Maximum number of data integration units that can be used to perform this data movement. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> DataIntegrationUnits { get; set; }
        /// <summary> Whether to skip incompatible row. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableSkipIncompatibleRow { get; set; }
        /// <summary> Redirect incompatible row settings when EnableSkipIncompatibleRow is true. </summary>
        public RedirectIncompatibleRowSettings RedirectIncompatibleRowSettings { get; set; }
        /// <summary> (Deprecated. Please use LogSettings) Log storage settings customer need to provide when enabling session log. </summary>
        public LogStorageSettings LogStorageSettings { get; set; }
        /// <summary> Log settings customer needs provide when enabling log. </summary>
        public DataFactoryLogSettings LogSettings { get; set; }
        /// <summary>
        /// Preserve Rules.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> PreserveRules { get; }
        /// <summary>
        /// Preserve rules.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> Preserve { get; }
        /// <summary> Whether to enable Data Consistency validation. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> ValidateDataConsistency { get; set; }
        /// <summary> Specify the fault tolerance for data consistency. </summary>
        public SkipErrorFile SkipErrorFile { get; set; }
    }
}
