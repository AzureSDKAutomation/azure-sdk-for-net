// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Tenant Id information.
    /// </summary>
    public partial class TenantIdDescription
    {
        /// <summary>
        /// Initializes a new instance of the TenantIdDescription class.
        /// </summary>
        public TenantIdDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantIdDescription class.
        /// </summary>
        /// <param name="id">The fully qualified ID of the tenant. For example,
        /// /tenants/00000000-0000-0000-0000-000000000000.</param>
        /// <param name="tenantId">The tenant ID. For example,
        /// 00000000-0000-0000-0000-000000000000.</param>
        /// <param name="tenantCategory">Category of the tenant. Possible
        /// values include: 'Home', 'ProjectedBy', 'ManagedBy'</param>
        /// <param name="country">Country/region name of the address for the
        /// tenant.</param>
        /// <param name="countryCode">Country/region abbreviation for the
        /// tenant.</param>
        /// <param name="displayName">The display name of the tenant.</param>
        /// <param name="domains">The list of domains for the tenant.</param>
        /// <param name="defaultDomain">The default domain for the
        /// tenant.</param>
        /// <param name="tenantType">The tenant type. Only available for 'Home'
        /// tenant category.</param>
        /// <param name="tenantBrandingLogoUrl">The tenant's branding logo URL.
        /// Only available for 'Home' tenant category.</param>
        public TenantIdDescription(string id = default(string), string tenantId = default(string), TenantCategory? tenantCategory = default(TenantCategory?), string country = default(string), string countryCode = default(string), string displayName = default(string), IList<string> domains = default(IList<string>), string defaultDomain = default(string), string tenantType = default(string), string tenantBrandingLogoUrl = default(string))
        {
            Id = id;
            TenantId = tenantId;
            TenantCategory = tenantCategory;
            Country = country;
            CountryCode = countryCode;
            DisplayName = displayName;
            Domains = domains;
            DefaultDomain = defaultDomain;
            TenantType = tenantType;
            TenantBrandingLogoUrl = tenantBrandingLogoUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the fully qualified ID of the tenant. For example,
        /// /tenants/00000000-0000-0000-0000-000000000000.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the tenant ID. For example,
        /// 00000000-0000-0000-0000-000000000000.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets category of the tenant. Possible values include: 'Home',
        /// 'ProjectedBy', 'ManagedBy'
        /// </summary>
        [JsonProperty(PropertyName = "tenantCategory")]
        public TenantCategory? TenantCategory { get; private set; }

        /// <summary>
        /// Gets country/region name of the address for the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; private set; }

        /// <summary>
        /// Gets country/region abbreviation for the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; private set; }

        /// <summary>
        /// Gets the display name of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the list of domains for the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public IList<string> Domains { get; private set; }

        /// <summary>
        /// Gets the default domain for the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "defaultDomain")]
        public string DefaultDomain { get; private set; }

        /// <summary>
        /// Gets the tenant type. Only available for 'Home' tenant category.
        /// </summary>
        [JsonProperty(PropertyName = "tenantType")]
        public string TenantType { get; private set; }

        /// <summary>
        /// Gets the tenant's branding logo URL. Only available for 'Home'
        /// tenant category.
        /// </summary>
        [JsonProperty(PropertyName = "tenantBrandingLogoUrl")]
        public string TenantBrandingLogoUrl { get; private set; }

    }
}
