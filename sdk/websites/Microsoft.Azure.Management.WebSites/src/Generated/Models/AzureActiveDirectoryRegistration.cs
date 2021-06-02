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
    /// The configuration settings of the Azure Active Directory app
    /// registration.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AzureActiveDirectoryRegistration : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryRegistration
        /// class.
        /// </summary>
        public AzureActiveDirectoryRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryRegistration
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="openIdIssuer">The OpenID Connect Issuer URI that
        /// represents the entity which issues access tokens for this
        /// application.
        /// When using Azure Active Directory, this value is the URI of the
        /// directory tenant, e.g.
        /// https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery:
        /// http://openid.net/specs/openid-connect-discovery-1_0.html</param>
        /// <param name="clientId">The Client ID of this relying party
        /// application, known as the client_id.
        /// This setting is required for enabling OpenID Connection
        /// authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html</param>
        /// <param name="clientSecretSettingName">The app setting name that
        /// contains the client secret of the relying party
        /// application.</param>
        /// <param name="clientSecretCertificateThumbprint">An alternative to
        /// the client secret, that is the thumbprint of a certificate used for
        /// signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.</param>
        public AzureActiveDirectoryRegistration(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string openIdIssuer = default(string), string clientId = default(string), string clientSecretSettingName = default(string), string clientSecretCertificateThumbprint = default(string))
            : base(id, name, kind, type, systemData)
        {
            OpenIdIssuer = openIdIssuer;
            ClientId = clientId;
            ClientSecretSettingName = clientSecretSettingName;
            ClientSecretCertificateThumbprint = clientSecretCertificateThumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the OpenID Connect Issuer URI that represents the
        /// entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the
        /// directory tenant, e.g.
        /// https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery:
        /// http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "properties.openIdIssuer")]
        public string OpenIdIssuer { get; set; }

        /// <summary>
        /// Gets or sets the Client ID of this relying party application, known
        /// as the client_id.
        /// This setting is required for enabling OpenID Connection
        /// authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect:
        /// http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the app setting name that contains the client secret
        /// of the relying party application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }

        /// <summary>
        /// Gets or sets an alternative to the client secret, that is the
        /// thumbprint of a certificate used for signing purposes. This
        /// property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientSecretCertificateThumbprint")]
        public string ClientSecretCertificateThumbprint { get; set; }

    }
}
