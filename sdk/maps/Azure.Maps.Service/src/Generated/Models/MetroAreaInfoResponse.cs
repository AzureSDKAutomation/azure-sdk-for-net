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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Metro Area Info call.
    /// </summary>
    public partial class MetroAreaInfoResponse
    {
        /// <summary>
        /// Initializes a new instance of the MetroAreaInfoResponse class.
        /// </summary>
        public MetroAreaInfoResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetroAreaInfoResponse class.
        /// </summary>
        /// <param name="metroName">The name of the metro area.</param>
        /// <param name="isFaresSupported">Indicates if public transit fares
        /// information is available in the metro area. Fare information is
        /// available through [Get Transit Route
        /// API](https://aka.ms/AzureMapsMobilityTransitRoute) and [Get Transit
        /// Itinerary
        /// APIs](https://aka.ms/AzureMapsMobilityTransitItinerary).</param>
        /// <param name="transitTypes">Supported transit types in the metro
        /// area. Returned if specified in the request.</param>
        /// <param name="agencies">A list of all public transit agencies
        /// operating in the given metro area.</param>
        /// <param name="alerts">A list of all public transit alerts within the
        /// given metro area.</param>
        public MetroAreaInfoResponse(string metroName = default(string), string isFaresSupported = default(string), IList<TransitTypeResult> transitTypes = default(IList<TransitTypeResult>), IList<AgencyDetails> agencies = default(IList<AgencyDetails>), IList<AlertInformation> alerts = default(IList<AlertInformation>))
        {
            MetroName = metroName;
            IsFaresSupported = isFaresSupported;
            TransitTypes = transitTypes;
            Agencies = agencies;
            Alerts = alerts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metro area.
        /// </summary>
        [JsonProperty(PropertyName = "metroName")]
        public string MetroName { get; set; }

        /// <summary>
        /// Gets or sets indicates if public transit fares information is
        /// available in the metro area. Fare information is available through
        /// [Get Transit Route
        /// API](https://aka.ms/AzureMapsMobilityTransitRoute) and [Get Transit
        /// Itinerary APIs](https://aka.ms/AzureMapsMobilityTransitItinerary).
        /// </summary>
        [JsonProperty(PropertyName = "isFaresSupported")]
        public string IsFaresSupported { get; set; }

        /// <summary>
        /// Gets or sets supported transit types in the metro area. Returned if
        /// specified in the request.
        /// </summary>
        [JsonProperty(PropertyName = "transitTypes")]
        public IList<TransitTypeResult> TransitTypes { get; set; }

        /// <summary>
        /// Gets or sets a list of all public transit agencies operating in the
        /// given metro area.
        /// </summary>
        [JsonProperty(PropertyName = "agencies")]
        public IList<AgencyDetails> Agencies { get; set; }

        /// <summary>
        /// Gets or sets a list of all public transit alerts within the given
        /// metro area.
        /// </summary>
        [JsonProperty(PropertyName = "alerts")]
        public IList<AlertInformation> Alerts { get; set; }

    }
}
