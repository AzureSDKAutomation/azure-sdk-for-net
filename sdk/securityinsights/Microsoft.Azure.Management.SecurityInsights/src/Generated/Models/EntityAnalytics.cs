// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings with single toggle.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EntityAnalytics : Settings
    {
        /// <summary>
        /// Initializes a new instance of the EntityAnalytics class.
        /// </summary>
        public EntityAnalytics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityAnalytics class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="isEnabled">Determines whether the setting is enable or
        /// disabled.</param>
        public EntityAnalytics(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), SystemData systemData = default(SystemData), bool? isEnabled = default(bool?))
            : base(id, name, type, etag, systemData)
        {
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets determines whether the setting is enable or disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; private set; }

    }
}
