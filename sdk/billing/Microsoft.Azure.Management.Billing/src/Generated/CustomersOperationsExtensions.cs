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
    /// Extension methods for CustomersOperations.
    /// </summary>
    public static partial class CustomersOperationsExtensions
    {
            /// <summary>
            /// Lists the customers that are billed to a billing profile. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
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
            /// <param name='filter'>
            /// May be used to filter the list of customers.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            public static IPage<Customer> ListByBillingProfile(this ICustomersOperations operations, string billingAccountName, string billingProfileName, string filter = default(string), string skiptoken = default(string))
            {
                return operations.ListByBillingProfileAsync(billingAccountName, billingProfileName, filter, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the customers that are billed to a billing profile. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
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
            /// <param name='filter'>
            /// May be used to filter the list of customers.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Customer>> ListByBillingProfileAsync(this ICustomersOperations operations, string billingAccountName, string billingProfileName, string filter = default(string), string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, filter, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the customers that are billed to a billing account. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter the list of customers.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            public static IPage<Customer> ListByBillingAccount(this ICustomersOperations operations, string billingAccountName, string filter = default(string), string skiptoken = default(string))
            {
                return operations.ListByBillingAccountAsync(billingAccountName, filter, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the customers that are billed to a billing account. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter the list of customers.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Customer>> ListByBillingAccountAsync(this ICustomersOperations operations, string billingAccountName, string filter = default(string), string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountWithHttpMessagesAsync(billingAccountName, filter, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a customer by its ID. The operation is supported only for billing
            /// accounts with agreement type Microsoft Partner Agreement.
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
            /// <param name='expand'>
            /// May be used to expand enabledAzurePlans and resellers
            /// </param>
            public static Customer Get(this ICustomersOperations operations, string billingAccountName, string customerName, string expand = default(string))
            {
                return operations.GetAsync(billingAccountName, customerName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a customer by its ID. The operation is supported only for billing
            /// accounts with agreement type Microsoft Partner Agreement.
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
            /// <param name='expand'>
            /// May be used to expand enabledAzurePlans and resellers
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Customer> GetAsync(this ICustomersOperations operations, string billingAccountName, string customerName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, customerName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the customers that are billed to a billing profile. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Customer> ListByBillingProfileNext(this ICustomersOperations operations, string nextPageLink)
            {
                return operations.ListByBillingProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the customers that are billed to a billing profile. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
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
            public static async Task<IPage<Customer>> ListByBillingProfileNextAsync(this ICustomersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the customers that are billed to a billing account. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Customer> ListByBillingAccountNext(this ICustomersOperations operations, string nextPageLink)
            {
                return operations.ListByBillingAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the customers that are billed to a billing account. The operation is
            /// supported only for billing accounts with agreement type Microsoft Partner
            /// Agreement.
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
            public static async Task<IPage<Customer>> ListByBillingAccountNextAsync(this ICustomersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
