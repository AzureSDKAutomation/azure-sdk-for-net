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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GenerateDetailedCostReportOperations.
    /// </summary>
    public static partial class GenerateDetailedCostReportOperationsExtensions
    {
            /// <summary>
            /// Generates the detailed cost report for provided date range, billing
            /// period(Only enterprise customers) or Invoice Id asynchronously at a certain
            /// scope. Call returns a 202 with header Azure-Consumption-AsyncOperation
            /// providing a link to the operation created. A call on the operation will
            /// provide the status and if the operation is completed the blob file where
            /// generated detailed cost report is being stored.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope. Also, Modern Commerce Account scopes are
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// billingAccount scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create detailed cost report operation.
            /// </param>
            public static GenerateDetailedCostReportOperationResult CreateOperation(this IGenerateDetailedCostReportOperations operations, string scope, GenerateDetailedCostReportDefinition parameters)
            {
                return operations.CreateOperationAsync(scope, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates the detailed cost report for provided date range, billing
            /// period(Only enterprise customers) or Invoice Id asynchronously at a certain
            /// scope. Call returns a 202 with header Azure-Consumption-AsyncOperation
            /// providing a link to the operation created. A call on the operation will
            /// provide the status and if the operation is completed the blob file where
            /// generated detailed cost report is being stored.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope. Also, Modern Commerce Account scopes are
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// billingAccount scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create detailed cost report operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GenerateDetailedCostReportOperationResult> CreateOperationAsync(this IGenerateDetailedCostReportOperations operations, string scope, GenerateDetailedCostReportDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOperationWithHttpMessagesAsync(scope, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates the detailed cost report for provided date range, billing
            /// period(Only enterprise customers) or Invoice Id asynchronously at a certain
            /// scope. Call returns a 202 with header Azure-Consumption-AsyncOperation
            /// providing a link to the operation created. A call on the operation will
            /// provide the status and if the operation is completed the blob file where
            /// generated detailed cost report is being stored.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope. Also, Modern Commerce Account scopes are
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// billingAccount scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create detailed cost report operation.
            /// </param>
            public static GenerateDetailedCostReportOperationResult BeginCreateOperation(this IGenerateDetailedCostReportOperations operations, string scope, GenerateDetailedCostReportDefinition parameters)
            {
                return operations.BeginCreateOperationAsync(scope, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates the detailed cost report for provided date range, billing
            /// period(Only enterprise customers) or Invoice Id asynchronously at a certain
            /// scope. Call returns a 202 with header Azure-Consumption-AsyncOperation
            /// providing a link to the operation created. A call on the operation will
            /// provide the status and if the operation is completed the blob file where
            /// generated detailed cost report is being stored.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope. Also, Modern Commerce Account scopes are
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// billingAccount scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create detailed cost report operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GenerateDetailedCostReportOperationResult> BeginCreateOperationAsync(this IGenerateDetailedCostReportOperations operations, string scope, GenerateDetailedCostReportDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOperationWithHttpMessagesAsync(scope, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
