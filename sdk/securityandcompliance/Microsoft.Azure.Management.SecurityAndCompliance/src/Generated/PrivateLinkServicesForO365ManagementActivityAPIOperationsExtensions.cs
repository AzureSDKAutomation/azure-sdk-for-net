// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityAndCompliance
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateLinkServicesForO365ManagementActivityAPIOperations.
    /// </summary>
    public static partial class PrivateLinkServicesForO365ManagementActivityAPIOperationsExtensions
    {
            /// <summary>
            /// Get the metadata of a privateLinkServicesForO365ManagementActivityAPI
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            public static PrivateLinkServicesForO365ManagementActivityAPIDescription Get(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the metadata of a privateLinkServicesForO365ManagementActivityAPI
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForO365ManagementActivityAPIDescription> GetAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForO365ManagementActivityAPI instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='privateLinkServicesForO365ManagementActivityAPIDescription'>
            /// The service instance metadata.
            /// </param>
            public static PrivateLinkServicesForO365ManagementActivityAPIDescription CreateOrUpdate(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForO365ManagementActivityAPIDescription privateLinkServicesForO365ManagementActivityAPIDescription)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, privateLinkServicesForO365ManagementActivityAPIDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForO365ManagementActivityAPI instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='privateLinkServicesForO365ManagementActivityAPIDescription'>
            /// The service instance metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForO365ManagementActivityAPIDescription> CreateOrUpdateAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForO365ManagementActivityAPIDescription privateLinkServicesForO365ManagementActivityAPIDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateLinkServicesForO365ManagementActivityAPIDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForO365ManagementActivityAPI
            /// instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='servicePatchDescription'>
            /// The service instance metadata and security metadata.
            /// </param>
            public static PrivateLinkServicesForO365ManagementActivityAPIDescription Update(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription)
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, servicePatchDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForO365ManagementActivityAPI
            /// instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='servicePatchDescription'>
            /// The service instance metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForO365ManagementActivityAPIDescription> UpdateAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, servicePatchDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            public static void Delete(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName)
            {
                operations.DeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all the privateLinkServicesForO365ManagementActivityAPI instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription> List(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the privateLinkServicesForO365ManagementActivityAPI instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription>> ListAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the service instances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            public static IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription> ListByResourceGroup(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the service instances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription>> ListByResourceGroupAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForO365ManagementActivityAPI instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='privateLinkServicesForO365ManagementActivityAPIDescription'>
            /// The service instance metadata.
            /// </param>
            public static PrivateLinkServicesForO365ManagementActivityAPIDescription BeginCreateOrUpdate(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForO365ManagementActivityAPIDescription privateLinkServicesForO365ManagementActivityAPIDescription)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, privateLinkServicesForO365ManagementActivityAPIDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForO365ManagementActivityAPI instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='privateLinkServicesForO365ManagementActivityAPIDescription'>
            /// The service instance metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForO365ManagementActivityAPIDescription> BeginCreateOrUpdateAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForO365ManagementActivityAPIDescription privateLinkServicesForO365ManagementActivityAPIDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateLinkServicesForO365ManagementActivityAPIDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForO365ManagementActivityAPI
            /// instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='servicePatchDescription'>
            /// The service instance metadata and security metadata.
            /// </param>
            public static PrivateLinkServicesForO365ManagementActivityAPIDescription BeginUpdate(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription)
            {
                return operations.BeginUpdateAsync(resourceGroupName, resourceName, servicePatchDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForO365ManagementActivityAPI
            /// instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='servicePatchDescription'>
            /// The service instance metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForO365ManagementActivityAPIDescription> BeginUpdateAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, servicePatchDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            public static void BeginDelete(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all the privateLinkServicesForO365ManagementActivityAPI instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription> ListNext(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the privateLinkServicesForO365ManagementActivityAPI instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription>> ListNextAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the service instances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription> ListByResourceGroupNext(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the service instances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkServicesForO365ManagementActivityAPIDescription>> ListByResourceGroupNextAsync(this IPrivateLinkServicesForO365ManagementActivityAPIOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
