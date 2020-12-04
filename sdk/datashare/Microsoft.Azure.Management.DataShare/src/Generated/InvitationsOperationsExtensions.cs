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
    /// Extension methods for InvitationsOperations.
    /// </summary>
    public static partial class InvitationsOperationsExtensions
    {
            /// <summary>
            /// Get Invitation in a share.
            /// </summary>
            /// <remarks>
            /// Get an invitation in a share
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
            /// <param name='invitationName'>
            /// The name of the invitation.
            /// </param>
            public static Invitation Get(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string invitationName)
            {
                return operations.GetAsync(resourceGroupName, accountName, shareName, invitationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Invitation in a share.
            /// </summary>
            /// <remarks>
            /// Get an invitation in a share
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
            /// <param name='invitationName'>
            /// The name of the invitation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Invitation> GetAsync(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string invitationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, shareName, invitationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sends a new invitation to a recipient to access a share.
            /// </summary>
            /// <remarks>
            /// Create an invitation
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
            /// The name of the share to send the invitation for.
            /// </param>
            /// <param name='invitationName'>
            /// The name of the invitation.
            /// </param>
            /// <param name='invitation'>
            /// Invitation details.
            /// </param>
            public static Invitation Create(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string invitationName, Invitation invitation)
            {
                return operations.CreateAsync(resourceGroupName, accountName, shareName, invitationName, invitation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends a new invitation to a recipient to access a share.
            /// </summary>
            /// <remarks>
            /// Create an invitation
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
            /// The name of the share to send the invitation for.
            /// </param>
            /// <param name='invitationName'>
            /// The name of the invitation.
            /// </param>
            /// <param name='invitation'>
            /// Invitation details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Invitation> CreateAsync(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string invitationName, Invitation invitation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, shareName, invitationName, invitation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete Invitation in a share.
            /// </summary>
            /// <remarks>
            /// Delete an invitation in a share
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
            /// <param name='invitationName'>
            /// The name of the invitation.
            /// </param>
            public static void Delete(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string invitationName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, shareName, invitationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Invitation in a share.
            /// </summary>
            /// <remarks>
            /// Delete an invitation in a share
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
            /// <param name='invitationName'>
            /// The name of the invitation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string invitationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, invitationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all Invitations in a share.
            /// </summary>
            /// <remarks>
            /// List invitations in a share
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
            /// The continuation token
            /// </param>
            /// <param name='filter'>
            /// Filters the results using OData syntax.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results using OData syntax.
            /// </param>
            public static IPage<Invitation> ListByShare(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string skipToken = default(string), string filter = default(string), string orderby = default(string))
            {
                return operations.ListByShareAsync(resourceGroupName, accountName, shareName, skipToken, filter, orderby).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all Invitations in a share.
            /// </summary>
            /// <remarks>
            /// List invitations in a share
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
            /// The continuation token
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
            public static async Task<IPage<Invitation>> ListByShareAsync(this IInvitationsOperations operations, string resourceGroupName, string accountName, string shareName, string skipToken = default(string), string filter = default(string), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareWithHttpMessagesAsync(resourceGroupName, accountName, shareName, skipToken, filter, orderby, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all Invitations in a share.
            /// </summary>
            /// <remarks>
            /// List invitations in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Invitation> ListByShareNext(this IInvitationsOperations operations, string nextPageLink)
            {
                return operations.ListByShareNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all Invitations in a share.
            /// </summary>
            /// <remarks>
            /// List invitations in a share
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
            public static async Task<IPage<Invitation>> ListByShareNextAsync(this IInvitationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
