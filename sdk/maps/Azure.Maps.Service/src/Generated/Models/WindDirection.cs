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
    /// Wind direction
    /// </summary>
    public partial class WindDirection
    {
        /// <summary>
        /// Initializes a new instance of the WindDirection class.
        /// </summary>
        public WindDirection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WindDirection class.
        /// </summary>
        /// <param name="degrees">Wind direction in Azimuth degrees,  starting
        /// at true North and continuing in clockwise direction. North is 0
        /// degrees, east is 90 degrees, south is 180 degrees, west is 270
        /// degrees. Possible values 0-359.</param>
        /// <param name="localizedDescription">Direction abbreviation in the
        /// specified language.</param>
        public WindDirection(int? degrees = default(int?), string localizedDescription = default(string))
        {
            Degrees = degrees;
            LocalizedDescription = localizedDescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets wind direction in Azimuth degrees,  starting at true
        /// North and continuing in clockwise direction. North is 0 degrees,
        /// east is 90 degrees, south is 180 degrees, west is 270 degrees.
        /// Possible values 0-359.
        /// </summary>
        [JsonProperty(PropertyName = "degrees")]
        public int? Degrees { get; set; }

        /// <summary>
        /// Gets or sets direction abbreviation in the specified language.
        /// </summary>
        [JsonProperty(PropertyName = "localizedDescription")]
        public string LocalizedDescription { get; set; }

    }
}
