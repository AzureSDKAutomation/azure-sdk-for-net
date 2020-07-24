// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The manged cluster resource
    ///
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
        /// <param name="location">Azure resource location.</param>
        /// <param name="dnsName">The cluster dns name.</param>
        /// <param name="adminUserName">vm admin user name.</param>
        /// <param name="id">Azure resource identifier.</param>
        /// <param name="name">Azure resource name.</param>
        /// <param name="type">Azure resource type.</param>
        /// <param name="tags">Azure resource tags.</param>
        /// <param name="etag">Azure resource etag.</param>
        /// <param name="fqdn">the cluster Fully qualified domain name.</param>
        /// <param name="clusterId">A service generated unique identifier for
        /// the cluster resource.</param>
        /// <param name="clusterState">The current state of the cluster.
        ///
        /// - WaitingForNodes - Indicates that the cluster resource is created
        /// and the resource provider is waiting for Service Fabric VM
        /// extension to boot up and report to it.
        /// - Deploying - Indicates that the Service Fabric runtime is being
        /// installed on the VMs. Cluster resource will be in this state until
        /// the cluster boots up and system services are up.
        /// - BaselineUpgrade - Indicates that the cluster is upgrading to
        /// establishes the cluster version. This upgrade is automatically
        /// initiated when the cluster boots up for the first time.
        /// - UpdatingUserConfiguration - Indicates that the cluster is being
        /// upgraded with the user provided configuration.
        /// - UpdatingUserCertificate - Indicates that the cluster is being
        /// upgraded with the user provided certificate.
        /// - UpdatingInfrastructure - Indicates that the cluster is being
        /// upgraded with the latest Service Fabric runtime version. This
        /// happens only when the **upgradeMode** is set to 'Automatic'.
        /// - EnforcingClusterVersion - Indicates that cluster is on a
        /// different version than expected and the cluster is being upgraded
        /// to the expected version.
        /// - UpgradeServiceUnreachable - Indicates that the system service in
        /// the cluster is no longer polling the Resource Provider. Clusters in
        /// this state cannot be managed by the Resource Provider.
        /// - AutoScale - Indicates that the ReliabilityLevel of the cluster is
        /// being adjusted.
        /// - Ready - Indicates that the cluster is in a stable state.
        /// . Possible values include: 'WaitingForNodes', 'Deploying',
        /// 'BaselineUpgrade', 'UpdatingUserConfiguration',
        /// 'UpdatingUserCertificate', 'UpdatingInfrastructure',
        /// 'EnforcingClusterVersion', 'UpgradeServiceUnreachable',
        /// 'AutoScale', 'Ready'</param>
        /// <param name="clusterCertificateThumbprint">The cluster certificate
        /// thumbprint used node to node communication.</param>
        /// <param name="clientConnectionPort">The port used for client
        /// connections to the cluster.</param>
        /// <param name="httpGatewayConnectionPort">The port used for http
        /// connections to the cluster.</param>
        /// <param name="adminPassword">vm admin user password.</param>
        /// <param name="loadBalancingRules">Describes a load balancing
        /// rule.</param>
        /// <param name="clients">client certificates for the cluster.</param>
        /// <param name="azureActiveDirectory">Azure active directory.</param>
        /// <param name="fabricSettings">The list of custom fabric settings to
        /// configure the cluster.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// managed cluster resource. Possible values include: 'Updating',
        /// 'Succeeded', 'Failed', 'Canceled'</param>
        /// <param name="clusterCodeVersion">The Service Fabric runtime version
        /// of the cluster. This property can only by set the user when
        /// **upgradeMode** is set to 'Manual'. To get list of available
        /// Service Fabric versions for new clusters use [ClusterVersion
        /// API](./ClusterVersion.md). To get the list of available version for
        /// existing clusters use **availableClusterVersions**.</param>
        /// <param name="clusterUpgradeMode">The upgrade mode of the cluster
        /// when new Service Fabric runtime version is available.
        ///
        /// - Automatic - The cluster will be automatically upgraded to the
        /// latest Service Fabric runtime version as soon as it is available.
        /// - Manual - The cluster will not be automatically upgraded to the
        /// latest Service Fabric runtime version. The cluster is upgraded by
        /// setting the **clusterCodeVersion** property in the cluster
        /// resource.
        /// . Possible values include: 'Automatic', 'Manual'</param>
        /// <param name="clusterUpgradeDescription">Describes the policy used
        /// when upgrading the cluster.</param>
        /// <param name="reverseProxyEndpointPort">The endpoint used by reverse
        /// proxy.</param>
        /// <param name="sku">The sku of the managed cluster</param>
        public ManagedCluster(string location, string dnsName, string adminUserName, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string fqdn = default(string), string clusterId = default(string), string clusterState = default(string), string clusterCertificateThumbprint = default(string), int? clientConnectionPort = default(int?), int? httpGatewayConnectionPort = default(int?), string adminPassword = default(string), LoadBalancingRule loadBalancingRules = default(LoadBalancingRule), ClientCertificate clients = default(ClientCertificate), AzureActiveDirectory azureActiveDirectory = default(AzureActiveDirectory), SettingsSectionDescription fabricSettings = default(SettingsSectionDescription), string provisioningState = default(string), string clusterCodeVersion = default(string), string clusterUpgradeMode = default(string), ClusterUpgradePolicy clusterUpgradeDescription = default(ClusterUpgradePolicy), int? reverseProxyEndpointPort = default(int?), Sku sku = default(Sku))
            : base(location, id, name, type, tags, etag)
        {
            DnsName = dnsName;
            Fqdn = fqdn;
            ClusterId = clusterId;
            ClusterState = clusterState;
            ClusterCertificateThumbprint = clusterCertificateThumbprint;
            ClientConnectionPort = clientConnectionPort;
            HttpGatewayConnectionPort = httpGatewayConnectionPort;
            AdminUserName = adminUserName;
            AdminPassword = adminPassword;
            LoadBalancingRules = loadBalancingRules;
            Clients = clients;
            AzureActiveDirectory = azureActiveDirectory;
            FabricSettings = fabricSettings;
            ProvisioningState = provisioningState;
            ClusterCodeVersion = clusterCodeVersion;
            ClusterUpgradeMode = clusterUpgradeMode;
            ClusterUpgradeDescription = clusterUpgradeDescription;
            ReverseProxyEndpointPort = reverseProxyEndpointPort;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the cluster dns name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsName")]
        public string DnsName { get; set; }

        /// <summary>
        /// Gets the cluster Fully qualified domain name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets a service generated unique identifier for the cluster
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterId")]
        public string ClusterId { get; private set; }

        /// <summary>
        /// Gets the current state of the cluster.
        ///
        /// - WaitingForNodes - Indicates that the cluster resource is created
        /// and the resource provider is waiting for Service Fabric VM
        /// extension to boot up and report to it.
        /// - Deploying - Indicates that the Service Fabric runtime is being
        /// installed on the VMs. Cluster resource will be in this state until
        /// the cluster boots up and system services are up.
        /// - BaselineUpgrade - Indicates that the cluster is upgrading to
        /// establishes the cluster version. This upgrade is automatically
        /// initiated when the cluster boots up for the first time.
        /// - UpdatingUserConfiguration - Indicates that the cluster is being
        /// upgraded with the user provided configuration.
        /// - UpdatingUserCertificate - Indicates that the cluster is being
        /// upgraded with the user provided certificate.
        /// - UpdatingInfrastructure - Indicates that the cluster is being
        /// upgraded with the latest Service Fabric runtime version. This
        /// happens only when the **upgradeMode** is set to 'Automatic'.
        /// - EnforcingClusterVersion - Indicates that cluster is on a
        /// different version than expected and the cluster is being upgraded
        /// to the expected version.
        /// - UpgradeServiceUnreachable - Indicates that the system service in
        /// the cluster is no longer polling the Resource Provider. Clusters in
        /// this state cannot be managed by the Resource Provider.
        /// - AutoScale - Indicates that the ReliabilityLevel of the cluster is
        /// being adjusted.
        /// - Ready - Indicates that the cluster is in a stable state.
        /// . Possible values include: 'WaitingForNodes', 'Deploying',
        /// 'BaselineUpgrade', 'UpdatingUserConfiguration',
        /// 'UpdatingUserCertificate', 'UpdatingInfrastructure',
        /// 'EnforcingClusterVersion', 'UpgradeServiceUnreachable',
        /// 'AutoScale', 'Ready'
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterState")]
        public string ClusterState { get; private set; }

        /// <summary>
        /// Gets the cluster certificate thumbprint used node to node
        /// communication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterCertificateThumbprint")]
        public string ClusterCertificateThumbprint { get; private set; }

        /// <summary>
        /// Gets or sets the port used for client connections to the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientConnectionPort")]
        public int? ClientConnectionPort { get; set; }

        /// <summary>
        /// Gets or sets the port used for http connections to the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpGatewayConnectionPort")]
        public int? HttpGatewayConnectionPort { get; set; }

        /// <summary>
        /// Gets or sets vm admin user name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminUserName")]
        public string AdminUserName { get; set; }

        /// <summary>
        /// Gets or sets vm admin user password.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets describes a load balancing rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public LoadBalancingRule LoadBalancingRules { get; set; }

        /// <summary>
        /// Gets or sets client certificates for the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clients")]
        public ClientCertificate Clients { get; set; }

        /// <summary>
        /// Gets or sets azure active directory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureActiveDirectory")]
        public AzureActiveDirectory AzureActiveDirectory { get; set; }

        /// <summary>
        /// Gets or sets the list of custom fabric settings to configure the
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fabricSettings")]
        public SettingsSectionDescription FabricSettings { get; set; }

        /// <summary>
        /// Gets the provisioning state of the managed cluster resource.
        /// Possible values include: 'Updating', 'Succeeded', 'Failed',
        /// 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the Service Fabric runtime version of the cluster.
        /// This property can only by set the user when **upgradeMode** is set
        /// to 'Manual'. To get list of available Service Fabric versions for
        /// new clusters use [ClusterVersion API](./ClusterVersion.md). To get
        /// the list of available version for existing clusters use
        /// **availableClusterVersions**.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterCodeVersion")]
        public string ClusterCodeVersion { get; set; }

        /// <summary>
        /// Gets or sets the upgrade mode of the cluster when new Service
        /// Fabric runtime version is available.
        ///
        /// - Automatic - The cluster will be automatically upgraded to the
        /// latest Service Fabric runtime version as soon as it is available.
        /// - Manual - The cluster will not be automatically upgraded to the
        /// latest Service Fabric runtime version. The cluster is upgraded by
        /// setting the **clusterCodeVersion** property in the cluster
        /// resource.
        /// . Possible values include: 'Automatic', 'Manual'
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterUpgradeMode")]
        public string ClusterUpgradeMode { get; set; }

        /// <summary>
        /// Gets or sets describes the policy used when upgrading the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterUpgradeDescription")]
        public ClusterUpgradePolicy ClusterUpgradeDescription { get; set; }

        /// <summary>
        /// Gets or sets the endpoint used by reverse proxy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reverseProxyEndpointPort")]
        public int? ReverseProxyEndpointPort { get; set; }

        /// <summary>
        /// Gets or sets the sku of the managed cluster
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DnsName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DnsName");
            }
            if (AdminUserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdminUserName");
            }
            if (LoadBalancingRules != null)
            {
                LoadBalancingRules.Validate();
            }
            if (Clients != null)
            {
                Clients.Validate();
            }
            if (FabricSettings != null)
            {
                FabricSettings.Validate();
            }
            if (ClusterUpgradeDescription != null)
            {
                ClusterUpgradeDescription.Validate();
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
