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
    /// The configuration settings of each of the identity providers used to
    /// configure App Service Authentication/Authorization.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IdentityProviders : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the IdentityProviders class.
        /// </summary>
        public IdentityProviders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityProviders class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="azureActiveDirectory">The configuration settings of
        /// the Azure Active directory provider.</param>
        /// <param name="facebook">The configuration settings of the Facebook
        /// provider.</param>
        /// <param name="gitHub">The configuration settings of the GitHub
        /// provider.</param>
        /// <param name="google">The configuration settings of the Google
        /// provider.</param>
        /// <param name="twitter">The configuration settings of the Twitter
        /// provider.</param>
        /// <param name="customOpenIdConnectProviders">The map of the name of
        /// the alias of each custom Open ID Connect provider to the
        /// configuration settings of the custom Open ID Connect
        /// provider.</param>
        /// <param name="legacyMicrosoftAccount">The configuration settings of
        /// the legacy Microsoft Account provider.</param>
        /// <param name="apple">The configuration settings of the Apple
        /// provider.</param>
        /// <param name="azureStaticWebApps">The configuration settings of the
        /// Azure Static Web Apps provider.</param>
        public IdentityProviders(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), AzureActiveDirectory azureActiveDirectory = default(AzureActiveDirectory), Facebook facebook = default(Facebook), GitHub gitHub = default(GitHub), Google google = default(Google), Twitter twitter = default(Twitter), IDictionary<string, CustomOpenIdConnectProvider> customOpenIdConnectProviders = default(IDictionary<string, CustomOpenIdConnectProvider>), LegacyMicrosoftAccount legacyMicrosoftAccount = default(LegacyMicrosoftAccount), Apple apple = default(Apple), AzureStaticWebApps azureStaticWebApps = default(AzureStaticWebApps))
            : base(id, name, kind, type, systemData)
        {
            AzureActiveDirectory = azureActiveDirectory;
            Facebook = facebook;
            GitHub = gitHub;
            Google = google;
            Twitter = twitter;
            CustomOpenIdConnectProviders = customOpenIdConnectProviders;
            LegacyMicrosoftAccount = legacyMicrosoftAccount;
            Apple = apple;
            AzureStaticWebApps = azureStaticWebApps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the configuration settings of the Azure Active
        /// directory provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureActiveDirectory")]
        public AzureActiveDirectory AzureActiveDirectory { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the Facebook provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.facebook")]
        public Facebook Facebook { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the GitHub provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gitHub")]
        public GitHub GitHub { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the Google provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.google")]
        public Google Google { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the Twitter provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.twitter")]
        public Twitter Twitter { get; set; }

        /// <summary>
        /// Gets or sets the map of the name of the alias of each custom Open
        /// ID Connect provider to the
        /// configuration settings of the custom Open ID Connect provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customOpenIdConnectProviders")]
        public IDictionary<string, CustomOpenIdConnectProvider> CustomOpenIdConnectProviders { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the legacy Microsoft
        /// Account provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.legacyMicrosoftAccount")]
        public LegacyMicrosoftAccount LegacyMicrosoftAccount { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the Apple provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apple")]
        public Apple Apple { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the Azure Static Web
        /// Apps provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureStaticWebApps")]
        public AzureStaticWebApps AzureStaticWebApps { get; set; }

    }
}
