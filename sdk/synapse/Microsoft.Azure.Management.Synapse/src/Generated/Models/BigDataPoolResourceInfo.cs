// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Big Data pool
    /// </summary>
    /// <remarks>
    /// A Big Data pool
    /// </remarks>
    [Rest.Serialization.JsonTransformation]
    public partial class BigDataPoolResourceInfo : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the BigDataPoolResourceInfo class.
        /// </summary>
        public BigDataPoolResourceInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BigDataPoolResourceInfo class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="provisioningState">The state of the Big Data
        /// pool.</param>
        /// <param name="autoScale">Auto-scaling properties</param>
        /// <param name="creationDate">The time when the Big Data pool was
        /// created.</param>
        /// <param name="autoPause">Auto-pausing properties</param>
        /// <param name="isComputeIsolationEnabled">Whether compute isolation
        /// is required or not.</param>
        /// <param name="sessionLevelPackagesEnabled">Whether session level
        /// library/package management is enabled or not.</param>
        /// <param name="sparkEventsFolder">The Spark events folder</param>
        /// <param name="nodeCount">The number of nodes in the Big Data
        /// pool.</param>
        /// <param name="libraryRequirements">Library version
        /// requirements</param>
        /// <param name="customLibraries">List of custom libraries/packages
        /// associated with the spark pool.</param>
        /// <param name="sparkConfigProperties">Spark configuration file to
        /// specify additional properties</param>
        /// <param name="sparkVersion">The Apache Spark version.</param>
        /// <param name="defaultSparkLogFolder">The default folder where Spark
        /// logs will be written.</param>
        /// <param name="nodeSize">The level of compute power that each node in
        /// the Big Data pool has. Possible values include: 'None', 'Small',
        /// 'Medium', 'Large', 'XLarge', 'XXLarge', 'XXXLarge'</param>
        /// <param name="nodeSizeFamily">The kind of nodes that the Big Data
        /// pool provides. Possible values include: 'None',
        /// 'MemoryOptimized'</param>
        public BigDataPoolResourceInfo(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), AutoScaleProperties autoScale = default(AutoScaleProperties), System.DateTime? creationDate = default(System.DateTime?), AutoPauseProperties autoPause = default(AutoPauseProperties), bool? isComputeIsolationEnabled = default(bool?), bool? sessionLevelPackagesEnabled = default(bool?), string sparkEventsFolder = default(string), int? nodeCount = default(int?), LibraryRequirements libraryRequirements = default(LibraryRequirements), IList<LibraryInfo> customLibraries = default(IList<LibraryInfo>), LibraryRequirements sparkConfigProperties = default(LibraryRequirements), string sparkVersion = default(string), string defaultSparkLogFolder = default(string), string nodeSize = default(string), string nodeSizeFamily = default(string))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            AutoScale = autoScale;
            CreationDate = creationDate;
            AutoPause = autoPause;
            IsComputeIsolationEnabled = isComputeIsolationEnabled;
            SessionLevelPackagesEnabled = sessionLevelPackagesEnabled;
            SparkEventsFolder = sparkEventsFolder;
            NodeCount = nodeCount;
            LibraryRequirements = libraryRequirements;
            CustomLibraries = customLibraries;
            SparkConfigProperties = sparkConfigProperties;
            SparkVersion = sparkVersion;
            DefaultSparkLogFolder = defaultSparkLogFolder;
            NodeSize = nodeSize;
            NodeSizeFamily = nodeSizeFamily;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the Big Data pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets auto-scaling properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoScale")]
        public AutoScaleProperties AutoScale { get; set; }

        /// <summary>
        /// Gets or sets the time when the Big Data pool was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or sets auto-pausing properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoPause")]
        public AutoPauseProperties AutoPause { get; set; }

        /// <summary>
        /// Gets or sets whether compute isolation is required or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isComputeIsolationEnabled")]
        public bool? IsComputeIsolationEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether session level library/package management is
        /// enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sessionLevelPackagesEnabled")]
        public bool? SessionLevelPackagesEnabled { get; set; }

        /// <summary>
        /// Gets or sets the Spark events folder
        /// </summary>
        [JsonProperty(PropertyName = "properties.sparkEventsFolder")]
        public string SparkEventsFolder { get; set; }

        /// <summary>
        /// Gets or sets the number of nodes in the Big Data pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeCount")]
        public int? NodeCount { get; set; }

        /// <summary>
        /// Gets or sets library version requirements
        /// </summary>
        [JsonProperty(PropertyName = "properties.libraryRequirements")]
        public LibraryRequirements LibraryRequirements { get; set; }

        /// <summary>
        /// Gets or sets list of custom libraries/packages associated with the
        /// spark pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customLibraries")]
        public IList<LibraryInfo> CustomLibraries { get; set; }

        /// <summary>
        /// Gets or sets spark configuration file to specify additional
        /// properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.sparkConfigProperties")]
        public LibraryRequirements SparkConfigProperties { get; set; }

        /// <summary>
        /// Gets or sets the Apache Spark version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sparkVersion")]
        public string SparkVersion { get; set; }

        /// <summary>
        /// Gets or sets the default folder where Spark logs will be written.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultSparkLogFolder")]
        public string DefaultSparkLogFolder { get; set; }

        /// <summary>
        /// Gets or sets the level of compute power that each node in the Big
        /// Data pool has. Possible values include: 'None', 'Small', 'Medium',
        /// 'Large', 'XLarge', 'XXLarge', 'XXXLarge'
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
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
