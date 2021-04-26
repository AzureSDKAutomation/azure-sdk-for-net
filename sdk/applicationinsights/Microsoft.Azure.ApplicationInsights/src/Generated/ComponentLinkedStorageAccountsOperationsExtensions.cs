// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ComponentLinkedStorageAccountsOperations.
    /// </summary>
    public static partial class ComponentLinkedStorageAccountsOperationsExtensions
    {
            /// <summary>
            /// Returns the current linked storage settings for an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            public static ComponentLinkedStorageAccounts Get(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the current linked storage settings for an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComponentLinkedStorageAccounts> GetAsync(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Replace current linked storage account for an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='linkedStorageAccount'>
            /// Linked storage account resource ID
            /// </param>
            public static ComponentLinkedStorageAccounts CreateAndUpdate(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName, string linkedStorageAccount = default(string))
            {
                return operations.CreateAndUpdateAsync(resourceGroupName, resourceName, linkedStorageAccount).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Replace current linked storage account for an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='linkedStorageAccount'>
            /// Linked storage account resource ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComponentLinkedStorageAccounts> CreateAndUpdateAsync(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName, string linkedStorageAccount = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateAndUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, linkedStorageAccount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update linked storage accounts for an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='linkedStorageAccount'>
            /// Linked storage account resource ID
            /// </param>
            public static ComponentLinkedStorageAccounts Update(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName, string linkedStorageAccount = default(string))
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, linkedStorageAccount).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update linked storage accounts for an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='linkedStorageAccount'>
            /// Linked storage account resource ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ComponentLinkedStorageAccounts> UpdateAsync(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName, string linkedStorageAccount = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, linkedStorageAccount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete linked storage accounts for an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            public static void Delete(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName)
            {
                operations.DeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete linked storage accounts for an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IComponentLinkedStorageAccountsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
