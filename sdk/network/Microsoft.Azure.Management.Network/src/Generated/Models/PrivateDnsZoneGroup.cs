// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Private dns zone group resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateDnsZoneGroup : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateDnsZoneGroup class.
        /// </summary>
        public PrivateDnsZoneGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateDnsZoneGroup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// private dns zone group resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="privateDnsZoneConfigs">A collection of private dns
        /// zone configurations of the private dns zone group.</param>
        public PrivateDnsZoneGroup(string id = default(string), string name = default(string), string etag = default(string), string provisioningState = default(string), IList<PrivateDnsZoneConfig> privateDnsZoneConfigs = default(IList<PrivateDnsZoneConfig>))
            : base(id)
        {
            Name = name;
            Etag = etag;
            ProvisioningState = provisioningState;
            PrivateDnsZoneConfigs = privateDnsZoneConfigs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the private dns zone group resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets a collection of private dns zone configurations of the
        /// private dns zone group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateDnsZoneConfigs")]
        public IList<PrivateDnsZoneConfig> PrivateDnsZoneConfigs { get; set; }

    }
}
