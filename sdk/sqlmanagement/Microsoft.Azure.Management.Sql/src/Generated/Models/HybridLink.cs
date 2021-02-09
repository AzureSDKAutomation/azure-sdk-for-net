// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hybrid link between box and Sql Managed Instance.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HybridLink : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the HybridLink class.
        /// </summary>
        public HybridLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridLink class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="targetDatabase">The name of the target
        /// database</param>
        /// <param name="sourceEndpoint">The source endpoint</param>
        /// <param name="primaryAvailabilityGroupName">The primary availability
        /// group name</param>
        /// <param name="secondaryAvailabilityGroupName">The secondary
        /// availability group name</param>
        /// <param name="replicationMode">The replication mode of hybrid link.
        /// Parameter will be ignored during link creation. Possible values
        /// include: 'Async', 'Sync'</param>
        /// <param name="distributedAvailabilityGroupId">The distributed
        /// availability group id</param>
        /// <param name="sourceReplicaId">The source replica id</param>
        /// <param name="targetReplicaId">The target replica id</param>
        public HybridLink(string id = default(string), string name = default(string), string type = default(string), string targetDatabase = default(string), string sourceEndpoint = default(string), string primaryAvailabilityGroupName = default(string), string secondaryAvailabilityGroupName = default(string), string replicationMode = default(string), System.Guid? distributedAvailabilityGroupId = default(System.Guid?), System.Guid? sourceReplicaId = default(System.Guid?), System.Guid? targetReplicaId = default(System.Guid?))
            : base(id, name, type)
        {
            TargetDatabase = targetDatabase;
            SourceEndpoint = sourceEndpoint;
            PrimaryAvailabilityGroupName = primaryAvailabilityGroupName;
            SecondaryAvailabilityGroupName = secondaryAvailabilityGroupName;
            ReplicationMode = replicationMode;
            DistributedAvailabilityGroupId = distributedAvailabilityGroupId;
            SourceReplicaId = sourceReplicaId;
            TargetReplicaId = targetReplicaId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the target database
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetDatabase")]
        public string TargetDatabase { get; set; }

        /// <summary>
        /// Gets or sets the source endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceEndpoint")]
        public string SourceEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the primary availability group name
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAvailabilityGroupName")]
        public string PrimaryAvailabilityGroupName { get; set; }

        /// <summary>
        /// Gets or sets the secondary availability group name
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryAvailabilityGroupName")]
        public string SecondaryAvailabilityGroupName { get; set; }

        /// <summary>
        /// Gets or sets the replication mode of hybrid link. Parameter will be
        /// ignored during link creation. Possible values include: 'Async',
        /// 'Sync'
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationMode")]
        public string ReplicationMode { get; set; }

        /// <summary>
        /// Gets the distributed availability group id
        /// </summary>
        [JsonProperty(PropertyName = "properties.distributedAvailabilityGroupId")]
        public System.Guid? DistributedAvailabilityGroupId { get; private set; }

        /// <summary>
        /// Gets the source replica id
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceReplicaId")]
        public System.Guid? SourceReplicaId { get; private set; }

        /// <summary>
        /// Gets the target replica id
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetReplicaId")]
        public System.Guid? TargetReplicaId { get; private set; }

    }
}
