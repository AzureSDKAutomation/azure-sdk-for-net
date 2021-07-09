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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The service resource properties.
    /// </summary>
    public partial class ServiceResourceProperties : ServiceResourcePropertiesBase
    {
        /// <summary>
        /// Initializes a new instance of the ServiceResourceProperties class.
        /// </summary>
        public ServiceResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceResourceProperties class.
        /// </summary>
        /// <param name="placementConstraints">The placement constraints as a
        /// string. Placement constraints are boolean expressions on node
        /// properties and allow for restricting a service to particular nodes
        /// based on the service requirements. For example, to place a service
        /// on nodes where NodeType is blue specify the following: "NodeColor
        /// == blue)".</param>
        /// <param name="defaultMoveCost">Possible values include: 'Zero',
        /// 'Low', 'Medium', 'High'</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response</param>
        /// <param name="serviceTypeName">The name of the service type</param>
        /// <param name="servicePackageActivationMode">The activation Mode of
        /// the service package. Possible values include: 'SharedProcess',
        /// 'ExclusiveProcess'</param>
        /// <param name="serviceDnsName">Dns name used for the service. If this
        /// is specified, then the service can be accessed via its DNS name
        /// instead of service name.</param>
        public ServiceResourceProperties(string placementConstraints = default(string), IList<ServiceCorrelationDescription> correlationScheme = default(IList<ServiceCorrelationDescription>), IList<ServiceLoadMetricDescription> serviceLoadMetrics = default(IList<ServiceLoadMetricDescription>), IList<ServicePlacementPolicyDescription> servicePlacementPolicies = default(IList<ServicePlacementPolicyDescription>), string defaultMoveCost = default(string), string provisioningState = default(string), string serviceTypeName = default(string), PartitionSchemeDescription partitionDescription = default(PartitionSchemeDescription), string servicePackageActivationMode = default(string), string serviceDnsName = default(string))
            : base(placementConstraints, correlationScheme, serviceLoadMetrics, servicePlacementPolicies, defaultMoveCost)
        {
            ProvisioningState = provisioningState;
            ServiceTypeName = serviceTypeName;
            PartitionDescription = partitionDescription;
            ServicePackageActivationMode = servicePackageActivationMode;
            ServiceDnsName = serviceDnsName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the service type
        /// </summary>
        [JsonProperty(PropertyName = "serviceTypeName")]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partitionDescription")]
        public PartitionSchemeDescription PartitionDescription { get; set; }

        /// <summary>
        /// Gets or sets the activation Mode of the service package. Possible
        /// values include: 'SharedProcess', 'ExclusiveProcess'
        /// </summary>
        [JsonProperty(PropertyName = "servicePackageActivationMode")]
        public string ServicePackageActivationMode { get; set; }

        /// <summary>
        /// Gets or sets dns name used for the service. If this is specified,
        /// then the service can be accessed via its DNS name instead of
        /// service name.
        /// </summary>
        [JsonProperty(PropertyName = "serviceDnsName")]
        public string ServiceDnsName { get; set; }

    }
}
