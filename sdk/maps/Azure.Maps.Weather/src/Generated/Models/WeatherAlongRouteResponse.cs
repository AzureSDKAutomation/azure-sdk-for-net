// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Weather.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Weather Along Route.
    /// </summary>
    public partial class WeatherAlongRouteResponse
    {
        /// <summary>
        /// Initializes a new instance of the WeatherAlongRouteResponse class.
        /// </summary>
        public WeatherAlongRouteResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WeatherAlongRouteResponse class.
        /// </summary>
        /// <param name="waypoints">Data for each waypoint returned in the same
        /// order as specified in the request.</param>
        public WeatherAlongRouteResponse(WeatherAlongRouteSummary summary = default(WeatherAlongRouteSummary), IList<WeatherWaypoint> waypoints = default(IList<WeatherWaypoint>))
        {
            Summary = summary;
            Waypoints = waypoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public WeatherAlongRouteSummary Summary { get; set; }

        /// <summary>
        /// Gets or sets data for each waypoint returned in the same order as
        /// specified in the request.
        /// </summary>
        [JsonProperty(PropertyName = "waypoints")]
        public IList<WeatherWaypoint> Waypoints { get; set; }

    }
}
