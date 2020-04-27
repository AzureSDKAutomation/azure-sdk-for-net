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
    /// PrivateLink Resource configuration of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayPrivateLinkResource : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayPrivateLinkResource class.
        /// </summary>
        public ApplicationGatewayPrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayPrivateLinkResource class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="subnet">Reference to the subnet resource. A subnet is
        /// needed to support private link on application gateway.</param>
        /// <param name="ipAddressesToAllocate">Number of ip addresses to
        /// allocate from the private link resource subnet. Default is
        /// 1.</param>
        /// <param name="groupId">Group id is the identifier for private link
        /// resource. Use the identifier when creating or updating private
        /// endpoint connection.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// application gateway private link resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">Name of the private link resource that is unique
        /// within an Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayPrivateLinkResource(string id = default(string), SubResource subnet = default(SubResource), int? ipAddressesToAllocate = default(int?), string groupId = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Subnet = subnet;
            IpAddressesToAllocate = ipAddressesToAllocate;
            GroupId = groupId;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference to the subnet resource. A subnet is needed
        /// to support private link on application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets number of ip addresses to allocate from the private
        /// link resource subnet. Default is 1.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddressesToAllocate")]
        public int? IpAddressesToAllocate { get; set; }

        /// <summary>
        /// Gets group id is the identifier for private link resource. Use the
        /// identifier when creating or updating private endpoint connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the application gateway private link
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the private link resource that is unique
        /// within an Application Gateway.
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
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IpAddressesToAllocate > 8)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "IpAddressesToAllocate", 8);
            }
            if (IpAddressesToAllocate < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "IpAddressesToAllocate", 1);
            }
        }
    }
}
