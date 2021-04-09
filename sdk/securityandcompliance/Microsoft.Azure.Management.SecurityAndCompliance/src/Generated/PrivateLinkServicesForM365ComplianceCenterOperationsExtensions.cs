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
    /// Extension methods for PrivateLinkServicesForM365ComplianceCenterOperations.
    /// </summary>
    public static partial class PrivateLinkServicesForM365ComplianceCenterOperationsExtensions
    {
            /// <summary>
            /// Get the metadata of a privateLinkServicesForM365ComplianceCenter resource.
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
            public static PrivateLinkServicesForM365ComplianceCenterDescription Get(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the metadata of a privateLinkServicesForM365ComplianceCenter resource.
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
            public static async Task<PrivateLinkServicesForM365ComplianceCenterDescription> GetAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForM365ComplianceCenter instance.
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
            /// <param name='privateLinkServicesForM365ComplianceCenterDescription'>
            /// The service instance metadata.
            /// </param>
            public static PrivateLinkServicesForM365ComplianceCenterDescription CreateOrUpdate(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForM365ComplianceCenterDescription privateLinkServicesForM365ComplianceCenterDescription)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, privateLinkServicesForM365ComplianceCenterDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForM365ComplianceCenter instance.
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
            /// <param name='privateLinkServicesForM365ComplianceCenterDescription'>
            /// The service instance metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForM365ComplianceCenterDescription> CreateOrUpdateAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForM365ComplianceCenterDescription privateLinkServicesForM365ComplianceCenterDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateLinkServicesForM365ComplianceCenterDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForM365ComplianceCenter
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
            public static PrivateLinkServicesForM365ComplianceCenterDescription Update(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription)
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, servicePatchDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForM365ComplianceCenter
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
            public static async Task<PrivateLinkServicesForM365ComplianceCenterDescription> UpdateAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription, CancellationToken cancellationToken = default(CancellationToken))
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
            public static void Delete(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName)
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
            public static async Task DeleteAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all the privateLinkServicesForM365ComplianceCenter instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PrivateLinkServicesForM365ComplianceCenterDescription> List(this IPrivateLinkServicesForM365ComplianceCenterOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the privateLinkServicesForM365ComplianceCenter instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkServicesForM365ComplianceCenterDescription>> ListAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, CancellationToken cancellationToken = default(CancellationToken))
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
            public static IPage<PrivateLinkServicesForM365ComplianceCenterDescription> ListByResourceGroup(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName)
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
            public static async Task<IPage<PrivateLinkServicesForM365ComplianceCenterDescription>> ListByResourceGroupAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForM365ComplianceCenter instance.
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
            /// <param name='privateLinkServicesForM365ComplianceCenterDescription'>
            /// The service instance metadata.
            /// </param>
            public static PrivateLinkServicesForM365ComplianceCenterDescription BeginCreateOrUpdate(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForM365ComplianceCenterDescription privateLinkServicesForM365ComplianceCenterDescription)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, privateLinkServicesForM365ComplianceCenterDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a
            /// privateLinkServicesForM365ComplianceCenter instance.
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
            /// <param name='privateLinkServicesForM365ComplianceCenterDescription'>
            /// The service instance metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkServicesForM365ComplianceCenterDescription> BeginCreateOrUpdateAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, PrivateLinkServicesForM365ComplianceCenterDescription privateLinkServicesForM365ComplianceCenterDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, privateLinkServicesForM365ComplianceCenterDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForM365ComplianceCenter
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
            public static PrivateLinkServicesForM365ComplianceCenterDescription BeginUpdate(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription)
            {
                return operations.BeginUpdateAsync(resourceGroupName, resourceName, servicePatchDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the metadata of a privateLinkServicesForM365ComplianceCenter
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
            public static async Task<PrivateLinkServicesForM365ComplianceCenterDescription> BeginUpdateAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, ServicesPatchDescription servicePatchDescription, CancellationToken cancellationToken = default(CancellationToken))
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
            public static void BeginDelete(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName)
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
            public static async Task BeginDeleteAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all the privateLinkServicesForM365ComplianceCenter instances in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkServicesForM365ComplianceCenterDescription> ListNext(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the privateLinkServicesForM365ComplianceCenter instances in a
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
            public static async Task<IPage<PrivateLinkServicesForM365ComplianceCenterDescription>> ListNextAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
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
            public static IPage<PrivateLinkServicesForM365ComplianceCenterDescription> ListByResourceGroupNext(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string nextPageLink)
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
            public static async Task<IPage<PrivateLinkServicesForM365ComplianceCenterDescription>> ListByResourceGroupNextAsync(this IPrivateLinkServicesForM365ComplianceCenterOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
