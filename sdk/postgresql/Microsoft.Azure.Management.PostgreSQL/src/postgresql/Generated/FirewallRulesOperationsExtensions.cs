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
    /// Extension methods for FirewallRulesOperations.
    /// </summary>
    public static partial class FirewallRulesOperationsExtensions
    {
            /// <summary>
            /// Creates a new firewall rule or updates an existing firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a firewall rule.
            /// </param>
            public static FirewallRule CreateOrUpdate(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName, FirewallRule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, firewallRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new firewall rule or updates an existing firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> CreateOrUpdateAsync(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName, FirewallRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a PostgreSQL server firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            public static void Delete(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, firewallRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a PostgreSQL server firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all the firewall rules in a given server.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            public static FirewallRule Get(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName)
            {
                return operations.GetAsync(resourceGroupName, serverName, firewallRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the firewall rules in a given server.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> GetAsync(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the firewall rules in a given PostgreSQL server.
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
            public static IPage<FirewallRule> ListByServer(this IFirewallRulesOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the firewall rules in a given PostgreSQL server.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallRule>> ListByServerAsync(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new firewall rule or updates an existing firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a firewall rule.
            /// </param>
            public static FirewallRule BeginCreateOrUpdate(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName, FirewallRule parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, firewallRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new firewall rule or updates an existing firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> BeginCreateOrUpdateAsync(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName, FirewallRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a PostgreSQL server firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            public static void BeginDelete(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, firewallRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a PostgreSQL server firewall rule.
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
            /// <param name='firewallRuleName'>
            /// The name of the server firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IFirewallRulesOperations operations, string resourceGroupName, string serverName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, firewallRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all the firewall rules in a given PostgreSQL server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FirewallRule> ListByServerNext(this IFirewallRulesOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the firewall rules in a given PostgreSQL server.
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
            public static async Task<IPage<FirewallRule>> ListByServerNextAsync(this IFirewallRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
