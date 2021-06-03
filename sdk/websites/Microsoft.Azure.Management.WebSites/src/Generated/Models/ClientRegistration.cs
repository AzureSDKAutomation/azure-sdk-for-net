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
    /// The configuration settings of the app registration for providers that
    /// have client ids and client secrets
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ClientRegistration : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the ClientRegistration class.
        /// </summary>
        public ClientRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientRegistration class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="clientId">The Client ID of the app used for
        /// login.</param>
        /// <param name="clientSecretSettingName">The app setting name that
        /// contains the client secret.</param>
        public ClientRegistration(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string clientId = default(string), string clientSecretSettingName = default(string))
            : base(id, name, kind, type, systemData)
        {
            ClientId = clientId;
            ClientSecretSettingName = clientSecretSettingName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Client ID of the app used for login.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the app setting name that contains the client secret.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }

    }
}
