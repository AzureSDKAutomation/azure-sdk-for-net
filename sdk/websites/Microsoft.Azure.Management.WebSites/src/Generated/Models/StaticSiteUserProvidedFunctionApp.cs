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
    /// A static site user provided function.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteUserProvidedFunctionApp : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the StaticSiteUserProvidedFunctionApp
        /// class.
        /// </summary>
        public StaticSiteUserProvidedFunctionApp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StaticSiteUserProvidedFunctionApp
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="functionAppResourceId">The resource id of the function
        /// app registered with the static site</param>
        /// <param name="functionAppRegion">The region of the function app
        /// registered with the static site</param>
        /// <param name="createdOn">The date and time on which the function app
        /// was registered with the static site.</param>
        public StaticSiteUserProvidedFunctionApp(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string functionAppResourceId = default(string), string functionAppRegion = default(string), System.DateTime? createdOn = default(System.DateTime?))
            : base(id, name, kind, type, systemData)
        {
            FunctionAppResourceId = functionAppResourceId;
            FunctionAppRegion = functionAppRegion;
            CreatedOn = createdOn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id of the function app registered with
        /// the static site
        /// </summary>
        [JsonProperty(PropertyName = "properties.functionAppResourceId")]
        public string FunctionAppResourceId { get; set; }

        /// <summary>
        /// Gets or sets the region of the function app registered with the
        /// static site
        /// </summary>
        [JsonProperty(PropertyName = "properties.functionAppRegion")]
        public string FunctionAppRegion { get; set; }

        /// <summary>
        /// Gets the date and time on which the function app was registered
        /// with the static site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdOn")]
        public System.DateTime? CreatedOn { get; private set; }

    }
}
