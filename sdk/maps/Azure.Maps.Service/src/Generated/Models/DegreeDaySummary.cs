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

    public partial class DegreeDaySummary
    {
        /// <summary>
        /// Initializes a new instance of the DegreeDaySummary class.
        /// </summary>
        public DegreeDaySummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DegreeDaySummary class.
        /// </summary>
        /// <param name="heating">Number of degrees that the mean temperature
        /// is below 65 degrees F/ 18 degree C.</param>
        /// <param name="cooling">Number of degrees that the mean temperature
        /// is above 65 degrees F/ 18 degree C.</param>
        public DegreeDaySummary(WeatherUnit heating = default(WeatherUnit), WeatherUnit cooling = default(WeatherUnit))
        {
            Heating = heating;
            Cooling = cooling;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of degrees that the mean temperature is below
        /// 65 degrees F/ 18 degree C.
        /// </summary>
        [JsonProperty(PropertyName = "heating")]
        public WeatherUnit Heating { get; set; }

        /// <summary>
        /// Gets or sets number of degrees that the mean temperature is above
        /// 65 degrees F/ 18 degree C.
        /// </summary>
        [JsonProperty(PropertyName = "cooling")]
        public WeatherUnit Cooling { get; set; }

    }
}
