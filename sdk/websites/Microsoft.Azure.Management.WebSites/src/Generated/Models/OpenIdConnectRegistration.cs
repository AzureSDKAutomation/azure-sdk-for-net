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
    /// The configuration settings of the app registration for the custom Open
    /// ID Connect provider.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OpenIdConnectRegistration : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the OpenIdConnectRegistration class.
        /// </summary>
        public OpenIdConnectRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OpenIdConnectRegistration class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="clientId">The client id of the custom Open ID Connect
        /// provider.</param>
        /// <param name="clientCredential">The authentication credentials of
        /// the custom Open ID Connect provider.</param>
        /// <param name="openIdConnectConfiguration">The configuration settings
        /// of the endpoints used for the custom Open ID Connect
        /// provider.</param>
        public OpenIdConnectRegistration(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string clientId = default(string), OpenIdConnectClientCredential clientCredential = default(OpenIdConnectClientCredential), OpenIdConnectConfig openIdConnectConfiguration = default(OpenIdConnectConfig))
            : base(id, name, kind, type, systemData)
        {
            ClientId = clientId;
            ClientCredential = clientCredential;
            OpenIdConnectConfiguration = openIdConnectConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the client id of the custom Open ID Connect provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the authentication credentials of the custom Open ID
        /// Connect provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientCredential")]
        public OpenIdConnectClientCredential ClientCredential { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the endpoints used for
        /// the custom Open ID Connect provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.openIdConnectConfiguration")]
        public OpenIdConnectConfig OpenIdConnectConfiguration { get; set; }

    }
}
