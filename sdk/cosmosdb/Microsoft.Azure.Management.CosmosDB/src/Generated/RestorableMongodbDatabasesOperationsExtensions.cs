// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorableMongodbDatabasesOperations.
    /// </summary>
    public static partial class RestorableMongodbDatabasesOperationsExtensions
    {
            /// <summary>
            /// Show the event feed of all mutations done on all the Azure Cosmos DB
            /// MongoDB databases under the restorable account.  This helps in scenario
            /// where database was accidentally deleted to get the deletion time.  This API
            /// requires
            /// 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read'
            /// permission
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='instanceId'>
            /// The instanceId GUID of a restorable database account.
            /// </param>
            public static IEnumerable<RestorableMongodbDatabaseGetResult> List(this IRestorableMongodbDatabasesOperations operations, string location, string instanceId)
            {
                return operations.ListAsync(location, instanceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Show the event feed of all mutations done on all the Azure Cosmos DB
            /// MongoDB databases under the restorable account.  This helps in scenario
            /// where database was accidentally deleted to get the deletion time.  This API
            /// requires
            /// 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read'
            /// permission
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='instanceId'>
            /// The instanceId GUID of a restorable database account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<RestorableMongodbDatabaseGetResult>> ListAsync(this IRestorableMongodbDatabasesOperations operations, string location, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, instanceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
