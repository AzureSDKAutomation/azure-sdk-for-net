// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GenerateDetailedCostReportOperationStatusOperations operations.
    /// </summary>
    public partial interface IGenerateDetailedCostReportOperationStatusOperations
    {
        /// <summary>
        /// Get the status of the specified operation. This link is provided in
        /// the GenerateDetailedCostReport creation request response header.
        /// </summary>
        /// <param name='operationId'>
        /// The target operation Id.
        /// </param>
        /// <param name='scope'>
        /// The scope associated with usage details operations. This includes
        /// '/subscriptions/{subscriptionId}/' for subscription scope,
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for Billing Account scope,
        /// '/providers/Microsoft.Billing/departments/{departmentId}' for
        /// Department scope,
        /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope. Also, Modern Commerce Account scopes
        /// are
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for billingAccount scope,
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for billingProfile scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
        /// for invoiceSection scope, and
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
        /// specific for partners.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GenerateDetailedCostReportOperationStatuses>> GetWithHttpMessagesAsync(string operationId, string scope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the status of the specified operation. This link is provided in
        /// the GenerateDetailedCostReport creation request response header.
        /// </summary>
        /// <param name='operationId'>
        /// The target operation Id.
        /// </param>
        /// <param name='scope'>
        /// The scope associated with usage details operations. This includes
        /// '/subscriptions/{subscriptionId}/' for subscription scope,
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for Billing Account scope,
        /// '/providers/Microsoft.Billing/departments/{departmentId}' for
        /// Department scope,
        /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope. Also, Modern Commerce Account scopes
        /// are
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for billingAccount scope,
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for billingProfile scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
        /// for invoiceSection scope, and
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
        /// specific for partners.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GenerateDetailedCostReportOperationStatuses>> BeginGetWithHttpMessagesAsync(string operationId, string scope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
