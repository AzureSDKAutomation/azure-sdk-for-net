// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The AzureStorageSection. </summary>
    public partial class AzureStorageSection
    {
        /// <summary> Initializes a new instance of AzureStorageSection. </summary>
        /// <param name="accountName"> Storage account name. </param>
        /// <param name="containerName"> Storage account container name. </param>
        /// <param name="credentials"> . </param>
        /// <param name="endpoint"> Azure cloud endpoint for the storage account. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="containerName"/>, <paramref name="credentials"/>, <paramref name="endpoint"/>, or <paramref name="protocol"/> is null. </exception>
        public AzureStorageSection(string accountName, string containerName, DatastoreCredentials credentials, string endpoint, string protocol)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (credentials == null)
            {
                throw new ArgumentNullException(nameof(credentials));
            }
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (protocol == null)
            {
                throw new ArgumentNullException(nameof(protocol));
            }

            AccountName = accountName;
            ContainerName = containerName;
            Credentials = credentials;
            Endpoint = endpoint;
            Protocol = protocol;
        }

        /// <summary> Initializes a new instance of AzureStorageSection. </summary>
        /// <param name="accountName"> Storage account name. </param>
        /// <param name="blobCacheTimeout"> Blob storage cache timeout. </param>
        /// <param name="containerName"> Storage account container name. </param>
        /// <param name="credentials"> . </param>
        /// <param name="endpoint"> Azure cloud endpoint for the storage account. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account. </param>
        internal AzureStorageSection(string accountName, int? blobCacheTimeout, string containerName, DatastoreCredentials credentials, string endpoint, string protocol)
        {
            AccountName = accountName;
            BlobCacheTimeout = blobCacheTimeout;
            ContainerName = containerName;
            Credentials = credentials;
            Endpoint = endpoint;
            Protocol = protocol;
        }

        /// <summary> Storage account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Blob storage cache timeout. </summary>
        public int? BlobCacheTimeout { get; set; }
        /// <summary> Storage account container name. </summary>
        public string ContainerName { get; set; }
        public DatastoreCredentials Credentials { get; set; }
        /// <summary> Azure cloud endpoint for the storage account. </summary>
        public string Endpoint { get; set; }
        /// <summary> Protocol used to communicate with the storage account. </summary>
        public string Protocol { get; set; }
    }
}
