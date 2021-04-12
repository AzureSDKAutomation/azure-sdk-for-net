// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PeeringService provider
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PeeringServiceProvider : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PeeringServiceProvider class.
        /// </summary>
        public PeeringServiceProvider()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringServiceProvider class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="serviceProviderName">The name of the service
        /// provider.</param>
        /// <param name="peeringLocations">The list of locations at which the
        /// service provider peers with Microsoft.</param>
        public PeeringServiceProvider(string name = default(string), string id = default(string), string type = default(string), string serviceProviderName = default(string), IList<string> peeringLocations = default(IList<string>))
            : base(name, id, type)
        {
            ServiceProviderName = serviceProviderName;
            PeeringLocations = peeringLocations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the service provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderName")]
        public string ServiceProviderName { get; set; }

        /// <summary>
        /// Gets or sets the list of locations at which the service provider
        /// peers with Microsoft.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringLocations")]
        public IList<string> PeeringLocations { get; set; }

    }
}
