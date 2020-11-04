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
    /// Extension methods for IntegrationRuntimeMonitoringDataOperations.
    /// </summary>
    public static partial class IntegrationRuntimeMonitoringDataOperationsExtensions
    {
            /// <summary>
            /// Get integration runtime monitoring data
            /// </summary>
            /// <remarks>
            /// Get monitoring data for an integration runtime
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
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            public static IntegrationRuntimeMonitoringData List(this IIntegrationRuntimeMonitoringDataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName, integrationRuntimeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get integration runtime monitoring data
            /// </summary>
            /// <remarks>
            /// Get monitoring data for an integration runtime
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
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationRuntimeMonitoringData> ListAsync(this IIntegrationRuntimeMonitoringDataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
