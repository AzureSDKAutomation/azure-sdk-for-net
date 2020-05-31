// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MariaDB
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
    /// The Microsoft Azure management API provides create, read, update, and
    /// delete functionality for Azure MariaDB resources including servers,
    /// databases, firewall rules, VNET rules, log files and configurations
    /// with new business model.
    /// </summary>
    public partial interface IMariaDBManagementClient : System.IDisposable
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
        /// The API version to use for this operation.
        /// </summary>
        string ApiVersion { get; }

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
        /// Gets the IServersOperations.
        /// </summary>
        IServersOperations Servers { get; }

        /// <summary>
        /// Gets the IReplicasOperations.
        /// </summary>
        IReplicasOperations Replicas { get; }

        /// <summary>
        /// Gets the IFirewallRulesOperations.
        /// </summary>
        IFirewallRulesOperations FirewallRules { get; }

        /// <summary>
        /// Gets the IVirtualNetworkRulesOperations.
        /// </summary>
        IVirtualNetworkRulesOperations VirtualNetworkRules { get; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        IDatabasesOperations Databases { get; }

        /// <summary>
        /// Gets the IConfigurationsOperations.
        /// </summary>
        IConfigurationsOperations Configurations { get; }

        /// <summary>
        /// Gets the ILogFilesOperations.
        /// </summary>
        ILogFilesOperations LogFiles { get; }

        /// <summary>
        /// Gets the ILocationBasedPerformanceTierOperations.
        /// </summary>
        ILocationBasedPerformanceTierOperations LocationBasedPerformanceTier { get; }

        /// <summary>
        /// Gets the ICheckNameAvailabilityOperations.
        /// </summary>
        ICheckNameAvailabilityOperations CheckNameAvailability { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IQueryTextsOperations.
        /// </summary>
        IQueryTextsOperations QueryTexts { get; }

        /// <summary>
        /// Gets the ITopQueryStatisticsOperations.
        /// </summary>
        ITopQueryStatisticsOperations TopQueryStatistics { get; }

        /// <summary>
        /// Gets the IWaitStatisticsOperations.
        /// </summary>
        IWaitStatisticsOperations WaitStatistics { get; }

        /// <summary>
        /// Gets the IAdvisorsOperations.
        /// </summary>
        IAdvisorsOperations Advisors { get; }

        /// <summary>
        /// Gets the IRecommendedActionsOperations.
        /// </summary>
        IRecommendedActionsOperations RecommendedActions { get; }

        /// <summary>
        /// Gets the ILocationBasedRecommendedActionSessionsOperationStatusOperations.
        /// </summary>
        ILocationBasedRecommendedActionSessionsOperationStatusOperations LocationBasedRecommendedActionSessionsOperationStatus { get; }

        /// <summary>
        /// Gets the ILocationBasedRecommendedActionSessionsResultOperations.
        /// </summary>
        ILocationBasedRecommendedActionSessionsResultOperations LocationBasedRecommendedActionSessionsResult { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Create recommendation action session for the advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='advisorName'>
        /// The advisor name for recommendation action.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> CreateRecommendedActionSessionWithHttpMessagesAsync(string resourceGroupName, string serverName, string advisorName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create recommendation action session for the advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='advisorName'>
        /// The advisor name for recommendation action.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginCreateRecommendedActionSessionWithHttpMessagesAsync(string resourceGroupName, string serverName, string advisorName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
