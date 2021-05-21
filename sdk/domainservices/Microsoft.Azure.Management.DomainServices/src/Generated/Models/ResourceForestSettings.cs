// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DomainServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Settings for Resource Forest
    /// </summary>
    public partial class ResourceForestSettings
    {
        /// <summary>
        /// Initializes a new instance of the ResourceForestSettings class.
        /// </summary>
        public ResourceForestSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceForestSettings class.
        /// </summary>
        /// <param name="settings">List of settings for Resource Forest</param>
        /// <param name="resourceForest">Resource Forest</param>
        public ResourceForestSettings(IList<ForestTrust> settings = default(IList<ForestTrust>), string resourceForest = default(string))
        {
            Settings = settings;
            ResourceForest = resourceForest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of settings for Resource Forest
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public IList<ForestTrust> Settings { get; set; }

        /// <summary>
        /// Gets or sets resource Forest
        /// </summary>
        [JsonProperty(PropertyName = "resourceForest")]
        public string ResourceForest { get; set; }

    }
}
