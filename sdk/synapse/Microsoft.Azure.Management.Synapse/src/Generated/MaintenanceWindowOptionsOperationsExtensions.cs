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
    /// Extension methods for MaintenanceWindowOptionsOperations.
    /// </summary>
    public static partial class MaintenanceWindowOptionsOperationsExtensions
    {
            /// <summary>
            /// Gets the maintenance window options for the given maintenance window.
            /// </summary>
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
            /// <param name='maintenanceWindowOptionsName'>
            /// Maintenance window options name.
            /// </param>
            public static MaintenanceWindowOptions Get(this IMaintenanceWindowOptionsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string maintenanceWindowOptionsName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, maintenanceWindowOptionsName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the maintenance window options for the given maintenance window.
            /// </summary>
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
            /// <param name='maintenanceWindowOptionsName'>
            /// Maintenance window options name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MaintenanceWindowOptions> GetAsync(this IMaintenanceWindowOptionsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string maintenanceWindowOptionsName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, maintenanceWindowOptionsName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
