// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Traffic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A location represented as a latitude and longitude.
    /// </summary>
    public partial class CoordinatesPair
    {
        /// <summary>
        /// Initializes a new instance of the CoordinatesPair class.
        /// </summary>
        public CoordinatesPair()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CoordinatesPair class.
        /// </summary>
        /// <param name="latitude">Latitude property</param>
        /// <param name="longitude">Longitude property</param>
        public CoordinatesPair(double? latitude = default(double?), double? longitude = default(double?))
        {
            Latitude = latitude;
            Longitude = longitude;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets latitude property
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets longitude property
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

    }
}
