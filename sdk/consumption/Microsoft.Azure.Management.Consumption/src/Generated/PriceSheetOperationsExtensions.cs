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
    /// Extension methods for PriceSheetOperations.
    /// </summary>
    public static partial class PriceSheetOperationsExtensions
    {
            /// <summary>
            /// Gets the price sheet for a subscription. Price sheet is available via this
            /// API only for May 1, 2014 or later.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the properties/meterDetails within a price sheet. By
            /// default, these fields are not included when returning price sheet.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the top N results.
            /// </param>
            public static PriceSheetResult Get(this IPriceSheetOperations operations, string expand = default(string), string skiptoken = default(string), int? top = default(int?))
            {
                return operations.GetAsync(expand, skiptoken, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the price sheet for a subscription. Price sheet is available via this
            /// API only for May 1, 2014 or later.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the properties/meterDetails within a price sheet. By
            /// default, these fields are not included when returning price sheet.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the top N results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PriceSheetResult> GetAsync(this IPriceSheetOperations operations, string expand = default(string), string skiptoken = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, skiptoken, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the price sheet for a scope by subscriptionId and billing period. Price
            /// sheet is available via this API only for May 1, 2014 or later.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingPeriodName'>
            /// Billing Period Name.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the properties/meterDetails within a price sheet. By
            /// default, these fields are not included when returning price sheet.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the top N results.
            /// </param>
            public static PriceSheetResult GetByBillingPeriod(this IPriceSheetOperations operations, string billingPeriodName, string expand = default(string), string skiptoken = default(string), int? top = default(int?))
            {
                return operations.GetByBillingPeriodAsync(billingPeriodName, expand, skiptoken, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the price sheet for a scope by subscriptionId and billing period. Price
            /// sheet is available via this API only for May 1, 2014 or later.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingPeriodName'>
            /// Billing Period Name.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the properties/meterDetails within a price sheet. By
            /// default, these fields are not included when returning price sheet.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the top N results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PriceSheetResult> GetByBillingPeriodAsync(this IPriceSheetOperations operations, string billingPeriodName, string expand = default(string), string skiptoken = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingPeriodWithHttpMessagesAsync(billingPeriodName, expand, skiptoken, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
