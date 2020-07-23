// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The share mount point.
    /// </summary>
    public partial class MountPointMap
    {
        /// <summary>
        /// Initializes a new instance of the MountPointMap class.
        /// </summary>
        public MountPointMap()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MountPointMap class.
        /// </summary>
        /// <param name="shareId">ID of the share mounted to the role
        /// VM.</param>
        /// <param name="roleId">ID of the role to which share is
        /// mounted.</param>
        /// <param name="mountPoint">Mount point for the share.</param>
        /// <param name="mountType">Mounting type. Possible values include:
        /// 'Volume', 'HostPath'</param>
        /// <param name="roleType">Role type. Possible values include: 'IOT',
        /// 'ASA', 'Functions', 'Cognitive'</param>
        public MountPointMap(string shareId, string roleId = default(string), string mountPoint = default(string), string mountType = default(string), string roleType = default(string))
        {
            ShareId = shareId;
            RoleId = roleId;
            MountPoint = mountPoint;
            MountType = mountType;
            RoleType = roleType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the share mounted to the role VM.
        /// </summary>
        [JsonProperty(PropertyName = "shareId")]
        public string ShareId { get; set; }

        /// <summary>
        /// Gets ID of the role to which share is mounted.
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        public string RoleId { get; private set; }

        /// <summary>
        /// Gets mount point for the share.
        /// </summary>
        [JsonProperty(PropertyName = "mountPoint")]
        public string MountPoint { get; private set; }

        /// <summary>
        /// Gets mounting type. Possible values include: 'Volume', 'HostPath'
        /// </summary>
        [JsonProperty(PropertyName = "mountType")]
        public string MountType { get; private set; }

        /// <summary>
        /// Gets role type. Possible values include: 'IOT', 'ASA', 'Functions',
        /// 'Cognitive'
        /// </summary>
        [JsonProperty(PropertyName = "roleType")]
        public string RoleType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShareId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShareId");
            }
        }
    }
}
