// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Disk update resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiskUpdate
    {
        /// <summary>
        /// Initializes a new instance of the DiskUpdate class.
        /// </summary>
        public DiskUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskUpdate class.
        /// </summary>
        /// <param name="osType">the Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="diskSizeGB">If creationData.createOption is Empty,
        /// this field is mandatory and it indicates the size of the disk to
        /// create. If this field is present for updates or creation with other
        /// options, it indicates a resize. Resizes are only allowed if the
        /// disk is not attached to a running VM, and can only increase the
        /// disk's size.</param>
        /// <param name="encryptionSettingsCollection">Encryption settings
        /// collection used be Azure Disk Encryption, can contain multiple
        /// encryption settings per disk or snapshot.</param>
        /// <param name="diskIOPSReadWrite">The number of IOPS allowed for this
        /// disk; only settable for UltraSSD disks. One operation can transfer
        /// between 4k and 256k bytes.</param>
        /// <param name="diskMBpsReadWrite">The bandwidth allowed for this
        /// disk; only settable for UltraSSD disks. MBps means millions of
        /// bytes per second - MB here uses the ISO notation, of powers of
        /// 10.</param>
        /// <param name="diskIOPSReadOnly">The total number of IOPS that will
        /// be allowed across all VMs mounting the shared disk as ReadOnly. One
        /// operation can transfer between 4k and 256k bytes.</param>
        /// <param name="diskMBpsReadOnly">The total throughput (MBps) that
        /// will be allowed across all VMs mounting the shared disk as
        /// ReadOnly. MBps means millions of bytes per second - MB here uses
        /// the ISO notation, of powers of 10.</param>
        /// <param name="maxShares">The maximum number of VMs that can attach
        /// to the disk at the same time. Value greater than one indicates a
        /// disk that can be mounted on multiple VMs at the same time.</param>
        /// <param name="encryption">Encryption property can be used to encrypt
        /// data at rest with customer managed keys or platform managed
        /// keys.</param>
        /// <param name="networkAccessPolicy">Possible values include:
        /// 'AllowAll', 'AllowPrivate', 'DenyAll'</param>
        /// <param name="publicNetworkAccess">Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="diskAccessId">ARM id of the DiskAccess resource for
        /// using private endpoints on disks.</param>
        /// <param name="tier">Performance tier of the disk (e.g, P4, S10) as
        /// described here:
        /// https://azure.microsoft.com/en-us/pricing/details/managed-disks/.
        /// Does not apply to Ultra disks.</param>
        /// <param name="burstingEnabled">Set to true to enable bursting beyond
        /// the provisioned performance target of the disk. Bursting is
        /// disabled by default. Does not apply to Ultra disks.</param>
        /// <param name="purchasePlan">Purchase plan information to be added on
        /// the OS disk</param>
        /// <param name="propertyUpdatesInProgress">Properties of the disk for
        /// which update is pending.</param>
        /// <param name="supportsHibernation">Indicates the OS on a disk
        /// supports hibernation.</param>
        /// <param name="tags">Resource tags</param>
        public DiskUpdate(OperatingSystemTypes? osType = default(OperatingSystemTypes?), int? diskSizeGB = default(int?), EncryptionSettingsCollection encryptionSettingsCollection = default(EncryptionSettingsCollection), long? diskIOPSReadWrite = default(long?), long? diskMBpsReadWrite = default(long?), long? diskIOPSReadOnly = default(long?), long? diskMBpsReadOnly = default(long?), int? maxShares = default(int?), Encryption encryption = default(Encryption), string networkAccessPolicy = default(string), string publicNetworkAccess = default(string), string diskAccessId = default(string), string tier = default(string), bool? burstingEnabled = default(bool?), PurchasePlan purchasePlan = default(PurchasePlan), PropertyUpdatesInProgress propertyUpdatesInProgress = default(PropertyUpdatesInProgress), bool? supportsHibernation = default(bool?), IDictionary<string, string> tags = default(IDictionary<string, string>), DiskSku sku = default(DiskSku))
        {
            OsType = osType;
            DiskSizeGB = diskSizeGB;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            DiskIOPSReadWrite = diskIOPSReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DiskIOPSReadOnly = diskIOPSReadOnly;
            DiskMBpsReadOnly = diskMBpsReadOnly;
            MaxShares = maxShares;
            Encryption = encryption;
            NetworkAccessPolicy = networkAccessPolicy;
            PublicNetworkAccess = publicNetworkAccess;
            DiskAccessId = diskAccessId;
            Tier = tier;
            BurstingEnabled = burstingEnabled;
            PurchasePlan = purchasePlan;
            PropertyUpdatesInProgress = propertyUpdatesInProgress;
            SupportsHibernation = supportsHibernation;
            Tags = tags;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets if creationData.createOption is Empty, this field is
        /// mandatory and it indicates the size of the disk to create. If this
        /// field is present for updates or creation with other options, it
        /// indicates a resize. Resizes are only allowed if the disk is not
        /// attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets encryption settings collection used be Azure Disk
        /// Encryption, can contain multiple encryption settings per disk or
        /// snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionSettingsCollection")]
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }

        /// <summary>
        /// Gets or sets the number of IOPS allowed for this disk; only
        /// settable for UltraSSD disks. One operation can transfer between 4k
        /// and 256k bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskIOPSReadWrite")]
        public long? DiskIOPSReadWrite { get; set; }

        /// <summary>
        /// Gets or sets the bandwidth allowed for this disk; only settable for
        /// UltraSSD disks. MBps means millions of bytes per second - MB here
        /// uses the ISO notation, of powers of 10.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskMBpsReadWrite")]
        public long? DiskMBpsReadWrite { get; set; }

        /// <summary>
        /// Gets or sets the total number of IOPS that will be allowed across
        /// all VMs mounting the shared disk as ReadOnly. One operation can
        /// transfer between 4k and 256k bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskIOPSReadOnly")]
        public long? DiskIOPSReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the total throughput (MBps) that will be allowed
        /// across all VMs mounting the shared disk as ReadOnly. MBps means
        /// millions of bytes per second - MB here uses the ISO notation, of
        /// powers of 10.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskMBpsReadOnly")]
        public long? DiskMBpsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of VMs that can attach to the disk
        /// at the same time. Value greater than one indicates a disk that can
        /// be mounted on multiple VMs at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxShares")]
        public int? MaxShares { get; set; }

        /// <summary>
        /// Gets or sets encryption property can be used to encrypt data at
        /// rest with customer managed keys or platform managed keys.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'AllowAll', 'AllowPrivate',
        /// 'DenyAll'
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAccessPolicy")]
        public string NetworkAccessPolicy { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets ARM id of the DiskAccess resource for using private
        /// endpoints on disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskAccessId")]
        public string DiskAccessId { get; set; }

        /// <summary>
        /// Gets or sets performance tier of the disk (e.g, P4, S10) as
        /// described here:
        /// https://azure.microsoft.com/en-us/pricing/details/managed-disks/.
        /// Does not apply to Ultra disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets set to true to enable bursting beyond the provisioned
        /// performance target of the disk. Bursting is disabled by default.
        /// Does not apply to Ultra disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.burstingEnabled")]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// Gets or sets purchase plan information to be added on the OS disk
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchasePlan")]
        public PurchasePlan PurchasePlan { get; set; }

        /// <summary>
        /// Gets properties of the disk for which update is pending.
        /// </summary>
        [JsonProperty(PropertyName = "properties.propertyUpdatesInProgress")]
        public PropertyUpdatesInProgress PropertyUpdatesInProgress { get; private set; }

        /// <summary>
        /// Gets or sets indicates the OS on a disk supports hibernation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHibernation")]
        public bool? SupportsHibernation { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public DiskSku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptionSettingsCollection != null)
            {
                EncryptionSettingsCollection.Validate();
            }
            if (PurchasePlan != null)
            {
                PurchasePlan.Validate();
            }
        }
    }
}
