// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used when creating a server endpoint.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerEndpointCreateParameters : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpointCreateParameters
        /// class.
        /// </summary>
        public ServerEndpointCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpointCreateParameters
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="serverLocalPath">Server Local path.</param>
        /// <param name="cloudTiering">Cloud Tiering. Possible values include:
        /// 'on', 'off'</param>
        /// <param name="volumeFreeSpacePercent">Level of free space to be
        /// maintained by Cloud Tiering if it is enabled.</param>
        /// <param name="tierFilesOlderThanDays">Tier files older than
        /// days.</param>
        /// <param name="friendlyName">Friendly Name</param>
        /// <param name="serverResourceId">Server Resource Id.</param>
        /// <param name="offlineDataTransfer">Offline data transfer. Possible
        /// values include: 'on', 'off'</param>
        /// <param name="offlineDataTransferShareName">Offline data transfer
        /// share name</param>
        /// <param name="initialDownloadPolicy">Policy for how namespace and
        /// files are recalled during FastDr. Possible values include:
        /// 'NamespaceOnly', 'NamespaceThenModifiedFiles',
        /// 'AvoidTieredFiles'</param>
        /// <param name="localCacheMode">Policy for enabling follow-the-sun
        /// business models: link local cache to cloud behavior to pre-populate
        /// before local access. Possible values include:
        /// 'DownloadNewAndModifiedFiles', 'UpdateLocallyCachedFiles'</param>
        public ServerEndpointCreateParameters(string id = default(string), string name = default(string), string type = default(string), string serverLocalPath = default(string), string cloudTiering = default(string), int? volumeFreeSpacePercent = default(int?), int? tierFilesOlderThanDays = default(int?), string friendlyName = default(string), string serverResourceId = default(string), string offlineDataTransfer = default(string), string offlineDataTransferShareName = default(string), string initialDownloadPolicy = default(string), string localCacheMode = default(string))
            : base(id, name, type)
        {
            ServerLocalPath = serverLocalPath;
            CloudTiering = cloudTiering;
            VolumeFreeSpacePercent = volumeFreeSpacePercent;
            TierFilesOlderThanDays = tierFilesOlderThanDays;
            FriendlyName = friendlyName;
            ServerResourceId = serverResourceId;
            OfflineDataTransfer = offlineDataTransfer;
            OfflineDataTransferShareName = offlineDataTransferShareName;
            InitialDownloadPolicy = initialDownloadPolicy;
            LocalCacheMode = localCacheMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets server Local path.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverLocalPath")]
        public string ServerLocalPath { get; set; }

        /// <summary>
        /// Gets or sets cloud Tiering. Possible values include: 'on', 'off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.cloudTiering")]
        public string CloudTiering { get; set; }

        /// <summary>
        /// Gets or sets level of free space to be maintained by Cloud Tiering
        /// if it is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeFreeSpacePercent")]
        public int? VolumeFreeSpacePercent { get; set; }

        /// <summary>
        /// Gets or sets tier files older than days.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tierFilesOlderThanDays")]
        public int? TierFilesOlderThanDays { get; set; }

        /// <summary>
        /// Gets or sets friendly Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets server Resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverResourceId")]
        public string ServerResourceId { get; set; }

        /// <summary>
        /// Gets or sets offline data transfer. Possible values include: 'on',
        /// 'off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.offlineDataTransfer")]
        public string OfflineDataTransfer { get; set; }

        /// <summary>
        /// Gets or sets offline data transfer share name
        /// </summary>
        [JsonProperty(PropertyName = "properties.offlineDataTransferShareName")]
        public string OfflineDataTransferShareName { get; set; }

        /// <summary>
        /// Gets or sets policy for how namespace and files are recalled during
        /// FastDr. Possible values include: 'NamespaceOnly',
        /// 'NamespaceThenModifiedFiles', 'AvoidTieredFiles'
        /// </summary>
        [JsonProperty(PropertyName = "properties.initialDownloadPolicy")]
        public string InitialDownloadPolicy { get; set; }

        /// <summary>
        /// Gets or sets policy for enabling follow-the-sun business models:
        /// link local cache to cloud behavior to pre-populate before local
        /// access. Possible values include: 'DownloadNewAndModifiedFiles',
        /// 'UpdateLocallyCachedFiles'
        /// </summary>
        [JsonProperty(PropertyName = "properties.localCacheMode")]
        public string LocalCacheMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VolumeFreeSpacePercent > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "VolumeFreeSpacePercent", 100);
            }
            if (VolumeFreeSpacePercent < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "VolumeFreeSpacePercent", 0);
            }
            if (TierFilesOlderThanDays > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "TierFilesOlderThanDays", 2147483647);
            }
            if (TierFilesOlderThanDays < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TierFilesOlderThanDays", 0);
            }
        }
    }
}
