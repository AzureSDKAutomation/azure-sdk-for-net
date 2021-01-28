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
    /// Describes a virtual machine scale set network profile's network
    /// configurations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetNetworkConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetNetworkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkConfiguration class.
        /// </summary>
        /// <param name="name">The network configuration name.</param>
        /// <param name="ipConfigurations">Specifies the IP configurations of
        /// the network interface.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="primary">Specifies the primary network interface in
        /// case the virtual machine has more than 1 network interface.</param>
        /// <param name="enableAcceleratedNetworking">Specifies whether the
        /// network interface is accelerated networking-enabled.</param>
        /// <param name="networkSecurityGroup">The network security
        /// group.</param>
        /// <param name="dnsSettings">The dns settings to be applied on the
        /// network interfaces.</param>
        /// <param name="enableIPForwarding">Whether IP forwarding enabled on
        /// this NIC.</param>
        public VirtualMachineScaleSetNetworkConfiguration(string name, IList<VirtualMachineScaleSetIPConfiguration> ipConfigurations, string id = default(string), bool? primary = default(bool?), bool? enableAcceleratedNetworking = default(bool?), SubResource networkSecurityGroup = default(SubResource), VirtualMachineScaleSetNetworkConfigurationDnsSettings dnsSettings = default(VirtualMachineScaleSetNetworkConfigurationDnsSettings), bool? enableIPForwarding = default(bool?))
            : base(id)
        {
            Name = name;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            NetworkSecurityGroup = networkSecurityGroup;
            DnsSettings = dnsSettings;
            IpConfigurations = ipConfigurations;
            EnableIPForwarding = enableIPForwarding;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the network configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specifies the primary network interface in case the
        /// virtual machine has more than 1 network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the network interface is accelerated
        /// networking-enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAcceleratedNetworking")]
        public bool? EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Gets or sets the network security group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets the dns settings to be applied on the network
        /// interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the IP configurations of the network
        /// interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<VirtualMachineScaleSetIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Gets or sets whether IP forwarding enabled on this NIC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableIPForwarding")]
        public bool? EnableIPForwarding { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (IpConfigurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IpConfigurations");
            }
            if (IpConfigurations != null)
            {
                foreach (var element in IpConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
