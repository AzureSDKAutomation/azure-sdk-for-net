// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The effective route configured on the virtual hub or specified
    /// resource.
    /// </summary>
    public partial class VirtualHubEffectiveRoute
    {
        /// <summary>
        /// Initializes a new instance of the VirtualHubEffectiveRoute class.
        /// </summary>
        public VirtualHubEffectiveRoute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualHubEffectiveRoute class.
        /// </summary>
        /// <param name="addressPrefixes">The list of address prefixes.</param>
        /// <param name="nextHops">The list of next hops.</param>
        /// <param name="nextHopType">The type of the next hop.</param>
        /// <param name="asPath">The ASPath of this route.</param>
        /// <param name="routeOrigin">The origin of this route.</param>
        public VirtualHubEffectiveRoute(IList<string> addressPrefixes = default(IList<string>), IList<string> nextHops = default(IList<string>), string nextHopType = default(string), string asPath = default(string), string routeOrigin = default(string))
        {
            AddressPrefixes = addressPrefixes;
            NextHops = nextHops;
            NextHopType = nextHopType;
            AsPath = asPath;
            RouteOrigin = routeOrigin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of address prefixes.
        /// </summary>
        [JsonProperty(PropertyName = "addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets the list of next hops.
        /// </summary>
        [JsonProperty(PropertyName = "nextHops")]
        public IList<string> NextHops { get; set; }

        /// <summary>
        /// Gets or sets the type of the next hop.
        /// </summary>
        [JsonProperty(PropertyName = "nextHopType")]
        public string NextHopType { get; set; }

        /// <summary>
        /// Gets or sets the ASPath of this route.
        /// </summary>
        [JsonProperty(PropertyName = "asPath")]
        public string AsPath { get; set; }

        /// <summary>
        /// Gets or sets the origin of this route.
        /// </summary>
        [JsonProperty(PropertyName = "routeOrigin")]
        public string RouteOrigin { get; set; }

    }
}
