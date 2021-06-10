// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Service.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The stateset information detail.
    /// </summary>
    public partial class StatesetInfoObject
    {
        /// <summary>
        /// Initializes a new instance of the StatesetInfoObject class.
        /// </summary>
        public StatesetInfoObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatesetInfoObject class.
        /// </summary>
        /// <param name="statesetId">The stateset ID of this stateset.</param>
        /// <param name="description">Description associated with the
        /// stateset.</param>
        /// <param name="datasetIds">Dataset ID associated with the
        /// stateset.</param>
        public StatesetInfoObject(string statesetId = default(string), string description = default(string), IList<string> datasetIds = default(IList<string>), StylesObject statesetStyle = default(StylesObject))
        {
            StatesetId = statesetId;
            Description = description;
            DatasetIds = datasetIds;
            StatesetStyle = statesetStyle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the stateset ID of this stateset.
        /// </summary>
        [JsonProperty(PropertyName = "statesetId")]
        public string StatesetId { get; set; }

        /// <summary>
        /// Gets description associated with the stateset.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets or sets dataset ID associated with the stateset.
        /// </summary>
        [JsonProperty(PropertyName = "datasetIds")]
        public IList<string> DatasetIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statesetStyle")]
        public StylesObject StatesetStyle { get; set; }

    }
}
