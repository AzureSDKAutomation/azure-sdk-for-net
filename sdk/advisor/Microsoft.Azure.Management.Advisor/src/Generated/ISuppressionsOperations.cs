// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Advisor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SuppressionsOperations operations.
    /// </summary>
    public partial interface ISuppressionsOperations
    {
        /// <summary>
        /// Obtains the details of a suppression.
        /// </summary>
        /// <param name='resourceUri'>
        /// The fully qualified Azure Resource Manager identifier of the
        /// resource to which the recommendation applies.
        /// </param>
        /// <param name='recommendationId'>
        /// The recommendation ID.
        /// </param>
        /// <param name='name'>
        /// The name of the suppression.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ArmErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object>> GetWithHttpMessagesAsync(string resourceUri, string recommendationId, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables the snoozed or dismissed attribute of a recommendation. The
        /// snoozed or dismissed attribute is referred to as a suppression. Use
        /// this API to create or update the snoozed or dismissed status of a
        /// recommendation.
        /// </summary>
        /// <param name='resourceUri'>
        /// The fully qualified Azure Resource Manager identifier of the
        /// resource to which the recommendation applies.
        /// </param>
        /// <param name='recommendationId'>
        /// The recommendation ID.
        /// </param>
        /// <param name='name'>
        /// The name of the suppression.
        /// </param>
        /// <param name='suppressionContract'>
        /// The snoozed or dismissed attribute; for example, the snooze
        /// duration.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ArmErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object>> CreateWithHttpMessagesAsync(string resourceUri, string recommendationId, string name, SuppressionContract suppressionContract, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables the activation of a snoozed or dismissed recommendation.
        /// The snoozed or dismissed attribute of a recommendation is referred
        /// to as a suppression.
        /// </summary>
        /// <param name='resourceUri'>
        /// The fully qualified Azure Resource Manager identifier of the
        /// resource to which the recommendation applies.
        /// </param>
        /// <param name='recommendationId'>
        /// The recommendation ID.
        /// </param>
        /// <param name='name'>
        /// The name of the suppression.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ArmErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceUri, string recommendationId, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the list of snoozed or dismissed suppressions for a
        /// subscription. The snoozed or dismissed attribute of a
        /// recommendation is referred to as a suppression.
        /// </summary>
        /// <param name='top'>
        /// The number of suppressions per page if a paged version of this API
        /// is being used.
        /// </param>
        /// <param name='skipToken'>
        /// The page-continuation token to use with a paged version of this
        /// API.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ArmErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SuppressionContract>>> ListWithHttpMessagesAsync(int? top = default(int?), string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the list of snoozed or dismissed suppressions for a
        /// subscription. The snoozed or dismissed attribute of a
        /// recommendation is referred to as a suppression.
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
        /// <exception cref="ArmErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SuppressionContract>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
