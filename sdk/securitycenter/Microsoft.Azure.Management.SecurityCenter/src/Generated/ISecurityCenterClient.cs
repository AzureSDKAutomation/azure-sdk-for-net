// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// API spec for Microsoft.Security (Azure Security Center) resource
    /// provider
    /// </summary>
    public partial interface ISecurityCenterClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Azure subscription ID
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The location where ASC stores the data of the subscription. can be
        /// retrieved from Get locations
        /// </summary>
        string AscLocation { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IPricingsOperations.
        /// </summary>
        IPricingsOperations Pricings { get; }

        /// <summary>
        /// Gets the ISettingsOperations.
        /// </summary>
        ISettingsOperations Settings { get; }

        /// <summary>
        /// Gets the IAdvancedThreatProtectionOperations.
        /// </summary>
        IAdvancedThreatProtectionOperations AdvancedThreatProtection { get; }

        /// <summary>
        /// Gets the IDeviceSecurityGroupsOperations.
        /// </summary>
        IDeviceSecurityGroupsOperations DeviceSecurityGroups { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionOperations.
        /// </summary>
        IIotSecuritySolutionOperations IotSecuritySolution { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionAnalyticsOperations.
        /// </summary>
        IIotSecuritySolutionAnalyticsOperations IotSecuritySolutionAnalytics { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionsAnalyticsAggregatedAlertOperations.
        /// </summary>
        IIotSecuritySolutionsAnalyticsAggregatedAlertOperations IotSecuritySolutionsAnalyticsAggregatedAlert { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionsAnalyticsRecommendationOperations.
        /// </summary>
        IIotSecuritySolutionsAnalyticsRecommendationOperations IotSecuritySolutionsAnalyticsRecommendation { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAutoProvisioningSettingsOperations.
        /// </summary>
        IAutoProvisioningSettingsOperations AutoProvisioningSettings { get; }

        /// <summary>
        /// Gets the IInformationProtectionPoliciesOperations.
        /// </summary>
        IInformationProtectionPoliciesOperations InformationProtectionPolicies { get; }

        /// <summary>
        /// Gets the ISecurityContactsOperations.
        /// </summary>
        ISecurityContactsOperations SecurityContacts { get; }

        /// <summary>
        /// Gets the IWorkspaceSettingsOperations.
        /// </summary>
        IWorkspaceSettingsOperations WorkspaceSettings { get; }

        /// <summary>
        /// Gets the IRegulatoryComplianceStandardsOperations.
        /// </summary>
        IRegulatoryComplianceStandardsOperations RegulatoryComplianceStandards { get; }

        /// <summary>
        /// Gets the IRegulatoryComplianceControlsOperations.
        /// </summary>
        IRegulatoryComplianceControlsOperations RegulatoryComplianceControls { get; }

        /// <summary>
        /// Gets the IRegulatoryComplianceAssessmentsOperations.
        /// </summary>
        IRegulatoryComplianceAssessmentsOperations RegulatoryComplianceAssessments { get; }

        /// <summary>
        /// Gets the ISubAssessmentsOperations.
        /// </summary>
        ISubAssessmentsOperations SubAssessments { get; }

        /// <summary>
        /// Gets the IAutomationsOperations.
        /// </summary>
        IAutomationsOperations Automations { get; }

        /// <summary>
        /// Gets the IAlertsSuppressionRulesOperations.
        /// </summary>
        IAlertsSuppressionRulesOperations AlertsSuppressionRules { get; }

        /// <summary>
        /// Gets the IServerVulnerabilityAssessmentOperations.
        /// </summary>
        IServerVulnerabilityAssessmentOperations ServerVulnerabilityAssessment { get; }

        /// <summary>
        /// Gets the IAssessmentsMetadataOperations.
        /// </summary>
        IAssessmentsMetadataOperations AssessmentsMetadata { get; }

        /// <summary>
        /// Gets the IAssessmentsOperations.
        /// </summary>
        IAssessmentsOperations Assessments { get; }

        /// <summary>
        /// Gets the IAdaptiveApplicationControlsOperations.
        /// </summary>
        IAdaptiveApplicationControlsOperations AdaptiveApplicationControls { get; }

        /// <summary>
        /// Gets the IAdaptiveNetworkHardeningsOperations.
        /// </summary>
        IAdaptiveNetworkHardeningsOperations AdaptiveNetworkHardenings { get; }

        /// <summary>
        /// Gets the IAllowedConnectionsOperations.
        /// </summary>
        IAllowedConnectionsOperations AllowedConnections { get; }

        /// <summary>
        /// Gets the ITopologyOperations.
        /// </summary>
        ITopologyOperations Topology { get; }

        /// <summary>
        /// Gets the IAlertsOperations.
        /// </summary>
        IAlertsOperations Alerts { get; }

        /// <summary>
        /// Gets the IJitNetworkAccessPoliciesOperations.
        /// </summary>
        IJitNetworkAccessPoliciesOperations JitNetworkAccessPolicies { get; }

        /// <summary>
        /// Gets the IDiscoveredSecuritySolutionsOperations.
        /// </summary>
        IDiscoveredSecuritySolutionsOperations DiscoveredSecuritySolutions { get; }

        /// <summary>
        /// Gets the ISecuritySolutionsReferenceDataOperations.
        /// </summary>
        ISecuritySolutionsReferenceDataOperations SecuritySolutionsReferenceData { get; }

        /// <summary>
        /// Gets the IExternalSecuritySolutionsOperations.
        /// </summary>
        IExternalSecuritySolutionsOperations ExternalSecuritySolutions { get; }

        /// <summary>
        /// Gets the ISecureScoresOperations.
        /// </summary>
        ISecureScoresOperations SecureScores { get; }

        /// <summary>
        /// Gets the ISecureScoreControlsOperations.
        /// </summary>
        ISecureScoreControlsOperations SecureScoreControls { get; }

        /// <summary>
        /// Gets the ISecureScoreControlDefinitionsOperations.
        /// </summary>
        ISecureScoreControlDefinitionsOperations SecureScoreControlDefinitions { get; }

        /// <summary>
        /// Gets the ISecuritySolutionsOperations.
        /// </summary>
        ISecuritySolutionsOperations SecuritySolutions { get; }

        /// <summary>
        /// Gets the IConnectorsOperations.
        /// </summary>
        IConnectorsOperations Connectors { get; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentScansOperations.
        /// </summary>
        ISqlVulnerabilityAssessmentScansOperations SqlVulnerabilityAssessmentScans { get; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentScanResultsOperations.
        /// </summary>
        ISqlVulnerabilityAssessmentScanResultsOperations SqlVulnerabilityAssessmentScanResults { get; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentBaselineRulesOperations.
        /// </summary>
        ISqlVulnerabilityAssessmentBaselineRulesOperations SqlVulnerabilityAssessmentBaselineRules { get; }

        /// <summary>
        /// Gets the IIotAlertTypesOperations.
        /// </summary>
        IIotAlertTypesOperations IotAlertTypes { get; }

        /// <summary>
        /// Gets the IIotAlertsOperations.
        /// </summary>
        IIotAlertsOperations IotAlerts { get; }

        /// <summary>
        /// Gets the IIotRecommendationTypesOperations.
        /// </summary>
        IIotRecommendationTypesOperations IotRecommendationTypes { get; }

        /// <summary>
        /// Gets the IIotRecommendationsOperations.
        /// </summary>
        IIotRecommendationsOperations IotRecommendations { get; }

        /// <summary>
        /// Gets the IIotDefenderSettingsOperations.
        /// </summary>
        IIotDefenderSettingsOperations IotDefenderSettings { get; }

        /// <summary>
        /// Gets the IIotSensorsOperations.
        /// </summary>
        IIotSensorsOperations IotSensors { get; }

        /// <summary>
        /// Gets the IDevicesForSubscriptionOperations.
        /// </summary>
        IDevicesForSubscriptionOperations DevicesForSubscription { get; }

        /// <summary>
        /// Gets the IDevicesForHubOperations.
        /// </summary>
        IDevicesForHubOperations DevicesForHub { get; }

        /// <summary>
        /// Gets the IDeviceOperations.
        /// </summary>
        IDeviceOperations Device { get; }

        /// <summary>
        /// Gets the IOnPremiseIotSensorsOperations.
        /// </summary>
        IOnPremiseIotSensorsOperations OnPremiseIotSensors { get; }

        /// <summary>
        /// Gets the IIotSitesOperations.
        /// </summary>
        IIotSitesOperations IotSites { get; }

    }
}
