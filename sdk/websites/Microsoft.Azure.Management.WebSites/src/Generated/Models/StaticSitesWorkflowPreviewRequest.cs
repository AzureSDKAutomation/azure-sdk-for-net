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
    /// Request entity for previewing the Static Site workflow
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSitesWorkflowPreviewRequest : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the StaticSitesWorkflowPreviewRequest
        /// class.
        /// </summary>
        public StaticSitesWorkflowPreviewRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StaticSitesWorkflowPreviewRequest
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="repositoryUrl">URL for the repository of the static
        /// site.</param>
        /// <param name="branch">The target branch in the repository.</param>
        /// <param name="buildProperties">Build properties to configure on the
        /// repository.</param>
        public StaticSitesWorkflowPreviewRequest(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string repositoryUrl = default(string), string branch = default(string), StaticSiteBuildProperties buildProperties = default(StaticSiteBuildProperties))
            : base(id, name, kind, type, systemData)
        {
            RepositoryUrl = repositoryUrl;
            Branch = branch;
            BuildProperties = buildProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL for the repository of the static site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryUrl")]
        public string RepositoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the target branch in the repository.
        /// </summary>
        [JsonProperty(PropertyName = "properties.branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets build properties to configure on the repository.
        /// </summary>
        [JsonProperty(PropertyName = "properties.buildProperties")]
        public StaticSiteBuildProperties BuildProperties { get; set; }

    }
}
