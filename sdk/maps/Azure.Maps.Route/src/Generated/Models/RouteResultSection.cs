// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Route.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RouteResultSection
    {
        /// <summary>
        /// Initializes a new instance of the RouteResultSection class.
        /// </summary>
        public RouteResultSection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteResultSection class.
        /// </summary>
        /// <param name="startPointIndex">Start Point Index property</param>
        /// <param name="endPointIndex">End Point Index property</param>
        /// <param name="sectionType">Section Type property</param>
        /// <param name="travelMode">Travel Mode property</param>
        /// <param name="simpleCategory">Type of the incident. Can currently be
        /// JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See "tec" for detailed
        /// information.</param>
        /// <param name="effectiveSpeedInKmh">Effective speed of the incident
        /// in km/h, averaged over its entire length.</param>
        /// <param name="delayInSeconds">Delay in seconds caused by the
        /// incident.</param>
        /// <param name="magnitudeOfDelay">The magnitude of delay caused by the
        /// incident. These values correspond to the values of the response
        /// field ty of the [Get Traffic Incident Detail
        /// API](https://docs.microsoft.com/rest/api/maps/traffic/gettrafficincidentdetail).
        /// Possible values include: '0', '1', '2', '3', '4'</param>
        public RouteResultSection(int? startPointIndex = default(int?), int? endPointIndex = default(int?), string sectionType = default(string), string travelMode = default(string), string simpleCategory = default(string), int? effectiveSpeedInKmh = default(int?), int? delayInSeconds = default(int?), string magnitudeOfDelay = default(string), RouteResultSectionTec tec = default(RouteResultSectionTec))
        {
            StartPointIndex = startPointIndex;
            EndPointIndex = endPointIndex;
            SectionType = sectionType;
            TravelMode = travelMode;
            SimpleCategory = simpleCategory;
            EffectiveSpeedInKmh = effectiveSpeedInKmh;
            DelayInSeconds = delayInSeconds;
            MagnitudeOfDelay = magnitudeOfDelay;
            Tec = tec;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets start Point Index property
        /// </summary>
        [JsonProperty(PropertyName = "startPointIndex")]
        public int? StartPointIndex { get; private set; }

        /// <summary>
        /// Gets end Point Index property
        /// </summary>
        [JsonProperty(PropertyName = "endPointIndex")]
        public int? EndPointIndex { get; private set; }

        /// <summary>
        /// Gets section Type property
        /// </summary>
        [JsonProperty(PropertyName = "sectionType")]
        public string SectionType { get; private set; }

        /// <summary>
        /// Gets travel Mode property
        /// </summary>
        [JsonProperty(PropertyName = "travelMode")]
        public string TravelMode { get; private set; }

        /// <summary>
        /// Gets type of the incident. Can currently be JAM, ROAD_WORK,
        /// ROAD_CLOSURE, or OTHER. See "tec" for detailed information.
        /// </summary>
        [JsonProperty(PropertyName = "simpleCategory")]
        public string SimpleCategory { get; private set; }

        /// <summary>
        /// Gets effective speed of the incident in km/h, averaged over its
        /// entire length.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveSpeedInKmh")]
        public int? EffectiveSpeedInKmh { get; private set; }

        /// <summary>
        /// Gets delay in seconds caused by the incident.
        /// </summary>
        [JsonProperty(PropertyName = "delayInSeconds")]
        public int? DelayInSeconds { get; private set; }

        /// <summary>
        /// Gets the magnitude of delay caused by the incident. These values
        /// correspond to the values of the response field ty of the [Get
        /// Traffic Incident Detail
        /// API](https://docs.microsoft.com/rest/api/maps/traffic/gettrafficincidentdetail).
        /// Possible values include: '0', '1', '2', '3', '4'
        /// </summary>
        [JsonProperty(PropertyName = "magnitudeOfDelay")]
        public string MagnitudeOfDelay { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tec")]
        public RouteResultSectionTec Tec { get; set; }

    }
}
