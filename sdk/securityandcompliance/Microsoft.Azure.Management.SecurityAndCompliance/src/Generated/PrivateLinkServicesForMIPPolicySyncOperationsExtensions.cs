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
    /// Extension methods for PrivateLinkServicesForMIPPolicySyncOperations.
    /// </summary>
    public static partial class PrivateLinkServicesForMIPPolicySyncOperationsExtensions
    {
            /// <summary>
            /// Get the metadata of a privateLinkServicesForMIPPolicySync resource.
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
            public static PrivateLinkServicesForMIPPolicySyncDescription Get(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the metadata of a privateLinkServicesForMIPPolicySync resource.
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
            public static async Task<PrivateLinkServicesForMIPPolicySyncDescription> GetAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a privateLinkServicesForMIPPolicySync
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
            /// <param name='privateLinkServicesForMIPPolicySyncDescription'>
            /// The service instance metadata.
            /// </param>
            public static PrivateLinkServicesForMIPPolicySyncDescription CreateOrUpdate(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForMIPPolicySyncDescription privateLinkServicesForMIPPolicySyncDescription)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, privateLinkServicesForMIPPolicySyncDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a privateLinkServicesForMIPPolicySync
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
            /// <param name='privateLinkServicesForMIPPolicySyncDescription'>
            /// The service instance metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForMIPPolicySyncDescription> CreateOrUpdateAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForMIPPolicySyncDescription privateLinkServicesForMIPPolicySyncDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateLinkServicesForMIPPolicySyncDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForMIPPolicySync instance.
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
            public static PrivateLinkServicesForMIPPolicySyncDescription Update(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription)
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, servicePatchDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForMIPPolicySync instance.
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
            public static async Task<PrivateLinkServicesForMIPPolicySyncDescription> UpdateAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription, CancellationToken cancellationToken = default(CancellationToken))
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
            public static void Delete(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName)
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
            public static async Task DeleteAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all the privateLinkServicesForMIPPolicySync instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PrivateLinkServicesForMIPPolicySyncDescription> List(this IPrivateLinkServicesForMIPPolicySyncOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the privateLinkServicesForMIPPolicySync instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkServicesForMIPPolicySyncDescription>> ListAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, CancellationToken cancellationToken = default(CancellationToken))
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
            public static IPage<PrivateLinkServicesForMIPPolicySyncDescription> ListByResourceGroup(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName)
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
            public static async Task<IPage<PrivateLinkServicesForMIPPolicySyncDescription>> ListByResourceGroupAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a privateLinkServicesForMIPPolicySync
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
            /// <param name='privateLinkServicesForMIPPolicySyncDescription'>
            /// The service instance metadata.
            /// </param>
            public static PrivateLinkServicesForMIPPolicySyncDescription BeginCreateOrUpdate(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForMIPPolicySyncDescription privateLinkServicesForMIPPolicySyncDescription)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, privateLinkServicesForMIPPolicySyncDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a privateLinkServicesForMIPPolicySync
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
            /// <param name='privateLinkServicesForMIPPolicySyncDescription'>
            /// The service instance metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForMIPPolicySyncDescription> BeginCreateOrUpdateAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForMIPPolicySyncDescription privateLinkServicesForMIPPolicySyncDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateLinkServicesForMIPPolicySyncDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForMIPPolicySync instance.
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
            public static PrivateLinkServicesForMIPPolicySyncDescription BeginUpdate(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription)
            {
                return operations.BeginUpdateAsync(resourceGroupName, resourceName, servicePatchDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForMIPPolicySync instance.
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
            public static async Task<PrivateLinkServicesForMIPPolicySyncDescription> BeginUpdateAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription, CancellationToken cancellationToken = default(CancellationToken))
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
            public static void BeginDelete(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName)
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
            public static async Task BeginDeleteAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all the privateLinkServicesForMIPPolicySync instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkServicesForMIPPolicySyncDescription> ListNext(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the privateLinkServicesForMIPPolicySync instances in a
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
            public static async Task<IPage<PrivateLinkServicesForMIPPolicySyncDescription>> ListNextAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
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
            public static IPage<PrivateLinkServicesForMIPPolicySyncDescription> ListByResourceGroupNext(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string nextPageLink)
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
            public static async Task<IPage<PrivateLinkServicesForMIPPolicySyncDescription>> ListByResourceGroupNextAsync(this IPrivateLinkServicesForMIPPolicySyncOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
