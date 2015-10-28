// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataLake.StoreFileSystem.Models;

namespace Microsoft.Azure.Management.DataLake.StoreFileSystem
{
    /// <summary>
    /// Operations for managing the DataLake filesystem
    /// </summary>
    public partial interface IFileSystemOperations
    {
        /// <summary>
        /// Initiates a file append request, resulting in a return of the data
        /// node location that will service the request.
        /// </summary>
        /// <param name="filePath">The path to the file to create.</param>
        /// <param name="accountName">The name of the account to use</param>
        /// <param name="bufferSize">The optional buffer size to use when appending data</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// The data from the file requested.
        /// </returns>
        Task<FileCreateOpenAndAppendResponse> BeginAppendAsync(string filePath, string accountName, int? bufferSize, CancellationToken cancellationToken);

        /// <summary>
        /// Initiates a file creation request, resulting in a return of the
        /// data node location that will service the request.
        /// </summary>
        /// <param name="filePath">The path to the file to create.</param>
        /// <param name="accountName">The name of the account to use</param>
        /// <param name="parameters">The optional parameters to use when creating the file</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// The data from the file requested.
        /// </returns>
        Task<FileCreateOpenAndAppendResponse> BeginCreateAsync(string filePath, string accountName, FileCreateParameters parameters, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the data associated with the file handle requested.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to open.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to retrieve
        /// </param>
        /// <param name='parameters'>
        /// The optional parameters to pass to the open operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The data from the file requested.
        /// </returns>
        Task<FileCreateOpenAndAppendResponse> BeginOpenAsync(string filePath, string accountName, FileOpenParameters parameters, CancellationToken cancellationToken);
    }
}
