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
    /// Target portal group properties for create or update iSCSI target
    /// request.
    /// </summary>
    public partial class TargetPortalGroupCreate
    {
        /// <summary>
        /// Initializes a new instance of the TargetPortalGroupCreate class.
        /// </summary>
        public TargetPortalGroupCreate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TargetPortalGroupCreate class.
        /// </summary>
        /// <param name="luns">List of LUNs to be exposed through the iSCSI
        /// target portal group.</param>
        /// <param name="acls">Access Control List (ACL) for an iSCSI target
        /// portal group.</param>
        /// <param name="attributes">Attributes of an iSCSI target portal
        /// group.</param>
        public TargetPortalGroupCreate(IList<IscsiLun> luns, IList<Acl> acls, Attributes attributes)
        {
            Luns = luns;
            Acls = acls;
            Attributes = attributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of LUNs to be exposed through the iSCSI target
        /// portal group.
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

    }
}
