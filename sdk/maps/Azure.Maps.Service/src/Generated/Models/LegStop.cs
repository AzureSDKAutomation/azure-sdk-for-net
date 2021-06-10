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
    /// The stop's basic info
    /// </summary>
    public partial class LegStop
    {
        /// <summary>
        /// Initializes a new instance of the LegStop class.
        /// </summary>
        public LegStop()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LegStop class.
        /// </summary>
        /// <param name="stopId">The unique Azure Maps identifier for the
        /// respective public transit stop. When referring to public transit
        /// stops over time, it is recommended to use `stopId` since it will
        /// not change, as long as the physical stop exists.</param>
        /// <param name="stopKey">The GTFS stop Id. GTFS stop Ids are provided
        /// by the transit authority and subject to change.</param>
        /// <param name="stopName">The name of the stop.</param>
        /// <param name="stopCode">The stop code displayed at the physical
        /// stop. Returned if available.</param>
        /// <param name="position">The Stop's location, latitude and
        /// longitude.</param>
        /// <param name="mainTransitType">The transit type of most lines
        /// stopping at this stop. One of Tram, Subway, Rail, Bus, Ferry,
        /// CableCar, Gondola, Funicular</param>
        /// <param name="mainAgencyId">The Id of the transit agency of most
        /// lines stopping at this stop. For example '5872'.</param>
        /// <param name="mainAgencyName">The name of the agency of most lines
        /// stopping at this stop, for example, 'Metro Transit'.</param>
        public LegStop(string stopId = default(string), string stopKey = default(string), string stopName = default(string), string stopCode = default(string), CoordinatesPair position = default(CoordinatesPair), string mainTransitType = default(string), string mainAgencyId = default(string), string mainAgencyName = default(string))
        {
            StopId = stopId;
            StopKey = stopKey;
            StopName = stopName;
            StopCode = stopCode;
            Position = position;
            MainTransitType = mainTransitType;
            MainAgencyId = mainAgencyId;
            MainAgencyName = mainAgencyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique Azure Maps identifier for the respective
        /// public transit stop. When referring to public transit stops over
        /// time, it is recommended to use `stopId` since it will not change,
        /// as long as the physical stop exists.
        /// </summary>
        [JsonProperty(PropertyName = "stopId")]
        public string StopId { get; set; }

        /// <summary>
        /// Gets or sets the GTFS stop Id. GTFS stop Ids are provided by the
        /// transit authority and subject to change.
        /// </summary>
        [JsonProperty(PropertyName = "stopKey")]
        public string StopKey { get; set; }

        /// <summary>
        /// Gets or sets the name of the stop.
        /// </summary>
        [JsonProperty(PropertyName = "stopName")]
        public string StopName { get; set; }

        /// <summary>
        /// Gets or sets the stop code displayed at the physical stop. Returned
        /// if available.
        /// </summary>
        [JsonProperty(PropertyName = "stopCode")]
        public string StopCode { get; set; }

        /// <summary>
        /// Gets or sets the Stop's location, latitude and longitude.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public CoordinatesPair Position { get; set; }

        /// <summary>
        /// Gets or sets the transit type of most lines stopping at this stop.
        /// One of Tram, Subway, Rail, Bus, Ferry, CableCar, Gondola, Funicular
        /// </summary>
        [JsonProperty(PropertyName = "mainTransitType")]
        public string MainTransitType { get; set; }

        /// <summary>
        /// Gets or sets the Id of the transit agency of most lines stopping at
        /// this stop. For example '5872'.
        /// </summary>
        [JsonProperty(PropertyName = "mainAgencyId")]
        public string MainAgencyId { get; set; }

        /// <summary>
        /// Gets or sets the name of the agency of most lines stopping at this
        /// stop, for example, 'Metro Transit'.
        /// </summary>
        [JsonProperty(PropertyName = "mainAgencyName")]
        public string MainAgencyName { get; set; }

    }
}
