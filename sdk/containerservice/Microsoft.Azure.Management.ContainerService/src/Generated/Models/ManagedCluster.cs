// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Managed cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedCluster : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedCluster class.
        /// </summary>
        public ManagedCluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedCluster class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response.</param>
        /// <param name="maxAgentPools">The max number of agent pools for the
        /// managed cluster.</param>
        /// <param name="kubernetesVersion">Version of Kubernetes specified
        /// when creating the managed cluster.</param>
        /// <param name="dnsPrefix">DNS prefix specified when creating the
        /// managed cluster.</param>
        /// <param name="fqdn">FQDN for the master pool.</param>
        /// <param name="privateFQDN">FQDN of private cluster.</param>
        /// <param name="agentPoolProfiles">Properties of the agent
        /// pool.</param>
        /// <param name="linuxProfile">Profile for Linux VMs in the container
        /// service cluster.</param>
        /// <param name="windowsProfile">Profile for Windows VMs in the
        /// container service cluster.</param>
        /// <param name="servicePrincipalProfile">Information about a service
        /// principal identity for the cluster to use for manipulating Azure
        /// APIs.</param>
        /// <param name="addonProfiles">Profile of managed cluster
        /// add-on.</param>
        /// <param name="nodeResourceGroup">Name of the resource group
        /// containing agent pool nodes.</param>
        /// <param name="enableRBAC">Whether to enable Kubernetes Role-Based
        /// Access Control.</param>
        /// <param name="enablePodSecurityPolicy">(PREVIEW) Whether to enable
        /// Kubernetes Pod security policy.</param>
        /// <param name="networkProfile">Profile of network
        /// configuration.</param>
        /// <param name="aadProfile">Profile of Azure Active Directory
        /// configuration.</param>
        /// <param name="autoScalerProfile">Parameters to be applied to the
        /// cluster-autoscaler when enabled</param>
        /// <param name="apiServerAccessProfile">Access profile for managed
        /// cluster API server.</param>
        /// <param name="diskEncryptionSetID">ResourceId of the disk encryption
        /// set to use for enabling encryption at rest.</param>
        /// <param name="identityProfile">Identities associated with the
        /// cluster.</param>
        /// <param name="identity">The identity of the managed cluster, if
        /// configured.</param>
        /// <param name="sku">The managed cluster SKU.</param>
        public ManagedCluster(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), int? maxAgentPools = default(int?), string kubernetesVersion = default(string), string dnsPrefix = default(string), string fqdn = default(string), string privateFQDN = default(string), IList<ManagedClusterAgentPoolProfile> agentPoolProfiles = default(IList<ManagedClusterAgentPoolProfile>), ContainerServiceLinuxProfile linuxProfile = default(ContainerServiceLinuxProfile), ManagedClusterWindowsProfile windowsProfile = default(ManagedClusterWindowsProfile), ManagedClusterServicePrincipalProfile servicePrincipalProfile = default(ManagedClusterServicePrincipalProfile), IDictionary<string, ManagedClusterAddonProfile> addonProfiles = default(IDictionary<string, ManagedClusterAddonProfile>), string nodeResourceGroup = default(string), bool? enableRBAC = default(bool?), bool? enablePodSecurityPolicy = default(bool?), ContainerServiceNetworkProfile networkProfile = default(ContainerServiceNetworkProfile), ManagedClusterAADProfile aadProfile = default(ManagedClusterAADProfile), ManagedClusterPropertiesAutoScalerProfile autoScalerProfile = default(ManagedClusterPropertiesAutoScalerProfile), ManagedClusterAPIServerAccessProfile apiServerAccessProfile = default(ManagedClusterAPIServerAccessProfile), string diskEncryptionSetID = default(string), IDictionary<string, ManagedClusterPropertiesIdentityProfileValue> identityProfile = default(IDictionary<string, ManagedClusterPropertiesIdentityProfileValue>), ManagedClusterIdentity identity = default(ManagedClusterIdentity), ManagedClusterSKU sku = default(ManagedClusterSKU))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            MaxAgentPools = maxAgentPools;
            KubernetesVersion = kubernetesVersion;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
            PrivateFQDN = privateFQDN;
            AgentPoolProfiles = agentPoolProfiles;
            LinuxProfile = linuxProfile;
            WindowsProfile = windowsProfile;
            ServicePrincipalProfile = servicePrincipalProfile;
            AddonProfiles = addonProfiles;
            NodeResourceGroup = nodeResourceGroup;
            EnableRBAC = enableRBAC;
            EnablePodSecurityPolicy = enablePodSecurityPolicy;
            NetworkProfile = networkProfile;
            AadProfile = aadProfile;
            AutoScalerProfile = autoScalerProfile;
            ApiServerAccessProfile = apiServerAccessProfile;
            DiskEncryptionSetID = diskEncryptionSetID;
            IdentityProfile = identityProfile;
            Identity = identity;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the max number of agent pools for the managed cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxAgentPools")]
        public int? MaxAgentPools { get; private set; }

        /// <summary>
        /// Gets or sets version of Kubernetes specified when creating the
        /// managed cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kubernetesVersion")]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// Gets or sets DNS prefix specified when creating the managed
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsPrefix")]
        public string DnsPrefix { get; set; }

        /// <summary>
        /// Gets FQDN for the master pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets FQDN of private cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateFQDN")]
        public string PrivateFQDN { get; private set; }

        /// <summary>
        /// Gets or sets properties of the agent pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentPoolProfiles")]
        public IList<ManagedClusterAgentPoolProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Gets or sets profile for Linux VMs in the container service
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linuxProfile")]
        public ContainerServiceLinuxProfile LinuxProfile { get; set; }

        /// <summary>
        /// Gets or sets profile for Windows VMs in the container service
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.windowsProfile")]
        public ManagedClusterWindowsProfile WindowsProfile { get; set; }

        /// <summary>
        /// Gets or sets information about a service principal identity for the
        /// cluster to use for manipulating Azure APIs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.servicePrincipalProfile")]
        public ManagedClusterServicePrincipalProfile ServicePrincipalProfile { get; set; }

        /// <summary>
        /// Gets or sets profile of managed cluster add-on.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addonProfiles")]
        public IDictionary<string, ManagedClusterAddonProfile> AddonProfiles { get; set; }

        /// <summary>
        /// Gets or sets name of the resource group containing agent pool
        /// nodes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeResourceGroup")]
        public string NodeResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets whether to enable Kubernetes Role-Based Access
        /// Control.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableRBAC")]
        public bool? EnableRBAC { get; set; }

        /// <summary>
        /// Gets or sets (PREVIEW) Whether to enable Kubernetes Pod security
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enablePodSecurityPolicy")]
        public bool? EnablePodSecurityPolicy { get; set; }

        /// <summary>
        /// Gets or sets profile of network configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkProfile")]
        public ContainerServiceNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets profile of Azure Active Directory configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.aadProfile")]
        public ManagedClusterAADProfile AadProfile { get; set; }

        /// <summary>
        /// Gets or sets parameters to be applied to the cluster-autoscaler
        /// when enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoScalerProfile")]
        public ManagedClusterPropertiesAutoScalerProfile AutoScalerProfile { get; set; }

        /// <summary>
        /// Gets or sets access profile for managed cluster API server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiServerAccessProfile")]
        public ManagedClusterAPIServerAccessProfile ApiServerAccessProfile { get; set; }

        /// <summary>
        /// Gets or sets resourceId of the disk encryption set to use for
        /// enabling encryption at rest.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskEncryptionSetID")]
        public string DiskEncryptionSetID { get; set; }

        /// <summary>
        /// Gets or sets identities associated with the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.identityProfile")]
        public IDictionary<string, ManagedClusterPropertiesIdentityProfileValue> IdentityProfile { get; set; }

        /// <summary>
        /// Gets or sets the identity of the managed cluster, if configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedClusterIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the managed cluster SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ManagedClusterSKU Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (AgentPoolProfiles != null)
            {
                foreach (var element in AgentPoolProfiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (LinuxProfile != null)
            {
                LinuxProfile.Validate();
            }
            if (WindowsProfile != null)
            {
                WindowsProfile.Validate();
            }
            if (ServicePrincipalProfile != null)
            {
                ServicePrincipalProfile.Validate();
            }
            if (AddonProfiles != null)
            {
                foreach (var valueElement in AddonProfiles.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (NetworkProfile != null)
            {
                NetworkProfile.Validate();
            }
            if (AadProfile != null)
            {
                AadProfile.Validate();
            }
        }
    }
}
