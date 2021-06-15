// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DelegatedNetwork
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OrchestratorInstanceServiceOperations.
    /// </summary>
    public static partial class OrchestratorInstanceServiceOperationsExtensions
    {
            /// <summary>
            /// Gets details about the orchestrator instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            public static Orchestrator GetDetails(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetDetailsAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details about the orchestrator instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Orchestrator> GetDetailsAsync(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDetailsWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a orchestrator instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='parameters'>
            /// OrchestratorInstance type parameters
            /// </param>
            public static Orchestrator Create(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, Orchestrator parameters)
            {
                return operations.CreateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a orchestrator instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='parameters'>
            /// OrchestratorInstance type parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Orchestrator> CreateAsync(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, Orchestrator parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the Orchestrator Instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='forceDelete'>
            /// Force delete resource
            /// </param>
            public static void Delete(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, bool? forceDelete = default(bool?))
            {
                operations.DeleteAsync(resourceGroupName, resourceName, forceDelete).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Orchestrator Instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='forceDelete'>
            /// Force delete resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, bool? forceDelete = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, forceDelete, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update Orchestrator Instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='parameters'>
            /// OrchestratorInstance update parameters
            /// </param>
            public static Orchestrator Patch(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, OrchestratorResourceUpdateParameters parameters)
            {
                return operations.PatchAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update Orchestrator Instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='parameters'>
            /// OrchestratorInstance update parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Orchestrator> PatchAsync(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, OrchestratorResourceUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the orchestratorInstance resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Orchestrator> ListBySubscription(this IOrchestratorInstanceServiceOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the orchestratorInstance resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Orchestrator>> ListBySubscriptionAsync(this IOrchestratorInstanceServiceOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the OrchestratorInstances resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<Orchestrator> ListByResourceGroup(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the OrchestratorInstances resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Orchestrator>> ListByResourceGroupAsync(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a orchestrator instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='parameters'>
            /// OrchestratorInstance type parameters
            /// </param>
            public static Orchestrator BeginCreate(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, Orchestrator parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a orchestrator instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='parameters'>
            /// OrchestratorInstance type parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Orchestrator> BeginCreateAsync(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, Orchestrator parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the Orchestrator Instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='forceDelete'>
            /// Force delete resource
            /// </param>
            public static void BeginDelete(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, bool? forceDelete = default(bool?))
            {
                operations.BeginDeleteAsync(resourceGroupName, resourceName, forceDelete).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Orchestrator Instance
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource. It must be a minimum of 3 characters, and a
            /// maximum of 63.
            /// </param>
            /// <param name='forceDelete'>
            /// Force delete resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IOrchestratorInstanceServiceOperations operations, string resourceGroupName, string resourceName, bool? forceDelete = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, forceDelete, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all the orchestratorInstance resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Orchestrator> ListBySubscriptionNext(this IOrchestratorInstanceServiceOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the orchestratorInstance resources in a subscription.
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
            public static async Task<IPage<Orchestrator>> ListBySubscriptionNextAsync(this IOrchestratorInstanceServiceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the OrchestratorInstances resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Orchestrator> ListByResourceGroupNext(this IOrchestratorInstanceServiceOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the OrchestratorInstances resources in a resource group.
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
            public static async Task<IPage<Orchestrator>> ListByResourceGroupNextAsync(this IOrchestratorInstanceServiceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
