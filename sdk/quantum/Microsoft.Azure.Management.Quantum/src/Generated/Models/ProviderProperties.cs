// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quantum.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provider properties.
    /// </summary>
    public partial class ProviderProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProviderProperties class.
        /// </summary>
        public ProviderProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderProperties class.
        /// </summary>
        /// <param name="description">A description about this
        /// provider.</param>
        /// <param name="providerType">Provider type.</param>
        /// <param name="company">Company name.</param>
        /// <param name="defaultEndpoint">Provider's default endpoint.</param>
        /// <param name="aad">Azure Active Directory info.</param>
        /// <param name="managedApplication">Provider's Managed-Application
        /// info</param>
        /// <param name="targets">The list of targets available from this
        /// provider.</param>
        /// <param name="skus">The list of skus available from this
        /// provider.</param>
        /// <param name="quotaDimensions">The list of quota dimensions from the
        /// provider.</param>
        /// <param name="pricingDimensions">The list of pricing dimensions from
        /// the provider.</param>
        public ProviderProperties(string description = default(string), string providerType = default(string), string company = default(string), string defaultEndpoint = default(string), ProviderPropertiesAad aad = default(ProviderPropertiesAad), ProviderPropertiesManagedApplication managedApplication = default(ProviderPropertiesManagedApplication), IList<TargetDescription> targets = default(IList<TargetDescription>), IList<SkuDescription> skus = default(IList<SkuDescription>), IList<QuotaDimension> quotaDimensions = default(IList<QuotaDimension>), IList<PricingDimension> pricingDimensions = default(IList<PricingDimension>))
        {
            Description = description;
            ProviderType = providerType;
            Company = company;
            DefaultEndpoint = defaultEndpoint;
            Aad = aad;
            ManagedApplication = managedApplication;
            Targets = targets;
            Skus = skus;
            QuotaDimensions = quotaDimensions;
            PricingDimensions = pricingDimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a description about this provider.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets provider type.
        /// </summary>
        [JsonProperty(PropertyName = "providerType")]
        public string ProviderType { get; private set; }

        /// <summary>
        /// Gets company name.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public string Company { get; private set; }

        /// <summary>
        /// Gets provider's default endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "defaultEndpoint")]
        public string DefaultEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets azure Active Directory info.
        /// </summary>
        [JsonProperty(PropertyName = "aad")]
        public ProviderPropertiesAad Aad { get; set; }

        /// <summary>
        /// Gets or sets provider's Managed-Application info
        /// </summary>
        [JsonProperty(PropertyName = "managedApplication")]
        public ProviderPropertiesManagedApplication ManagedApplication { get; set; }

        /// <summary>
        /// Gets or sets the list of targets available from this provider.
        /// </summary>
        [JsonProperty(PropertyName = "targets")]
        public IList<TargetDescription> Targets { get; set; }

        /// <summary>
        /// Gets or sets the list of skus available from this provider.
        /// </summary>
        [JsonProperty(PropertyName = "skus")]
        public IList<SkuDescription> Skus { get; set; }

        /// <summary>
        /// Gets or sets the list of quota dimensions from the provider.
        /// </summary>
        [JsonProperty(PropertyName = "quotaDimensions")]
        public IList<QuotaDimension> QuotaDimensions { get; set; }

        /// <summary>
        /// Gets or sets the list of pricing dimensions from the provider.
        /// </summary>
        [JsonProperty(PropertyName = "pricingDimensions")]
        public IList<PricingDimension> PricingDimensions { get; set; }

    }
}