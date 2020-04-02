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
    /// Extension methods for InvoicesOperations.
    /// </summary>
    public static partial class InvoicesOperationsExtensions
    {
            /// <summary>
            /// Lists the invoices for a billing account for a given start date and end
            /// date. The operation is supported for billing accounts with agreement type
            /// Microsoft Partner Agreement or Microsoft Customer Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='periodStartDate'>
            /// The start date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            /// <param name='periodEndDate'>
            /// The end date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            public static InvoiceListResult ListByBillingAccount(this IInvoicesOperations operations, string billingAccountName, string periodStartDate, string periodEndDate)
            {
                return operations.ListByBillingAccountAsync(billingAccountName, periodStartDate, periodEndDate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the invoices for a billing account for a given start date and end
            /// date. The operation is supported for billing accounts with agreement type
            /// Microsoft Partner Agreement or Microsoft Customer Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='periodStartDate'>
            /// The start date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            /// <param name='periodEndDate'>
            /// The end date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceListResult> ListByBillingAccountAsync(this IInvoicesOperations operations, string billingAccountName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountWithHttpMessagesAsync(billingAccountName, periodStartDate, periodEndDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the invoices for a billing profile for a given start date and end
            /// date. The operation is supported for billing accounts with agreement type
            /// Microsoft Partner Agreement or Microsoft Customer Agreement.
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
            /// <param name='periodStartDate'>
            /// The start date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            /// <param name='periodEndDate'>
            /// The end date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            public static InvoiceListResult ListByBillingProfile(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string periodStartDate, string periodEndDate)
            {
                return operations.ListByBillingProfileAsync(billingAccountName, billingProfileName, periodStartDate, periodEndDate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the invoices for a billing profile for a given start date and end
            /// date. The operation is supported for billing accounts with agreement type
            /// Microsoft Partner Agreement or Microsoft Customer Agreement.
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
            /// <param name='periodStartDate'>
            /// The start date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            /// <param name='periodEndDate'>
            /// The end date to fetch the invoices. The date should be specified in
            /// MM-DD-YYYY format.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceListResult> ListByBillingProfileAsync(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, periodStartDate, periodEndDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an invoice by ID. The operation is supported for billing accounts with
            /// agreement type Microsoft Partner Agreement or Microsoft Customer Agreement.
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
            /// <param name='invoiceName'>
            /// The ID that uniquely identifies an invoice.
            /// </param>
            public static Invoice Get(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName)
            {
                return operations.GetAsync(billingAccountName, billingProfileName, invoiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an invoice by ID. The operation is supported for billing accounts with
            /// agreement type Microsoft Partner Agreement or Microsoft Customer Agreement.
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
            /// <param name='invoiceName'>
            /// The ID that uniquely identifies an invoice.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Invoice> GetAsync(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a URL to download an invoice. The operation is supported for billing
            /// accounts with agreement type Microsoft Partner Agreement or Microsoft
            /// Customer Agreement.
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
            /// <param name='invoiceName'>
            /// The ID that uniquely identifies an invoice.
            /// </param>
            public static DownloadUrl Download(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName)
            {
                return operations.DownloadAsync(billingAccountName, billingProfileName, invoiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a URL to download an invoice. The operation is supported for billing
            /// accounts with agreement type Microsoft Partner Agreement or Microsoft
            /// Customer Agreement.
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
            /// <param name='invoiceName'>
            /// The ID that uniquely identifies an invoice.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DownloadUrl> DownloadAsync(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DownloadWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the invoices for a subscription.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// The ID that uniquely identifies a subscription.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            public static IPage<Invoice> ListByBillingSubscription(this IInvoicesOperations operations, string billingAccountName, string billingSubscriptionName, string periodStartDate, string periodEndDate)
            {
                return operations.ListByBillingSubscriptionAsync(billingAccountName, billingSubscriptionName, periodStartDate, periodEndDate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the invoices for a subscription.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// The ID that uniquely identifies a subscription.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Invoice>> ListByBillingSubscriptionAsync(this IInvoicesOperations operations, string billingAccountName, string billingSubscriptionName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingSubscriptionWithHttpMessagesAsync(billingAccountName, billingSubscriptionName, periodStartDate, periodEndDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a URL to download an invoice. The operation is supported for billing
            /// accounts with agreement type Microsoft Partner Agreement or Microsoft
            /// Customer Agreement.
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
            /// <param name='invoiceName'>
            /// The ID that uniquely identifies an invoice.
            /// </param>
            public static DownloadUrl BeginDownload(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName)
            {
                return operations.BeginDownloadAsync(billingAccountName, billingProfileName, invoiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a URL to download an invoice. The operation is supported for billing
            /// accounts with agreement type Microsoft Partner Agreement or Microsoft
            /// Customer Agreement.
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
            /// <param name='invoiceName'>
            /// The ID that uniquely identifies an invoice.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DownloadUrl> BeginDownloadAsync(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDownloadWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the invoices for a subscription.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Invoice> ListByBillingSubscriptionNext(this IInvoicesOperations operations, string nextPageLink)
            {
                return operations.ListByBillingSubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the invoices for a subscription.
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
            public static async Task<IPage<Invoice>> ListByBillingSubscriptionNextAsync(this IInvoicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
