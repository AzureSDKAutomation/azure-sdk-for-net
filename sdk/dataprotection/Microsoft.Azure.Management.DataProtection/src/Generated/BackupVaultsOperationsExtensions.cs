// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackupVaultsOperations.
    /// </summary>
    public static partial class BackupVaultsOperationsExtensions
    {
            /// <summary>
            /// Returns resource collection belonging to a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<BackupVaultResource> GetResourcesInSubscription(this IBackupVaultsOperations operations)
            {
                return operations.GetResourcesInSubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns resource collection belonging to a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BackupVaultResource>> GetResourcesInSubscriptionAsync(this IBackupVaultsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourcesInSubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns resource collection belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            public static IPage<BackupVaultResource> GetResourcesInResourceGroup(this IBackupVaultsOperations operations, string resourceGroupName)
            {
                return operations.GetResourcesInResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns resource collection belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BackupVaultResource>> GetResourcesInResourceGroupAsync(this IBackupVaultsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourcesInResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a resource belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            public static BackupVaultResource Get(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName)
            {
                return operations.GetAsync(vaultName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a resource belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupVaultResource> GetAsync(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a BackupVault resource belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static BackupVaultResource CreateOrUpdate(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, BackupVaultResource parameters)
            {
                return operations.CreateOrUpdateAsync(vaultName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a BackupVault resource belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupVaultResource> CreateOrUpdateAsync(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, BackupVaultResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(vaultName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a BackupVault resource from the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            public static void Delete(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName)
            {
                operations.DeleteAsync(vaultName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a BackupVault resource from the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(vaultName, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a BackupVault resource belonging to a resource group. For example,
            /// updating tags for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static BackupVaultResource Patch(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, PatchResourceRequestInput parameters)
            {
                return operations.PatchAsync(vaultName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a BackupVault resource belonging to a resource group. For example,
            /// updating tags for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupVaultResource> PatchAsync(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, PatchResourceRequestInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(vaultName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// API to check for resource name availability
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='location'>
            /// The location in which uniqueness will be verified.
            /// </param>
            /// <param name='parameters'>
            /// Check name availability request
            /// </param>
            public static CheckNameAvailabilityResult CheckNameAvailability(this IBackupVaultsOperations operations, string resourceGroupName, string location, CheckNameAvailabilityRequest parameters)
            {
                return operations.CheckNameAvailabilityAsync(resourceGroupName, location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// API to check for resource name availability
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='location'>
            /// The location in which uniqueness will be verified.
            /// </param>
            /// <param name='parameters'>
            /// Check name availability request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IBackupVaultsOperations operations, string resourceGroupName, string location, CheckNameAvailabilityRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(resourceGroupName, location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a BackupVault resource belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static BackupVaultResource BeginCreateOrUpdate(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, BackupVaultResource parameters)
            {
                return operations.BeginCreateOrUpdateAsync(vaultName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a BackupVault resource belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupVaultResource> BeginCreateOrUpdateAsync(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, BackupVaultResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(vaultName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a BackupVault resource belonging to a resource group. For example,
            /// updating tags for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static BackupVaultResource BeginPatch(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, PatchResourceRequestInput parameters)
            {
                return operations.BeginPatchAsync(vaultName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a BackupVault resource belonging to a resource group. For example,
            /// updating tags for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupVaultResource> BeginPatchAsync(this IBackupVaultsOperations operations, string vaultName, string resourceGroupName, PatchResourceRequestInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPatchWithHttpMessagesAsync(vaultName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns resource collection belonging to a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BackupVaultResource> GetResourcesInSubscriptionNext(this IBackupVaultsOperations operations, string nextPageLink)
            {
                return operations.GetResourcesInSubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns resource collection belonging to a subscription.
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
            public static async Task<IPage<BackupVaultResource>> GetResourcesInSubscriptionNextAsync(this IBackupVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourcesInSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns resource collection belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BackupVaultResource> GetResourcesInResourceGroupNext(this IBackupVaultsOperations operations, string nextPageLink)
            {
                return operations.GetResourcesInResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns resource collection belonging to a resource group.
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
            public static async Task<IPage<BackupVaultResource>> GetResourcesInResourceGroupNextAsync(this IBackupVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourcesInResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
