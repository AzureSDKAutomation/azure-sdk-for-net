// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FileSharesOperations.
    /// </summary>
    public static partial class FileSharesOperationsExtensions
    {
            /// <summary>
            /// Lists all shares.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='maxpagesize'>
            /// Optional. Specified maximum number of shares that can be included in the
            /// list.
            /// </param>
            /// <param name='filter'>
            /// Optional. When specified, only share names starting with the filter will be
            /// listed.
            /// </param>
            /// <param name='expand'>
            /// Optional, used to expand the properties within share's properties. Valid
            /// values are: deleted, snapshots. Should be passed as a string with delimiter
            /// ','
            /// </param>
            public static IPage<FileShareItem> List(this IFileSharesOperations operations, string resourceGroupName, string accountName, string maxpagesize = default(string), string filter = default(string), string expand = default(string))
            {
                return operations.ListAsync(resourceGroupName, accountName, maxpagesize, filter, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all shares.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='maxpagesize'>
            /// Optional. Specified maximum number of shares that can be included in the
            /// list.
            /// </param>
            /// <param name='filter'>
            /// Optional. When specified, only share names starting with the filter will be
            /// listed.
            /// </param>
            /// <param name='expand'>
            /// Optional, used to expand the properties within share's properties. Valid
            /// values are: deleted, snapshots. Should be passed as a string with delimiter
            /// ','
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FileShareItem>> ListAsync(this IFileSharesOperations operations, string resourceGroupName, string accountName, string maxpagesize = default(string), string filter = default(string), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, maxpagesize, filter, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new share under the specified account as described by request
            /// body. The share resource includes metadata and properties for that share.
            /// It does not include a list of the files contained by the share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='fileShare'>
            /// Properties of the file share to create.
            /// </param>
            /// <param name='expand'>
            /// Optional, used to expand the properties within share's properties. Valid
            /// values are: snapshots. Should be passed as a string with delimiter ','
            /// </param>
            public static FileShare Create(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, FileShare fileShare, string expand = default(string))
            {
                return operations.CreateAsync(resourceGroupName, accountName, shareName, fileShare, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new share under the specified account as described by request
            /// body. The share resource includes metadata and properties for that share.
            /// It does not include a list of the files contained by the share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='fileShare'>
            /// Properties of the file share to create.
            /// </param>
            /// <param name='expand'>
            /// Optional, used to expand the properties within share's properties. Valid
            /// values are: snapshots. Should be passed as a string with delimiter ','
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileShare> CreateAsync(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, FileShare fileShare, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, shareName, fileShare, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates share properties as specified in request body. Properties not
            /// mentioned in the request will not be changed. Update fails if the specified
            /// share does not already exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='fileShare'>
            /// Properties to update for the file share.
            /// </param>
            public static FileShare Update(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, FileShare fileShare)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, shareName, fileShare).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates share properties as specified in request body. Properties not
            /// mentioned in the request will not be changed. Update fails if the specified
            /// share does not already exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='fileShare'>
            /// Properties to update for the file share.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileShare> UpdateAsync(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, FileShare fileShare, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, shareName, fileShare, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets properties of a specified share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='expand'>
            /// Optional, used to expand the properties within share's properties. Valid
            /// values are: stats. Should be passed as a string with delimiter ','
            /// </param>
            /// <param name='xMsSnapshot'>
            /// Optional, used to retrieve properties of a snapshot.
            /// </param>
            public static FileShare Get(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, string expand = default(string), string xMsSnapshot = default(string))
            {
                return operations.GetAsync(resourceGroupName, accountName, shareName, expand, xMsSnapshot).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets properties of a specified share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='expand'>
            /// Optional, used to expand the properties within share's properties. Valid
            /// values are: stats. Should be passed as a string with delimiter ','
            /// </param>
            /// <param name='xMsSnapshot'>
            /// Optional, used to retrieve properties of a snapshot.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileShare> GetAsync(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, string expand = default(string), string xMsSnapshot = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, shareName, expand, xMsSnapshot, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes specified share under its account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='xMsSnapshot'>
            /// Optional, used to delete a snapshot.
            /// </param>
            /// <param name='include'>
            /// Optional. Valid values are: snapshots, leased-snapshots, none. The default
            /// value is snapshots. For 'snapshots', the file share is deleted including
            /// all of its file share snapshots. If the file share contains
            /// leased-snapshots, the deletion fails. For 'leased-snapshots', the file
            /// share is deleted included all of its file share snapshots
            /// (leased/unleased). For 'none', the file share is deleted if it has no share
            /// snapshots. If the file share contains any snapshots (leased or unleased),
            /// the deletion fails.
            /// </param>
            public static void Delete(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, string xMsSnapshot = default(string), string include = default(string))
            {
                operations.DeleteAsync(resourceGroupName, accountName, shareName, xMsSnapshot, include).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes specified share under its account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='xMsSnapshot'>
            /// Optional, used to delete a snapshot.
            /// </param>
            /// <param name='include'>
            /// Optional. Valid values are: snapshots, leased-snapshots, none. The default
            /// value is snapshots. For 'snapshots', the file share is deleted including
            /// all of its file share snapshots. If the file share contains
            /// leased-snapshots, the deletion fails. For 'leased-snapshots', the file
            /// share is deleted included all of its file share snapshots
            /// (leased/unleased). For 'none', the file share is deleted if it has no share
            /// snapshots. If the file share contains any snapshots (leased or unleased),
            /// the deletion fails.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, string xMsSnapshot = default(string), string include = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, xMsSnapshot, include, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Restore a file share within a valid retention days if share soft delete is
            /// enabled
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='deletedShareName'>
            /// Required. Identify the name of the deleted share that will be restored.
            /// </param>
            /// <param name='deletedShareVersion'>
            /// Required. Identify the version of the deleted share that will be restored.
            /// </param>
            public static void Restore(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, string deletedShareName, string deletedShareVersion)
            {
                operations.RestoreAsync(resourceGroupName, accountName, shareName, deletedShareName, deletedShareVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restore a file share within a valid retention days if share soft delete is
            /// enabled
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='deletedShareName'>
            /// Required. Identify the name of the deleted share that will be restored.
            /// </param>
            /// <param name='deletedShareVersion'>
            /// Required. Identify the version of the deleted share that will be restored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestoreAsync(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, string deletedShareName, string deletedShareVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RestoreWithHttpMessagesAsync(resourceGroupName, accountName, shareName, deletedShareName, deletedShareVersion, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The Lease Share operation establishes and manages a lock on a share for
            /// delete operations. The lock duration can be 15 to 60 seconds, or can be
            /// infinite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='parameters'>
            /// Lease Share request body.
            /// </param>
            public static LeaseShareResponse Lease(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, LeaseShareRequest parameters = default(LeaseShareRequest))
            {
                return operations.LeaseAsync(resourceGroupName, accountName, shareName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Lease Share operation establishes and manages a lock on a share for
            /// delete operations. The lock duration can be 15 to 60 seconds, or can be
            /// infinite.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='shareName'>
            /// The name of the file share within the specified storage account. File share
            /// names must be between 3 and 63 characters in length and use numbers,
            /// lower-case letters and dash (-) only. Every dash (-) character must be
            /// immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='parameters'>
            /// Lease Share request body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LeaseShareResponse> LeaseAsync(this IFileSharesOperations operations, string resourceGroupName, string accountName, string shareName, LeaseShareRequest parameters = default(LeaseShareRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LeaseWithHttpMessagesAsync(resourceGroupName, accountName, shareName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all shares.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FileShareItem> ListNext(this IFileSharesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all shares.
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
            public static async Task<IPage<FileShareItem>> ListNextAsync(this IFileSharesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
