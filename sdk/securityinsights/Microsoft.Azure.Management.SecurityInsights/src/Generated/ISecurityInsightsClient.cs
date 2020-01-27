// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// API spec for Microsoft.SecurityInsights (Azure Security Insights)
    /// resource provider
    /// </summary>
    public partial interface ISecurityInsightsClient : System.IDisposable
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
        /// API version for the operation
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Azure subscription ID
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
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAlertRulesOperations.
        /// </summary>
        IAlertRulesOperations AlertRules { get; }

        /// <summary>
        /// Gets the IActionsOperations.
        /// </summary>
        IActionsOperations Actions { get; }

        /// <summary>
        /// Gets the IAlertRuleTemplatesOperations.
        /// </summary>
        IAlertRuleTemplatesOperations AlertRuleTemplates { get; }

        /// <summary>
        /// Gets the ICasesOperations.
        /// </summary>
        ICasesOperations Cases { get; }

        /// <summary>
        /// Gets the ICommentsOperations.
        /// </summary>
        ICommentsOperations Comments { get; }

        /// <summary>
        /// Gets the ICaseCommentsOperations.
        /// </summary>
        ICaseCommentsOperations CaseComments { get; }

        /// <summary>
        /// Gets the IBookmarksOperations.
        /// </summary>
        IBookmarksOperations Bookmarks { get; }

        /// <summary>
        /// Gets the ICaseRelationsOperations.
        /// </summary>
        ICaseRelationsOperations CaseRelations { get; }

        /// <summary>
        /// Gets the IBookmarkRelationsOperations.
        /// </summary>
        IBookmarkRelationsOperations BookmarkRelations { get; }

        /// <summary>
        /// Gets the IBookmarkOperations.
        /// </summary>
        IBookmarkOperations Bookmark { get; }

        /// <summary>
        /// Gets the IDataConnectorsOperations.
        /// </summary>
        IDataConnectorsOperations DataConnectors { get; }

        /// <summary>
        /// Gets the IEntitiesOperations.
        /// </summary>
        IEntitiesOperations Entities { get; }

        /// <summary>
        /// Gets the IOfficeConsentsOperations.
        /// </summary>
        IOfficeConsentsOperations OfficeConsents { get; }

        /// <summary>
        /// Gets the IProductSettingsOperations.
        /// </summary>
        IProductSettingsOperations ProductSettings { get; }

        /// <summary>
        /// Gets the ICasesAggregationsOperations.
        /// </summary>
        ICasesAggregationsOperations CasesAggregations { get; }

        /// <summary>
        /// Gets the IEntityQueriesOperations.
        /// </summary>
        IEntityQueriesOperations EntityQueries { get; }

        /// <summary>
        /// Get requirements state for a data connector type.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='operationalInsightsResourceProvider'>
        /// The namespace of workspaces resource provider-
        /// Microsoft.OperationalInsights.
        /// </param>
        /// <param name='kind'>
        /// The kind of the data connector. Possible values include:
        /// 'AzureActiveDirectory', 'AzureSecurityCenter',
        /// 'MicrosoftCloudAppSecurity', 'ThreatIntelligence', 'Office365',
        /// 'AmazonWebServicesCloudTrail', 'AzureAdvancedThreatProtection',
        /// 'MicrosoftDefenderAdvancedThreatProtection'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataConnectorRequirementsState>> ListDataConnectorRequirementsWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string operationalInsightsResourceProvider, string kind, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
