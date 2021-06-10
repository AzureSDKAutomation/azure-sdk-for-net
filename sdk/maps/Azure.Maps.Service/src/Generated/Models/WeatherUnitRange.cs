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
    /// Returned temperature values.
    /// </summary>
    public partial class WeatherUnitRange
    {
        /// <summary>
        /// Initializes a new instance of the WeatherUnitRange class.
        /// </summary>
        public WeatherUnitRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WeatherUnitRange class.
        /// </summary>
        /// <param name="minimum">Minimum temperature for the time
        /// period.</param>
        /// <param name="maximum">Maximum temperature for the time
        /// period</param>
        public WeatherUnitRange(WeatherUnit minimum = default(WeatherUnit), WeatherUnit maximum = default(WeatherUnit))
        {
            Minimum = minimum;
            Maximum = maximum;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum temperature for the time period.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public WeatherUnit Minimum { get; set; }

        /// <summary>
        /// Gets or sets maximum temperature for the time period
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public WeatherUnit Maximum { get; set; }

    }
}
