// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Location information.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        /// <param name="id">The fully qualified ID of the location. For
        /// example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000/locations/westus.</param>
        /// <param name="subscriptionId">The subscription ID.</param>
        /// <param name="name">The location name.</param>
        /// <param name="displayName">The display name of the location.</param>
        /// <param name="regionalDisplayName">The display name of the location
        /// and its region.</param>
        /// <param name="metadata">Metadata of the location, such as lat/long,
        /// paired region, and others.</param>
        public Location(string id = default(string), string subscriptionId = default(string), string name = default(string), string displayName = default(string), string regionalDisplayName = default(string), LocationMetadata metadata = default(LocationMetadata))
        {
            Id = id;
            SubscriptionId = subscriptionId;
            Name = name;
            DisplayName = displayName;
            RegionalDisplayName = regionalDisplayName;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the fully qualified ID of the location. For example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000/locations/westus.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the subscription ID.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets the location name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the display name of the location.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the display name of the location and its region.
        /// </summary>
        [JsonProperty(PropertyName = "regionalDisplayName")]
        public string RegionalDisplayName { get; private set; }

        /// <summary>
        /// Gets or sets metadata of the location, such as lat/long, paired
        /// region, and others.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public LocationMetadata Metadata { get; set; }

    }
}
