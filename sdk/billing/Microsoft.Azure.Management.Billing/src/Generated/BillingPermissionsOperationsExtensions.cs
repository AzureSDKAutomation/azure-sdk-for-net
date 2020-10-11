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
    /// Extension methods for BillingPermissionsOperations.
    /// </summary>
    public static partial class BillingPermissionsOperationsExtensions
    {
            /// <summary>
            /// Lists the billing permissions the caller has for a customer.
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
            public static IPage<BillingPermissionsProperties> ListByCustomer(this IBillingPermissionsOperations operations, string billingAccountName, string customerName)
            {
                return operations.ListByCustomerAsync(billingAccountName, customerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has for a customer.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByCustomerAsync(this IBillingPermissionsOperations operations, string billingAccountName, string customerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCustomerWithHttpMessagesAsync(billingAccountName, customerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing account.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByBillingAccount(this IBillingPermissionsOperations operations, string billingAccountName)
            {
                return operations.ListByBillingAccountAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing account.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByBillingAccountAsync(this IBillingPermissionsOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an invoice section.
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
            public static IPage<BillingPermissionsProperties> ListByInvoiceSections(this IBillingPermissionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName)
            {
                return operations.ListByInvoiceSectionsAsync(billingAccountName, billingProfileName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an invoice section.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByInvoiceSectionsAsync(this IBillingPermissionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionsWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing profile.
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
            public static IPage<BillingPermissionsProperties> ListByBillingProfile(this IBillingPermissionsOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing profile.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByBillingProfileAsync(this IBillingPermissionsOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a department.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='departmentName'>
            /// The ID that uniquely identifies a department.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByDepartment(this IBillingPermissionsOperations operations, string billingAccountName, string departmentName)
            {
                return operations.ListByDepartmentAsync(billingAccountName, departmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a department.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='departmentName'>
            /// The ID that uniquely identifies a department.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingPermissionsProperties>> ListByDepartmentAsync(this IBillingPermissionsOperations operations, string billingAccountName, string departmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDepartmentWithHttpMessagesAsync(billingAccountName, departmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an enrollment account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The ID that uniquely identifies an enrollment account.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByEnrollmentAccount(this IBillingPermissionsOperations operations, string billingAccountName, string enrollmentAccountName)
            {
                return operations.ListByEnrollmentAccountAsync(billingAccountName, enrollmentAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an enrollment account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The ID that uniquely identifies an enrollment account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingPermissionsProperties>> ListByEnrollmentAccountAsync(this IBillingPermissionsOperations operations, string billingAccountName, string enrollmentAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEnrollmentAccountWithHttpMessagesAsync(billingAccountName, enrollmentAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has for a customer.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByCustomerNext(this IBillingPermissionsOperations operations, string nextPageLink)
            {
                return operations.ListByCustomerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has for a customer.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByCustomerNextAsync(this IBillingPermissionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCustomerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing account.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByBillingAccountNext(this IBillingPermissionsOperations operations, string nextPageLink)
            {
                return operations.ListByBillingAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing account.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByBillingAccountNextAsync(this IBillingPermissionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an invoice section.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByInvoiceSectionsNext(this IBillingPermissionsOperations operations, string nextPageLink)
            {
                return operations.ListByInvoiceSectionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an invoice section.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByInvoiceSectionsNextAsync(this IBillingPermissionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing profile.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByBillingProfileNext(this IBillingPermissionsOperations operations, string nextPageLink)
            {
                return operations.ListByBillingProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a billing profile.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByBillingProfileNextAsync(this IBillingPermissionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a department.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByDepartmentNext(this IBillingPermissionsOperations operations, string nextPageLink)
            {
                return operations.ListByDepartmentNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on a department.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByDepartmentNextAsync(this IBillingPermissionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDepartmentNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an enrollment account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingPermissionsProperties> ListByEnrollmentAccountNext(this IBillingPermissionsOperations operations, string nextPageLink)
            {
                return operations.ListByEnrollmentAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the billing permissions the caller has on an enrollment account.
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
            public static async Task<IPage<BillingPermissionsProperties>> ListByEnrollmentAccountNextAsync(this IBillingPermissionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEnrollmentAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
