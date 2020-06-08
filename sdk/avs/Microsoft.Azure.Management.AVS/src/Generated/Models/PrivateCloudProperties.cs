// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AVS.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a private cloud resource
    /// </summary>
    public partial class PrivateCloudProperties
    {
        /// <summary>
        /// Initializes a new instance of the PrivateCloudProperties class.
        /// </summary>
        public PrivateCloudProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateCloudProperties class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Succeeded', 'Failed', 'Cancelled', 'Pending',
        /// 'Building', 'Updating'</param>
        /// <param name="circuit">An ExpressRoute Circuit</param>
        /// <param name="cluster">The default cluster used for
        /// management</param>
        /// <param name="clusters">The clusters</param>
        /// <param name="endpoints">The endpoints</param>
        /// <param name="internet">Connectivity to internet is enabled or
        /// disabled. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="identitySources">vCenter Single Sign On Identity
        /// Sources</param>
        /// <param name="networkBlock">The block of addresses should be unique
        /// across VNet in your subscription as well as on-premise. Make sure
        /// the CIDR format is conformed to (A.B.C.D/X) where A,B,C,D are
        /// between 0 and 255, and X is between 0 and 22</param>
        /// <param name="managementNetwork">Network used to access vCenter
        /// Server and NSX-T Manager</param>
        /// <param name="provisioningNetwork">Used for virtual machine cold
        /// migration, cloning, and snapshot migration</param>
        /// <param name="vmotionNetwork">Used for live migration of virtual
        /// machines</param>
        /// <param name="vcenterPassword">Optionally, set the vCenter admin
        /// password when the private cloud is created</param>
        /// <param name="nsxtPassword">Optionally, set the NSX-T Manager
        /// password when the private cloud is created</param>
        /// <param name="vcenterCertificateThumbprint">Thumbprint of the
        /// vCenter Server SSL certificate</param>
        /// <param name="nsxtCertificateThumbprint">Thumbprint of the NSX-T
        /// Manager SSL certificate</param>
        public PrivateCloudProperties(string provisioningState = default(string), Circuit circuit = default(Circuit), DefaultClusterProperties cluster = default(DefaultClusterProperties), IList<string> clusters = default(IList<string>), Endpoints endpoints = default(Endpoints), string internet = default(string), IList<IdentitySource> identitySources = default(IList<IdentitySource>), string networkBlock = default(string), string managementNetwork = default(string), string provisioningNetwork = default(string), string vmotionNetwork = default(string), string vcenterPassword = default(string), string nsxtPassword = default(string), string vcenterCertificateThumbprint = default(string), string nsxtCertificateThumbprint = default(string))
        {
            ProvisioningState = provisioningState;
            Circuit = circuit;
            Cluster = cluster;
            Clusters = clusters;
            Endpoints = endpoints;
            Internet = internet;
            IdentitySources = identitySources;
            NetworkBlock = networkBlock;
            ManagementNetwork = managementNetwork;
            ProvisioningNetwork = provisioningNetwork;
            VmotionNetwork = vmotionNetwork;
            VcenterPassword = vcenterPassword;
            NsxtPassword = nsxtPassword;
            VcenterCertificateThumbprint = vcenterCertificateThumbprint;
            NsxtCertificateThumbprint = nsxtCertificateThumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state. Possible values include: 'Succeeded',
        /// 'Failed', 'Cancelled', 'Pending', 'Building', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets an ExpressRoute Circuit
        /// </summary>
        [JsonProperty(PropertyName = "circuit")]
        public Circuit Circuit { get; set; }

        /// <summary>
        /// Gets or sets the default cluster used for management
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public DefaultClusterProperties Cluster { get; set; }

        /// <summary>
        /// Gets the clusters
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<string> Clusters { get; private set; }

        /// <summary>
        /// Gets the endpoints
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public Endpoints Endpoints { get; private set; }

        /// <summary>
        /// Gets or sets connectivity to internet is enabled or disabled.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "internet")]
        public string Internet { get; set; }

        /// <summary>
        /// Gets or sets vCenter Single Sign On Identity Sources
        /// </summary>
        [JsonProperty(PropertyName = "identitySources")]
        public IList<IdentitySource> IdentitySources { get; set; }

        /// <summary>
        /// Gets or sets the block of addresses should be unique across VNet in
        /// your subscription as well as on-premise. Make sure the CIDR format
        /// is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255,
        /// and X is between 0 and 22
        /// </summary>
        [JsonProperty(PropertyName = "networkBlock")]
        public string NetworkBlock { get; set; }

        /// <summary>
        /// Gets network used to access vCenter Server and NSX-T Manager
        /// </summary>
        [JsonProperty(PropertyName = "managementNetwork")]
        public string ManagementNetwork { get; private set; }

        /// <summary>
        /// Gets used for virtual machine cold migration, cloning, and snapshot
        /// migration
        /// </summary>
        [JsonProperty(PropertyName = "provisioningNetwork")]
        public string ProvisioningNetwork { get; private set; }

        /// <summary>
        /// Gets used for live migration of virtual machines
        /// </summary>
        [JsonProperty(PropertyName = "vmotionNetwork")]
        public string VmotionNetwork { get; private set; }

        /// <summary>
        /// Gets or sets optionally, set the vCenter admin password when the
        /// private cloud is created
        /// </summary>
        [JsonProperty(PropertyName = "vcenterPassword")]
        public string VcenterPassword { get; set; }

        /// <summary>
        /// Gets or sets optionally, set the NSX-T Manager password when the
        /// private cloud is created
        /// </summary>
        [JsonProperty(PropertyName = "nsxtPassword")]
        public string NsxtPassword { get; set; }

        /// <summary>
        /// Gets thumbprint of the vCenter Server SSL certificate
        /// </summary>
        [JsonProperty(PropertyName = "vcenterCertificateThumbprint")]
        public string VcenterCertificateThumbprint { get; private set; }

        /// <summary>
        /// Gets thumbprint of the NSX-T Manager SSL certificate
        /// </summary>
        [JsonProperty(PropertyName = "nsxtCertificateThumbprint")]
        public string NsxtCertificateThumbprint { get; private set; }

    }
}
