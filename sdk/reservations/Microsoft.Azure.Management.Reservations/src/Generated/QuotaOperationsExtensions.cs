// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotaOperations.
    /// </summary>
    public static partial class QuotaOperationsExtensions
    {
            /// <summary>
            /// Gets the current quota limit and usages for the resource provider for the
            /// specified location for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// This API gets the current quota limit and usages for the specific resource
            /// for resource provider for the specified location. This response can be used
            /// to submit quotaRequests.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            public static CurrentQuotaLimitBase ListStatus(this IQuotaOperations operations, string subscriptionId, string providerId, string location, string resourceName)
            {
                return operations.ListStatusAsync(subscriptionId, providerId, location, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the current quota limit and usages for the resource provider for the
            /// specified location for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// This API gets the current quota limit and usages for the specific resource
            /// for resource provider for the specified location. This response can be used
            /// to submit quotaRequests.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CurrentQuotaLimitBase> ListStatusAsync(this IQuotaOperations operations, string subscriptionId, string providerId, string location, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStatusWithHttpMessagesAsync(subscriptionId, providerId, location, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
