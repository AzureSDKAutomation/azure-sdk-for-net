// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Featurestate.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The feature states model for a feature.
    /// </summary>
    public partial class FeatureStatesStructure
    {
        /// <summary>
        /// Initializes a new instance of the FeatureStatesStructure class.
        /// </summary>
        public FeatureStatesStructure()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeatureStatesStructure class.
        /// </summary>
        /// <param name="states">The feature states array.</param>
        public FeatureStatesStructure(IList<FeatureStateObject> states = default(IList<FeatureStateObject>))
        {
            States = states;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the feature states array.
        /// </summary>
        [JsonProperty(PropertyName = "states")]
        public IList<FeatureStateObject> States { get; set; }

    }
}
