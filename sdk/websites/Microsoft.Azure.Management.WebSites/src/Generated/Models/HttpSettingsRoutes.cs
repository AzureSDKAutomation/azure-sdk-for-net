// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the paths HTTP requests.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HttpSettingsRoutes : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the HttpSettingsRoutes class.
        /// </summary>
        public HttpSettingsRoutes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpSettingsRoutes class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="apiPrefix">The prefix that should precede all the
        /// authentication/authorization paths.</param>
        public HttpSettingsRoutes(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string apiPrefix = default(string))
            : base(id, name, kind, type, systemData)
        {
            ApiPrefix = apiPrefix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the prefix that should precede all the
        /// authentication/authorization paths.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiPrefix")]
        public string ApiPrefix { get; set; }

    }
}
