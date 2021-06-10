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

    public partial class TrafficIncidentPoi
    {
        /// <summary>
        /// Initializes a new instance of the TrafficIncidentPoi class.
        /// </summary>
        public TrafficIncidentPoi()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficIncidentPoi class.
        /// </summary>
        /// <param name="id">ID of the traffic incident</param>
        /// <param name="p">The point where an icon of the cluster or raw
        /// incident should be drawn, expressed in the requested projection.
        /// This is affected by traffic style, zoom level and road type</param>
        /// <param name="ic">The icon category associated with this incident.
        /// Values are numbers in the range 0-13, with the following meanings
        /// -- 0: Unknown, 1: Accident, 2: Fog, 3: Dangerous Conditions, 4:
        /// Rain, 5: Ice, 6: Jam, 7: Lane Closed, 8: Road Closed, 9: Road
        /// Works, 10: Wind, 11: Flooding, 12: Detour, 13: Cluster</param>
        /// <param name="ty">The magnitude of delay associated with incident.
        /// These values correspond to incident colors in the traffic
        /// tiles</param>
        /// <param name="cbl">Bottom left coordinate of the cluster in the
        /// projection of the request</param>
        /// <param name="ctr">Top right coordinate of the cluster in the
        /// projection of the request</param>
        /// <param name="cs">Cluster size: the number of incidents in the
        /// cluster</param>
        /// <param name="l">Length of the incident in meters</param>
        /// <param name="r">The road number(s) affected by the incident.
        /// Multiple road numbers will delimited by slashes</param>
        /// <param name="dl">Delay caused by the incident in seconds (except in
        /// road closures)</param>
        /// <param name="t">To: the name of the intersection or location where
        /// the traffic due to the incident ends</param>
        /// <param name="f">From: the name of the intersection or location
        /// where the traffic due to the incident starts</param>
        /// <param name="d">Description of the incident in the language
        /// requested</param>
        /// <param name="c">Cause of the incident, where available, in the
        /// language requested</param>
        public TrafficIncidentPoi(string id = default(string), TrafficIncidentPoiP p = default(TrafficIncidentPoiP), int? ic = default(int?), int? ty = default(int?), TrafficIncidentPoiCbl cbl = default(TrafficIncidentPoiCbl), TrafficIncidentPoiCtr ctr = default(TrafficIncidentPoiCtr), int? cs = default(int?), int? l = default(int?), string r = default(string), int? dl = default(int?), string t = default(string), string f = default(string), string d = default(string), string c = default(string))
        {
            Id = id;
            P = p;
            Ic = ic;
            Ty = ty;
            Cbl = cbl;
            Ctr = ctr;
            Cs = cs;
            L = l;
            R = r;
            Dl = dl;
            T = t;
            F = f;
            D = d;
            C = c;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID of the traffic incident
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the point where an icon of the cluster or raw incident should
        /// be drawn, expressed in the requested projection. This is affected
        /// by traffic style, zoom level and road type
        /// </summary>
        [JsonProperty(PropertyName = "p")]
        public TrafficIncidentPoiP P { get; private set; }

        /// <summary>
        /// Gets the icon category associated with this incident. Values are
        /// numbers in the range 0-13, with the following meanings -- 0:
        /// Unknown, 1: Accident, 2: Fog, 3: Dangerous Conditions, 4: Rain, 5:
        /// Ice, 6: Jam, 7: Lane Closed, 8: Road Closed, 9: Road Works, 10:
        /// Wind, 11: Flooding, 12: Detour, 13: Cluster
        /// </summary>
        [JsonProperty(PropertyName = "ic")]
        public int? Ic { get; private set; }

        /// <summary>
        /// Gets the magnitude of delay associated with incident. These values
        /// correspond to incident colors in the traffic tiles
        /// </summary>
        [JsonProperty(PropertyName = "ty")]
        public int? Ty { get; private set; }

        /// <summary>
        /// Gets bottom left coordinate of the cluster in the projection of the
        /// request
        /// </summary>
        [JsonProperty(PropertyName = "cbl")]
        public TrafficIncidentPoiCbl Cbl { get; private set; }

        /// <summary>
        /// Gets top right coordinate of the cluster in the projection of the
        /// request
        /// </summary>
        [JsonProperty(PropertyName = "ctr")]
        public TrafficIncidentPoiCtr Ctr { get; private set; }

        /// <summary>
        /// Gets cluster size: the number of incidents in the cluster
        /// </summary>
        [JsonProperty(PropertyName = "cs")]
        public int? Cs { get; private set; }

        /// <summary>
        /// Gets length of the incident in meters
        /// </summary>
        [JsonProperty(PropertyName = "l")]
        public int? L { get; private set; }

        /// <summary>
        /// Gets the road number(s) affected by the incident. Multiple road
        /// numbers will delimited by slashes
        /// </summary>
        [JsonProperty(PropertyName = "r")]
        public string R { get; private set; }

        /// <summary>
        /// Gets delay caused by the incident in seconds (except in road
        /// closures)
        /// </summary>
        [JsonProperty(PropertyName = "dl")]
        public int? Dl { get; private set; }

        /// <summary>
        /// Gets to: the name of the intersection or location where the traffic
        /// due to the incident ends
        /// </summary>
        [JsonProperty(PropertyName = "t")]
        public string T { get; private set; }

        /// <summary>
        /// Gets from: the name of the intersection or location where the
        /// traffic due to the incident starts
        /// </summary>
        [JsonProperty(PropertyName = "f")]
        public string F { get; private set; }

        /// <summary>
        /// Gets description of the incident in the language requested
        /// </summary>
        [JsonProperty(PropertyName = "d")]
        public string D { get; private set; }

        /// <summary>
        /// Gets cause of the incident, where available, in the language
        /// requested
        /// </summary>
        [JsonProperty(PropertyName = "c")]
        public string C { get; private set; }

    }
}
