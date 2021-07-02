// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Route.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result of the query. RouteDirectionsResponse if the query completed
    /// successfully, ErrorResponse otherwise.
    /// </summary>
    public partial class RouteDirectionsBatchItemResponse
    {
        /// <summary>
        /// Initializes a new instance of the RouteDirectionsBatchItemResponse
        /// class.
        /// </summary>
        public RouteDirectionsBatchItemResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteDirectionsBatchItemResponse
        /// class.
        /// </summary>
        /// <param name="formatVersion">Format Version property</param>
        /// <param name="routes">Routes array</param>
        /// <param name="optimizedWaypoints">Optimized sequence of waypoints.
        /// It shows the index from the user provided waypoint sequence for the
        /// original and optimized list. For instance, a response:
        ///
        /// ```
        /// &lt;optimizedWaypoints&gt;
        /// &lt;waypoint providedIndex="0" optimizedIndex="1"/&gt;
        /// &lt;waypoint providedIndex="1" optimizedIndex="2"/&gt;
        /// &lt;waypoint providedIndex="2" optimizedIndex="0"/&gt;
        /// &lt;/optimizedWaypoints&gt;
        /// ```
        ///
        /// means that the original sequence is [0, 1, 2] and optimized
        /// sequence is [1, 2, 0]. Since the index starts by 0 the original is
        /// "first, second, third" while the optimized is "second, third,
        /// first".</param>
        /// <param name="error">The error object.</param>
        public RouteDirectionsBatchItemResponse(string formatVersion = default(string), IList<RouteDirectionsResult> routes = default(IList<RouteDirectionsResult>), IList<RouteOptimizedWaypoint> optimizedWaypoints = default(IList<RouteOptimizedWaypoint>), RouteResponseReport report = default(RouteResponseReport), ErrorDetail error = default(ErrorDetail))
        {
            FormatVersion = formatVersion;
            Routes = routes;
            OptimizedWaypoints = optimizedWaypoints;
            Report = report;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets format Version property
        /// </summary>
        [JsonProperty(PropertyName = "formatVersion")]
        public string FormatVersion { get; private set; }

        /// <summary>
        /// Gets routes array
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<RouteDirectionsResult> Routes { get; private set; }

        /// <summary>
        /// Gets optimized sequence of waypoints. It shows the index from the
        /// user provided waypoint sequence for the original and optimized
        /// list. For instance, a response:
        ///
        /// ```
        /// &amp;lt;optimizedWaypoints&amp;gt;
        /// &amp;lt;waypoint providedIndex="0" optimizedIndex="1"/&amp;gt;
        /// &amp;lt;waypoint providedIndex="1" optimizedIndex="2"/&amp;gt;
        /// &amp;lt;waypoint providedIndex="2" optimizedIndex="0"/&amp;gt;
        /// &amp;lt;/optimizedWaypoints&amp;gt;
        /// ```
        ///
        /// means that the original sequence is [0, 1, 2] and optimized
        /// sequence is [1, 2, 0]. Since the index starts by 0 the original is
        /// "first, second, third" while the optimized is "second, third,
        /// first".
        /// </summary>
        [JsonProperty(PropertyName = "optimizedWaypoints")]
        public IList<RouteOptimizedWaypoint> OptimizedWaypoints { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "report")]
        public RouteResponseReport Report { get; set; }

        /// <summary>
        /// Gets or sets the error object.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorDetail Error { get; set; }

    }
}
