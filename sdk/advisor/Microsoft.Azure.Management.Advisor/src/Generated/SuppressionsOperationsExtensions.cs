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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SuppressionsOperations.
    /// </summary>
    public static partial class SuppressionsOperationsExtensions
    {
            /// <summary>
            /// Obtains the details of a suppression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The fully qualified Azure Resource Manager identifier of the resource to
            /// which the recommendation applies.
            /// </param>
            /// <param name='recommendationId'>
            /// The recommendation ID.
            /// </param>
            /// <param name='name'>
            /// The name of the suppression.
            /// </param>
            public static object Get(this ISuppressionsOperations operations, string resourceUri, string recommendationId, string name)
            {
                return operations.GetAsync(resourceUri, recommendationId, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtains the details of a suppression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The fully qualified Azure Resource Manager identifier of the resource to
            /// which the recommendation applies.
            /// </param>
            /// <param name='recommendationId'>
            /// The recommendation ID.
            /// </param>
            /// <param name='name'>
            /// The name of the suppression.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this ISuppressionsOperations operations, string resourceUri, string recommendationId, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceUri, recommendationId, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enables the snoozed or dismissed attribute of a recommendation. The snoozed
            /// or dismissed attribute is referred to as a suppression. Use this API to
            /// create or update the snoozed or dismissed status of a recommendation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The fully qualified Azure Resource Manager identifier of the resource to
            /// which the recommendation applies.
            /// </param>
            /// <param name='recommendationId'>
            /// The recommendation ID.
            /// </param>
            /// <param name='name'>
            /// The name of the suppression.
            /// </param>
            /// <param name='suppressionContract'>
            /// The snoozed or dismissed attribute; for example, the snooze duration.
            /// </param>
            public static SuppressionContract Create(this ISuppressionsOperations operations, string resourceUri, string recommendationId, string name, SuppressionContract suppressionContract)
            {
                return operations.CreateAsync(resourceUri, recommendationId, name, suppressionContract).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables the snoozed or dismissed attribute of a recommendation. The snoozed
            /// or dismissed attribute is referred to as a suppression. Use this API to
            /// create or update the snoozed or dismissed status of a recommendation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The fully qualified Azure Resource Manager identifier of the resource to
            /// which the recommendation applies.
            /// </param>
            /// <param name='recommendationId'>
            /// The recommendation ID.
            /// </param>
            /// <param name='name'>
            /// The name of the suppression.
            /// </param>
            /// <param name='suppressionContract'>
            /// The snoozed or dismissed attribute; for example, the snooze duration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SuppressionContract> CreateAsync(this ISuppressionsOperations operations, string resourceUri, string recommendationId, string name, SuppressionContract suppressionContract, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceUri, recommendationId, name, suppressionContract, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enables the activation of a snoozed or dismissed recommendation. The
            /// snoozed or dismissed attribute of a recommendation is referred to as a
            /// suppression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The fully qualified Azure Resource Manager identifier of the resource to
            /// which the recommendation applies.
            /// </param>
            /// <param name='recommendationId'>
            /// The recommendation ID.
            /// </param>
            /// <param name='name'>
            /// The name of the suppression.
            /// </param>
            public static void Delete(this ISuppressionsOperations operations, string resourceUri, string recommendationId, string name)
            {
                operations.DeleteAsync(resourceUri, recommendationId, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables the activation of a snoozed or dismissed recommendation. The
            /// snoozed or dismissed attribute of a recommendation is referred to as a
            /// suppression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The fully qualified Azure Resource Manager identifier of the resource to
            /// which the recommendation applies.
            /// </param>
            /// <param name='recommendationId'>
            /// The recommendation ID.
            /// </param>
            /// <param name='name'>
            /// The name of the suppression.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISuppressionsOperations operations, string resourceUri, string recommendationId, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceUri, recommendationId, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves the list of snoozed or dismissed suppressions for a subscription.
            /// The snoozed or dismissed attribute of a recommendation is referred to as a
            /// suppression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of suppressions per page if a paged version of this API is being
            /// used.
            /// </param>
            /// <param name='skipToken'>
            /// The page-continuation token to use with a paged version of this API.
            /// </param>
            public static IPage<SuppressionContract> List(this ISuppressionsOperations operations, int? top = default(int?), string skipToken = default(string))
            {
                return operations.ListAsync(top, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the list of snoozed or dismissed suppressions for a subscription.
            /// The snoozed or dismissed attribute of a recommendation is referred to as a
            /// suppression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of suppressions per page if a paged version of this API is being
            /// used.
            /// </param>
            /// <param name='skipToken'>
            /// The page-continuation token to use with a paged version of this API.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SuppressionContract>> ListAsync(this ISuppressionsOperations operations, int? top = default(int?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves the list of snoozed or dismissed suppressions for a subscription.
            /// The snoozed or dismissed attribute of a recommendation is referred to as a
            /// suppression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SuppressionContract> ListNext(this ISuppressionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the list of snoozed or dismissed suppressions for a subscription.
            /// The snoozed or dismissed attribute of a recommendation is referred to as a
            /// suppression.
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
            public static async Task<IPage<SuppressionContract>> ListNextAsync(this ISuppressionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
