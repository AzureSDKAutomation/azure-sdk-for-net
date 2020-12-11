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
    using System.Linq;

    /// <summary>
    /// Network Virtual Appliance Sku Properties.
    /// </summary>
    public partial class SiteBreakOutCategoryPolicies
    {
        /// <summary>
        /// Initializes a new instance of the SiteBreakOutCategoryPolicies
        /// class.
        /// </summary>
        public SiteBreakOutCategoryPolicies()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteBreakOutCategoryPolicies
        /// class.
        /// </summary>
        /// <param name="allow">Flag to control breakout of o365 allow
        /// category.</param>
        /// <param name="optimize">Flag to control breakout of o365 optimize
        /// category.</param>
        /// <param name="defaultProperty">Flag to control breakout of o365
        /// default category.</param>
        public SiteBreakOutCategoryPolicies(bool? allow = default(bool?), bool? optimize = default(bool?), bool? defaultProperty = default(bool?))
        {
            Allow = allow;
            Optimize = optimize;
            DefaultProperty = defaultProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets flag to control breakout of o365 allow category.
        /// </summary>
        [JsonProperty(PropertyName = "allow")]
        public bool? Allow { get; set; }

        /// <summary>
        /// Gets or sets flag to control breakout of o365 optimize category.
        /// </summary>
        [JsonProperty(PropertyName = "optimize")]
        public bool? Optimize { get; set; }

        /// <summary>
        /// Gets or sets flag to control breakout of o365 default category.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public bool? DefaultProperty { get; set; }

    }
}
