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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a node type in the cluster, each node type represents sub set
    /// of nodes in the cluster.
    /// </summary>
    public partial class NodeTypeDescription
    {
        /// <summary>
        /// Initializes a new instance of the NodeTypeDescription class.
        /// </summary>
        public NodeTypeDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeTypeDescription class.
        /// </summary>
        /// <param name="name">The name of the node type.</param>
        /// <param name="clientConnectionEndpointPort">The TCP cluster
        /// management endpoint port.</param>
        /// <param name="httpGatewayEndpointPort">The HTTP cluster management
        /// endpoint port.</param>
        /// <param name="isPrimary">The node type on which system services will
        /// run. Only one node type should be marked as primary. Primary node
        /// type cannot be deleted or changed for existing clusters.</param>
        /// <param name="vmInstanceCount">The number of nodes in the node type.
        /// This count should match the capacity property in the corresponding
        /// VirtualMachineScaleSet resource.</param>
        /// <param name="placementProperties">The placement tags applied to
        /// nodes in the node type, which can be used to indicate where certain
        /// services (workload) should run.</param>
        /// <param name="capacities">The capacity tags applied to the nodes in
        /// the node type, the cluster resource manager uses these tags to
        /// understand how much resource a node has.</param>
        /// <param name="durabilityLevel">The durability level of the node
        /// type. Learn about
        /// [DurabilityLevel](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        /// - Bronze - No privileges. This is the default.
        /// - Silver - The infrastructure jobs can be paused for a duration of
        /// 10 minutes per UD.
        /// - Gold - The infrastructure jobs can be paused for a duration of 2
        /// hours per UD. Gold durability can be enabled only on full node VM
        /// skus like D15_V2, G5 etc.
        /// . Possible values include: 'Bronze', 'Silver', 'Gold'</param>
        /// <param name="applicationPorts">The range of ports from which
        /// cluster assigned port to Service Fabric applications.</param>
        /// <param name="ephemeralPorts">The range of ephemeral ports that
        /// nodes in this node type should be configured with.</param>
        /// <param name="reverseProxyEndpointPort">The endpoint used by reverse
        /// proxy.</param>
        public NodeTypeDescription(string name, int clientConnectionEndpointPort, int httpGatewayEndpointPort, bool isPrimary, int vmInstanceCount, IDictionary<string, string> placementProperties = default(IDictionary<string, string>), IDictionary<string, string> capacities = default(IDictionary<string, string>), string durabilityLevel = default(string), EndpointRangeDescription applicationPorts = default(EndpointRangeDescription), EndpointRangeDescription ephemeralPorts = default(EndpointRangeDescription), int? reverseProxyEndpointPort = default(int?))
        {
            Name = name;
            PlacementProperties = placementProperties;
            Capacities = capacities;
            ClientConnectionEndpointPort = clientConnectionEndpointPort;
            HttpGatewayEndpointPort = httpGatewayEndpointPort;
            DurabilityLevel = durabilityLevel;
            ApplicationPorts = applicationPorts;
            EphemeralPorts = ephemeralPorts;
            IsPrimary = isPrimary;
            VmInstanceCount = vmInstanceCount;
            ReverseProxyEndpointPort = reverseProxyEndpointPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the node type.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the placement tags applied to nodes in the node type,
        /// which can be used to indicate where certain services (workload)
        /// should run.
        /// </summary>
        [JsonProperty(PropertyName = "placementProperties")]
        public IDictionary<string, string> PlacementProperties { get; set; }

        /// <summary>
        /// Gets or sets the capacity tags applied to the nodes in the node
        /// type, the cluster resource manager uses these tags to understand
        /// how much resource a node has.
        /// </summary>
        [JsonProperty(PropertyName = "capacities")]
        public IDictionary<string, string> Capacities { get; set; }

        /// <summary>
        /// Gets or sets the TCP cluster management endpoint port.
        /// </summary>
        [JsonProperty(PropertyName = "clientConnectionEndpointPort")]
        public int ClientConnectionEndpointPort { get; set; }

        /// <summary>
        /// Gets or sets the HTTP cluster management endpoint port.
        /// </summary>
        [JsonProperty(PropertyName = "httpGatewayEndpointPort")]
        public int HttpGatewayEndpointPort { get; set; }

        /// <summary>
        /// Gets or sets the durability level of the node type. Learn about
        /// [DurabilityLevel](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        /// - Bronze - No privileges. This is the default.
        /// - Silver - The infrastructure jobs can be paused for a duration of
        /// 10 minutes per UD.
        /// - Gold - The infrastructure jobs can be paused for a duration of 2
        /// hours per UD. Gold durability can be enabled only on full node VM
        /// skus like D15_V2, G5 etc.
        /// . Possible values include: 'Bronze', 'Silver', 'Gold'
        /// </summary>
        [JsonProperty(PropertyName = "durabilityLevel")]
        public string DurabilityLevel { get; set; }

        /// <summary>
        /// Gets or sets the range of ports from which cluster assigned port to
        /// Service Fabric applications.
        /// </summary>
        [JsonProperty(PropertyName = "applicationPorts")]
        public EndpointRangeDescription ApplicationPorts { get; set; }

        /// <summary>
        /// Gets or sets the range of ephemeral ports that nodes in this node
        /// type should be configured with.
        /// </summary>
        [JsonProperty(PropertyName = "ephemeralPorts")]
        public EndpointRangeDescription EphemeralPorts { get; set; }

        /// <summary>
        /// Gets or sets the node type on which system services will run. Only
        /// one node type should be marked as primary. Primary node type cannot
        /// be deleted or changed for existing clusters.
        /// </summary>
        [JsonProperty(PropertyName = "isPrimary")]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Gets or sets the number of nodes in the node type. This count
        /// should match the capacity property in the corresponding
        /// VirtualMachineScaleSet resource.
        /// </summary>
        [JsonProperty(PropertyName = "vmInstanceCount")]
        public int VmInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets the endpoint used by reverse proxy.
        /// </summary>
        [JsonProperty(PropertyName = "reverseProxyEndpointPort")]
        public int? ReverseProxyEndpointPort { get; set; }

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
            if (ApplicationPorts != null)
            {
                ApplicationPorts.Validate();
            }
            if (EphemeralPorts != null)
            {
                EphemeralPorts.Validate();
            }
            if (VmInstanceCount > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "VmInstanceCount", 2147483647);
            }
            if (VmInstanceCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "VmInstanceCount", 1);
            }
        }
    }
}
