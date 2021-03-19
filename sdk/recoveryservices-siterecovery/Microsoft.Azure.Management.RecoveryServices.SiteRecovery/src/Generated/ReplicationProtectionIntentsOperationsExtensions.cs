// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationProtectionIntentsOperations.
    /// </summary>
    public static partial class ReplicationProtectionIntentsOperationsExtensions
    {
            /// <summary>
            /// Gets the list of replication protection intent objects.
            /// </summary>
            /// <remarks>
            /// Gets the list of ASR replication protection intent objects in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// The pagination token.
            /// </param>
            /// <param name='takeToken'>
            /// The page size.
            /// </param>
            public static IPage<ReplicationProtectionIntent> List(this IReplicationProtectionIntentsOperations operations, string skipToken = default(string), string takeToken = default(string))
            {
                return operations.ListAsync(skipToken, takeToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of replication protection intent objects.
            /// </summary>
            /// <remarks>
            /// Gets the list of ASR replication protection intent objects in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// The pagination token.
            /// </param>
            /// <param name='takeToken'>
            /// The page size.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReplicationProtectionIntent>> ListAsync(this IReplicationProtectionIntentsOperations operations, string skipToken = default(string), string takeToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(skipToken, takeToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of a Replication protection intent item.
            /// </summary>
            /// <remarks>
            /// Gets the details of an ASR replication protection intent.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intentObjectName'>
            /// Replication protection intent name.
            /// </param>
            public static ReplicationProtectionIntent Get(this IReplicationProtectionIntentsOperations operations, string intentObjectName)
            {
                return operations.GetAsync(intentObjectName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a Replication protection intent item.
            /// </summary>
            /// <remarks>
            /// Gets the details of an ASR replication protection intent.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intentObjectName'>
            /// Replication protection intent name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationProtectionIntent> GetAsync(this IReplicationProtectionIntentsOperations operations, string intentObjectName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(intentObjectName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create protection intent Resource.
            /// </summary>
            /// <remarks>
            /// The operation to create an ASR replication protection intent item.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intentObjectName'>
            /// A name for the replication protection item.
            /// </param>
            /// <param name='input'>
            /// Create Protection Intent Input.
            /// </param>
            public static ReplicationProtectionIntent Create(this IReplicationProtectionIntentsOperations operations, string intentObjectName, CreateProtectionIntentInput input)
            {
                return operations.CreateAsync(intentObjectName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create protection intent Resource.
            /// </summary>
            /// <remarks>
            /// The operation to create an ASR replication protection intent item.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intentObjectName'>
            /// A name for the replication protection item.
            /// </param>
            /// <param name='input'>
            /// Create Protection Intent Input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationProtectionIntent> CreateAsync(this IReplicationProtectionIntentsOperations operations, string intentObjectName, CreateProtectionIntentInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(intentObjectName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create protection intent Resource.
            /// </summary>
            /// <remarks>
            /// The operation to create an ASR replication protection intent item.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intentObjectName'>
            /// A name for the replication protection item.
            /// </param>
            /// <param name='input'>
            /// Create Protection Intent Input.
            /// </param>
            public static ReplicationProtectionIntent BeginCreate(this IReplicationProtectionIntentsOperations operations, string intentObjectName, CreateProtectionIntentInput input)
            {
                return operations.BeginCreateAsync(intentObjectName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create protection intent Resource.
            /// </summary>
            /// <remarks>
            /// The operation to create an ASR replication protection intent item.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intentObjectName'>
            /// A name for the replication protection item.
            /// </param>
            /// <param name='input'>
            /// Create Protection Intent Input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationProtectionIntent> BeginCreateAsync(this IReplicationProtectionIntentsOperations operations, string intentObjectName, CreateProtectionIntentInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(intentObjectName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of replication protection intent objects.
            /// </summary>
            /// <remarks>
            /// Gets the list of ASR replication protection intent objects in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReplicationProtectionIntent> ListNext(this IReplicationProtectionIntentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of replication protection intent objects.
            /// </summary>
            /// <remarks>
            /// Gets the list of ASR replication protection intent objects in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReplicationProtectionIntent>> ListNextAsync(this IReplicationProtectionIntentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
