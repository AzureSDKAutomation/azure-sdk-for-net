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
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SensitivityLabelsOperations.
    /// </summary>
    public static partial class SensitivityLabelsOperationsExtensions
    {
            /// <summary>
            /// Gets the sensitivity labels of a given database
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<SensitivityLabel> ListCurrentByDatabase(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>))
            {
                return operations.ListCurrentByDatabaseAsync(resourceGroupName, serverName, databaseName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the sensitivity labels of a given database
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SensitivityLabel>> ListCurrentByDatabaseAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCurrentByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the sensitivity labels of a given database
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='includeDisabledRecommendations'>
            /// Specifies whether to include disabled recommendations or not.
            /// </param>
            /// <param name='skipToken'>
            /// </param>
            public static IPage<SensitivityLabel> ListRecommendedByDatabase(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>), bool? includeDisabledRecommendations = default(bool?), string skipToken = default(string))
            {
                return operations.ListRecommendedByDatabaseAsync(resourceGroupName, serverName, databaseName, odataQuery, includeDisabledRecommendations, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the sensitivity labels of a given database
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='includeDisabledRecommendations'>
            /// Specifies whether to include disabled recommendations or not.
            /// </param>
            /// <param name='skipToken'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SensitivityLabel>> ListRecommendedByDatabaseAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>), bool? includeDisabledRecommendations = default(bool?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendedByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, odataQuery, includeDisabledRecommendations, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enables sensitivity recommendations on a given column (recommendations are
            /// enabled by default on all columns)
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            public static void EnableRecommendation(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
            {
                operations.EnableRecommendationAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables sensitivity recommendations on a given column (recommendations are
            /// enabled by default on all columns)
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableRecommendationAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EnableRecommendationWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Disables sensitivity recommendations on a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            public static void DisableRecommendation(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
            {
                operations.DisableRecommendationAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables sensitivity recommendations on a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableRecommendationAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DisableRecommendationWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the sensitivity label of a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='sensitivityLabelSource'>
            /// The source of the sensitivity label. Possible values include: 'current',
            /// 'recommended'
            /// </param>
            public static SensitivityLabel Get(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource)
            {
                return operations.GetAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, sensitivityLabelSource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the sensitivity label of a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='sensitivityLabelSource'>
            /// The source of the sensitivity label. Possible values include: 'current',
            /// 'recommended'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SensitivityLabel> GetAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, sensitivityLabelSource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the sensitivity label of a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='parameters'>
            /// The column sensitivity label resource.
            /// </param>
            public static SensitivityLabel CreateOrUpdate(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabel parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the sensitivity label of a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='parameters'>
            /// The column sensitivity label resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SensitivityLabel> CreateOrUpdateAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabel parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the sensitivity label of a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            public static void Delete(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the sensitivity label of a given column
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
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISensitivityLabelsOperations operations, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the sensitivity labels of a given database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SensitivityLabel> ListCurrentByDatabaseNext(this ISensitivityLabelsOperations operations, string nextPageLink)
            {
                return operations.ListCurrentByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the sensitivity labels of a given database
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
            public static async Task<IPage<SensitivityLabel>> ListCurrentByDatabaseNextAsync(this ISensitivityLabelsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCurrentByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the sensitivity labels of a given database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SensitivityLabel> ListRecommendedByDatabaseNext(this ISensitivityLabelsOperations operations, string nextPageLink)
            {
                return operations.ListRecommendedByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the sensitivity labels of a given database
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
            public static async Task<IPage<SensitivityLabel>> ListRecommendedByDatabaseNextAsync(this ISensitivityLabelsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendedByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
