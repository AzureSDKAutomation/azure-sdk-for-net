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
    /// Static Site Reset Properties ARM resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteResetPropertiesARMResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteResetPropertiesARMResource class.
        /// </summary>
        public StaticSiteResetPropertiesARMResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteResetPropertiesARMResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="repositoryToken">The token which proves admin
        /// privileges to the repository.</param>
        /// <param name="shouldUpdateRepository">Determines whether the
        /// repository should be updated with the new properties.</param>
        public StaticSiteResetPropertiesARMResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string repositoryToken = default(string), bool? shouldUpdateRepository = default(bool?))
            : base(id, name, kind, type, systemData)
        {
            RepositoryToken = repositoryToken;
            ShouldUpdateRepository = shouldUpdateRepository;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the token which proves admin privileges to the
        /// repository.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryToken")]
        public string RepositoryToken { get; set; }

        /// <summary>
        /// Gets or sets determines whether the repository should be updated
        /// with the new properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shouldUpdateRepository")]
        public bool? ShouldUpdateRepository { get; set; }

    }
}
