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

    public partial class RouteDirectionsResult
    {
        /// <summary>
        /// Initializes a new instance of the RouteDirectionsResult class.
        /// </summary>
        public RouteDirectionsResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteDirectionsResult class.
        /// </summary>
        /// <param name="legs">Legs array</param>
        /// <param name="sections">Sections array</param>
        public RouteDirectionsResult(RouteDirectionsSummary summary = default(RouteDirectionsSummary), IList<RouteResultLeg> legs = default(IList<RouteResultLeg>), IList<RouteResultSection> sections = default(IList<RouteResultSection>), RouteResultGuidance guidance = default(RouteResultGuidance))
        {
            Summary = summary;
            Legs = legs;
            Sections = sections;
            Guidance = guidance;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public RouteDirectionsSummary Summary { get; set; }

        /// <summary>
        /// Gets legs array
        /// </summary>
        [JsonProperty(PropertyName = "legs")]
        public IList<RouteResultLeg> Legs { get; private set; }

        /// <summary>
        /// Gets sections array
        /// </summary>
        [JsonProperty(PropertyName = "sections")]
        public IList<RouteResultSection> Sections { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "guidance")]
        public RouteResultGuidance Guidance { get; set; }

    }
}
