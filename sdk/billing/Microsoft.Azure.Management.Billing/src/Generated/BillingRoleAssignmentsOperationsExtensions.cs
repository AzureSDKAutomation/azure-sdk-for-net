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
    /// Extension methods for BillingRoleAssignmentsOperations.
    /// </summary>
    public static partial class BillingRoleAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Adds a role assignment on a billing account. The operation is supported for
            /// billing accounts with agreement type Microsoft Customer Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the create billing role assignment
            /// operation.
            /// </param>
            public static BillingRoleAssignment AddByBillingAccount(this IBillingRoleAssignmentsOperations operations, string billingAccountName, BillingRoleAssignmentRequestProperties parameters)
            {
                return operations.AddByBillingAccountAsync(billingAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a role assignment on a billing account. The operation is supported for
            /// billing accounts with agreement type Microsoft Customer Agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The ID that uniquely identifies a billing account.
            /// </param>
            /// <param name='parameters'>
            /// Request parameters that are provided to the create billing role assignment
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> AddByBillingAccountAsync(this IBillingRoleAssignmentsOperations operations, string billingAccountName, BillingRoleAssignmentRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddByBillingAccountWithHttpMessagesAsync(billingAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a role assignment on an invoice section. The operation is supported
            /// for billing accounts with agreement type Microsoft Customer Agreement.
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
            /// <param name='parameters'>
            /// Request parameters that are provided to the create billing role assignment
            /// operation.
            /// </param>
            public static BillingRoleAssignment AddByInvoiceSection(this IBillingRoleAssignmentsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, BillingRoleAssignmentRequestProperties parameters)
            {
                return operations.AddByInvoiceSectionAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a role assignment on an invoice section. The operation is supported
            /// for billing accounts with agreement type Microsoft Customer Agreement.
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
            /// <param name='parameters'>
            /// Request parameters that are provided to the create billing role assignment
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> AddByInvoiceSectionAsync(this IBillingRoleAssignmentsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, BillingRoleAssignmentRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddByInvoiceSectionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a role assignment on a billing profile. The operation is supported for
            /// billing accounts with agreement type Microsoft Customer Agreement.
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
            /// <param name='parameters'>
            /// Request parameters that are provided to the create billing role assignment
            /// operation.
            /// </param>
            public static BillingRoleAssignment AddByBillingProfile(this IBillingRoleAssignmentsOperations operations, string billingAccountName, string billingProfileName, BillingRoleAssignmentRequestProperties parameters)
            {
                return operations.AddByBillingProfileAsync(billingAccountName, billingProfileName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a role assignment on a billing profile. The operation is supported for
            /// billing accounts with agreement type Microsoft Customer Agreement.
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
            /// <param name='parameters'>
            /// Request parameters that are provided to the create billing role assignment
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> AddByBillingProfileAsync(this IBillingRoleAssignmentsOperations operations, string billingAccountName, string billingProfileName, BillingRoleAssignmentRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
