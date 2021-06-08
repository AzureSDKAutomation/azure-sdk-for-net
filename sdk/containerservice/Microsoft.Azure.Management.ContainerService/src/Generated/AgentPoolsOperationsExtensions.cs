// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AgentPoolsOperations.
    /// </summary>
    public static partial class AgentPoolsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of agent pools in the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets a list of agent pools in the specified managed cluster. The operation
            /// returns properties of each agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            public static IPage<AgentPool> List(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of agent pools in the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets a list of agent pools in the specified managed cluster. The operation
            /// returns properties of each agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AgentPool>> ListAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the agent pool.
            /// </summary>
            /// <remarks>
            /// Gets the details of the agent pool by managed cluster and resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            public static AgentPool Get(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName)
            {
                return operations.GetAsync(resourceGroupName, resourceName, agentPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the agent pool.
            /// </summary>
            /// <remarks>
            /// Gets the details of the agent pool by managed cluster and resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPool> GetAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an agent pool.
            /// </summary>
            /// <remarks>
            /// Creates or updates an agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update an agent pool operation.
            /// </param>
            public static AgentPool CreateOrUpdate(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, AgentPool parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, agentPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an agent pool.
            /// </summary>
            /// <remarks>
            /// Creates or updates an agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update an agent pool operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPool> CreateOrUpdateAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, AgentPool parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an agent pool.
            /// </summary>
            /// <remarks>
            /// Deletes the agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            public static void Delete(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName)
            {
                operations.DeleteAsync(resourceGroupName, resourceName, agentPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an agent pool.
            /// </summary>
            /// <remarks>
            /// Deletes the agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets upgrade profile for an agent pool.
            /// </summary>
            /// <remarks>
            /// Gets the details of the upgrade profile for an agent pool with a specified
            /// resource group and managed cluster name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            public static AgentPoolUpgradeProfile GetUpgradeProfile(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName)
            {
                return operations.GetUpgradeProfileAsync(resourceGroupName, resourceName, agentPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets upgrade profile for an agent pool.
            /// </summary>
            /// <remarks>
            /// Gets the details of the upgrade profile for an agent pool with a specified
            /// resource group and managed cluster name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolUpgradeProfile> GetUpgradeProfileAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUpgradeProfileWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of supported versions for the specified agent pool.
            /// </summary>
            /// <remarks>
            /// Gets a list of supported versions for the specified agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            public static AgentPoolAvailableVersions GetAvailableAgentPoolVersions(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAvailableAgentPoolVersionsAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of supported versions for the specified agent pool.
            /// </summary>
            /// <remarks>
            /// Gets a list of supported versions for the specified agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPoolAvailableVersions> GetAvailableAgentPoolVersionsAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableAgentPoolVersionsWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upgrade node image version of an agent pool to the latest.
            /// </summary>
            /// <remarks>
            /// Upgrade node image version of an agent pool to the latest.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            public static AgentPool UpgradeNodeImageVersion(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName)
            {
                return operations.UpgradeNodeImageVersionAsync(resourceGroupName, resourceName, agentPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upgrade node image version of an agent pool to the latest.
            /// </summary>
            /// <remarks>
            /// Upgrade node image version of an agent pool to the latest.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPool> UpgradeNodeImageVersionAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpgradeNodeImageVersionWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an agent pool.
            /// </summary>
            /// <remarks>
            /// Creates or updates an agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update an agent pool operation.
            /// </param>
            public static AgentPool BeginCreateOrUpdate(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, AgentPool parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, agentPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an agent pool.
            /// </summary>
            /// <remarks>
            /// Creates or updates an agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update an agent pool operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPool> BeginCreateOrUpdateAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, AgentPool parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an agent pool.
            /// </summary>
            /// <remarks>
            /// Deletes the agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            public static void BeginDelete(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName)
            {
                operations.BeginDeleteAsync(resourceGroupName, resourceName, agentPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an agent pool.
            /// </summary>
            /// <remarks>
            /// Deletes the agent pool in the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Upgrade node image version of an agent pool to the latest.
            /// </summary>
            /// <remarks>
            /// Upgrade node image version of an agent pool to the latest.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            public static AgentPool BeginUpgradeNodeImageVersion(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName)
            {
                return operations.BeginUpgradeNodeImageVersionAsync(resourceGroupName, resourceName, agentPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upgrade node image version of an agent pool to the latest.
            /// </summary>
            /// <remarks>
            /// Upgrade node image version of an agent pool to the latest.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the managed cluster resource.
            /// </param>
            /// <param name='agentPoolName'>
            /// The name of the agent pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentPool> BeginUpgradeNodeImageVersionAsync(this IAgentPoolsOperations operations, string resourceGroupName, string resourceName, string agentPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpgradeNodeImageVersionWithHttpMessagesAsync(resourceGroupName, resourceName, agentPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of agent pools in the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets a list of agent pools in the specified managed cluster. The operation
            /// returns properties of each agent pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AgentPool> ListNext(this IAgentPoolsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of agent pools in the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets a list of agent pools in the specified managed cluster. The operation
            /// returns properties of each agent pool.
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
            public static async Task<IPage<AgentPool>> ListNextAsync(this IAgentPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
