// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.Edge.LiveVideoAnalytics.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a Media Graph instance.
    /// </summary>
    public partial class MediaGraphInstanceProperties
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphInstanceProperties
        /// class.
        /// </summary>
        public MediaGraphInstanceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphInstanceProperties
        /// class.
        /// </summary>
        /// <param name="description">An optional description for the
        /// instance.</param>
        /// <param name="topologyName">The name of the graph topology that this
        /// instance will run. A topology with this name should already have
        /// been set in the Edge module.</param>
        /// <param name="parameters">List of one or more graph instance
        /// parameters.</param>
        /// <param name="state">Allowed states for a graph Instance. Possible
        /// values include: 'Inactive', 'Activating', 'Active',
        /// 'Deactivating'</param>
        public MediaGraphInstanceProperties(string description = default(string), string topologyName = default(string), IList<MediaGraphParameterDefinition> parameters = default(IList<MediaGraphParameterDefinition>), MediaGraphInstanceState? state = default(MediaGraphInstanceState?))
        {
            Description = description;
            TopologyName = topologyName;
            Parameters = parameters;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an optional description for the instance.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the graph topology that this instance will
        /// run. A topology with this name should already have been set in the
        /// Edge module.
        /// </summary>
        [JsonProperty(PropertyName = "topologyName")]
        public string TopologyName { get; set; }

        /// <summary>
        /// Gets or sets list of one or more graph instance parameters.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<MediaGraphParameterDefinition> Parameters { get; set; }

        /// <summary>
        /// Gets or sets allowed states for a graph Instance. Possible values
        /// include: 'Inactive', 'Activating', 'Active', 'Deactivating'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public MediaGraphInstanceState? State { get; set; }

    }
}
