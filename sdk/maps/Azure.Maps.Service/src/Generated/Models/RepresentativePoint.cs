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
    /// Representative point property
    /// </summary>
    public partial class RepresentativePoint
    {
        /// <summary>
        /// Initializes a new instance of the RepresentativePoint class.
        /// </summary>
        public RepresentativePoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepresentativePoint class.
        /// </summary>
        /// <param name="latitude">Latitude property</param>
        /// <param name="longitude">Longitude property</param>
        public RepresentativePoint(double? latitude = default(double?), double? longitude = default(double?))
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
        /// Gets latitude property
        /// </summary>
        [JsonProperty(PropertyName = "Latitude")]
        public double? Latitude { get; private set; }

        /// <summary>
        /// Gets longitude property
        /// </summary>
        [JsonProperty(PropertyName = "Longitude")]
        public double? Longitude { get; private set; }

    }
}
