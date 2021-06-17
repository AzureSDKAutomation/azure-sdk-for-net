// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebPubSub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the properties of a resource type that has been onboarded to
    /// private link service
    /// </summary>
    public partial class ShareablePrivateLinkResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ShareablePrivateLinkResourceProperties class.
        /// </summary>
        public ShareablePrivateLinkResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ShareablePrivateLinkResourceProperties class.
        /// </summary>
        /// <param name="description">The description of the resource type that
        /// has been onboarded to private link service</param>
        /// <param name="groupId">The resource provider group id for the
        /// resource that has been onboarded to private link service</param>
        /// <param name="type">The resource provider type for the resource that
        /// has been onboarded to private link service</param>
        public ShareablePrivateLinkResourceProperties(string description = default(string), string groupId = default(string), string type = default(string))
        {
            Description = description;
            GroupId = groupId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of the resource type that has been
        /// onboarded to private link service
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the resource provider group id for the resource that
        /// has been onboarded to private link service
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the resource provider type for the resource that has
        /// been onboarded to private link service
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
