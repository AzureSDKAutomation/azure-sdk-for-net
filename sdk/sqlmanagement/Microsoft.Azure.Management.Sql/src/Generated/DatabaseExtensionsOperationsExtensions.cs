// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DatabaseExtensionsOperations.
    /// </summary>
    public static partial class DatabaseExtensionsOperationsExtensions
    {
            /// <summary>
            /// Gets a database extension. This will return resource not found as it is not
            /// supported.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='extensionName'>
            /// </param>
            public static void Get(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName, string extensionName)
            {
                operations.GetAsync(resourceGroupName, serverName, databaseName, extensionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a database extension. This will return resource not found as it is not
            /// supported.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='extensionName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAsync(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName, string extensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, extensionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Perform a database extension operation, like polybase import
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='extensionName'>
            /// </param>
            /// <param name='parameters'>
            /// The database import request parameters.
            /// </param>
            public static ImportExportExtensionsOperationResult CreateOrUpdate(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName, string extensionName, DatabaseExtensions parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, extensionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Perform a database extension operation, like polybase import
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='extensionName'>
            /// </param>
            /// <param name='parameters'>
            /// The database import request parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportExtensionsOperationResult> CreateOrUpdateAsync(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName, string extensionName, DatabaseExtensions parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, extensionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List database extension. This will return an empty list as it is not
            /// supported.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static IPage<ImportExportExtensionsOperationResult> ListByDatabase(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName)
            {
                return operations.ListByDatabaseAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List database extension. This will return an empty list as it is not
            /// supported.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ImportExportExtensionsOperationResult>> ListByDatabaseAsync(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Perform a database extension operation, like polybase import
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='extensionName'>
            /// </param>
            /// <param name='parameters'>
            /// The database import request parameters.
            /// </param>
            public static ImportExportExtensionsOperationResult BeginCreateOrUpdate(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName, string extensionName, DatabaseExtensions parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, databaseName, extensionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Perform a database extension operation, like polybase import
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='extensionName'>
            /// </param>
            /// <param name='parameters'>
            /// The database import request parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportExtensionsOperationResult> BeginCreateOrUpdateAsync(this IDatabaseExtensionsOperations operations, string resourceGroupName, string serverName, string databaseName, string extensionName, DatabaseExtensions parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, extensionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List database extension. This will return an empty list as it is not
            /// supported.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ImportExportExtensionsOperationResult> ListByDatabaseNext(this IDatabaseExtensionsOperations operations, string nextPageLink)
            {
                return operations.ListByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List database extension. This will return an empty list as it is not
            /// supported.
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
            public static async Task<IPage<ImportExportExtensionsOperationResult>> ListByDatabaseNextAsync(this IDatabaseExtensionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
