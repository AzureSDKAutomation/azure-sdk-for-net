// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EndpointsOperations.
    /// </summary>
    public static partial class EndpointsOperationsExtensions
    {
            /// <summary>
            /// Update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the Update operation.
            /// </param>
            public static EndpointResult Update(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, Endpoint parameters)
            {
                return operations.UpdateAsync(resourceGroupName, profileName, endpointType, endpointName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the Update operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EndpointResult> UpdateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, Endpoint parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint.
            /// </param>
            public static EndpointResult Get(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName)
            {
                return operations.GetAsync(resourceGroupName, profileName, endpointType, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EndpointResult> GetAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be created or updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            public static EndpointResult CreateOrUpdate(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, Endpoint parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, profileName, endpointType, endpointName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be created or updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EndpointResult> CreateOrUpdateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, Endpoint parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be deleted.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be deleted.
            /// </param>
            public static DeleteOperationResult Delete(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName)
            {
                return operations.DeleteAsync(resourceGroupName, profileName, endpointType, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be deleted.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeleteOperationResult> DeleteAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
