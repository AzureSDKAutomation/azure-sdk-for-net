// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Synapse Spark Pool constrained resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SynapseSparkPool : ConstrainedResource
    {
        /// <summary>
        /// Initializes a new instance of the SynapseSparkPool class.
        /// </summary>
        public SynapseSparkPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SynapseSparkPool class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="systemData">System Data of the Azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="autoPause">Gets or sets auto-pausing
        /// properties</param>
        /// <param name="autoScale">Gets or sets auto-scaling
        /// properties</param>
        /// <param name="constrainedResourceId">Unique id for identifying a
        /// constrained resource</param>
        /// <param name="family">Family of constrained resource. Possible
        /// values include: 'Compute', 'Storage'</param>
        /// <param name="libraryRequirements">Gets or sets library requirements
        /// properties</param>
        /// <param name="nodeCount">Gets or sets the number of nodes in the Big
        /// Data pool.</param>
        /// <param name="nodeSize">Gets or sets the level of compute power that
        /// each node in the Synapse Spark pool has. Possible values include:
        /// 'None', 'Small', 'Medium', 'Large', 'XLarge', 'XXLarge',
        /// 'XXXLarge'</param>
        /// <param name="nodeSizeFamily">Gets or sets the kind of nodes that
        /// the Big Data pool provides. Possible values include: 'None',
        /// 'MemoryOptimized'</param>
        /// <param name="provisioningState">Provisioning state of the
        /// constrained resource. Possible values include: 'Succeeded',
        /// 'Creating', 'Updating', 'Deleting', 'Moving', 'Failed'</param>
        /// <param name="sparkVersion">Gets or sets the Apache Spark
        /// version.</param>
        public SynapseSparkPool(string id = default(string), string name = default(string), ProxyDtoSystemData systemData = default(ProxyDtoSystemData), string type = default(string), SynapseSparkPoolAutoPauseProperties autoPause = default(SynapseSparkPoolAutoPauseProperties), SynapseSparkPoolAutoScaleProperties autoScale = default(SynapseSparkPoolAutoScaleProperties), string constrainedResourceId = default(string), string family = default(string), SynapseSparkPoolLibraryRequirementsProperties libraryRequirements = default(SynapseSparkPoolLibraryRequirementsProperties), int? nodeCount = default(int?), string nodeSize = default(string), string nodeSizeFamily = default(string), string provisioningState = default(string), string sparkVersion = default(string))
            : base(id, name, systemData, type)
        {
            AutoPause = autoPause;
            AutoScale = autoScale;
            ConstrainedResourceId = constrainedResourceId;
            Family = family;
            LibraryRequirements = libraryRequirements;
            NodeCount = nodeCount;
            NodeSize = nodeSize;
            NodeSizeFamily = nodeSizeFamily;
            ProvisioningState = provisioningState;
            SparkVersion = sparkVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets auto-pausing properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoPause")]
        public SynapseSparkPoolAutoPauseProperties AutoPause { get; set; }

        /// <summary>
        /// Gets or sets auto-scaling properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoScale")]
        public SynapseSparkPoolAutoScaleProperties AutoScale { get; set; }

        /// <summary>
        /// Gets unique id for identifying a constrained resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.constrainedResourceId")]
        public string ConstrainedResourceId { get; private set; }

        /// <summary>
        /// Gets family of constrained resource. Possible values include:
        /// 'Compute', 'Storage'
        /// </summary>
        [JsonProperty(PropertyName = "properties.family")]
        public string Family { get; private set; }

        /// <summary>
        /// Gets or sets library requirements properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.libraryRequirements")]
        public SynapseSparkPoolLibraryRequirementsProperties LibraryRequirements { get; set; }

        /// <summary>
        /// Gets or sets the number of nodes in the Big Data pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeCount")]
        public int? NodeCount { get; set; }

        /// <summary>
        /// Gets or sets the level of compute power that each node in the
        /// Synapse Spark pool has. Possible values include: 'None', 'Small',
        /// 'Medium', 'Large', 'XLarge', 'XXLarge', 'XXXLarge'
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeSize")]
        public string NodeSize { get; set; }

        /// <summary>
        /// Gets or sets the kind of nodes that the Big Data pool provides.
        /// Possible values include: 'None', 'MemoryOptimized'
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeSizeFamily")]
        public string NodeSizeFamily { get; set; }

        /// <summary>
        /// Gets provisioning state of the constrained resource. Possible
        /// values include: 'Succeeded', 'Creating', 'Updating', 'Deleting',
        /// 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the Apache Spark version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sparkVersion")]
        public string SparkVersion { get; set; }

    }
}
