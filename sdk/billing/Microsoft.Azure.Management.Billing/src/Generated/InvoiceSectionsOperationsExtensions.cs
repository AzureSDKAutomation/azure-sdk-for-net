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
    /// Extension methods for InvoiceSectionsOperations.
    /// </summary>
    public static partial class InvoiceSectionsOperationsExtensions
    {
            /// <summary>
            /// Lists all invoice sections for a user which he has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            public static InvoiceSectionListResult ListByBillingProfileName(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileNameAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all invoice sections for a user which he has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSectionListResult> ListByBillingProfileNameAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the InvoiceSection by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static InvoiceSection Get(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName)
            {
                return operations.GetAsync(billingAccountName, billingProfileName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the InvoiceSection by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSection> GetAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create an invoice section.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            public static InvoiceSection Create(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSectionCreationRequest parameters)
            {
                return operations.CreateAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create an invoice section.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSection> CreateAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSectionCreationRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update a InvoiceSection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            public static InvoiceSection Update(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSection parameters)
            {
                return operations.UpdateAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update a InvoiceSection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSection> UpdateAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Elevates the caller's access to match their billing profile access.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static void ElevateToBillingProfile(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName)
            {
                operations.ElevateToBillingProfileAsync(billingAccountName, billingProfileName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Elevates the caller's access to match their billing profile access.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ElevateToBillingProfileAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ElevateToBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation to create an invoice section.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            public static InvoiceSection BeginCreate(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSectionCreationRequest parameters)
            {
                return operations.BeginCreateAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create an invoice section.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSection> BeginCreateAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSectionCreationRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update a InvoiceSection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            public static InvoiceSection BeginUpdate(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSection parameters)
            {
                return operations.BeginUpdateAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update a InvoiceSection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters supplied to the Create InvoiceSection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceSection> BeginUpdateAsync(this IInvoiceSectionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
