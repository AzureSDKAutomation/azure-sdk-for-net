// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolMaintenanceWindowsOperations.
    /// </summary>
    public static partial class SqlPoolMaintenanceWindowsOperationsExtensions
    {
            /// <summary>
            /// Get a SQL pool's Maintenance Windows.
            /// </summary>
            /// <remarks>
            /// Get a SQL pool's Maintenance Windows.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='maintenanceWindowName'>
            /// Maintenance window name.
            /// </param>
            public static MaintenanceWindows Get(this ISqlPoolMaintenanceWindowsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string maintenanceWindowName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, maintenanceWindowName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a SQL pool's Maintenance Windows.
            /// </summary>
            /// <remarks>
            /// Get a SQL pool's Maintenance Windows.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='maintenanceWindowName'>
            /// Maintenance window name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MaintenanceWindows> GetAsync(this ISqlPoolMaintenanceWindowsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string maintenanceWindowName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, maintenanceWindowName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Sql pool's maintenance windows settings.
            /// </summary>
            /// <remarks>
            /// Creates or updates a Sql pool's maintenance windows settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='maintenanceWindowName'>
            /// Maintenance window name.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating Maintenance Windows
            /// settings
            /// </param>
            public static void CreateOrUpdate(this ISqlPoolMaintenanceWindowsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string maintenanceWindowName, MaintenanceWindows parameters)
            {
                operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, maintenanceWindowName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Sql pool's maintenance windows settings.
            /// </summary>
            /// <remarks>
            /// Creates or updates a Sql pool's maintenance windows settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='maintenanceWindowName'>
            /// Maintenance window name.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating Maintenance Windows
            /// settings
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateOrUpdateAsync(this ISqlPoolMaintenanceWindowsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string maintenanceWindowName, MaintenanceWindows parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, maintenanceWindowName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
