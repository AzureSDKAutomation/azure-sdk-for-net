// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StoragePool.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response properties for iSCSI target portal group.
    /// </summary>
    public partial class TargetPortalGroup
    {
        /// <summary>
        /// Initializes a new instance of the TargetPortalGroup class.
        /// </summary>
        public TargetPortalGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TargetPortalGroup class.
        /// </summary>
        /// <param name="luns">List of LUNs to be exposed through iSCSI target
        /// portal group.</param>
        /// <param name="acls">Access Control List (ACL) for an iSCSI target
        /// portal group.</param>
        /// <param name="attributes">Attributes of an iSCSI target portal
        /// group.</param>
        /// <param name="endpoints">List of private IPv4 addresses to connect
        /// to the iSCSI target.</param>
        /// <param name="tag">The tag associated with the iSCSI target portal
        /// group.</param>
        /// <param name="port">The port used by iSCSI target portal
        /// group.</param>
        public TargetPortalGroup(IList<IscsiLun> luns, IList<Acl> acls, Attributes attributes, IList<string> endpoints, int tag, int port)
        {
            Luns = luns;
            Acls = acls;
            Attributes = attributes;
            Endpoints = endpoints;
            Tag = tag;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of LUNs to be exposed through iSCSI target portal
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "luns")]
        public IList<IscsiLun> Luns { get; set; }

        /// <summary>
        /// Gets or sets access Control List (ACL) for an iSCSI target portal
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "acls")]
        public IList<Acl> Acls { get; set; }

        /// <summary>
        /// Gets or sets attributes of an iSCSI target portal group.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets list of private IPv4 addresses to connect to the iSCSI
        /// target.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<string> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets the tag associated with the iSCSI target portal group.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public int Tag { get; set; }

        /// <summary>
        /// Gets or sets the port used by iSCSI target portal group.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int Port { get; set; }

    }
}
