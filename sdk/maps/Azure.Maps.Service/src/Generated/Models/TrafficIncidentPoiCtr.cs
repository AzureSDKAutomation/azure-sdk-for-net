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
    /// Top right coordinate of the cluster in the projection of the request
    /// </summary>
    public partial class TrafficIncidentPoiCtr
    {
        /// <summary>
        /// Initializes a new instance of the TrafficIncidentPoiCtr class.
        /// </summary>
        public TrafficIncidentPoiCtr()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficIncidentPoiCtr class.
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public TrafficIncidentPoiCtr(double? x = default(double?), double? y = default(double?))
        {
            X = x;
            Y = y;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets x coordinate
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public double? X { get; private set; }

        /// <summary>
        /// Gets y coordinate
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public double? Y { get; private set; }

    }
}
