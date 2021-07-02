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
    using System.Linq;

    /// <summary>
    /// Short summary of the weather along the route.
    /// </summary>
    public partial class WeatherAlongRouteSummary
    {
        /// <summary>
        /// Initializes a new instance of the WeatherAlongRouteSummary class.
        /// </summary>
        public WeatherAlongRouteSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WeatherAlongRouteSummary class.
        /// </summary>
        /// <param name="iconCode">Numeric value representing an image that
        /// displays the `iconPhrase`. Please refer to [Weather Service
        /// Concepts](https://aka.ms/AzureMapsWeatherConcepts) for
        /// details.</param>
        public WeatherAlongRouteSummary(int? iconCode = default(int?), WeatherHazards hazards = default(WeatherHazards))
        {
            IconCode = iconCode;
            Hazards = hazards;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets numeric value representing an image that displays the
        /// `iconPhrase`. Please refer to [Weather Service
        /// Concepts](https://aka.ms/AzureMapsWeatherConcepts) for details.
        /// </summary>
        [JsonProperty(PropertyName = "iconCode")]
        public int? IconCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hazards")]
        public WeatherHazards Hazards { get; set; }

    }
}
