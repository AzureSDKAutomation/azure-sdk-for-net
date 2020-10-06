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
    /// Extension methods for ApplicationsOperations.
    /// </summary>
    public static partial class ApplicationsOperationsExtensions
    {
            /// <summary>
            /// Gets the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            public static Application Get(this IApplicationsOperations operations, string resourceGroupName, string applicationName)
            {
                return operations.GetAsync(resourceGroupName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> GetAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, applicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            public static void Delete(this IApplicationsOperations operations, string resourceGroupName, string applicationName)
            {
                operations.DeleteAsync(resourceGroupName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            public static Application CreateOrUpdate(this IApplicationsOperations operations, string resourceGroupName, string applicationName, Application parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, applicationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> CreateOrUpdateAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, Application parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing managed application. The only value that can be updated
            /// via PATCH currently is the tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update an existing managed application.
            /// </param>
            public static Application Update(this IApplicationsOperations operations, string resourceGroupName, string applicationName, ApplicationPatchable parameters = default(ApplicationPatchable))
            {
                return operations.UpdateAsync(resourceGroupName, applicationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing managed application. The only value that can be updated
            /// via PATCH currently is the tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update an existing managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> UpdateAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, ApplicationPatchable parameters = default(ApplicationPatchable), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, applicationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the applications within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<Application> ListByResourceGroup(this IApplicationsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the applications within a resource group.
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
            public static async Task<IPage<Application>> ListByResourceGroupAsync(this IApplicationsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the applications within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Application> ListBySubscription(this IApplicationsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the applications within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Application>> ListBySubscriptionAsync(this IApplicationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            public static Application GetById(this IApplicationsOperations operations, string applicationId)
            {
                return operations.GetByIdAsync(applicationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> GetByIdAsync(this IApplicationsOperations operations, string applicationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(applicationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            public static void DeleteById(this IApplicationsOperations operations, string applicationId)
            {
                operations.DeleteByIdAsync(applicationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IApplicationsOperations operations, string applicationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(applicationId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            public static Application CreateOrUpdateById(this IApplicationsOperations operations, string applicationId, Application parameters)
            {
                return operations.CreateOrUpdateByIdAsync(applicationId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> CreateOrUpdateByIdAsync(this IApplicationsOperations operations, string applicationId, Application parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateByIdWithHttpMessagesAsync(applicationId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing managed application. The only value that can be updated
            /// via PATCH currently is the tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update an existing managed application.
            /// </param>
            public static Application UpdateById(this IApplicationsOperations operations, string applicationId, Application parameters = default(Application))
            {
                return operations.UpdateByIdAsync(applicationId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing managed application. The only value that can be updated
            /// via PATCH currently is the tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update an existing managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> UpdateByIdAsync(this IApplicationsOperations operations, string applicationId, Application parameters = default(Application), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateByIdWithHttpMessagesAsync(applicationId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refresh Permissions for application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            public static void RefreshPermissions(this IApplicationsOperations operations, string resourceGroupName, string applicationName)
            {
                operations.RefreshPermissionsAsync(resourceGroupName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refresh Permissions for application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RefreshPermissionsAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RefreshPermissionsWithHttpMessagesAsync(resourceGroupName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            public static void BeginDelete(this IApplicationsOperations operations, string resourceGroupName, string applicationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            public static Application BeginCreateOrUpdate(this IApplicationsOperations operations, string resourceGroupName, string applicationName, Application parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, applicationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> BeginCreateOrUpdateAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, Application parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            public static void BeginDeleteById(this IApplicationsOperations operations, string applicationId)
            {
                operations.BeginDeleteByIdAsync(applicationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteByIdAsync(this IApplicationsOperations operations, string applicationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteByIdWithHttpMessagesAsync(applicationId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            public static Application BeginCreateOrUpdateById(this IApplicationsOperations operations, string applicationId, Application parameters)
            {
                return operations.BeginCreateOrUpdateByIdAsync(applicationId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new managed application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationId'>
            /// The fully qualified ID of the managed application, including the managed
            /// application name and the managed application resource type. Use the format,
            /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> BeginCreateOrUpdateByIdAsync(this IApplicationsOperations operations, string applicationId, Application parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateByIdWithHttpMessagesAsync(applicationId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refresh Permissions for application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            public static void BeginRefreshPermissions(this IApplicationsOperations operations, string resourceGroupName, string applicationName)
            {
                operations.BeginRefreshPermissionsAsync(resourceGroupName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refresh Permissions for application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the managed application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRefreshPermissionsAsync(this IApplicationsOperations operations, string resourceGroupName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRefreshPermissionsWithHttpMessagesAsync(resourceGroupName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the applications within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Application> ListByResourceGroupNext(this IApplicationsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the applications within a resource group.
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
            public static async Task<IPage<Application>> ListByResourceGroupNextAsync(this IApplicationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the applications within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Application> ListBySubscriptionNext(this IApplicationsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the applications within a subscription.
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
            public static async Task<IPage<Application>> ListBySubscriptionNextAsync(this IApplicationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
