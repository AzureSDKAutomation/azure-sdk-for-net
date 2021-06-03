// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Virtual Network gateway contract. This is used to give the Virtual
    /// Network gateway access to the VPN package.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VnetGateway : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the VnetGateway class.
        /// </summary>
        public VnetGateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VnetGateway class.
        /// </summary>
        /// <param name="vpnPackageUri">The URI where the VPN package can be
        /// downloaded.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="vnetName">The Virtual Network name.</param>
        public VnetGateway(string vpnPackageUri, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string vnetName = default(string))
            : base(id, name, kind, type, systemData)
        {
            VnetName = vnetName;
            VpnPackageUri = vpnPackageUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Virtual Network name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// Gets or sets the URI where the VPN package can be downloaded.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnPackageUri")]
        public string VpnPackageUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VpnPackageUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VpnPackageUri");
            }
        }
    }
}
