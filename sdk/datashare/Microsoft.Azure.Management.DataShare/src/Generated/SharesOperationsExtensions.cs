// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SharesOperations.
    /// </summary>
    public static partial class SharesOperationsExtensions
    {
            /// <summary>
            /// Get a specified share
            /// </summary>
            /// <remarks>
            /// Get a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share to retrieve.
            /// </param>
            public static Share Get(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName)
            {
                return operations.GetAsync(resourceGroupName, accountName, shareName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a specified share
            /// </summary>
            /// <remarks>
            /// Get a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Share> GetAsync(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, shareName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a share in the given account.
            /// </summary>
            /// <remarks>
            /// Create a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='share'>
            /// The share payload
            /// </param>
            public static Share Create(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, Share share)
            {
                return operations.CreateAsync(resourceGroupName, accountName, shareName, share).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a share in the given account.
            /// </summary>
            /// <remarks>
            /// Create a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='share'>
            /// The share payload
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Share> CreateAsync(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, Share share, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, shareName, share, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a share
            /// </summary>
            /// <remarks>
            /// Delete a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            public static OperationResponse Delete(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName)
            {
                return operations.DeleteAsync(resourceGroupName, accountName, shareName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a share
            /// </summary>
            /// <remarks>
            /// Delete a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResponse> DeleteAsync(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List of available shares under an account.
            /// </summary>
            /// <remarks>
            /// List shares in an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation Token
            /// </param>
            /// <param name='filter'>
            /// Filters the results using OData syntax.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results using OData syntax.
            /// </param>
            public static IPage<Share> ListByAccount(this ISharesOperations operations, string resourceGroupName, string accountName, string skipToken = default(string), string filter = default(string), string orderby = default(string))
            {
                return operations.ListByAccountAsync(resourceGroupName, accountName, skipToken, filter, orderby).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of available shares under an account.
            /// </summary>
            /// <remarks>
            /// List shares in an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation Token
            /// </param>
            /// <param name='filter'>
            /// Filters the results using OData syntax.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results using OData syntax.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Share>> ListByAccountAsync(this ISharesOperations operations, string resourceGroupName, string accountName, string skipToken = default(string), string filter = default(string), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, skipToken, filter, orderby, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Synchronizations in a share
            /// </summary>
            /// <remarks>
            /// List synchronizations of a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            /// <param name='filter'>
            /// Filters the results using OData syntax.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results using OData syntax.
            /// </param>
            public static IPage<ShareSynchronization> ListSynchronizations(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, string skipToken = default(string), string filter = default(string), string orderby = default(string))
            {
                return operations.ListSynchronizationsAsync(resourceGroupName, accountName, shareName, skipToken, filter, orderby).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Synchronizations in a share
            /// </summary>
            /// <remarks>
            /// List synchronizations of a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            /// <param name='filter'>
            /// Filters the results using OData syntax.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results using OData syntax.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ShareSynchronization>> ListSynchronizationsAsync(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, string skipToken = default(string), string filter = default(string), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSynchronizationsWithHttpMessagesAsync(resourceGroupName, accountName, shareName, skipToken, filter, orderby, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List data set level details for a share synchronization
            /// </summary>
            /// <remarks>
            /// List synchronization details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='shareSynchronization'>
            /// Share Synchronization payload.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            /// <param name='filter'>
            /// Filters the results using OData syntax.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results using OData syntax.
            /// </param>
            public static IPage<SynchronizationDetails> ListSynchronizationDetails(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, ShareSynchronization shareSynchronization, string skipToken = default(string), string filter = default(string), string orderby = default(string))
            {
                return operations.ListSynchronizationDetailsAsync(resourceGroupName, accountName, shareName, shareSynchronization, skipToken, filter, orderby).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List data set level details for a share synchronization
            /// </summary>
            /// <remarks>
            /// List synchronization details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='shareSynchronization'>
            /// Share Synchronization payload.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            /// <param name='filter'>
            /// Filters the results using OData syntax.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results using OData syntax.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SynchronizationDetails>> ListSynchronizationDetailsAsync(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, ShareSynchronization shareSynchronization, string skipToken = default(string), string filter = default(string), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSynchronizationDetailsWithHttpMessagesAsync(resourceGroupName, accountName, shareName, shareSynchronization, skipToken, filter, orderby, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a share
            /// </summary>
            /// <remarks>
            /// Delete a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            public static OperationResponse BeginDelete(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, accountName, shareName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a share
            /// </summary>
            /// <remarks>
            /// Delete a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResponse> BeginDeleteAsync(this ISharesOperations operations, string resourceGroupName, string accountName, string shareName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List of available shares under an account.
            /// </summary>
            /// <remarks>
            /// List shares in an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Share> ListByAccountNext(this ISharesOperations operations, string nextPageLink)
            {
                return operations.ListByAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of available shares under an account.
            /// </summary>
            /// <remarks>
            /// List shares in an account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Share>> ListByAccountNextAsync(this ISharesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Synchronizations in a share
            /// </summary>
            /// <remarks>
            /// List synchronizations of a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ShareSynchronization> ListSynchronizationsNext(this ISharesOperations operations, string nextPageLink)
            {
                return operations.ListSynchronizationsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Synchronizations in a share
            /// </summary>
            /// <remarks>
            /// List synchronizations of a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ShareSynchronization>> ListSynchronizationsNextAsync(this ISharesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSynchronizationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List data set level details for a share synchronization
            /// </summary>
            /// <remarks>
            /// List synchronization details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SynchronizationDetails> ListSynchronizationDetailsNext(this ISharesOperations operations, string nextPageLink)
            {
                return operations.ListSynchronizationDetailsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List data set level details for a share synchronization
            /// </summary>
            /// <remarks>
            /// List synchronization details
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SynchronizationDetails>> ListSynchronizationDetailsNextAsync(this ISharesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSynchronizationDetailsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
