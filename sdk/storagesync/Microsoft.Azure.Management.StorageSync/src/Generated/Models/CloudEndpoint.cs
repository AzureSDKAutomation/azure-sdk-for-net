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
    /// Cloud Endpoint object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CloudEndpoint : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the CloudEndpoint class.
        /// </summary>
        public CloudEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudEndpoint class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="storageAccountResourceId">Storage Account Resource
        /// Id</param>
        /// <param name="azureFileShareName">Azure file share name</param>
        /// <param name="storageAccountTenantId">Storage Account Tenant
        /// Id</param>
        /// <param name="partnershipId">Partnership Id</param>
        /// <param name="friendlyName">Friendly Name</param>
        /// <param name="backupEnabled">Backup Enabled</param>
        /// <param name="provisioningState">CloudEndpoint Provisioning
        /// State</param>
        /// <param name="lastWorkflowId">CloudEndpoint lastWorkflowId</param>
        /// <param name="lastOperationName">Resource Last Operation
        /// Name</param>
        /// <param name="changeEnumerationStatus">Cloud endpoint change
        /// enumeration status</param>
        public CloudEndpoint(string id = default(string), string name = default(string), string type = default(string), string storageAccountResourceId = default(string), string azureFileShareName = default(string), string storageAccountTenantId = default(string), string partnershipId = default(string), string friendlyName = default(string), string backupEnabled = default(string), string provisioningState = default(string), string lastWorkflowId = default(string), string lastOperationName = default(string), CloudEndpointChangeEnumerationStatus changeEnumerationStatus = default(CloudEndpointChangeEnumerationStatus))
            : base(id, name, type)
        {
            StorageAccountResourceId = storageAccountResourceId;
            AzureFileShareName = azureFileShareName;
            StorageAccountTenantId = storageAccountTenantId;
            PartnershipId = partnershipId;
            FriendlyName = friendlyName;
            BackupEnabled = backupEnabled;
            ProvisioningState = provisioningState;
            LastWorkflowId = lastWorkflowId;
            LastOperationName = lastOperationName;
            ChangeEnumerationStatus = changeEnumerationStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage Account Resource Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountResourceId")]
        public string StorageAccountResourceId { get; set; }

        /// <summary>
        /// Gets or sets azure file share name
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureFileShareName")]
        public string AzureFileShareName { get; set; }

        /// <summary>
        /// Gets or sets storage Account Tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountTenantId")]
        public string StorageAccountTenantId { get; set; }

        /// <summary>
        /// Gets or sets partnership Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnershipId")]
        public string PartnershipId { get; set; }

        /// <summary>
        /// Gets or sets friendly Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets backup Enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupEnabled")]
        public string BackupEnabled { get; private set; }

        /// <summary>
        /// Gets or sets cloudEndpoint Provisioning State
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets cloudEndpoint lastWorkflowId
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastWorkflowId")]
        public string LastWorkflowId { get; set; }

        /// <summary>
        /// Gets or sets resource Last Operation Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastOperationName")]
        public string LastOperationName { get; set; }

        /// <summary>
        /// Gets cloud endpoint change enumeration status
        /// </summary>
        [JsonProperty(PropertyName = "properties.changeEnumerationStatus")]
        public CloudEndpointChangeEnumerationStatus ChangeEnumerationStatus { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ChangeEnumerationStatus != null)
            {
                ChangeEnumerationStatus.Validate();
            }
        }
    }
}
