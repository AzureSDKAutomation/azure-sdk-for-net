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
    /// Server Endpoint object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerEndpoint : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpoint class.
        /// </summary>
        public ServerEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpoint class.
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
        /// <param name="provisioningState">ServerEndpoint Provisioning
        /// State</param>
        /// <param name="lastWorkflowId">ServerEndpoint lastWorkflowId</param>
        /// <param name="lastOperationName">Resource Last Operation
        /// Name</param>
        /// <param name="syncStatus">Server Endpoint sync status</param>
        /// <param name="offlineDataTransfer">Offline data transfer. Possible
        /// values include: 'on', 'off'</param>
        /// <param name="offlineDataTransferStorageAccountResourceId">Offline
        /// data transfer storage account resource ID</param>
        /// <param name="offlineDataTransferStorageAccountTenantId">Offline
        /// data transfer storage account tenant ID</param>
        /// <param name="offlineDataTransferShareName">Offline data transfer
        /// share name</param>
        /// <param name="cloudTieringStatus">Cloud tiering status. Only
        /// populated if cloud tiering is enabled.</param>
        /// <param name="recallStatus">Recall status. Only populated if cloud
        /// tiering is enabled.</param>
        /// <param name="initialDownloadPolicy">Policy for how namespace and
        /// files are recalled during FastDr. Possible values include:
        /// 'NamespaceOnly', 'NamespaceThenModifiedFiles',
        /// 'AvoidTieredFiles'</param>
        /// <param name="localCacheMode">Policy for enabling follow-the-sun
        /// business models: link local cache to cloud behavior to pre-populate
        /// before local access. Possible values include:
        /// 'DownloadNewAndModifiedFiles', 'UpdateLocallyCachedFiles'</param>
        /// <param name="serverName">Server name</param>
        public ServerEndpoint(string id = default(string), string name = default(string), string type = default(string), string serverLocalPath = default(string), string cloudTiering = default(string), int? volumeFreeSpacePercent = default(int?), int? tierFilesOlderThanDays = default(int?), string friendlyName = default(string), string serverResourceId = default(string), string provisioningState = default(string), string lastWorkflowId = default(string), string lastOperationName = default(string), ServerEndpointSyncStatus syncStatus = default(ServerEndpointSyncStatus), string offlineDataTransfer = default(string), string offlineDataTransferStorageAccountResourceId = default(string), string offlineDataTransferStorageAccountTenantId = default(string), string offlineDataTransferShareName = default(string), ServerEndpointCloudTieringStatus cloudTieringStatus = default(ServerEndpointCloudTieringStatus), ServerEndpointRecallStatus recallStatus = default(ServerEndpointRecallStatus), string initialDownloadPolicy = default(string), string localCacheMode = default(string), string serverName = default(string))
            : base(id, name, type)
        {
            ServerLocalPath = serverLocalPath;
            CloudTiering = cloudTiering;
            VolumeFreeSpacePercent = volumeFreeSpacePercent;
            TierFilesOlderThanDays = tierFilesOlderThanDays;
            FriendlyName = friendlyName;
            ServerResourceId = serverResourceId;
            ProvisioningState = provisioningState;
            LastWorkflowId = lastWorkflowId;
            LastOperationName = lastOperationName;
            SyncStatus = syncStatus;
            OfflineDataTransfer = offlineDataTransfer;
            OfflineDataTransferStorageAccountResourceId = offlineDataTransferStorageAccountResourceId;
            OfflineDataTransferStorageAccountTenantId = offlineDataTransferStorageAccountTenantId;
            OfflineDataTransferShareName = offlineDataTransferShareName;
            CloudTieringStatus = cloudTieringStatus;
            RecallStatus = recallStatus;
            InitialDownloadPolicy = initialDownloadPolicy;
            LocalCacheMode = localCacheMode;
            ServerName = serverName;
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
        /// Gets serverEndpoint Provisioning State
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets serverEndpoint lastWorkflowId
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastWorkflowId")]
        public string LastWorkflowId { get; private set; }

        /// <summary>
        /// Gets resource Last Operation Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastOperationName")]
        public string LastOperationName { get; private set; }

        /// <summary>
        /// Gets server Endpoint sync status
        /// </summary>
        [JsonProperty(PropertyName = "properties.syncStatus")]
        public ServerEndpointSyncStatus SyncStatus { get; private set; }

        /// <summary>
        /// Gets or sets offline data transfer. Possible values include: 'on',
        /// 'off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.offlineDataTransfer")]
        public string OfflineDataTransfer { get; set; }

        /// <summary>
        /// Gets offline data transfer storage account resource ID
        /// </summary>
        [JsonProperty(PropertyName = "properties.offlineDataTransferStorageAccountResourceId")]
        public string OfflineDataTransferStorageAccountResourceId { get; private set; }

        /// <summary>
        /// Gets offline data transfer storage account tenant ID
        /// </summary>
        [JsonProperty(PropertyName = "properties.offlineDataTransferStorageAccountTenantId")]
        public string OfflineDataTransferStorageAccountTenantId { get; private set; }

        /// <summary>
        /// Gets or sets offline data transfer share name
        /// </summary>
        [JsonProperty(PropertyName = "properties.offlineDataTransferShareName")]
        public string OfflineDataTransferShareName { get; set; }

        /// <summary>
        /// Gets cloud tiering status. Only populated if cloud tiering is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cloudTieringStatus")]
        public ServerEndpointCloudTieringStatus CloudTieringStatus { get; private set; }

        /// <summary>
        /// Gets recall status. Only populated if cloud tiering is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recallStatus")]
        public ServerEndpointRecallStatus RecallStatus { get; private set; }

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
        /// Gets server name
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverName")]
        public string ServerName { get; private set; }

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
            if (SyncStatus != null)
            {
                SyncStatus.Validate();
            }
            if (CloudTieringStatus != null)
            {
                CloudTieringStatus.Validate();
            }
            if (RecallStatus != null)
            {
                RecallStatus.Validate();
            }
        }
    }
}
