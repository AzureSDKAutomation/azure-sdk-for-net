// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppConfiguration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateLinkResourcesOperations.
    /// </summary>
    public static partial class PrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// Gets the private link resources that need to be created for a configuration
            /// store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            public static IPage<PrivateLinkResource> ListByConfigurationStore(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string configStoreName)
            {
                return operations.ListByConfigurationStoreAsync(resourceGroupName, configStoreName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a configuration
            /// store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkResource>> ListByConfigurationStoreAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByConfigurationStoreWithHttpMessagesAsync(resourceGroupName, configStoreName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a private link resource that need to be created for a configuration
            /// store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='groupName'>
            /// The name of the private link resource group.
            /// </param>
            public static PrivateLinkResource Get(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string configStoreName, string groupName)
            {
                return operations.GetAsync(resourceGroupName, configStoreName, groupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a private link resource that need to be created for a configuration
            /// store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='groupName'>
            /// The name of the private link resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkResource> GetAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, configStoreName, groupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a configuration
            /// store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkResource> ListByConfigurationStoreNext(this IPrivateLinkResourcesOperations operations, string nextPageLink)
            {
                return operations.ListByConfigurationStoreNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a configuration
            /// store.
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
            public static async Task<IPage<PrivateLinkResource>> ListByConfigurationStoreNextAsync(this IPrivateLinkResourcesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByConfigurationStoreNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
