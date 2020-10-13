// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationDefinitionsOperations.
    /// </summary>
    public static partial class ApplicationDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Gets the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            public static ApplicationDefinition Get(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName)
            {
                return operations.GetAsync(resourceGroupName, applicationDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationDefinition> GetAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition to delete.
            /// </param>
            public static void Delete(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName)
            {
                operations.DeleteAsync(resourceGroupName, applicationDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update an managed application
            /// definition.
            /// </param>
            public static ApplicationDefinition CreateOrUpdate(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, applicationDefinitionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update an managed application
            /// definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationDefinition> CreateOrUpdateAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the managed application definitions in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<ApplicationDefinition> ListByResourceGroup(this IApplicationDefinitionsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the managed application definitions in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationDefinition>> ListByResourceGroupAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            public static ApplicationDefinition GetById(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName)
            {
                return operations.GetByIdAsync(resourceGroupName, applicationDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationDefinition> GetByIdAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            public static void DeleteById(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName)
            {
                operations.DeleteByIdAsync(resourceGroupName, applicationDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application
            /// definition.
            /// </param>
            public static ApplicationDefinition CreateOrUpdateById(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters)
            {
                return operations.CreateOrUpdateByIdAsync(resourceGroupName, applicationDefinitionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application
            /// definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationDefinition> CreateOrUpdateByIdAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateByIdWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition to delete.
            /// </param>
            public static void BeginDelete(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, applicationDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update an managed application
            /// definition.
            /// </param>
            public static ApplicationDefinition BeginCreateOrUpdate(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, applicationDefinitionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update an managed application
            /// definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationDefinition> BeginCreateOrUpdateAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            public static void BeginDeleteById(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName)
            {
                operations.BeginDeleteByIdAsync(resourceGroupName, applicationDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteByIdAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteByIdWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application
            /// definition.
            /// </param>
            public static ApplicationDefinition BeginCreateOrUpdateById(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters)
            {
                return operations.BeginCreateOrUpdateByIdAsync(resourceGroupName, applicationDefinitionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationDefinitionName'>
            /// The name of the managed application definition.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application
            /// definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationDefinition> BeginCreateOrUpdateByIdAsync(this IApplicationDefinitionsOperations operations, string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateByIdWithHttpMessagesAsync(resourceGroupName, applicationDefinitionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the managed application definitions in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationDefinition> ListByResourceGroupNext(this IApplicationDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the managed application definitions in a resource group.
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
            public static async Task<IPage<ApplicationDefinition>> ListByResourceGroupNextAsync(this IApplicationDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
