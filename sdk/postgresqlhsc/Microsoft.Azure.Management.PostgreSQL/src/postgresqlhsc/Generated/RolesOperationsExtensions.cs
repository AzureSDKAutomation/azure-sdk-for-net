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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RolesOperations.
    /// </summary>
    public static partial class RolesOperationsExtensions
    {
            /// <summary>
            /// Creates a new role or updates an existing role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a role.
            /// </param>
            public static Role Create(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName, Role parameters)
            {
                return operations.CreateAsync(resourceGroupName, serverGroupName, roleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new role or updates an existing role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a role.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Role> CreateAsync(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName, Role parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, serverGroupName, roleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a server group role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            public static void Delete(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName)
            {
                operations.DeleteAsync(resourceGroupName, serverGroupName, roleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a server group role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverGroupName, roleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all the roles in a given server group.
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
            public static IEnumerable<Role> ListByServerGroup(this IRolesOperations operations, string resourceGroupName, string serverGroupName)
            {
                return operations.ListByServerGroupAsync(resourceGroupName, serverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the roles in a given server group.
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
            public static async Task<IEnumerable<Role>> ListByServerGroupAsync(this IRolesOperations operations, string resourceGroupName, string serverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerGroupWithHttpMessagesAsync(resourceGroupName, serverGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new role or updates an existing role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a role.
            /// </param>
            public static Role BeginCreate(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName, Role parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, serverGroupName, roleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new role or updates an existing role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a role.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Role> BeginCreateAsync(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName, Role parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, serverGroupName, roleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a server group role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            public static void BeginDelete(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverGroupName, roleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a server group role.
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
            /// <param name='roleName'>
            /// The name of the server group role name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IRolesOperations operations, string resourceGroupName, string serverGroupName, string roleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverGroupName, roleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
