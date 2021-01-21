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
    /// Static Site ARM resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteARMResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StaticSiteARMResource class.
        /// </summary>
        public StaticSiteARMResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StaticSiteARMResource class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="defaultHostname">The default autogenerated hostname
        /// for the static site.</param>
        /// <param name="repositoryUrl">URL for the repository of the static
        /// site.</param>
        /// <param name="branch">The target branch in the repository.</param>
        /// <param name="provider">The provider that submitted the last
        /// deployment to the primary environment of the static site.</param>
        /// <param name="customDomains">The custom domains associated with this
        /// static site.</param>
        /// <param name="repositoryToken">A user's github repository token.
        /// This is used to setup the Github Actions workflow file and API
        /// secrets.</param>
        /// <param name="buildProperties">Build properties to configure on the
        /// repository.</param>
        /// <param name="contentDistributionEndpoint">The content distribution
        /// endpoint for the static site.</param>
        /// <param name="keyVaultReferenceIdentity">Identity to use for Key
        /// Vault Reference authentication.</param>
        /// <param name="userProvidedFunctionApps">User provided function apps
        /// registered with the static site</param>
        public StaticSiteARMResource(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), string defaultHostname = default(string), string repositoryUrl = default(string), string branch = default(string), string provider = default(string), IList<string> customDomains = default(IList<string>), string repositoryToken = default(string), StaticSiteBuildProperties buildProperties = default(StaticSiteBuildProperties), string contentDistributionEndpoint = default(string), string keyVaultReferenceIdentity = default(string), IList<StaticSiteUserProvidedFunctionApp> userProvidedFunctionApps = default(IList<StaticSiteUserProvidedFunctionApp>), SkuDescription sku = default(SkuDescription))
            : base(location, id, name, kind, type, tags, systemData)
        {
            DefaultHostname = defaultHostname;
            RepositoryUrl = repositoryUrl;
            Branch = branch;
            Provider = provider;
            CustomDomains = customDomains;
            RepositoryToken = repositoryToken;
            BuildProperties = buildProperties;
            ContentDistributionEndpoint = contentDistributionEndpoint;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            UserProvidedFunctionApps = userProvidedFunctionApps;
            Sku = sku;
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
        /// Gets the provider that submitted the last deployment to the primary
        /// environment of the static site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provider")]
        public string Provider { get; private set; }

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
        /// Gets the content distribution endpoint for the static site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentDistributionEndpoint")]
        public string ContentDistributionEndpoint { get; private set; }

        /// <summary>
        /// Gets identity to use for Key Vault Reference authentication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; private set; }

        /// <summary>
        /// Gets user provided function apps registered with the static site
        /// </summary>
        [JsonProperty(PropertyName = "properties.userProvidedFunctionApps")]
        public IList<StaticSiteUserProvidedFunctionApp> UserProvidedFunctionApps { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SkuDescription Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
