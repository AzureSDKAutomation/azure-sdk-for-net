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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure specific enable protection input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HyperVReplicaAzure")]
    public partial class HyperVReplicaAzureEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureEnableProtectionInput class.
        /// </summary>
        public HyperVReplicaAzureEnableProtectionInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureEnableProtectionInput class.
        /// </summary>
        /// <param name="hvHostVmId">The Hyper-V host Vm Id.</param>
        /// <param name="vmName">The Vm Name.</param>
        /// <param name="osType">The OS type associated with vm.</param>
        /// <param name="vhdId">The OS disk VHD id associated with vm.</param>
        /// <param name="targetStorageAccountId">The storage account
        /// name.</param>
        /// <param name="targetAzureNetworkId">The selected target Azure
        /// network Id.</param>
        /// <param name="targetAzureSubnetId">The selected target Azure subnet
        /// Id.</param>
        /// <param name="enableRdpOnTargetOption">The selected option to enable
        /// RDP\SSH on target vm after failover. String value of
        /// {SrsDataContract.EnableRDPOnTargetOption} enum.</param>
        /// <param name="targetAzureVmName">The target azure Vm Name.</param>
        /// <param name="logStorageAccountId">The storage account to be used
        /// for logging during replication.</param>
        /// <param name="disksToInclude">The list of VHD IDs of disks to be
        /// protected.</param>
        /// <param name="targetAzureV1ResourceGroupId">The Id of the target
        /// resource group (for classic deployment) in which the failover VM is
        /// to be created.</param>
        /// <param name="targetAzureV2ResourceGroupId">The Id of the target
        /// resource group (for resource manager deployment) in which the
        /// failover VM is to be created.</param>
        /// <param name="useManagedDisks">A value indicating whether managed
        /// disks should be used during failover.</param>
        /// <param name="targetAvailabilityZone">The target availability
        /// zone.</param>
        /// <param name="targetProximityPlacementGroupId">The proximity
        /// placement group ARM Id.</param>
        public HyperVReplicaAzureEnableProtectionInput(string hvHostVmId = default(string), string vmName = default(string), string osType = default(string), string vhdId = default(string), string targetStorageAccountId = default(string), string targetAzureNetworkId = default(string), string targetAzureSubnetId = default(string), string enableRdpOnTargetOption = default(string), string targetAzureVmName = default(string), string logStorageAccountId = default(string), IList<string> disksToInclude = default(IList<string>), string targetAzureV1ResourceGroupId = default(string), string targetAzureV2ResourceGroupId = default(string), string useManagedDisks = default(string), string targetAvailabilityZone = default(string), string targetProximityPlacementGroupId = default(string))
        {
            HvHostVmId = hvHostVmId;
            VmName = vmName;
            OsType = osType;
            VhdId = vhdId;
            TargetStorageAccountId = targetStorageAccountId;
            TargetAzureNetworkId = targetAzureNetworkId;
            TargetAzureSubnetId = targetAzureSubnetId;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            TargetAzureVmName = targetAzureVmName;
            LogStorageAccountId = logStorageAccountId;
            DisksToInclude = disksToInclude;
            TargetAzureV1ResourceGroupId = targetAzureV1ResourceGroupId;
            TargetAzureV2ResourceGroupId = targetAzureV2ResourceGroupId;
            UseManagedDisks = useManagedDisks;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Hyper-V host Vm Id.
        /// </summary>
        [JsonProperty(PropertyName = "hvHostVmId")]
        public string HvHostVmId { get; set; }

        /// <summary>
        /// Gets or sets the Vm Name.
        /// </summary>
        [JsonProperty(PropertyName = "vmName")]
        public string VmName { get; set; }

        /// <summary>
        /// Gets or sets the OS type associated with vm.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the OS disk VHD id associated with vm.
        /// </summary>
        [JsonProperty(PropertyName = "vhdId")]
        public string VhdId { get; set; }

        /// <summary>
        /// Gets or sets the storage account name.
        /// </summary>
        [JsonProperty(PropertyName = "targetStorageAccountId")]
        public string TargetStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the selected target Azure network Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureNetworkId")]
        public string TargetAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the selected target Azure subnet Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureSubnetId")]
        public string TargetAzureSubnetId { get; set; }

        /// <summary>
        /// Gets or sets the selected option to enable RDP\SSH on target vm
        /// after failover. String value of
        /// {SrsDataContract.EnableRDPOnTargetOption} enum.
        /// </summary>
        [JsonProperty(PropertyName = "enableRdpOnTargetOption")]
        public string EnableRdpOnTargetOption { get; set; }

        /// <summary>
        /// Gets or sets the target azure Vm Name.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureVmName")]
        public string TargetAzureVmName { get; set; }

        /// <summary>
        /// Gets or sets the storage account to be used for logging during
        /// replication.
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountId")]
        public string LogStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the list of VHD IDs of disks to be protected.
        /// </summary>
        [JsonProperty(PropertyName = "disksToInclude")]
        public IList<string> DisksToInclude { get; set; }

        /// <summary>
        /// Gets or sets the Id of the target resource group (for classic
        /// deployment) in which the failover VM is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureV1ResourceGroupId")]
        public string TargetAzureV1ResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the target resource group (for resource
        /// manager deployment) in which the failover VM is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureV2ResourceGroupId")]
        public string TargetAzureV2ResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether managed disks should be
        /// used during failover.
        /// </summary>
        [JsonProperty(PropertyName = "useManagedDisks")]
        public string UseManagedDisks { get; set; }

        /// <summary>
        /// Gets or sets the target availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilityZone")]
        public string TargetAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the proximity placement group ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetProximityPlacementGroupId")]
        public string TargetProximityPlacementGroupId { get; set; }

    }
}
