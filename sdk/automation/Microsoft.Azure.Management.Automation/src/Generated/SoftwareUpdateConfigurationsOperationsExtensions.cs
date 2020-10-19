// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SoftwareUpdateConfigurationsOperations.
    /// </summary>
    public static partial class SoftwareUpdateConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Create a new software update configuration with the name given in the URI.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationName'>
            /// The name of the software update configuration to be created.
            /// </param>
            /// <param name='parameters'>
            /// Request body.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            public static SoftwareUpdateConfiguration Create(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, SoftwareUpdateConfiguration parameters, string clientRequestId = default(string))
            {
                return operations.CreateAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationName, parameters, clientRequestId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new software update configuration with the name given in the URI.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationName'>
            /// The name of the software update configuration to be created.
            /// </param>
            /// <param name='parameters'>
            /// Request body.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfiguration> CreateAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, SoftwareUpdateConfiguration parameters, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationName, parameters, clientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a single software update configuration by name.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationName'>
            /// The name of the software update configuration to be created.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            public static SoftwareUpdateConfiguration GetByName(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, string clientRequestId = default(string))
            {
                return operations.GetByNameAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationName, clientRequestId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a single software update configuration by name.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationName'>
            /// The name of the software update configuration to be created.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfiguration> GetByNameAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByNameWithHttpMessagesAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationName, clientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a specific software update configuration.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationName'>
            /// The name of the software update configuration to be created.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            public static void Delete(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, string clientRequestId = default(string))
            {
                operations.DeleteAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationName, clientRequestId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a specific software update configuration.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationName'>
            /// The name of the software update configuration to be created.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationName, clientRequestId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all software update configurations for the account.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<SoftwareUpdateConfigurationCollectionItem> List(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string clientRequestId = default(string), string filter = default(string))
            {
                return operations.ListAsync(resourceGroupName, automationAccountName, clientRequestId, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all software update configurations for the account.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SoftwareUpdateConfigurationCollectionItem>> ListAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string automationAccountName, string clientRequestId = default(string), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, automationAccountName, clientRequestId, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all software update configurations for the account.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            public static IPage<SoftwareUpdateConfigurationCollectionItem> ListNext(this ISoftwareUpdateConfigurationsOperations operations, string nextPageLink, string clientRequestId = default(string))
            {
                return operations.ListNextAsync(nextPageLink, clientRequestId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all software update configurations for the account.
            /// <see href="https://docs.microsoft.com/dotnet/api/microsoft.azure.management.automation.softwareupdateconfigurationsoperationsextensions" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SoftwareUpdateConfigurationCollectionItem>> ListNextAsync(this ISoftwareUpdateConfigurationsOperations operations, string nextPageLink, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, clientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
