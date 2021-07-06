// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IotRecommendationsOperations.
    /// </summary>
    public static partial class IotRecommendationsOperationsExtensions
    {
            /// <summary>
            /// List IoT recommendations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='recommendationType'>
            /// Filter by recommendation type
            /// </param>
            /// <param name='deviceId'>
            /// Filter by device id
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            public static IPage<IotRecommendationModel> List(this IIotRecommendationsOperations operations, string scope, string recommendationType = default(string), string deviceId = default(string), int? limit = default(int?), string skipToken = default(string))
            {
                return operations.ListAsync(scope, recommendationType, deviceId, limit, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List IoT recommendations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='recommendationType'>
            /// Filter by recommendation type
            /// </param>
            /// <param name='deviceId'>
            /// Filter by device id
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotRecommendationModel>> ListAsync(this IIotRecommendationsOperations operations, string scope, string recommendationType = default(string), string deviceId = default(string), int? limit = default(int?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, recommendationType, deviceId, limit, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get IoT recommendation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='iotRecommendationId'>
            /// Id of the recommendation
            /// </param>
            public static IotRecommendationModel Get(this IIotRecommendationsOperations operations, string scope, string iotRecommendationId)
            {
                return operations.GetAsync(scope, iotRecommendationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get IoT recommendation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='iotRecommendationId'>
            /// Id of the recommendation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotRecommendationModel> GetAsync(this IIotRecommendationsOperations operations, string scope, string iotRecommendationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, iotRecommendationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List IoT recommendations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotRecommendationModel> ListNext(this IIotRecommendationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List IoT recommendations
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
            public static async Task<IPage<IotRecommendationModel>> ListNextAsync(this IIotRecommendationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
