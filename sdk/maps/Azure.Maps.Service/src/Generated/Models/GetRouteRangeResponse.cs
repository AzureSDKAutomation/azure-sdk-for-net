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
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Route Reachable Range call
    /// </summary>
    public partial class GetRouteRangeResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetRouteRangeResponse class.
        /// </summary>
        public GetRouteRangeResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetRouteRangeResponse class.
        /// </summary>
        /// <param name="formatVersion">Format Version property</param>
        public GetRouteRangeResponse(string formatVersion = default(string), RouteRange reachableRange = default(RouteRange), RouteResponseReport report = default(RouteResponseReport))
        {
            FormatVersion = formatVersion;
            ReachableRange = reachableRange;
            Report = report;
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
        /// </summary>
        [JsonProperty(PropertyName = "reachableRange")]
        public RouteRange ReachableRange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "report")]
        public RouteResponseReport Report { get; set; }

    }
}
