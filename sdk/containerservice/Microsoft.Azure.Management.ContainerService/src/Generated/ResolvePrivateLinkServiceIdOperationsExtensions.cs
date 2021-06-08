// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ResolvePrivateLinkServiceIdOperations.
    /// </summary>
    public static partial class ResolvePrivateLinkServiceIdOperationsExtensions
    {
            /// <summary>
            /// Gets the private link service ID for the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the private link service ID the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters (name, groupId) supplied in order to resolve a private link
            /// service ID.
            /// </param>
            public static PrivateLinkResource POST(this IResolvePrivateLinkServiceIdOperations operations, string resourceGroupName, string resourceName, PrivateLinkResource parameters)
            {
                return operations.POSTAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link service ID for the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets the private link service ID the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters (name, groupId) supplied in order to resolve a private link
            /// service ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkResource> POSTAsync(this IResolvePrivateLinkServiceIdOperations operations, string resourceGroupName, string resourceName, PrivateLinkResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.POSTWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
