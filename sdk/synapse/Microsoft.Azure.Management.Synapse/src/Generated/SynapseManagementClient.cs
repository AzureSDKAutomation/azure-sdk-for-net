// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Azure Synapse Analytics Management Client
    /// </summary>
    public partial class SynapseManagementClient : ServiceClient<SynapseManagementClient>, ISynapseManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IBigDataPoolsOperations.
        /// </summary>
        public virtual IBigDataPoolsOperations BigDataPools { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IIpFirewallRulesOperations.
        /// </summary>
        public virtual IIpFirewallRulesOperations IpFirewallRules { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolsOperations.
        /// </summary>
        public virtual ISqlPoolsOperations SqlPools { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolMetadataSyncConfigsOperations.
        /// </summary>
        public virtual ISqlPoolMetadataSyncConfigsOperations SqlPoolMetadataSyncConfigs { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolOperationResultsOperations.
        /// </summary>
        public virtual ISqlPoolOperationResultsOperations SqlPoolOperationResults { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolGeoBackupPoliciesOperations.
        /// </summary>
        public virtual ISqlPoolGeoBackupPoliciesOperations SqlPoolGeoBackupPolicies { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolDataWarehouseUserActivitiesOperations.
        /// </summary>
        public virtual ISqlPoolDataWarehouseUserActivitiesOperations SqlPoolDataWarehouseUserActivities { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolRestorePointsOperations.
        /// </summary>
        public virtual ISqlPoolRestorePointsOperations SqlPoolRestorePoints { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolReplicationLinksOperations.
        /// </summary>
        public virtual ISqlPoolReplicationLinksOperations SqlPoolReplicationLinks { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolTransparentDataEncryptionsOperations.
        /// </summary>
        public virtual ISqlPoolTransparentDataEncryptionsOperations SqlPoolTransparentDataEncryptions { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual ISqlPoolBlobAuditingPoliciesOperations SqlPoolBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolOperations.
        /// </summary>
        public virtual ISqlPoolOperations SqlPoolOperations { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolUsagesOperations.
        /// </summary>
        public virtual ISqlPoolUsagesOperations SqlPoolUsages { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolSensitivityLabelsOperations.
        /// </summary>
        public virtual ISqlPoolSensitivityLabelsOperations SqlPoolSensitivityLabels { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolSchemasOperations.
        /// </summary>
        public virtual ISqlPoolSchemasOperations SqlPoolSchemas { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolTablesOperations.
        /// </summary>
        public virtual ISqlPoolTablesOperations SqlPoolTables { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolTableColumnsOperations.
        /// </summary>
        public virtual ISqlPoolTableColumnsOperations SqlPoolTableColumns { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolConnectionPoliciesOperations.
        /// </summary>
        public virtual ISqlPoolConnectionPoliciesOperations SqlPoolConnectionPolicies { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolVulnerabilityAssessmentsOperations.
        /// </summary>
        public virtual ISqlPoolVulnerabilityAssessmentsOperations SqlPoolVulnerabilityAssessments { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolVulnerabilityAssessmentScansOperations.
        /// </summary>
        public virtual ISqlPoolVulnerabilityAssessmentScansOperations SqlPoolVulnerabilityAssessmentScans { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual ISqlPoolSecurityAlertPoliciesOperations SqlPoolSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        public virtual ISqlPoolVulnerabilityAssessmentRuleBaselinesOperations SqlPoolVulnerabilityAssessmentRuleBaselines { get; private set; }

        /// <summary>
        /// Gets the IExtendedSqlPoolBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IExtendedSqlPoolBlobAuditingPoliciesOperations ExtendedSqlPoolBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDataMaskingPoliciesOperations.
        /// </summary>
        public virtual IDataMaskingPoliciesOperations DataMaskingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDataMaskingRulesOperations.
        /// </summary>
        public virtual IDataMaskingRulesOperations DataMaskingRules { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolColumnsOperations.
        /// </summary>
        public virtual ISqlPoolColumnsOperations SqlPoolColumns { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolWorkloadGroupOperations.
        /// </summary>
        public virtual ISqlPoolWorkloadGroupOperations SqlPoolWorkloadGroup { get; private set; }

        /// <summary>
        /// Gets the ISqlPoolWorkloadClassifierOperations.
        /// </summary>
        public virtual ISqlPoolWorkloadClassifierOperations SqlPoolWorkloadClassifier { get; private set; }

        /// <summary>
        /// Gets the IWorkspacesOperations.
        /// </summary>
        public virtual IWorkspacesOperations Workspaces { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceAadAdminsOperations.
        /// </summary>
        public virtual IWorkspaceAadAdminsOperations WorkspaceAadAdmins { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceSqlAadAdminsOperations.
        /// </summary>
        public virtual IWorkspaceSqlAadAdminsOperations WorkspaceSqlAadAdmins { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceManagedIdentitySqlControlSettingsOperations.
        /// </summary>
        public virtual IWorkspaceManagedIdentitySqlControlSettingsOperations WorkspaceManagedIdentitySqlControlSettings { get; private set; }

        /// <summary>
        /// Gets the IRestorableDroppedSqlPoolsOperations.
        /// </summary>
        public virtual IRestorableDroppedSqlPoolsOperations RestorableDroppedSqlPools { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimesOperations.
        /// </summary>
        public virtual IIntegrationRuntimesOperations IntegrationRuntimes { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeNodeIpAddressOperations.
        /// </summary>
        public virtual IIntegrationRuntimeNodeIpAddressOperations IntegrationRuntimeNodeIpAddress { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeObjectMetadataOperations.
        /// </summary>
        public virtual IIntegrationRuntimeObjectMetadataOperations IntegrationRuntimeObjectMetadata { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeNodesOperations.
        /// </summary>
        public virtual IIntegrationRuntimeNodesOperations IntegrationRuntimeNodes { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeCredentialsOperations.
        /// </summary>
        public virtual IIntegrationRuntimeCredentialsOperations IntegrationRuntimeCredentials { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeConnectionInfosOperations.
        /// </summary>
        public virtual IIntegrationRuntimeConnectionInfosOperations IntegrationRuntimeConnectionInfos { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeAuthKeysOperations.
        /// </summary>
        public virtual IIntegrationRuntimeAuthKeysOperations IntegrationRuntimeAuthKeys { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeMonitoringDataOperations.
        /// </summary>
        public virtual IIntegrationRuntimeMonitoringDataOperations IntegrationRuntimeMonitoringData { get; private set; }

        /// <summary>
        /// Gets the IIntegrationRuntimeStatusOperations.
        /// </summary>
        public virtual IIntegrationRuntimeStatusOperations IntegrationRuntimeStatus { get; private set; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        public virtual IPrivateLinkResourcesOperations PrivateLinkResources { get; private set; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        public virtual IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets the IPrivateLinkHubsOperations.
        /// </summary>
        public virtual IPrivateLinkHubsOperations PrivateLinkHubs { get; private set; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsPrivateLinkHubOperations.
        /// </summary>
        public virtual IPrivateEndpointConnectionsPrivateLinkHubOperations PrivateEndpointConnectionsPrivateLinkHub { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceManagedSqlServerBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IWorkspaceManagedSqlServerBlobAuditingPoliciesOperations WorkspaceManagedSqlServerBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesOperations WorkspaceManagedSqlServerExtendedBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceManagedSqlServerSecurityAlertPolicyOperations.
        /// </summary>
        public virtual IWorkspaceManagedSqlServerSecurityAlertPolicyOperations WorkspaceManagedSqlServerSecurityAlertPolicy { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceManagedSqlServerVulnerabilityAssessmentsOperations.
        /// </summary>
        public virtual IWorkspaceManagedSqlServerVulnerabilityAssessmentsOperations WorkspaceManagedSqlServerVulnerabilityAssessments { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceManagedSqlServerUsagesOperations.
        /// </summary>
        public virtual IWorkspaceManagedSqlServerUsagesOperations WorkspaceManagedSqlServerUsages { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations.
        /// </summary>
        public virtual IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations WorkspaceManagedSqlServerRecoverableSqlPools { get; private set; }

        /// <summary>
        /// Gets the IKeysOperations.
        /// </summary>
        public virtual IKeysOperations Keys { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SynapseManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected SynapseManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SynapseManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SynapseManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SynapseManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SynapseManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SynapseManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SynapseManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SynapseManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SynapseManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SynapseManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SynapseManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SynapseManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            BigDataPools = new BigDataPoolsOperations(this);
            Operations = new Operations(this);
            IpFirewallRules = new IpFirewallRulesOperations(this);
            SqlPools = new SqlPoolsOperations(this);
            SqlPoolMetadataSyncConfigs = new SqlPoolMetadataSyncConfigsOperations(this);
            SqlPoolOperationResults = new SqlPoolOperationResultsOperations(this);
            SqlPoolGeoBackupPolicies = new SqlPoolGeoBackupPoliciesOperations(this);
            SqlPoolDataWarehouseUserActivities = new SqlPoolDataWarehouseUserActivitiesOperations(this);
            SqlPoolRestorePoints = new SqlPoolRestorePointsOperations(this);
            SqlPoolReplicationLinks = new SqlPoolReplicationLinksOperations(this);
            SqlPoolTransparentDataEncryptions = new SqlPoolTransparentDataEncryptionsOperations(this);
            SqlPoolBlobAuditingPolicies = new SqlPoolBlobAuditingPoliciesOperations(this);
            SqlPoolOperations = new SqlPoolOperations(this);
            SqlPoolUsages = new SqlPoolUsagesOperations(this);
            SqlPoolSensitivityLabels = new SqlPoolSensitivityLabelsOperations(this);
            SqlPoolSchemas = new SqlPoolSchemasOperations(this);
            SqlPoolTables = new SqlPoolTablesOperations(this);
            SqlPoolTableColumns = new SqlPoolTableColumnsOperations(this);
            SqlPoolConnectionPolicies = new SqlPoolConnectionPoliciesOperations(this);
            SqlPoolVulnerabilityAssessments = new SqlPoolVulnerabilityAssessmentsOperations(this);
            SqlPoolVulnerabilityAssessmentScans = new SqlPoolVulnerabilityAssessmentScansOperations(this);
            SqlPoolSecurityAlertPolicies = new SqlPoolSecurityAlertPoliciesOperations(this);
            SqlPoolVulnerabilityAssessmentRuleBaselines = new SqlPoolVulnerabilityAssessmentRuleBaselinesOperations(this);
            ExtendedSqlPoolBlobAuditingPolicies = new ExtendedSqlPoolBlobAuditingPoliciesOperations(this);
            DataMaskingPolicies = new DataMaskingPoliciesOperations(this);
            DataMaskingRules = new DataMaskingRulesOperations(this);
            SqlPoolColumns = new SqlPoolColumnsOperations(this);
            SqlPoolWorkloadGroup = new SqlPoolWorkloadGroupOperations(this);
            SqlPoolWorkloadClassifier = new SqlPoolWorkloadClassifierOperations(this);
            Workspaces = new WorkspacesOperations(this);
            WorkspaceAadAdmins = new WorkspaceAadAdminsOperations(this);
            WorkspaceSqlAadAdmins = new WorkspaceSqlAadAdminsOperations(this);
            WorkspaceManagedIdentitySqlControlSettings = new WorkspaceManagedIdentitySqlControlSettingsOperations(this);
            RestorableDroppedSqlPools = new RestorableDroppedSqlPoolsOperations(this);
            IntegrationRuntimes = new IntegrationRuntimesOperations(this);
            IntegrationRuntimeNodeIpAddress = new IntegrationRuntimeNodeIpAddressOperations(this);
            IntegrationRuntimeObjectMetadata = new IntegrationRuntimeObjectMetadataOperations(this);
            IntegrationRuntimeNodes = new IntegrationRuntimeNodesOperations(this);
            IntegrationRuntimeCredentials = new IntegrationRuntimeCredentialsOperations(this);
            IntegrationRuntimeConnectionInfos = new IntegrationRuntimeConnectionInfosOperations(this);
            IntegrationRuntimeAuthKeys = new IntegrationRuntimeAuthKeysOperations(this);
            IntegrationRuntimeMonitoringData = new IntegrationRuntimeMonitoringDataOperations(this);
            IntegrationRuntimeStatus = new IntegrationRuntimeStatusOperations(this);
            PrivateLinkResources = new PrivateLinkResourcesOperations(this);
            PrivateEndpointConnections = new PrivateEndpointConnectionsOperations(this);
            PrivateLinkHubs = new PrivateLinkHubsOperations(this);
            PrivateEndpointConnectionsPrivateLinkHub = new PrivateEndpointConnectionsPrivateLinkHubOperations(this);
            WorkspaceManagedSqlServerBlobAuditingPolicies = new WorkspaceManagedSqlServerBlobAuditingPoliciesOperations(this);
            WorkspaceManagedSqlServerExtendedBlobAuditingPolicies = new WorkspaceManagedSqlServerExtendedBlobAuditingPoliciesOperations(this);
            WorkspaceManagedSqlServerSecurityAlertPolicy = new WorkspaceManagedSqlServerSecurityAlertPolicyOperations(this);
            WorkspaceManagedSqlServerVulnerabilityAssessments = new WorkspaceManagedSqlServerVulnerabilityAssessmentsOperations(this);
            WorkspaceManagedSqlServerUsages = new WorkspaceManagedSqlServerUsagesOperations(this);
            WorkspaceManagedSqlServerRecoverableSqlPools = new WorkspaceManagedSqlServerRecoverableSqlPoolsOperations(this);
            Keys = new KeysOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2019-06-01-preview";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<IntegrationRuntime>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<IntegrationRuntime>("type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<CustomSetupBase>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<CustomSetupBase>("type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<SecretBase>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<SecretBase>("type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<LinkedIntegrationRuntimeType>("authorizationType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<LinkedIntegrationRuntimeType>("authorizationType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<IntegrationRuntimeStatus>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<IntegrationRuntimeStatus>("type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<SsisObjectMetadata>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<SsisObjectMetadata>("type"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
