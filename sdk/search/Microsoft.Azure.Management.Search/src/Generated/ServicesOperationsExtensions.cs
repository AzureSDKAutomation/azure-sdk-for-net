// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServicesOperations.
    /// </summary>
    public static partial class ServicesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service to create or update. Search
            /// service names must only contain lowercase letters, digits or dashes, cannot
            /// use dash as the first two or last one characters, cannot contain
            /// consecutive dashes, and must be between 2 and 60 characters in length.
            /// Search service names must be globally unique since they are part of the
            /// service URI (https://&lt;name&gt;.search.windows.net). You cannot change
            /// the service name after the service is created.
            /// </param>
            /// <param name='service'>
            /// The definition of the Search service to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SearchService CreateOrUpdate(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service to create or update. Search
            /// service names must only contain lowercase letters, digits or dashes, cannot
            /// use dash as the first two or last one characters, cannot contain
            /// consecutive dashes, and must be between 2 and 60 characters in length.
            /// Search service names must be globally unique since they are part of the
            /// service URI (https://&lt;name&gt;.search.windows.net). You cannot change
            /// the service name after the service is created.
            /// </param>
            /// <param name='service'>
            /// The definition of the Search service to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchService> CreateOrUpdateAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing Search service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service to update.
            /// </param>
            /// <param name='service'>
            /// The definition of the Search service to update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SearchService Update(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.UpdateAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing Search service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service to update.
            /// </param>
            /// <param name='service'>
            /// The definition of the Search service to update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchService> UpdateAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Search service with the given name in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SearchService Get(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.GetAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Search service with the given name in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchService> GetAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Search service in the given resource group, along with its
            /// associated resources.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                operations.DeleteAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Search service in the given resource group, along with its
            /// associated resources.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of all Search services in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IEnumerable<SearchService> ListByResourceGroup(this IServicesOperations operations, string resourceGroupName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all Search services in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<SearchService>> ListByResourceGroupAsync(this IServicesOperations operations, string resourceGroupName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all Search services in the given subscription.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IEnumerable<SearchService> ListBySubscription(this IServicesOperations operations, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.ListBySubscriptionAsync(searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all Search services in the given subscription.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<SearchService>> ListBySubscriptionAsync(this IServicesOperations operations, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks whether or not the given Search service name is available for use.
            /// Search service names must be globally unique since they are part of the
            /// service URI (https://&lt;name&gt;.search.windows.net).
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The Search service name to validate. Search service names must only contain
            /// lowercase letters, digits or dashes, cannot use dash as the first two or
            /// last one characters, cannot contain consecutive dashes, and must be between
            /// 2 and 60 characters in length.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CheckNameAvailabilityOutput CheckNameAvailability(this IServicesOperations operations, string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.CheckNameAvailabilityAsync(name, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether or not the given Search service name is available for use.
            /// Search service names must be globally unique since they are part of the
            /// service URI (https://&lt;name&gt;.search.windows.net).
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The Search service name to validate. Search service names must only contain
            /// lowercase letters, digits or dashes, cannot use dash as the first two or
            /// last one characters, cannot contain consecutive dashes, and must be between
            /// 2 and 60 characters in length.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityOutput> CheckNameAvailabilityAsync(this IServicesOperations operations, string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(name, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service to create or update. Search
            /// service names must only contain lowercase letters, digits or dashes, cannot
            /// use dash as the first two or last one characters, cannot contain
            /// consecutive dashes, and must be between 2 and 60 characters in length.
            /// Search service names must be globally unique since they are part of the
            /// service URI (https://&lt;name&gt;.search.windows.net). You cannot change
            /// the service name after the service is created.
            /// </param>
            /// <param name='service'>
            /// The definition of the Search service to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SearchService BeginCreateOrUpdate(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service to create or update. Search
            /// service names must only contain lowercase letters, digits or dashes, cannot
            /// use dash as the first two or last one characters, cannot contain
            /// consecutive dashes, and must be between 2 and 60 characters in length.
            /// Search service names must be globally unique since they are part of the
            /// service URI (https://&lt;name&gt;.search.windows.net). You cannot change
            /// the service name after the service is created.
            /// </param>
            /// <param name='service'>
            /// The definition of the Search service to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchService> BeginCreateOrUpdateAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
