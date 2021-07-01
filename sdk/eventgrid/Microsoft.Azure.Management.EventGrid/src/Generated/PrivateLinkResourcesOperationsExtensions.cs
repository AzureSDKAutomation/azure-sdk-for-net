// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateLinkResourcesOperations.
    /// </summary>
    public static partial class PrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// Get a private link resource.
            /// </summary>
            /// <remarks>
            /// Get properties of a private link resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\',
            /// \'domains\', or \'partnerNamespaces\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name, domain
            /// name, or partner namespace name).
            /// </param>
            /// <param name='privateLinkResourceName'>
            /// The name of private link resource.
            /// </param>
            public static PrivateLinkResource Get(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string parentType, string parentName, string privateLinkResourceName)
            {
                return operations.GetAsync(resourceGroupName, parentType, parentName, privateLinkResourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a private link resource.
            /// </summary>
            /// <remarks>
            /// Get properties of a private link resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\',
            /// \'domains\', or \'partnerNamespaces\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name, domain
            /// name, or partner namespace name).
            /// </param>
            /// <param name='privateLinkResourceName'>
            /// The name of private link resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkResource> GetAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string parentType, string parentName, string privateLinkResourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, parentType, parentName, privateLinkResourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List private link resources under specific topic, domain, or partner
            /// namespace.
            /// </summary>
            /// <remarks>
            /// List all the private link resources under a topic, domain, or partner
            /// namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\',
            /// \'domains\', or \'partnerNamespaces\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name, domain
            /// name, or partner namespace name).
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            public static IPage<PrivateLinkResource> ListByResource(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string parentType, string parentName, string filter = default(string), int? top = default(int?))
            {
                return operations.ListByResourceAsync(resourceGroupName, parentType, parentName, filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private link resources under specific topic, domain, or partner
            /// namespace.
            /// </summary>
            /// <remarks>
            /// List all the private link resources under a topic, domain, or partner
            /// namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='parentType'>
            /// The type of the parent resource. This can be either \'topics\',
            /// \'domains\', or \'partnerNamespaces\'.
            /// </param>
            /// <param name='parentName'>
            /// The name of the parent resource (namely, either, the topic name, domain
            /// name, or partner namespace name).
            /// </param>
            /// <param name='filter'>
            /// The query used to filter the search results using OData syntax. Filtering
            /// is permitted on the 'name' property only and with limited number of OData
            /// operations. These operations are: the 'contains' function as well as the
            /// following logical operations: not, and, or, eq (for equal), and ne (for not
            /// equal). No arithmetic operations are supported. The following is a valid
            /// filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'.
            /// The following is not a valid filter example: $filter=location eq 'westus'.
            /// </param>
            /// <param name='top'>
            /// The number of results to return per page for the list operation. Valid
            /// range for top parameter is 1 to 100. If not specified, the default number
            /// of results to be returned is 20 items per page.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkResource>> ListByResourceAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string parentType, string parentName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceWithHttpMessagesAsync(resourceGroupName, parentType, parentName, filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List private link resources under specific topic, domain, or partner
            /// namespace.
            /// </summary>
            /// <remarks>
            /// List all the private link resources under a topic, domain, or partner
            /// namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkResource> ListByResourceNext(this IPrivateLinkResourcesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private link resources under specific topic, domain, or partner
            /// namespace.
            /// </summary>
            /// <remarks>
            /// List all the private link resources under a topic, domain, or partner
            /// namespace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkResource>> ListByResourceNextAsync(this IPrivateLinkResourcesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
