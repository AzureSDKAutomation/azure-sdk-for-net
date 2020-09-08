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
    /// Extension methods for BillingSubscriptionsOperations.
    /// </summary>
    public static partial class BillingSubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Lists the subscriptions for a customer. The operation is supported only for
            /// billing accounts with agreement type Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='customerName'>
            /// The ID that uniquely identifies a customer.
            /// </param>
            public static IPage<BillingSubscription> ListByCustomer(this IBillingSubscriptionsOperations operations, string billingAccountName, string customerName)
            {
                return operations.ListByCustomerAsync(billingAccountName, customerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions for a customer. The operation is supported only for
            /// billing accounts with agreement type Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='customerName'>
            /// The ID that uniquely identifies a customer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingSubscription>> ListByCustomerAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string customerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCustomerWithHttpMessagesAsync(billingAccountName, customerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the subscriptions for a billing account. The operation is supported
            /// for billing accounts with agreement type Microsoft Customer Agreement or
            /// Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            public static IPage<BillingSubscription> ListByBillingAccount(this IBillingSubscriptionsOperations operations, string billingAccountName)
            {
                return operations.ListByBillingAccountAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions for a billing account. The operation is supported
            /// for billing accounts with agreement type Microsoft Customer Agreement or
            /// Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingSubscription>> ListByBillingAccountAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the subscriptions that are billed to a billing profile. The operation
            /// is supported for billing accounts with agreement type Microsoft Customer
            /// Agreement or Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            public static IPage<BillingSubscription> ListByBillingProfile(this IBillingSubscriptionsOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions that are billed to a billing profile. The operation
            /// is supported for billing accounts with agreement type Microsoft Customer
            /// Agreement or Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingSubscription>> ListByBillingProfileAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the subscriptions that are billed to an invoice section. The
            /// operation is supported only for billing accounts with agreement type
            /// Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The ID that uniquely identifies an invoice section.
            /// </param>
            public static IPage<BillingSubscription> ListByInvoiceSection(this IBillingSubscriptionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName)
            {
                return operations.ListByInvoiceSectionAsync(billingAccountName, billingProfileName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions that are billed to an invoice section. The
            /// operation is supported only for billing accounts with agreement type
            /// Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingProfileName'>
            /// The ID that uniquely identifies a billing profile.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The ID that uniquely identifies an invoice section.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingSubscription>> ListByInvoiceSectionAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a subscription by its ID. The operation is supported for billing
            /// accounts with agreement type Microsoft Customer Agreement and Microsoft
            /// Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            public static BillingSubscription Get(this IBillingSubscriptionsOperations operations, string billingAccountName)
            {
                return operations.GetAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a subscription by its ID. The operation is supported for billing
            /// accounts with agreement type Microsoft Customer Agreement and Microsoft
            /// Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscription> GetAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the properties of a billing subscription. Currently, cost center
            /// can be updated. The operation is supported only for billing accounts with
            /// agreement type Microsoft Customer Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the update billing subscription
            /// operation.
            /// </param>
            public static BillingSubscription Update(this IBillingSubscriptionsOperations operations, string billingAccountName, BillingSubscription parameters)
            {
                return operations.UpdateAsync(billingAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of a billing subscription. Currently, cost center
            /// can be updated. The operation is supported only for billing accounts with
            /// agreement type Microsoft Customer Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the update billing subscription
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscription> UpdateAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, BillingSubscription parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(billingAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. The new invoice
            /// section must belong to the same billing profile as the existing invoice
            /// section. This operation is supported for billing accounts with agreement
            /// type Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            public static BillingSubscription Move(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters)
            {
                return operations.MoveAsync(billingAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. The new invoice
            /// section must belong to the same billing profile as the existing invoice
            /// section. This operation is supported for billing accounts with agreement
            /// type Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscription> MoveAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.MoveWithHttpMessagesAsync(billingAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Validates if a subscription's charges can be moved to a new invoice
            /// section. This operation is supported for billing accounts with agreement
            /// type Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the validate move eligibility
            /// operation.
            /// </param>
            public static ValidateSubscriptionTransferEligibilityResult ValidateMove(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters)
            {
                return operations.ValidateMoveAsync(billingAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validates if a subscription's charges can be moved to a new invoice
            /// section. This operation is supported for billing accounts with agreement
            /// type Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the validate move eligibility
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ValidateSubscriptionTransferEligibilityResult> ValidateMoveAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateMoveWithHttpMessagesAsync(billingAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. This operation is
            /// supported for billing accounts with agreement type Microsoft Customer
            /// Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            public static BillingSubscriptionsChangeInvoiceSectionHeaders ChangeInvoiceSection(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters)
            {
                return operations.ChangeInvoiceSectionAsync(billingAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. This operation is
            /// supported for billing accounts with agreement type Microsoft Customer
            /// Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscriptionsChangeInvoiceSectionHeaders> ChangeInvoiceSectionAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ChangeInvoiceSectionWithHttpMessagesAsync(billingAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. The new invoice
            /// section must belong to the same billing profile as the existing invoice
            /// section. This operation is supported for billing accounts with agreement
            /// type Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            public static BillingSubscription BeginMove(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters)
            {
                return operations.BeginMoveAsync(billingAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. The new invoice
            /// section must belong to the same billing profile as the existing invoice
            /// section. This operation is supported for billing accounts with agreement
            /// type Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscription> BeginMoveAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginMoveWithHttpMessagesAsync(billingAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. This operation is
            /// supported for billing accounts with agreement type Microsoft Customer
            /// Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            public static BillingSubscriptionsChangeInvoiceSectionHeaders BeginChangeInvoiceSection(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters)
            {
                return operations.BeginChangeInvoiceSectionAsync(billingAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Moves a subscription's charges to a new invoice section. This operation is
            /// supported for billing accounts with agreement type Microsoft Customer
            /// Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the move subscription operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscriptionsChangeInvoiceSectionHeaders> BeginChangeInvoiceSectionAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, TransferBillingSubscriptionRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginChangeInvoiceSectionWithHttpMessagesAsync(billingAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists the subscriptions for a customer. The operation is supported only for
            /// billing accounts with agreement type Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingSubscription> ListByCustomerNext(this IBillingSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListByCustomerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions for a customer. The operation is supported only for
            /// billing accounts with agreement type Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
            public static async Task<IPage<BillingSubscription>> ListByCustomerNextAsync(this IBillingSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCustomerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the subscriptions for a billing account. The operation is supported
            /// for billing accounts with agreement type Microsoft Customer Agreement or
            /// Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingSubscription> ListByBillingAccountNext(this IBillingSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListByBillingAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions for a billing account. The operation is supported
            /// for billing accounts with agreement type Microsoft Customer Agreement or
            /// Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
            public static async Task<IPage<BillingSubscription>> ListByBillingAccountNextAsync(this IBillingSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the subscriptions that are billed to a billing profile. The operation
            /// is supported for billing accounts with agreement type Microsoft Customer
            /// Agreement or Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingSubscription> ListByBillingProfileNext(this IBillingSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListByBillingProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions that are billed to a billing profile. The operation
            /// is supported for billing accounts with agreement type Microsoft Customer
            /// Agreement or Microsoft Partner Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
            public static async Task<IPage<BillingSubscription>> ListByBillingProfileNextAsync(this IBillingSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the subscriptions that are billed to an invoice section. The
            /// operation is supported only for billing accounts with agreement type
            /// Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingSubscription> ListByInvoiceSectionNext(this IBillingSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListByInvoiceSectionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the subscriptions that are billed to an invoice section. The
            /// operation is supported only for billing accounts with agreement type
            /// Microsoft Customer Agreement.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
            public static async Task<IPage<BillingSubscription>> ListByInvoiceSectionNextAsync(this IBillingSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
