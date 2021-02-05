// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubscriptionsOperations.
    /// </summary>
    public static partial class SubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Gets all available geo-locations.
            /// </summary>
            /// <remarks>
            /// This operation provides all the locations that are available for resource
            /// providers; however, each resource provider may support a subset of this
            /// list.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            public static IEnumerable<Location> ListLocations(this ISubscriptionsOperations operations, string subscriptionId)
            {
                return operations.ListLocationsAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all available geo-locations.
            /// </summary>
            /// <remarks>
            /// This operation provides all the locations that are available for resource
            /// providers; however, each resource provider may support a subset of this
            /// list.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Location>> ListLocationsAsync(this ISubscriptionsOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListLocationsWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets details about a specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            public static SubscriptionModel Get(this ISubscriptionsOperations operations, string subscriptionId)
            {
                return operations.GetAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details about a specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionModel> GetAsync(this ISubscriptionsOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<SubscriptionModel> List(this ISubscriptionsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SubscriptionModel>> ListAsync(this ISubscriptionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult CreateSubscriptionInEnrollmentAccount(this ISubscriptionsOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body)
            {
                return operations.CreateSubscriptionInEnrollmentAccountAsync(enrollmentAccountName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> CreateSubscriptionInEnrollmentAccountAsync(this ISubscriptionsOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSubscriptionInEnrollmentAccountWithHttpMessagesAsync(enrollmentAccountName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult CreateSubscription(this ISubscriptionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body)
            {
                return operations.CreateSubscriptionAsync(billingAccountName, billingProfileName, invoiceSectionName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> CreateSubscriptionAsync(this ISubscriptionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSubscriptionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult CreateCspSubscription(this ISubscriptionsOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body)
            {
                return operations.CreateCspSubscriptionAsync(billingAccountName, customerName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> CreateCspSubscriptionAsync(this ISubscriptionsOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateCspSubscriptionWithHttpMessagesAsync(billingAccountName, customerName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SubscriptionAliasResponse CreateAlias(this ISubscriptionsOperations operations, string aliasName, PutAliasRequest body)
            {
                return operations.CreateAliasAsync(aliasName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasResponse> CreateAliasAsync(this ISubscriptionsOperations operations, string aliasName, PutAliasRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateAliasWithHttpMessagesAsync(aliasName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            public static SubscriptionAliasResponse GetAlias(this ISubscriptionsOperations operations, string aliasName)
            {
                return operations.GetAliasAsync(aliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasResponse> GetAliasAsync(this ISubscriptionsOperations operations, string aliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAliasWithHttpMessagesAsync(aliasName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete Alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            public static void DeleteAlias(this ISubscriptionsOperations operations, string aliasName)
            {
                operations.DeleteAliasAsync(aliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAliasAsync(this ISubscriptionsOperations operations, string aliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAliasWithHttpMessagesAsync(aliasName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SubscriptionAliasListResult ListAlias(this ISubscriptionsOperations operations)
            {
                return operations.ListAliasAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasListResult> ListAliasAsync(this ISubscriptionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAliasWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Redeem subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            public static SubscriptionsRedeemHeaders Redeem(this ISubscriptionsOperations operations, string subscriptionId)
            {
                return operations.RedeemAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Redeem subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionsRedeemHeaders> RedeemAsync(this ISubscriptionsOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RedeemWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Redeem subscription status.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            public static SubscriptionAliasRedeemResponse RedeemStatus(this ISubscriptionsOperations operations, string subscriptionId)
            {
                return operations.RedeemStatusAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Redeem subscription status.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasRedeemResponse> RedeemStatusAsync(this ISubscriptionsOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RedeemStatusWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult BeginCreateSubscriptionInEnrollmentAccount(this ISubscriptionsOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body)
            {
                return operations.BeginCreateSubscriptionInEnrollmentAccountAsync(enrollmentAccountName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> BeginCreateSubscriptionInEnrollmentAccountAsync(this ISubscriptionsOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateSubscriptionInEnrollmentAccountWithHttpMessagesAsync(enrollmentAccountName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult BeginCreateSubscription(this ISubscriptionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body)
            {
                return operations.BeginCreateSubscriptionAsync(billingAccountName, billingProfileName, invoiceSectionName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> BeginCreateSubscriptionAsync(this ISubscriptionsOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateSubscriptionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult BeginCreateCspSubscription(this ISubscriptionsOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body)
            {
                return operations.BeginCreateCspSubscriptionAsync(billingAccountName, customerName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> BeginCreateCspSubscriptionAsync(this ISubscriptionsOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateCspSubscriptionWithHttpMessagesAsync(billingAccountName, customerName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SubscriptionAliasResponse BeginCreateAlias(this ISubscriptionsOperations operations, string aliasName, PutAliasRequest body)
            {
                return operations.BeginCreateAliasAsync(aliasName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// Alias Name
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasResponse> BeginCreateAliasAsync(this ISubscriptionsOperations operations, string aliasName, PutAliasRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateAliasWithHttpMessagesAsync(aliasName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Redeem subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            public static SubscriptionsRedeemHeaders BeginRedeem(this ISubscriptionsOperations operations, string subscriptionId)
            {
                return operations.BeginRedeemAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Redeem subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionsRedeemHeaders> BeginRedeemAsync(this ISubscriptionsOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRedeemWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SubscriptionModel> ListNext(this ISubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
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
            public static async Task<IPage<SubscriptionModel>> ListNextAsync(this ISubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
