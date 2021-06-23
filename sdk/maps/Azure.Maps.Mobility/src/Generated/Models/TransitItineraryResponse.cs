// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Mobility.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Get Transit Itinerary call
    /// </summary>
    public partial class TransitItineraryResponse
    {
        /// <summary>
        /// Initializes a new instance of the TransitItineraryResponse class.
        /// </summary>
        public TransitItineraryResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransitItineraryResponse class.
        /// </summary>
        /// <param name="departureTime">The date and time of departure from the
        /// origin point in ISO 8601 format, e.g.
        /// 1996-12-19T16:39:57-08:00.</param>
        /// <param name="arrivalTime">The date and time of arrival at the
        /// destination point in ISO 8601 format, e.g.
        /// 1996-12-19T19:39:57-08:00.</param>
        /// <param name="itineraryFare">Itinerary level transit fare
        /// information. Returned only if fare information is available for the
        /// entire itinerary. [Get Metro Area Info
        /// API](https://aka.ms/AzureMapsMobilityMetroAreaInfo) can be
        /// requested to confirm if fare information is available in the metro
        /// area.</param>
        public TransitItineraryResponse(string departureTime = default(string), string arrivalTime = default(string), IList<ItineraryLeg> legs = default(IList<ItineraryLeg>), ItineraryFare itineraryFare = default(ItineraryFare))
        {
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Legs = legs;
            ItineraryFare = itineraryFare;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the date and time of departure from the origin point
        /// in ISO 8601 format, e.g. 1996-12-19T16:39:57-08:00.
        /// </summary>
        [JsonProperty(PropertyName = "departureTime")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Gets or sets the date and time of arrival at the destination point
        /// in ISO 8601 format, e.g. 1996-12-19T19:39:57-08:00.
        /// </summary>
        [JsonProperty(PropertyName = "arrivalTime")]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "legs")]
        public IList<ItineraryLeg> Legs { get; set; }

        /// <summary>
        /// Gets or sets itinerary level transit fare information. Returned
        /// only if fare information is available for the entire itinerary.
        /// [Get Metro Area Info
        /// API](https://aka.ms/AzureMapsMobilityMetroAreaInfo) can be
        /// requested to confirm if fare information is available in the metro
        /// area.
        /// </summary>
        [JsonProperty(PropertyName = "itineraryFare")]
        public ItineraryFare ItineraryFare { get; set; }

    }
}
