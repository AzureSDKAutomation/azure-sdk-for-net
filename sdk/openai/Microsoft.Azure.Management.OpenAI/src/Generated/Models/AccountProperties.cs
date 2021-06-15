// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OpenAI.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of OpenAI account.
    /// </summary>
    public partial class AccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the AccountProperties class.
        /// </summary>
        public AccountProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountProperties class.
        /// </summary>
        /// <param name="provisioningState">Gets the status of the OpenAI
        /// account at the time the operation was called. Possible values
        /// include: 'Accepted', 'Creating', 'Deleting', 'Moving', 'Failed',
        /// 'Succeeded', 'ResolvingDNS'</param>
        /// <param name="endpoint">Endpoint of the created account.</param>
        /// <param name="capabilities">Gets the capabilities of the OpenAI
        /// account. Each item indicates the capability of a specific feature.
        /// The values are read-only and for reference only.</param>
        /// <param name="networkAcls">A collection of rules governing the
        /// accessibility from specific network locations.</param>
        /// <param name="encryption">The encryption properties for this
        /// resource.</param>
        /// <param name="privateEndpointConnections">The private endpoint
        /// connection associated with the OpenAI account.</param>
        /// <param name="publicNetworkAccess">Whether or not public endpoint
        /// access is allowed for this account. Value is optional but if passed
        /// in, must be 'Enabled' or 'Disabled'. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="callRateLimit">The call rate limit for the OpenAI
        /// account.</param>
        /// <param name="quotaLimit">The quota limit for the OpenAI
        /// account.</param>
        /// <param name="disableLocalAuth">Disable local authentication, such
        /// as key based authentication.</param>
        /// <param name="endpoints">The endpoint list for the OpenAI
        /// account.</param>
        /// <param name="restore">Restore a soft-deleted account.</param>
        public AccountProperties(string provisioningState = default(string), string endpoint = default(string), IList<SkuCapability> capabilities = default(IList<SkuCapability>), NetworkRuleSet networkAcls = default(NetworkRuleSet), Encryption encryption = default(Encryption), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), string publicNetworkAccess = default(string), CallRateLimit callRateLimit = default(CallRateLimit), QuotaLimit quotaLimit = default(QuotaLimit), bool? disableLocalAuth = default(bool?), IDictionary<string, string> endpoints = default(IDictionary<string, string>), bool? restore = default(bool?))
        {
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            Capabilities = capabilities;
            NetworkAcls = networkAcls;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            CallRateLimit = callRateLimit;
            QuotaLimit = quotaLimit;
            DisableLocalAuth = disableLocalAuth;
            Endpoints = endpoints;
            Restore = restore;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status of the OpenAI account at the time the operation was
        /// called. Possible values include: 'Accepted', 'Creating',
        /// 'Deleting', 'Moving', 'Failed', 'Succeeded', 'ResolvingDNS'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets endpoint of the created account.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets the capabilities of the OpenAI account. Each item indicates
        /// the capability of a specific feature. The values are read-only and
        /// for reference only.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<SkuCapability> Capabilities { get; private set; }

        /// <summary>
        /// Gets or sets a collection of rules governing the accessibility from
        /// specific network locations.
        /// </summary>
        [JsonProperty(PropertyName = "networkAcls")]
        public NetworkRuleSet NetworkAcls { get; set; }

        /// <summary>
        /// Gets or sets the encryption properties for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets the private endpoint connection associated with the OpenAI
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets whether or not public endpoint access is allowed for
        /// this account. Value is optional but if passed in, must be 'Enabled'
        /// or 'Disabled'. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets the call rate limit for the OpenAI account.
        /// </summary>
        [JsonProperty(PropertyName = "callRateLimit")]
        public CallRateLimit CallRateLimit { get; private set; }

        /// <summary>
        /// Gets the quota limit for the OpenAI account.
        /// </summary>
        [JsonProperty(PropertyName = "quotaLimit")]
        public QuotaLimit QuotaLimit { get; private set; }

        /// <summary>
        /// Gets or sets disable local authentication, such as key based
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "disableLocalAuth")]
        public bool? DisableLocalAuth { get; set; }

        /// <summary>
        /// Gets the endpoint list for the OpenAI account.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IDictionary<string, string> Endpoints { get; private set; }

        /// <summary>
        /// Gets or sets restore a soft-deleted account.
        /// </summary>
        [JsonProperty(PropertyName = "restore")]
        public bool? Restore { get; set; }

    }
}
