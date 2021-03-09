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
    /// Extension methods for PrivateLinkResourcesCompOperations.
    /// </summary>
    public static partial class PrivateLinkResourcesCompOperationsExtensions
    {
            /// <summary>
            /// Gets the private link resources that need to be created for a service.
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
            public static PrivateLinkResourceListResult ListByService(this IPrivateLinkResourcesCompOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListByServiceAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link resources that need to be created for a service.
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
            public static async Task<PrivateLinkResourceListResult> ListByServiceAsync(this IPrivateLinkResourcesCompOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a private link resource that need to be created for a service.
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
            /// <param name='groupName'>
            /// The name of the private link resource group.
            /// </param>
            public static PrivateLinkResource Get(this IPrivateLinkResourcesCompOperations operations, string resourceGroupName, string resourceName, string groupName)
            {
                return operations.GetAsync(resourceGroupName, resourceName, groupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a private link resource that need to be created for a service.
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
            /// <param name='groupName'>
            /// The name of the private link resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkResource> GetAsync(this IPrivateLinkResourcesCompOperations operations, string resourceGroupName, string resourceName, string groupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, groupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
