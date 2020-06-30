// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Graph system data.
    /// </summary>
    public partial class MediaGraphSystemData
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphSystemData class.
        /// </summary>
        public MediaGraphSystemData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphSystemData class.
        /// </summary>
        /// <param name="createdAt">The timestamp of resource creation
        /// (UTC).</param>
        /// <param name="lastModifiedAt">The timestamp of resource last
        /// modification (UTC).</param>
        public MediaGraphSystemData(System.DateTime? createdAt = default(System.DateTime?), System.DateTime? lastModifiedAt = default(System.DateTime?))
        {
            CreatedAt = createdAt;
            LastModifiedAt = lastModifiedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timestamp of resource creation (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of resource last modification (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedAt")]
        public System.DateTime? LastModifiedAt { get; set; }

    }
}
