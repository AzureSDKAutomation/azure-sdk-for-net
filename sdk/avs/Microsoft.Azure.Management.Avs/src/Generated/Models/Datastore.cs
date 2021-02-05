// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A datastore resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Datastore : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Datastore class.
        /// </summary>
        public Datastore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Datastore class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="provisioningState">The state of the datastore
        /// provisioning. Possible values include: 'Succeeded', 'Failed',
        /// 'Cancelled', 'Deleting', 'Updating'</param>
        /// <param name="netAppVolume">Resource ID of the Azure NetApp Files
        /// volume</param>
        /// <param name="diskPoolVolume">Resource ID of the iSCSI target from a
        /// Storage Pool and LUN to be used</param>
        public Datastore(string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string), NetAppVolumeProperties netAppVolume = default(NetAppVolumeProperties), DiskPoolVolumeProperties diskPoolVolume = default(DiskPoolVolumeProperties))
            : base(id, name, type)
        {
            ProvisioningState = provisioningState;
            NetAppVolume = netAppVolume;
            DiskPoolVolume = diskPoolVolume;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the state of the datastore provisioning. Possible values
        /// include: 'Succeeded', 'Failed', 'Cancelled', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets resource ID of the Azure NetApp Files volume
        /// </summary>
        [JsonProperty(PropertyName = "properties.netAppVolume")]
        public NetAppVolumeProperties NetAppVolume { get; set; }

        /// <summary>
        /// Gets or sets resource ID of the iSCSI target from a Storage Pool
        /// and LUN to be used
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskPoolVolume")]
        public DiskPoolVolumeProperties DiskPoolVolume { get; set; }

    }
}
