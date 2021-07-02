// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Links to other WFS endpoints
    /// </summary>
    public partial class WfsEndpointLink
    {
        /// <summary>
        /// Initializes a new instance of the WfsEndpointLink class.
        /// </summary>
        public WfsEndpointLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WfsEndpointLink class.
        /// </summary>
        /// <param name="href">The link target.</param>
        /// <param name="rel">The relation type.</param>
        /// <param name="type">A hint indicating what the media type of the
        /// result of dereferencing the link should be.</param>
        /// <param name="hreflang">A hint indicating what the language of the
        /// result of dereferencing the link should be.</param>
        /// <param name="title">Used to label the destination of a link such
        /// that it can be used as a human-readable identifier (e.g., a menu
        /// entry) in the language indicated by the Content-Language header
        /// field (if present).</param>
        public WfsEndpointLink(string href, string rel = default(string), string type = default(string), string hreflang = default(string), string title = default(string))
        {
            Href = href;
            Rel = rel;
            Type = type;
            Hreflang = hreflang;
            Title = title;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the link target.
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the relation type.
        /// </summary>
        [JsonProperty(PropertyName = "rel")]
        public string Rel { get; set; }

        /// <summary>
        /// Gets or sets a hint indicating what the media type of the result of
        /// dereferencing the link should be.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a hint indicating what the language of the result of
        /// dereferencing the link should be.
        /// </summary>
        [JsonProperty(PropertyName = "hreflang")]
        public string Hreflang { get; set; }

        /// <summary>
        /// Gets or sets used to label the destination of a link such that it
        /// can be used as a human-readable identifier (e.g., a menu entry) in
        /// the language indicated by the Content-Language header field (if
        /// present).
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Href == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Href");
            }
        }
    }
}
