// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServerParametersOperations.
    /// </summary>
    public static partial class ServerParametersOperationsExtensions
    {
            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='value'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            public static ConfigurationListResult ListUpdateConfigurations(this IServerParametersOperations operations, string resourceGroupName, string serverName, ConfigurationListResult value)
            {
                return operations.ListUpdateConfigurationsAsync(resourceGroupName, serverName, value).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='value'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationListResult> ListUpdateConfigurationsAsync(this IServerParametersOperations operations, string resourceGroupName, string serverName, ConfigurationListResult value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUpdateConfigurationsWithHttpMessagesAsync(resourceGroupName, serverName, value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='value'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            public static ConfigurationListResult BeginListUpdateConfigurations(this IServerParametersOperations operations, string resourceGroupName, string serverName, ConfigurationListResult value)
            {
                return operations.BeginListUpdateConfigurationsAsync(resourceGroupName, serverName, value).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='value'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationListResult> BeginListUpdateConfigurationsAsync(this IServerParametersOperations operations, string resourceGroupName, string serverName, ConfigurationListResult value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListUpdateConfigurationsWithHttpMessagesAsync(resourceGroupName, serverName, value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
