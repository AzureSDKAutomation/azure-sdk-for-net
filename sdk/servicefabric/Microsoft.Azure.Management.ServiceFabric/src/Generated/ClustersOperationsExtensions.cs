// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ClustersOperations.
    /// </summary>
    public static partial class ClustersOperationsExtensions
    {
            /// <summary>
            /// Gets a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric cluster resource created or in the process of being
            /// created in the specified resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            public static Cluster Get(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.GetAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric cluster resource created or in the process of being
            /// created in the specified resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> GetAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric cluster resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The cluster resource.
            /// </param>
            public static Cluster CreateOrUpdate(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric cluster resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> CreateOrUpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the configuration of a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a Service Fabric cluster resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration.
            /// </param>
            public static Cluster Update(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the configuration of a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a Service Fabric cluster resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> UpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric cluster resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            public static void Delete(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric cluster resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of Service Fabric cluster resources created in the specified
            /// resource group.
            /// </summary>
            /// <remarks>
            /// Gets all Service Fabric cluster resources created or in the process of
            /// being created in the resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static ClusterListResult ListByResourceGroup(this IClustersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Service Fabric cluster resources created in the specified
            /// resource group.
            /// </summary>
            /// <remarks>
            /// Gets all Service Fabric cluster resources created or in the process of
            /// being created in the resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterListResult> ListByResourceGroupAsync(this IClustersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of Service Fabric cluster resources created in the specified
            /// subscription.
            /// </summary>
            /// <remarks>
            /// Gets all Service Fabric cluster resources created or in the process of
            /// being created in the subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ClusterListResult List(this IClustersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Service Fabric cluster resources created in the specified
            /// subscription.
            /// </summary>
            /// <remarks>
            /// Gets all Service Fabric cluster resources created or in the process of
            /// being created in the subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClusterListResult> ListAsync(this IClustersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to get the minimum and maximum upgradable version from the
            /// current cluster version, or the required path to get to the an specific
            /// target version.
            /// </summary>
            /// <remarks>
            /// If a target is not provided, it will get the minimum and maximum versions
            /// available from the current cluster version. If a target is given, it will
            /// provide the required path to get from the current cluster version to the
            /// target version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='targetVersion'>
            /// The target code version.
            /// </param>
            public static UpgradableVersionPathResult ListUpgradableVersions(this IClustersOperations operations, string resourceGroupName, string clusterName, string targetVersion)
            {
                return operations.ListUpgradableVersionsAsync(resourceGroupName, clusterName, targetVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to get the minimum and maximum upgradable version from the
            /// current cluster version, or the required path to get to the an specific
            /// target version.
            /// </summary>
            /// <remarks>
            /// If a target is not provided, it will get the minimum and maximum versions
            /// available from the current cluster version. If a target is given, it will
            /// provide the required path to get from the current cluster version to the
            /// target version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='targetVersion'>
            /// The target code version.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UpgradableVersionPathResult> ListUpgradableVersionsAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, string targetVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUpgradableVersionsWithHttpMessagesAsync(resourceGroupName, clusterName, targetVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric cluster resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The cluster resource.
            /// </param>
            public static Cluster BeginCreateOrUpdate(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric cluster resource with the specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> BeginCreateOrUpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the configuration of a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a Service Fabric cluster resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration.
            /// </param>
            public static Cluster BeginUpdate(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the configuration of a Service Fabric cluster resource.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a Service Fabric cluster resource with the
            /// specified name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> BeginUpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
