// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hyper-V Managed disk details.
    /// </summary>
    public partial class HyperVReplicaAzureManagedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureManagedDiskDetails class.
        /// </summary>
        public HyperVReplicaAzureManagedDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureManagedDiskDetails class.
        /// </summary>
        /// <param name="diskId">The disk Id.</param>
        /// <param name="seedManagedDiskId">Seed managed disk Id.</param>
        /// <param name="replicaDiskType">The replica disk type.</param>
        /// <param name="diskEncryptionSetId">The disk encryption set ARM
        /// Id.</param>
        /// <param name="targetDiskName">The name for the target managed
        /// disk.</param>
        public HyperVReplicaAzureManagedDiskDetails(string diskId = default(string), string seedManagedDiskId = default(string), string replicaDiskType = default(string), string diskEncryptionSetId = default(string), string targetDiskName = default(string))
        {
            DiskId = diskId;
            SeedManagedDiskId = seedManagedDiskId;
            ReplicaDiskType = replicaDiskType;
            DiskEncryptionSetId = diskEncryptionSetId;
            TargetDiskName = targetDiskName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk Id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets seed managed disk Id.
        /// </summary>
        [JsonProperty(PropertyName = "seedManagedDiskId")]
        public string SeedManagedDiskId { get; set; }

        /// <summary>
        /// Gets or sets the replica disk type.
        /// </summary>
        [JsonProperty(PropertyName = "replicaDiskType")]
        public string ReplicaDiskType { get; set; }

        /// <summary>
        /// Gets or sets the disk encryption set ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionSetId")]
        public string DiskEncryptionSetId { get; set; }

        /// <summary>
        /// Gets or sets the name for the target managed disk.
        /// </summary>
        [JsonProperty(PropertyName = "targetDiskName")]
        public string TargetDiskName { get; set; }

    }
}
