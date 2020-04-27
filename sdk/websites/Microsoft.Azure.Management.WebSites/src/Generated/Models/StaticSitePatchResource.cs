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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ARM resource for a static site when patching
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSitePatchResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the StaticSitePatchResource class.
        /// </summary>
        public StaticSitePatchResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StaticSitePatchResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="defaultHostname">The default autogenerated hostname
        /// for the static site.</param>
        /// <param name="repositoryUrl">URL for the repository of the static
        /// site.</param>
        /// <param name="branch">The target branch in the repository.</param>
        /// <param name="customDomains">The custom domains associated with this
        /// static site.</param>
        /// <param name="repositoryToken">A user's github repository token.
        /// This is used to setup the Github Actions workflow file and API
        /// secrets.</param>
        /// <param name="buildProperties">Build properties to configure on the
        /// repository.</param>
        /// <param name="privateEndpointConnections">Private endpoint
        /// connections referencing this resource.</param>
        public StaticSitePatchResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string defaultHostname = default(string), string repositoryUrl = default(string), string branch = default(string), IList<string> customDomains = default(IList<string>), string repositoryToken = default(string), StaticSiteBuildProperties buildProperties = default(StaticSiteBuildProperties), IList<PrivateEndpointConnectionResource> privateEndpointConnections = default(IList<PrivateEndpointConnectionResource>))
            : base(id, name, kind, type)
        {
            DefaultHostname = defaultHostname;
            RepositoryUrl = repositoryUrl;
            Branch = branch;
            CustomDomains = customDomains;
            RepositoryToken = repositoryToken;
            BuildProperties = buildProperties;
            PrivateEndpointConnections = privateEndpointConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the default autogenerated hostname for the static site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultHostname")]
        public string DefaultHostname { get; private set; }

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
        /// Gets the custom domains associated with this static site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomains")]
        public IList<string> CustomDomains { get; private set; }

        /// <summary>
        /// Gets or sets a user's github repository token. This is used to
        /// setup the Github Actions workflow file and API secrets.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryToken")]
        public string RepositoryToken { get; set; }

        /// <summary>
        /// Gets or sets build properties to configure on the repository.
        /// </summary>
        [JsonProperty(PropertyName = "properties.buildProperties")]
        public StaticSiteBuildProperties BuildProperties { get; set; }

        /// <summary>
        /// Gets private endpoint connections referencing this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnectionResource> PrivateEndpointConnections { get; private set; }

    }
}
