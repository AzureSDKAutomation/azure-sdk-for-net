// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReservationRecommendationDetailsOperations.
    /// </summary>
    public static partial class ReservationRecommendationDetailsOperationsExtensions
    {
            /// <summary>
            /// Details of a reservation recommendation for what-if analysis of reserved
            /// instances.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with reservation recommendation details operations.
            /// This includes '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}',
            /// /providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// BillingAccount scope, and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope
            /// </param>
            public static ReservationRecommendationDetailsModel Get(this IReservationRecommendationDetailsOperations operations, string scope)
            {
                return operations.GetAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Details of a reservation recommendation for what-if analysis of reserved
            /// instances.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with reservation recommendation details operations.
            /// This includes '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}',
            /// /providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// BillingAccount scope, and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationRecommendationDetailsModel> GetAsync(this IReservationRecommendationDetailsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
