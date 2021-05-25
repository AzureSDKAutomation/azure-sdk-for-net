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
    using System.Linq;

    /// <summary>
    /// An IP Configuration of the private endpoint.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateEndpointIPConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpointIPConfiguration
        /// class.
        /// </summary>
        public PrivateEndpointIPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpointIPConfiguration
        /// class.
        /// </summary>
        /// <param name="groupId">The ID of a group obtained from the remote
        /// resource that this private endpoint should connect to.</param>
        /// <param name="memberName">The member name of a group obtained from
        /// the remote resource that this private endpoint should connect
        /// to.</param>
        /// <param name="privateIPAddress">A private ip address obtained from
        /// the private endpoint's subnet.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group.</param>
        public PrivateEndpointIPConfiguration(string groupId = default(string), string memberName = default(string), string privateIPAddress = default(string), string name = default(string))
        {
            GroupId = groupId;
            MemberName = memberName;
            PrivateIPAddress = privateIPAddress;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of a group obtained from the remote resource
        /// that this private endpoint should connect to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the member name of a group obtained from the remote
        /// resource that this private endpoint should connect to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.memberName")]
        public string MemberName { get; set; }

        /// <summary>
        /// Gets or sets a private ip address obtained from the private
        /// endpoint's subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
