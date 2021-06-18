// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.WFS.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LandingPageResponse
    {
        /// <summary>
        /// Initializes a new instance of the LandingPageResponse class.
        /// </summary>
        public LandingPageResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LandingPageResponse class.
        /// </summary>
        /// <param name="links">Links to other WFS endpoints.</param>
        public LandingPageResponse(IList<WfsEndpointLink> links, string ontology = default(string))
        {
            Ontology = ontology;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ontology")]
        public string Ontology { get; set; }

        /// <summary>
        /// Gets or sets links to other WFS endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<WfsEndpointLink> Links { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Links == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Links");
            }
            if (Links != null)
            {
                foreach (var element in Links)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
