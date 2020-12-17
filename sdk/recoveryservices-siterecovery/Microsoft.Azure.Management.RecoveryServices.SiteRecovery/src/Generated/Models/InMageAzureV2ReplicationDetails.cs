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
    /// InMageAzureV2 provider specific settings
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageAzureV2")]
    public partial class InMageAzureV2ReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the InMageAzureV2ReplicationDetails
        /// class.
        /// </summary>
        public InMageAzureV2ReplicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageAzureV2ReplicationDetails
        /// class.
        /// </summary>
        /// <param name="infrastructureVmId">The infrastructure VM Id.</param>
        /// <param name="vCenterInfrastructureId">The vCenter infrastructure
        /// Id.</param>
        /// <param name="protectionStage">The protection stage.</param>
        /// <param name="vmId">The virtual machine Id.</param>
        /// <param name="vmProtectionState">The protection state for the
        /// vm.</param>
        /// <param name="vmProtectionStateDescription">The protection state
        /// description for the vm.</param>
        /// <param name="resyncProgressPercentage">The resync progress
        /// percentage.</param>
        /// <param name="rpoInSeconds">The RPO in seconds.</param>
        /// <param name="compressedDataRateInMB">The compressed data change
        /// rate in MB.</param>
        /// <param name="uncompressedDataRateInMB">The uncompressed data change
        /// rate in MB.</param>
        /// <param name="ipAddress">The source IP address.</param>
        /// <param name="agentVersion">The agent version.</param>
        /// <param name="agentExpiryDate">Agent expiry date.</param>
        /// <param name="isAgentUpdateRequired">A value indicating whether
        /// installed agent needs to be updated.</param>
        /// <param name="isRebootAfterUpdateRequired">A value indicating
        /// whether the source server requires a restart after update.</param>
        /// <param name="lastHeartbeat">The last heartbeat received from the
        /// source server.</param>
        /// <param name="processServerId">The process server Id.</param>
        /// <param name="processServerName">The process server name.</param>
        /// <param name="multiVmGroupId">The multi vm group Id.</param>
        /// <param name="multiVmGroupName">The multi vm group name.</param>
        /// <param name="multiVmSyncStatus">A value indicating whether multi vm
        /// sync is enabled or disabled.</param>
        /// <param name="protectedDisks">The list of protected disks.</param>
        /// <param name="diskResized">A value indicating whether any disk is
        /// resized for this VM.</param>
        /// <param name="masterTargetId">The master target Id.</param>
        /// <param name="sourceVmCpuCount">The CPU count of the VM on the
        /// primary side.</param>
        /// <param name="sourceVmRamSizeInMB">The RAM size of the VM on the
        /// primary side.</param>
        /// <param name="osType">The type of the OS on the VM.</param>
        /// <param name="vhdName">The OS disk VHD name.</param>
        /// <param name="osDiskId">The id of the disk containing the
        /// OS.</param>
        /// <param name="azureVMDiskDetails">Azure VM Disk details.</param>
        /// <param name="recoveryAzureVMName">Recovery Azure given
        /// name.</param>
        /// <param name="recoveryAzureVMSize">The Recovery Azure VM
        /// size.</param>
        /// <param name="recoveryAzureStorageAccount">The recovery Azure
        /// storage account.</param>
        /// <param name="recoveryAzureLogStorageAccountId">The ARM id of the
        /// log storage account used for replication. This will be set to null
        /// if no log storage account was provided during enable
        /// protection.</param>
        /// <param name="vmNics">The PE Network details.</param>
        /// <param name="selectedRecoveryAzureNetworkId">The selected recovery
        /// azure network Id.</param>
        /// <param name="selectedTfoAzureNetworkId">The test failover virtual
        /// network.</param>
        /// <param name="selectedSourceNicId">The selected source nic Id which
        /// will be used as the primary nic during failover.</param>
        /// <param name="discoveryType">A value indicating the discovery type
        /// of the machine. Value can be vCenter or physical.</param>
        /// <param name="enableRdpOnTargetOption">The selected option to enable
        /// RDP\SSH on target vm after failover. String value of
        /// {SrsDataContract.EnableRDPOnTargetOption} enum.</param>
        /// <param name="datastores">The data stores of the on-premise machine.
        /// Value can be list of strings that contain data store names.</param>
        /// <param name="targetVmId">The ARM Id of the target Azure VM. This
        /// value will be null until the VM is failed over. Only after failure
        /// it will be populated with the ARM Id of the Azure VM.</param>
        /// <param name="recoveryAzureResourceGroupId">The target resource
        /// group Id.</param>
        /// <param name="recoveryAvailabilitySetId">The recovery availability
        /// set Id.</param>
        /// <param name="targetAvailabilityZone">The target availability
        /// zone.</param>
        /// <param name="targetProximityPlacementGroupId">The target proximity
        /// placement group Id.</param>
        /// <param name="useManagedDisks">A value indicating whether managed
        /// disks should be used during failover.</param>
        /// <param name="licenseType">License Type of the VM to be
        /// used.</param>
        /// <param name="validationErrors">The validation errors of the
        /// on-premise machine Value can be list of validation errors.</param>
        /// <param name="lastRpoCalculatedTime">The last RPO calculated
        /// time.</param>
        /// <param name="lastUpdateReceivedTime">The last update time received
        /// from on-prem components.</param>
        /// <param name="replicaId">The replica id of the protected
        /// item.</param>
        /// <param name="osVersion">The OS Version of the protected
        /// item.</param>
        /// <param name="protectedManagedDisks">The list of protected managed
        /// disks.</param>
        /// <param name="targetVmTags">The target VM tags.</param>
        /// <param name="seedManagedDiskTags">The tags for the seed managed
        /// disks.</param>
        /// <param name="targetManagedDiskTags">The tags for the target managed
        /// disks.</param>
        /// <param name="targetNicTags">The tags for the target NICs.</param>
        public InMageAzureV2ReplicationDetails(string infrastructureVmId = default(string), string vCenterInfrastructureId = default(string), string protectionStage = default(string), string vmId = default(string), string vmProtectionState = default(string), string vmProtectionStateDescription = default(string), int? resyncProgressPercentage = default(int?), long? rpoInSeconds = default(long?), double? compressedDataRateInMB = default(double?), double? uncompressedDataRateInMB = default(double?), string ipAddress = default(string), string agentVersion = default(string), System.DateTime? agentExpiryDate = default(System.DateTime?), string isAgentUpdateRequired = default(string), string isRebootAfterUpdateRequired = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string processServerId = default(string), string processServerName = default(string), string multiVmGroupId = default(string), string multiVmGroupName = default(string), string multiVmSyncStatus = default(string), IList<InMageAzureV2ProtectedDiskDetails> protectedDisks = default(IList<InMageAzureV2ProtectedDiskDetails>), string diskResized = default(string), string masterTargetId = default(string), int? sourceVmCpuCount = default(int?), int? sourceVmRamSizeInMB = default(int?), string osType = default(string), string vhdName = default(string), string osDiskId = default(string), IList<AzureVmDiskDetails> azureVMDiskDetails = default(IList<AzureVmDiskDetails>), string recoveryAzureVMName = default(string), string recoveryAzureVMSize = default(string), string recoveryAzureStorageAccount = default(string), string recoveryAzureLogStorageAccountId = default(string), IList<VMNicDetails> vmNics = default(IList<VMNicDetails>), string selectedRecoveryAzureNetworkId = default(string), string selectedTfoAzureNetworkId = default(string), string selectedSourceNicId = default(string), string discoveryType = default(string), string enableRdpOnTargetOption = default(string), IList<string> datastores = default(IList<string>), string targetVmId = default(string), string recoveryAzureResourceGroupId = default(string), string recoveryAvailabilitySetId = default(string), string targetAvailabilityZone = default(string), string targetProximityPlacementGroupId = default(string), string useManagedDisks = default(string), string licenseType = default(string), IList<HealthError> validationErrors = default(IList<HealthError>), System.DateTime? lastRpoCalculatedTime = default(System.DateTime?), System.DateTime? lastUpdateReceivedTime = default(System.DateTime?), string replicaId = default(string), string osVersion = default(string), IList<InMageAzureV2ManagedDiskDetails> protectedManagedDisks = default(IList<InMageAzureV2ManagedDiskDetails>), IDictionary<string, string> targetVmTags = default(IDictionary<string, string>), IDictionary<string, string> seedManagedDiskTags = default(IDictionary<string, string>), IDictionary<string, string> targetManagedDiskTags = default(IDictionary<string, string>), IDictionary<string, string> targetNicTags = default(IDictionary<string, string>))
        {
            InfrastructureVmId = infrastructureVmId;
            VCenterInfrastructureId = vCenterInfrastructureId;
            ProtectionStage = protectionStage;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            ResyncProgressPercentage = resyncProgressPercentage;
            RpoInSeconds = rpoInSeconds;
            CompressedDataRateInMB = compressedDataRateInMB;
            UncompressedDataRateInMB = uncompressedDataRateInMB;
            IpAddress = ipAddress;
            AgentVersion = agentVersion;
            AgentExpiryDate = agentExpiryDate;
            IsAgentUpdateRequired = isAgentUpdateRequired;
            IsRebootAfterUpdateRequired = isRebootAfterUpdateRequired;
            LastHeartbeat = lastHeartbeat;
            ProcessServerId = processServerId;
            ProcessServerName = processServerName;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            MultiVmSyncStatus = multiVmSyncStatus;
            ProtectedDisks = protectedDisks;
            DiskResized = diskResized;
            MasterTargetId = masterTargetId;
            SourceVmCpuCount = sourceVmCpuCount;
            SourceVmRamSizeInMB = sourceVmRamSizeInMB;
            OsType = osType;
            VhdName = vhdName;
            OsDiskId = osDiskId;
            AzureVMDiskDetails = azureVMDiskDetails;
            RecoveryAzureVMName = recoveryAzureVMName;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            RecoveryAzureStorageAccount = recoveryAzureStorageAccount;
            RecoveryAzureLogStorageAccountId = recoveryAzureLogStorageAccountId;
            VmNics = vmNics;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            SelectedTfoAzureNetworkId = selectedTfoAzureNetworkId;
            SelectedSourceNicId = selectedSourceNicId;
            DiscoveryType = discoveryType;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            Datastores = datastores;
            TargetVmId = targetVmId;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            UseManagedDisks = useManagedDisks;
            LicenseType = licenseType;
            ValidationErrors = validationErrors;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            LastUpdateReceivedTime = lastUpdateReceivedTime;
            ReplicaId = replicaId;
            OsVersion = osVersion;
            ProtectedManagedDisks = protectedManagedDisks;
            TargetVmTags = targetVmTags;
            SeedManagedDiskTags = seedManagedDiskTags;
            TargetManagedDiskTags = targetManagedDiskTags;
            TargetNicTags = targetNicTags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the infrastructure VM Id.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureVmId")]
        public string InfrastructureVmId { get; set; }

        /// <summary>
        /// Gets or sets the vCenter infrastructure Id.
        /// </summary>
        [JsonProperty(PropertyName = "vCenterInfrastructureId")]
        public string VCenterInfrastructureId { get; set; }

        /// <summary>
        /// Gets or sets the protection stage.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStage")]
        public string ProtectionStage { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine Id.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets or sets the protection state for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionState")]
        public string VmProtectionState { get; set; }

        /// <summary>
        /// Gets or sets the protection state description for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionStateDescription")]
        public string VmProtectionStateDescription { get; set; }

        /// <summary>
        /// Gets or sets the resync progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressPercentage")]
        public int? ResyncProgressPercentage { get; set; }

        /// <summary>
        /// Gets or sets the RPO in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the compressed data change rate in MB.
        /// </summary>
        [JsonProperty(PropertyName = "compressedDataRateInMB")]
        public double? CompressedDataRateInMB { get; set; }

        /// <summary>
        /// Gets or sets the uncompressed data change rate in MB.
        /// </summary>
        [JsonProperty(PropertyName = "uncompressedDataRateInMB")]
        public double? UncompressedDataRateInMB { get; set; }

        /// <summary>
        /// Gets or sets the source IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets agent expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "agentExpiryDate")]
        public System.DateTime? AgentExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether installed agent needs to be
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "isAgentUpdateRequired")]
        public string IsAgentUpdateRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the source server requires
        /// a restart after update.
        /// </summary>
        [JsonProperty(PropertyName = "isRebootAfterUpdateRequired")]
        public string IsRebootAfterUpdateRequired { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from the source server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets the process server Id.
        /// </summary>
        [JsonProperty(PropertyName = "processServerId")]
        public string ProcessServerId { get; set; }

        /// <summary>
        /// Gets the process server name.
        /// </summary>
        [JsonProperty(PropertyName = "processServerName")]
        public string ProcessServerName { get; private set; }

        /// <summary>
        /// Gets or sets the multi vm group Id.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi vm sync is enabled or
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmSyncStatus")]
        public string MultiVmSyncStatus { get; set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<InMageAzureV2ProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether any disk is resized for
        /// this VM.
        /// </summary>
        [JsonProperty(PropertyName = "diskResized")]
        public string DiskResized { get; set; }

        /// <summary>
        /// Gets or sets the master target Id.
        /// </summary>
        [JsonProperty(PropertyName = "masterTargetId")]
        public string MasterTargetId { get; set; }

        /// <summary>
        /// Gets or sets the CPU count of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmCpuCount")]
        public int? SourceVmCpuCount { get; set; }

        /// <summary>
        /// Gets or sets the RAM size of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmRamSizeInMB")]
        public int? SourceVmRamSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the type of the OS on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the OS disk VHD name.
        /// </summary>
        [JsonProperty(PropertyName = "vhdName")]
        public string VhdName { get; set; }

        /// <summary>
        /// Gets or sets the id of the disk containing the OS.
        /// </summary>
        [JsonProperty(PropertyName = "osDiskId")]
        public string OsDiskId { get; set; }

        /// <summary>
        /// Gets or sets azure VM Disk details.
        /// </summary>
        [JsonProperty(PropertyName = "azureVMDiskDetails")]
        public IList<AzureVmDiskDetails> AzureVMDiskDetails { get; set; }

        /// <summary>
        /// Gets or sets recovery Azure given name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMName")]
        public string RecoveryAzureVMName { get; set; }

        /// <summary>
        /// Gets or sets the Recovery Azure VM size.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMSize")]
        public string RecoveryAzureVMSize { get; set; }

        /// <summary>
        /// Gets or sets the recovery Azure storage account.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureStorageAccount")]
        public string RecoveryAzureStorageAccount { get; set; }

        /// <summary>
        /// Gets or sets the ARM id of the log storage account used for
        /// replication. This will be set to null if no log storage account was
        /// provided during enable protection.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureLogStorageAccountId")]
        public string RecoveryAzureLogStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the PE Network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets or sets the selected recovery azure network Id.
        /// </summary>
        [JsonProperty(PropertyName = "selectedRecoveryAzureNetworkId")]
        public string SelectedRecoveryAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the test failover virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "selectedTfoAzureNetworkId")]
        public string SelectedTfoAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the selected source nic Id which will be used as the
        /// primary nic during failover.
        /// </summary>
        [JsonProperty(PropertyName = "selectedSourceNicId")]
        public string SelectedSourceNicId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the discovery type of the machine.
        /// Value can be vCenter or physical.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryType")]
        public string DiscoveryType { get; set; }

        /// <summary>
        /// Gets or sets the selected option to enable RDP\SSH on target vm
        /// after failover. String value of
        /// {SrsDataContract.EnableRDPOnTargetOption} enum.
        /// </summary>
        [JsonProperty(PropertyName = "enableRdpOnTargetOption")]
        public string EnableRdpOnTargetOption { get; set; }

        /// <summary>
        /// Gets or sets the data stores of the on-premise machine. Value can
        /// be list of strings that contain data store names.
        /// </summary>
        [JsonProperty(PropertyName = "datastores")]
        public IList<string> Datastores { get; set; }

        /// <summary>
        /// Gets or sets the ARM Id of the target Azure VM. This value will be
        /// null until the VM is failed over. Only after failure it will be
        /// populated with the ARM Id of the Azure VM.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmId")]
        public string TargetVmId { get; set; }

        /// <summary>
        /// Gets or sets the target resource group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureResourceGroupId")]
        public string RecoveryAzureResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the recovery availability set Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilitySetId")]
        public string RecoveryAvailabilitySetId { get; set; }

        /// <summary>
        /// Gets or sets the target availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilityZone")]
        public string TargetAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the target proximity placement group Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetProximityPlacementGroupId")]
        public string TargetProximityPlacementGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether managed disks should be
        /// used during failover.
        /// </summary>
        [JsonProperty(PropertyName = "useManagedDisks")]
        public string UseManagedDisks { get; set; }

        /// <summary>
        /// Gets or sets license Type of the VM to be used.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the validation errors of the on-premise machine Value
        /// can be list of validation errors.
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<HealthError> ValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets the last RPO calculated time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRpoCalculatedTime")]
        public System.DateTime? LastRpoCalculatedTime { get; set; }

        /// <summary>
        /// Gets or sets the last update time received from on-prem components.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateReceivedTime")]
        public System.DateTime? LastUpdateReceivedTime { get; set; }

        /// <summary>
        /// Gets or sets the replica id of the protected item.
        /// </summary>
        [JsonProperty(PropertyName = "replicaId")]
        public string ReplicaId { get; set; }

        /// <summary>
        /// Gets or sets the OS Version of the protected item.
        /// </summary>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or sets the list of protected managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedManagedDisks")]
        public IList<InMageAzureV2ManagedDiskDetails> ProtectedManagedDisks { get; set; }

        /// <summary>
        /// Gets or sets the target VM tags.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmTags")]
        public IDictionary<string, string> TargetVmTags { get; set; }

        /// <summary>
        /// Gets or sets the tags for the seed managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "seedManagedDiskTags")]
        public IDictionary<string, string> SeedManagedDiskTags { get; set; }

        /// <summary>
        /// Gets or sets the tags for the target managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "targetManagedDiskTags")]
        public IDictionary<string, string> TargetManagedDiskTags { get; set; }

        /// <summary>
        /// Gets or sets the tags for the target NICs.
        /// </summary>
        [JsonProperty(PropertyName = "targetNicTags")]
        public IDictionary<string, string> TargetNicTags { get; set; }

    }
}
