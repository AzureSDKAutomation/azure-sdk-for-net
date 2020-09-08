// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecipientTransfersOperations.
    /// </summary>
    public static partial class RecipientTransfersOperationsExtensions
    {
            /// <summary>
            /// Accepts a transfer request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the accept transfer operation.
            /// </param>
            public static RecipientTransferDetails Accept(this IRecipientTransfersOperations operations, string transferName, AcceptTransferRequest parameters)
            {
                return operations.AcceptAsync(transferName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Accepts a transfer request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the accept transfer operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecipientTransferDetails> AcceptAsync(this IRecipientTransfersOperations operations, string transferName, AcceptTransferRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AcceptWithHttpMessagesAsync(transferName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Validates if a subscription or a reservation can be transferred. Use this
            /// operation to validate your subscriptions or reservation before using the
            /// accept transfer operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the validate transfer operation.
            /// </param>
            public static ValidateTransferListResponse Validate(this IRecipientTransfersOperations operations, string transferName, AcceptTransferRequest parameters)
            {
                return operations.ValidateAsync(transferName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validates if a subscription or a reservation can be transferred. Use this
            /// operation to validate your subscriptions or reservation before using the
            /// accept transfer operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the validate transfer operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ValidateTransferListResponse> ValidateAsync(this IRecipientTransfersOperations operations, string transferName, AcceptTransferRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(transferName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Declines a transfer request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            public static RecipientTransferDetails Decline(this IRecipientTransfersOperations operations, string transferName)
            {
                return operations.DeclineAsync(transferName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Declines a transfer request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecipientTransferDetails> DeclineAsync(this IRecipientTransfersOperations operations, string transferName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeclineWithHttpMessagesAsync(transferName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a transfer request by ID. The caller must be the recipient of the
            /// transfer request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            public static RecipientTransferDetails Get(this IRecipientTransfersOperations operations, string transferName)
            {
                return operations.GetAsync(transferName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a transfer request by ID. The caller must be the recipient of the
            /// transfer request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transferName'>
            /// The ID that uniquely identifies a transfer request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecipientTransferDetails> GetAsync(this IRecipientTransfersOperations operations, string transferName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(transferName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the transfer requests received by the caller.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<RecipientTransferDetails> List(this IRecipientTransfersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the transfer requests received by the caller.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecipientTransferDetails>> ListAsync(this IRecipientTransfersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the transfer requests received by the caller.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecipientTransferDetails> ListNext(this IRecipientTransfersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the transfer requests received by the caller.
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
            public static async Task<IPage<RecipientTransferDetails>> ListNextAsync(this IRecipientTransfersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
