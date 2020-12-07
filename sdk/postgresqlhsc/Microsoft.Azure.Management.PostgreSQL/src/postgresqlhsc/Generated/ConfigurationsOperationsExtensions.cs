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
    /// Extension methods for ConfigurationsOperations.
    /// </summary>
    public static partial class ConfigurationsOperationsExtensions
    {
            /// <summary>
            /// List all the configurations of a server in server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IPage<ServerConfiguration> ListByServer(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the configurations of a server in server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServerConfiguration>> ListByServerAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the configurations of a server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            public static IPage<ServerGroupConfiguration> ListByServerGroup(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName)
            {
                return operations.ListByServerGroupAsync(resourceGroupName, serverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the configurations of a server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServerGroupConfiguration>> ListByServerGroupAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerGroupWithHttpMessagesAsync(resourceGroupName, serverGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates configuration of server role groups in a server group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server group configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server group configuration.
            /// </param>
            public static ServerGroupConfiguration Update(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string configurationName, ServerGroupConfiguration parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serverGroupName, configurationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates configuration of server role groups in a server group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server group configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server group configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerGroupConfiguration> UpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string configurationName, ServerGroupConfiguration parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverGroupName, configurationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about single server group configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server group configuration.
            /// </param>
            public static ServerGroupConfiguration Get(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string configurationName)
            {
                return operations.GetAsync(resourceGroupName, serverGroupName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about single server group configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server group configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerGroupConfiguration> GetAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverGroupName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates configuration of server role groups in a server group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server group configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server group configuration.
            /// </param>
            public static ServerGroupConfiguration BeginUpdate(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string configurationName, ServerGroupConfiguration parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serverGroupName, configurationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates configuration of server role groups in a server group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverGroupName'>
            /// The name of the server group.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server group configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server group configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerGroupConfiguration> BeginUpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverGroupName, string configurationName, ServerGroupConfiguration parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverGroupName, configurationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the configurations of a server in server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServerConfiguration> ListByServerNext(this IConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the configurations of a server in server group.
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
            public static async Task<IPage<ServerConfiguration>> ListByServerNextAsync(this IConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the configurations of a server group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServerGroupConfiguration> ListByServerGroupNext(this IConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListByServerGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the configurations of a server group.
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
            public static async Task<IPage<ServerGroupConfiguration>> ListByServerGroupNextAsync(this IConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
