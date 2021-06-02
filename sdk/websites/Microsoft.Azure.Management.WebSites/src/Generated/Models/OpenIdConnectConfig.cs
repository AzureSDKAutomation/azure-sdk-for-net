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
    /// The configuration settings of the endpoints used for the custom Open ID
    /// Connect provider.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OpenIdConnectConfig : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the OpenIdConnectConfig class.
        /// </summary>
        public OpenIdConnectConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OpenIdConnectConfig class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="authorizationEndpoint">The endpoint to be used to make
        /// an authorization request.</param>
        /// <param name="tokenEndpoint">The endpoint to be used to request a
        /// token.</param>
        /// <param name="issuer">The endpoint that issues the token.</param>
        /// <param name="certificationUri">The endpoint that provides the keys
        /// necessary to validate the token.</param>
        /// <param name="wellKnownOpenIdConfiguration">The endpoint that
        /// contains all the configuration endpoints for the provider.</param>
        public OpenIdConnectConfig(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string authorizationEndpoint = default(string), string tokenEndpoint = default(string), string issuer = default(string), string certificationUri = default(string), string wellKnownOpenIdConfiguration = default(string))
            : base(id, name, kind, type, systemData)
        {
            AuthorizationEndpoint = authorizationEndpoint;
            TokenEndpoint = tokenEndpoint;
            Issuer = issuer;
            CertificationUri = certificationUri;
            WellKnownOpenIdConfiguration = wellKnownOpenIdConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint to be used to make an authorization
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the endpoint to be used to request a token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenEndpoint")]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the endpoint that issues the token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the endpoint that provides the keys necessary to
        /// validate the token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificationUri")]
        public string CertificationUri { get; set; }

        /// <summary>
        /// Gets or sets the endpoint that contains all the configuration
        /// endpoints for the provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.wellKnownOpenIdConfiguration")]
        public string WellKnownOpenIdConfiguration { get; set; }

    }
}
