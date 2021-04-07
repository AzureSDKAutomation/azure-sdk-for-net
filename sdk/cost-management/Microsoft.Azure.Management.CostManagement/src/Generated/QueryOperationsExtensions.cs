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
    /// Extension methods for QueryOperations.
    /// </summary>
    public static partial class QueryOperationsExtensions
    {
            /// <summary>
            /// Query the usage data for scope defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with query and export operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId} for
            /// Management Group scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Query Config operation.
            /// </param>
            public static QueryResult Usage(this IQueryOperations operations, string scope, QueryDefinition parameters)
            {
                return operations.UsageAsync(scope, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query the usage data for scope defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with query and export operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId} for
            /// Management Group scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Query Config operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueryResult> UsageAsync(this IQueryOperations operations, string scope, QueryDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UsageWithHttpMessagesAsync(scope, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Query the usage data for external cloud provider type defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='externalCloudProviderType'>
            /// The external cloud provider type associated with dimension/query
            /// operations. This includes 'externalSubscriptions' for linked account and
            /// 'externalBillingAccounts' for consolidated account. Possible values
            /// include: 'externalSubscriptions', 'externalBillingAccounts'
            /// </param>
            /// <param name='externalCloudProviderId'>
            /// This can be '{externalSubscriptionId}' for linked account or
            /// '{externalBillingAccountId}' for consolidated account used with
            /// dimension/query operations.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Query Config operation.
            /// </param>
            public static QueryResult UsageByExternalCloudProviderType(this IQueryOperations operations, string externalCloudProviderType, string externalCloudProviderId, QueryDefinition parameters)
            {
                return operations.UsageByExternalCloudProviderTypeAsync(externalCloudProviderType, externalCloudProviderId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query the usage data for external cloud provider type defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='externalCloudProviderType'>
            /// The external cloud provider type associated with dimension/query
            /// operations. This includes 'externalSubscriptions' for linked account and
            /// 'externalBillingAccounts' for consolidated account. Possible values
            /// include: 'externalSubscriptions', 'externalBillingAccounts'
            /// </param>
            /// <param name='externalCloudProviderId'>
            /// This can be '{externalSubscriptionId}' for linked account or
            /// '{externalBillingAccountId}' for consolidated account used with
            /// dimension/query operations.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Query Config operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueryResult> UsageByExternalCloudProviderTypeAsync(this IQueryOperations operations, string externalCloudProviderType, string externalCloudProviderId, QueryDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UsageByExternalCloudProviderTypeWithHttpMessagesAsync(externalCloudProviderType, externalCloudProviderId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
