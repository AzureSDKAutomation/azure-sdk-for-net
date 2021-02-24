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
    /// Static Site Custom Domain Overview ARM resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteCustomDomainOverviewARMResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteCustomDomainOverviewARMResource class.
        /// </summary>
        public StaticSiteCustomDomainOverviewARMResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteCustomDomainOverviewARMResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="domainName">The domain name for the static site custom
        /// domain.</param>
        /// <param name="createdOn">The date and time on which the custom
        /// domain was created for the static site.</param>
        public StaticSiteCustomDomainOverviewARMResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string domainName = default(string), System.DateTime? createdOn = default(System.DateTime?))
            : base(id, name, kind, type, systemData)
        {
            DomainName = domainName;
            CreatedOn = createdOn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the domain name for the static site custom domain.
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainName")]
        public string DomainName { get; private set; }

        /// <summary>
        /// Gets the date and time on which the custom domain was created for
        /// the static site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdOn")]
        public System.DateTime? CreatedOn { get; private set; }

    }
}
