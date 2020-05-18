// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BindingsOperations.
    /// </summary>
    public static partial class BindingsOperationsExtensions
    {
            /// <summary>
            /// Get a Binding and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            public static BindingResource Get(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, appName, bindingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Binding and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BindingResource> GetAsync(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, appName, bindingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new Binding or update an exiting Binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            /// <param name='bindingResource'>
            /// Parameters for the create or update operation
            /// </param>
            public static BindingResource CreateOrUpdate(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName, BindingResource bindingResource)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, appName, bindingName, bindingResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new Binding or update an exiting Binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            /// <param name='bindingResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BindingResource> CreateOrUpdateAsync(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName, BindingResource bindingResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, appName, bindingName, bindingResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a Binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            public static void Delete(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, appName, bindingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a Binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, appName, bindingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Operation to update an exiting Binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            /// <param name='bindingResource'>
            /// Parameters for the update operation
            /// </param>
            public static BindingResource Update(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName, BindingResource bindingResource)
            {
                return operations.UpdateAsync(resourceGroupName, serviceName, appName, bindingName, bindingResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to update an exiting Binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='bindingName'>
            /// The name of the Binding resource.
            /// </param>
            /// <param name='bindingResource'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BindingResource> UpdateAsync(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, string bindingName, BindingResource bindingResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, appName, bindingName, bindingResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in an App.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            public static IPage<BindingResource> List(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName)
            {
                return operations.ListAsync(resourceGroupName, serviceName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in an App.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='appName'>
            /// The name of the App resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BindingResource>> ListAsync(this IBindingsOperations operations, string resourceGroupName, string serviceName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in an App.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BindingResource> ListNext(this IBindingsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in an App.
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
            public static async Task<IPage<BindingResource>> ListNextAsync(this IBindingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
