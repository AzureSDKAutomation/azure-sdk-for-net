// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DisasterRecoveryConfigsOperations.
    /// </summary>
    public static partial class DisasterRecoveryConfigsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of authorization rules for a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRules(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, alias).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of authorization rules for a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an AuthorizationRule for a Namespace by rule name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static AuthorizationRule GetAuthorizationRule(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, alias, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an AuthorizationRule for a Namespace by rule name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRule> GetAuthorizationRuleAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static AccessKeys ListKeys(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, alias, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check the give Namespace name availability.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='name'>
            /// Name to check the namespace name availability
            /// </param>
            public static CheckNameAvailabilityResult CheckNameAvailability(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string name)
            {
                return operations.CheckNameAvailabilityAsync(resourceGroupName, namespaceName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the give Namespace name availability.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='name'>
            /// Name to check the namespace name availability
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(resourceGroupName, namespaceName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all Alias(Disaster Recovery configurations)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            public static IPage<ArmDisasterRecovery> List(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all Alias(Disaster Recovery configurations)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ArmDisasterRecovery>> ListAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a new Alias(Disaster Recovery configuration)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='partnerNamespace'>
            /// ARM Id of the Primary/Secondary eventhub namespace name, which is part of
            /// GEO DR pairing
            /// </param>
            /// <param name='alternateName'>
            /// Alternate name specified when alias and namespace names are same.
            /// </param>
            public static ArmDisasterRecovery CreateOrUpdate(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, string partnerNamespace = default(string), string alternateName = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, alias, partnerNamespace, alternateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a new Alias(Disaster Recovery configuration)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='partnerNamespace'>
            /// ARM Id of the Primary/Secondary eventhub namespace name, which is part of
            /// GEO DR pairing
            /// </param>
            /// <param name='alternateName'>
            /// Alternate name specified when alias and namespace names are same.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArmDisasterRecovery> CreateOrUpdateAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, string partnerNamespace = default(string), string alternateName = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, partnerNamespace, alternateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Alias(Disaster Recovery configuration)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            public static void Delete(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, alias).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Alias(Disaster Recovery configuration)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary
            /// namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            public static ArmDisasterRecovery Get(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, alias).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary
            /// namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArmDisasterRecovery> GetAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation disables the Disaster Recovery and stops replicating changes
            /// from primary to secondary namespaces
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            public static void BreakPairing(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias)
            {
                operations.BreakPairingAsync(resourceGroupName, namespaceName, alias).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation disables the Disaster Recovery and stops replicating changes
            /// from primary to secondary namespaces
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BreakPairingAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BreakPairingWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Invokes GEO DR failover and reconfigure the alias to point to the secondary
            /// namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            public static void FailOver(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias)
            {
                operations.FailOverAsync(resourceGroupName, namespaceName, alias).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Invokes GEO DR failover and reconfigure the alias to point to the secondary
            /// namespace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='alias'>
            /// The Disaster Recovery configuration name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FailOverAsync(this IDisasterRecoveryConfigsOperations operations, string resourceGroupName, string namespaceName, string alias, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.FailOverWithHttpMessagesAsync(resourceGroupName, namespaceName, alias, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of authorization rules for a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRulesNext(this IDisasterRecoveryConfigsOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of authorization rules for a Namespace.
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
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesNextAsync(this IDisasterRecoveryConfigsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all Alias(Disaster Recovery configurations)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ArmDisasterRecovery> ListNext(this IDisasterRecoveryConfigsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all Alias(Disaster Recovery configurations)
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
            public static async Task<IPage<ArmDisasterRecovery>> ListNextAsync(this IDisasterRecoveryConfigsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
