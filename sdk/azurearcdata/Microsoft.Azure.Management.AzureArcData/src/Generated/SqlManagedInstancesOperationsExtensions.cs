// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlManagedInstancesOperations.
    /// </summary>
    public static partial class SqlManagedInstancesOperationsExtensions
    {
            /// <summary>
            /// List sqlManagedInstance resources in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<SqlManagedInstance> List(this ISqlManagedInstancesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List sqlManagedInstance resources in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlManagedInstance>> ListAsync(this ISqlManagedInstancesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List sqlManagedInstance resources in the resource group
            /// </summary>
            /// <remarks>
            /// Gets all sqlManagedInstances in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            public static IPage<SqlManagedInstance> ListByResourceGroup(this ISqlManagedInstancesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List sqlManagedInstance resources in the resource group
            /// </summary>
            /// <remarks>
            /// Gets all sqlManagedInstances in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlManagedInstance>> ListByResourceGroupAsync(this ISqlManagedInstancesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// Name of SQL Managed Instance
            /// </param>
            public static SqlManagedInstance Get(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName)
            {
                return operations.GetAsync(resourceGroupName, sqlManagedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// Name of SQL Managed Instance
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlManagedInstance> GetAsync(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, sqlManagedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or replaces a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// The name of SQL Managed Instances
            /// </param>
            /// <param name='sqlManagedInstance'>
            /// The SQL Managed Instance to be created or updated.
            /// </param>
            public static SqlManagedInstance Create(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName, SqlManagedInstance sqlManagedInstance)
            {
                return operations.CreateAsync(resourceGroupName, sqlManagedInstanceName, sqlManagedInstance).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or replaces a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// The name of SQL Managed Instances
            /// </param>
            /// <param name='sqlManagedInstance'>
            /// The SQL Managed Instance to be created or updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlManagedInstance> CreateAsync(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName, SqlManagedInstance sqlManagedInstance, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, sqlManagedInstanceName, sqlManagedInstance, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// The name of Sql Managed Instances
            /// </param>
            public static void Delete(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName)
            {
                operations.DeleteAsync(resourceGroupName, sqlManagedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// The name of Sql Managed Instances
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, sqlManagedInstanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// Name of sqlManagedInstance
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static SqlManagedInstance Update(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, sqlManagedInstanceName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a SQL Managed Instance resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group
            /// </param>
            /// <param name='sqlManagedInstanceName'>
            /// Name of sqlManagedInstance
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlManagedInstance> UpdateAsync(this ISqlManagedInstancesOperations operations, string resourceGroupName, string sqlManagedInstanceName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, sqlManagedInstanceName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List sqlManagedInstance resources in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlManagedInstance> ListNext(this ISqlManagedInstancesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List sqlManagedInstance resources in the subscription
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
            public static async Task<IPage<SqlManagedInstance>> ListNextAsync(this ISqlManagedInstancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List sqlManagedInstance resources in the resource group
            /// </summary>
            /// <remarks>
            /// Gets all sqlManagedInstances in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlManagedInstance> ListByResourceGroupNext(this ISqlManagedInstancesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List sqlManagedInstance resources in the resource group
            /// </summary>
            /// <remarks>
            /// Gets all sqlManagedInstances in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlManagedInstance>> ListByResourceGroupNextAsync(this ISqlManagedInstancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
