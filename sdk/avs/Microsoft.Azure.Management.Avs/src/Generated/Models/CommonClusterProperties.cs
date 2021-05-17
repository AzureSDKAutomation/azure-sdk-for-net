// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The common properties of a cluster
    /// </summary>
    public partial class CommonClusterProperties
    {
        /// <summary>
        /// Initializes a new instance of the CommonClusterProperties class.
        /// </summary>
        public CommonClusterProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommonClusterProperties class.
        /// </summary>
        /// <param name="provisioningState">The state of the cluster
        /// provisioning. Possible values include: 'Succeeded', 'Failed',
        /// 'Cancelled', 'Deleting', 'Updating'</param>
        /// <param name="clusterSize">The cluster size</param>
        /// <param name="clusterId">The identity</param>
        /// <param name="hosts">The hosts</param>
        public CommonClusterProperties(string provisioningState = default(string), int? clusterSize = default(int?), int? clusterId = default(int?), IList<string> hosts = default(IList<string>))
        {
            ProvisioningState = provisioningState;
            ClusterSize = clusterSize;
            ClusterId = clusterId;
            Hosts = hosts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the cluster provisioning. Possible values
        /// include: 'Succeeded', 'Failed', 'Cancelled', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the cluster size
        /// </summary>
        [JsonProperty(PropertyName = "clusterSize")]
        public int? ClusterSize { get; set; }

        /// <summary>
        /// Gets the identity
        /// </summary>
        [JsonProperty(PropertyName = "clusterId")]
        public int? ClusterId { get; private set; }

        /// <summary>
        /// Gets the hosts
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; private set; }

    }
}
