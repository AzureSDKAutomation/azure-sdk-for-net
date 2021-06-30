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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// IotRecommendationsOperations operations.
    /// </summary>
    public partial interface IIotRecommendationsOperations
    {
        /// <summary>
        /// List IoT recommendations
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query: Subscription (i.e.
        /// /subscriptions/{subscriptionId}) or IoT Hub (i.e.
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<IotRecommendationModel>>> ListWithHttpMessagesAsync(string scope, string recommendationType = default(string), string deviceId = default(string), int? limit = default(int?), string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get IoT recommendation
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query: Subscription (i.e.
        /// /subscriptions/{subscriptionId}) or IoT Hub (i.e.
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
        /// </param>
        /// <param name='iotRecommendationId'>
        /// Id of the recommendation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IotRecommendationModel>> GetWithHttpMessagesAsync(string scope, string iotRecommendationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List IoT recommendations
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<IotRecommendationModel>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
