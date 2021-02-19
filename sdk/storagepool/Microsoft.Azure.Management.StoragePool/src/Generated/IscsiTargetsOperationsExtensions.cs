// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StoragePool
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IscsiTargetsOperations.
    /// </summary>
    public static partial class IscsiTargetsOperationsExtensions
    {
            /// <summary>
            /// Get iSCSI Targets in a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            public static IPage<IscsiTarget> ListByDiskPool(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName)
            {
                return operations.ListByDiskPoolAsync(resourceGroupName, diskPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get iSCSI Targets in a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IscsiTarget>> ListByDiskPoolAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDiskPoolWithHttpMessagesAsync(resourceGroupName, diskPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            /// <param name='targetIqn'>
            /// iSCSI target IQN (iSCSI Qualified Name); example:
            /// "iqn.2005-03.org.iscsi:server".
            /// </param>
            public static IscsiTarget CreateOrUpdate(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupCreate> tpgs, string targetIqn = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs, targetIqn).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            /// <param name='targetIqn'>
            /// iSCSI target IQN (iSCSI Qualified Name); example:
            /// "iqn.2005-03.org.iscsi:server".
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IscsiTarget> CreateOrUpdateAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupCreate> tpgs, string targetIqn = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs, targetIqn, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            public static IscsiTarget Update(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupUpdate> tpgs)
            {
                return operations.UpdateAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IscsiTarget> UpdateAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupUpdate> tpgs, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            public static void Delete(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName)
            {
                operations.DeleteAsync(resourceGroupName, diskPoolName, iscsiTargetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, diskPoolName, iscsiTargetName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            public static IscsiTarget Get(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName)
            {
                return operations.GetAsync(resourceGroupName, diskPoolName, iscsiTargetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IscsiTarget> GetAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, diskPoolName, iscsiTargetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            /// <param name='targetIqn'>
            /// iSCSI target IQN (iSCSI Qualified Name); example:
            /// "iqn.2005-03.org.iscsi:server".
            /// </param>
            public static IscsiTarget BeginCreateOrUpdate(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupCreate> tpgs, string targetIqn = default(string))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs, targetIqn).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            /// <param name='targetIqn'>
            /// iSCSI target IQN (iSCSI Qualified Name); example:
            /// "iqn.2005-03.org.iscsi:server".
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IscsiTarget> BeginCreateOrUpdateAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupCreate> tpgs, string targetIqn = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs, targetIqn, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            public static IscsiTarget BeginUpdate(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupUpdate> tpgs)
            {
                return operations.BeginUpdateAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='tpgs'>
            /// List of iSCSI target portal groups. Can have 1 portal group at most.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IscsiTarget> BeginUpdateAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, IList<TargetPortalGroupUpdate> tpgs, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, diskPoolName, iscsiTargetName, tpgs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            public static void BeginDelete(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName)
            {
                operations.BeginDeleteAsync(resourceGroupName, diskPoolName, iscsiTargetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an iSCSI target.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='diskPoolName'>
            /// The name of the Disk pool.
            /// </param>
            /// <param name='iscsiTargetName'>
            /// The name of the iSCSI target.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IIscsiTargetsOperations operations, string resourceGroupName, string diskPoolName, string iscsiTargetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, diskPoolName, iscsiTargetName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get iSCSI Targets in a Disk pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IscsiTarget> ListByDiskPoolNext(this IIscsiTargetsOperations operations, string nextPageLink)
            {
                return operations.ListByDiskPoolNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get iSCSI Targets in a Disk pool.
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
            public static async Task<IPage<IscsiTarget>> ListByDiskPoolNextAsync(this IIscsiTargetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDiskPoolNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
