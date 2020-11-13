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
    /// Extension methods for IntegrationRuntimeCredentialsOperations.
    /// </summary>
    public static partial class IntegrationRuntimeCredentialsOperationsExtensions
    {
            /// <summary>
            /// Sync integration runtime credentials
            /// </summary>
            /// <remarks>
            /// Force the integration runtime to synchronize credentials across integration
            /// runtime nodes, and this will override the credentials across all worker
            /// nodes with those available on the dispatcher node. If you already have the
            /// latest credential backup file, you should manually import it (preferred) on
            /// any self-hosted integration runtime node than using this API directly.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            public static void Sync(this IIntegrationRuntimeCredentialsOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName)
            {
                operations.SyncAsync(resourceGroupName, workspaceName, integrationRuntimeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sync integration runtime credentials
            /// </summary>
            /// <remarks>
            /// Force the integration runtime to synchronize credentials across integration
            /// runtime nodes, and this will override the credentials across all worker
            /// nodes with those available on the dispatcher node. If you already have the
            /// latest credential backup file, you should manually import it (preferred) on
            /// any self-hosted integration runtime node than using this API directly.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SyncAsync(this IIntegrationRuntimeCredentialsOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SyncWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
