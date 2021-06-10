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
    /// A line group
    /// </summary>
    public partial class ItineraryLineGroup
    {
        /// <summary>
        /// Initializes a new instance of the ItineraryLineGroup class.
        /// </summary>
        public ItineraryLineGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ItineraryLineGroup class.
        /// </summary>
        /// <param name="lineGroupId">Line group Id. Typically contains 2 lines
        /// having the same agency and line, one going from A to B, and the
        /// other from B to A.</param>
        /// <param name="agencyId">The Id of the transit agency, for example,
        /// '5872'.</param>
        /// <param name="agencyName">The name of the transit agency, e.g. Metro
        /// Transit.</param>
        /// <param name="lineNumber">The transit line number.</param>
        /// <param name="caption1">A descriptive string. In case caption2 is
        /// null, should be used alone as a subtitle to the line number (i.e.
        /// Circular). In case caption2 has a value present, should be used in
        /// conjunction with it (i.e. Rome ↔ Napoli).</param>
        /// <param name="caption2">A descriptive string.</param>
        /// <param name="color">HEX color for the line.</param>
        /// <param name="transitType">The public transit type of the line.
        /// Possible values include: 'Bus', 'CableCar', 'Ferry', 'Funicular',
        /// 'Gondola', 'Rail', 'Tram', 'Subway'</param>
        public ItineraryLineGroup(string lineGroupId = default(string), string agencyId = default(string), string agencyName = default(string), string lineNumber = default(string), string caption1 = default(string), string caption2 = default(string), string color = default(string), string transitType = default(string))
        {
            LineGroupId = lineGroupId;
            AgencyId = agencyId;
            AgencyName = agencyName;
            LineNumber = lineNumber;
            Caption1 = caption1;
            Caption2 = caption2;
            Color = color;
            TransitType = transitType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets line group Id. Typically contains 2 lines having the
        /// same agency and line, one going from A to B, and the other from B
        /// to A.
        /// </summary>
        [JsonProperty(PropertyName = "lineGroupId")]
        public string LineGroupId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the transit agency, for example, '5872'.
        /// </summary>
        [JsonProperty(PropertyName = "agencyId")]
        public string AgencyId { get; set; }

        /// <summary>
        /// Gets or sets the name of the transit agency, e.g. Metro Transit.
        /// </summary>
        [JsonProperty(PropertyName = "agencyName")]
        public string AgencyName { get; set; }

        /// <summary>
        /// Gets or sets the transit line number.
        /// </summary>
        [JsonProperty(PropertyName = "lineNumber")]
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets a descriptive string. In case caption2 is null, should
        /// be used alone as a subtitle to the line number (i.e. Circular). In
        /// case caption2 has a value present, should be used in conjunction
        /// with it (i.e. Rome ↔ Napoli).
        /// </summary>
        [JsonProperty(PropertyName = "caption1")]
        public string Caption1 { get; set; }

        /// <summary>
        /// Gets or sets a descriptive string.
        /// </summary>
        [JsonProperty(PropertyName = "caption2")]
        public string Caption2 { get; set; }

        /// <summary>
        /// Gets or sets HEX color for the line.
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the public transit type of the line. Possible values
        /// include: 'Bus', 'CableCar', 'Ferry', 'Funicular', 'Gondola',
        /// 'Rail', 'Tram', 'Subway'
        /// </summary>
        [JsonProperty(PropertyName = "transitType")]
        public string TransitType { get; set; }

    }
}
