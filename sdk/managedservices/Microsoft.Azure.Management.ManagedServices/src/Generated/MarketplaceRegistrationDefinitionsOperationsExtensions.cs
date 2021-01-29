// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MarketplaceRegistrationDefinitionsOperations.
    /// </summary>
    public static partial class MarketplaceRegistrationDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of the marketplace registration definitions for the marketplace
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='filter'>
            /// The filter query parameter. Might be used to filter marketplace
            /// registration definition by plan identifier, publisher, version etc.
            /// </param>
            public static IPage<MarketplaceRegistrationDefinition> List(this IMarketplaceRegistrationDefinitionsOperations operations, string scope, string filter = default(string))
            {
                return operations.ListAsync(scope, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of the marketplace registration definitions for the marketplace
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='filter'>
            /// The filter query parameter. Might be used to filter marketplace
            /// registration definition by plan identifier, publisher, version etc.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MarketplaceRegistrationDefinition>> ListAsync(this IMarketplaceRegistrationDefinitionsOperations operations, string scope, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the marketplace registration definition for the marketplace identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='marketplaceIdentifier'>
            /// Market place identifer. Expected Formats -
            /// {publisher}.{product[-preview]}.{planName}.{version} or
            /// {publisher}.{product[-preview]}.{planName} or
            /// {publisher}.{product[-preview]} or {publisher}).
            /// </param>
            public static MarketplaceRegistrationDefinition Get(this IMarketplaceRegistrationDefinitionsOperations operations, string scope, string marketplaceIdentifier)
            {
                return operations.GetAsync(scope, marketplaceIdentifier).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the marketplace registration definition for the marketplace identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='marketplaceIdentifier'>
            /// Market place identifer. Expected Formats -
            /// {publisher}.{product[-preview]}.{planName}.{version} or
            /// {publisher}.{product[-preview]}.{planName} or
            /// {publisher}.{product[-preview]} or {publisher}).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MarketplaceRegistrationDefinition> GetAsync(this IMarketplaceRegistrationDefinitionsOperations operations, string scope, string marketplaceIdentifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, marketplaceIdentifier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of the marketplace registration definitions for the marketplace
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<MarketplaceRegistrationDefinition> ListNext(this IMarketplaceRegistrationDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of the marketplace registration definitions for the marketplace
            /// identifier.
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
            public static async Task<IPage<MarketplaceRegistrationDefinition>> ListNextAsync(this IMarketplaceRegistrationDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}