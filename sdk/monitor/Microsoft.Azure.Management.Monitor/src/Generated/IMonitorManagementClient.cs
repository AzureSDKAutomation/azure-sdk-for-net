// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Monitor Management Client
    /// </summary>
    public partial interface IMonitorManagementClient : System.IDisposable
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
        /// The ID of the target subscription.
        /// </summary>
        string SubscriptionId { get; set; }

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
        /// Gets the IAutoscaleSettingsOperations.
        /// </summary>
        IAutoscaleSettingsOperations AutoscaleSettings { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAlertRuleIncidentsOperations.
        /// </summary>
        IAlertRuleIncidentsOperations AlertRuleIncidents { get; }

        /// <summary>
        /// Gets the IAlertRulesOperations.
        /// </summary>
        IAlertRulesOperations AlertRules { get; }

        /// <summary>
        /// Gets the ILogProfilesOperations.
        /// </summary>
        ILogProfilesOperations LogProfiles { get; }

        /// <summary>
        /// Gets the IDiagnosticSettingsOperations.
        /// </summary>
        IDiagnosticSettingsOperations DiagnosticSettings { get; }

        /// <summary>
        /// Gets the IDiagnosticSettingsCategoryOperations.
        /// </summary>
        IDiagnosticSettingsCategoryOperations DiagnosticSettingsCategory { get; }

        /// <summary>
        /// Gets the IActionGroupsOperations.
        /// </summary>
        IActionGroupsOperations ActionGroups { get; }

        /// <summary>
        /// Gets the IActivityLogAlertsOperations.
        /// </summary>
        IActivityLogAlertsOperations ActivityLogAlerts { get; }

        /// <summary>
        /// Gets the IActivityLogsOperations.
        /// </summary>
        IActivityLogsOperations ActivityLogs { get; }

        /// <summary>
        /// Gets the IEventCategoriesOperations.
        /// </summary>
        IEventCategoriesOperations EventCategories { get; }

        /// <summary>
        /// Gets the ITenantActivityLogsOperations.
        /// </summary>
        ITenantActivityLogsOperations TenantActivityLogs { get; }

        /// <summary>
        /// Gets the IMetricDefinitionsOperations.
        /// </summary>
        IMetricDefinitionsOperations MetricDefinitions { get; }

        /// <summary>
        /// Gets the IMetricsOperations.
        /// </summary>
        IMetricsOperations Metrics { get; }

        /// <summary>
        /// Gets the IMetricBaselineOperations.
        /// </summary>
        IMetricBaselineOperations MetricBaseline { get; }

        /// <summary>
        /// Gets the IBaselinesOperations.
        /// </summary>
        IBaselinesOperations Baselines { get; }

        /// <summary>
        /// Gets the IMetricAlertsOperations.
        /// </summary>
        IMetricAlertsOperations MetricAlerts { get; }

        /// <summary>
        /// Gets the IMetricAlertsStatusOperations.
        /// </summary>
        IMetricAlertsStatusOperations MetricAlertsStatus { get; }

        /// <summary>
        /// Gets the IScheduledQueryRulesOperations.
        /// </summary>
        IScheduledQueryRulesOperations ScheduledQueryRules { get; }

        /// <summary>
        /// Gets the IMetricNamespacesOperations.
        /// </summary>
        IMetricNamespacesOperations MetricNamespaces { get; }

        /// <summary>
        /// Gets the IVMInsightsOperations.
        /// </summary>
        IVMInsightsOperations VMInsights { get; }

        /// <summary>
        /// Gets the IPrivateLinkScopesOperations.
        /// </summary>
        IPrivateLinkScopesOperations PrivateLinkScopes { get; }

        /// <summary>
        /// Gets the IPrivateLinkScopeOperationStatusOperations.
        /// </summary>
        IPrivateLinkScopeOperationStatusOperations PrivateLinkScopeOperationStatus { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the IPrivateLinkScopedResourcesOperations.
        /// </summary>
        IPrivateLinkScopedResourcesOperations PrivateLinkScopedResources { get; }

    }
}
