// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of graph topologies.
    /// </summary>
    public partial class MediaGraphTopologyCollection
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphTopologyCollection
        /// class.
        /// </summary>
        public MediaGraphTopologyCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphTopologyCollection
        /// class.
        /// </summary>
        /// <param name="value">Collection of graph topologies.</param>
        /// <param name="continuationToken">Continuation token to use in
        /// subsequent calls to enumerate through the graph topologies
        /// collection (when the collection contains too many results to return
        /// in one response).</param>
        public MediaGraphTopologyCollection(IList<MediaGraphTopology> value = default(IList<MediaGraphTopology>), string continuationToken = default(string))
        {
            Value = value;
            ContinuationToken = continuationToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of graph topologies.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MediaGraphTopology> Value { get; set; }

        /// <summary>
        /// Gets or sets continuation token to use in subsequent calls to
        /// enumerate through the graph topologies collection (when the
        /// collection contains too many results to return in one response).
        /// </summary>
        [JsonProperty(PropertyName = "@continuationToken")]
        public string ContinuationToken { get; set; }

    }
}
