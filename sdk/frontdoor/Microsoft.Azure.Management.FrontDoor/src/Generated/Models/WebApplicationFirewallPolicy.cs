// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines web application firewall policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WebApplicationFirewallPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the WebApplicationFirewallPolicy
        /// class.
        /// </summary>
        public WebApplicationFirewallPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebApplicationFirewallPolicy
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The pricing tier for web application firewall
        /// policy.</param>
        /// <param name="policySettings">Describes settings for the
        /// policy.</param>
        /// <param name="customRules">Describes custom rules inside the
        /// policy.</param>
        /// <param name="managedRules">Describes managed rules inside the
        /// policy.</param>
        /// <param name="frontendEndpointLinks">Describes Frontend Endpoints
        /// associated with this Web Application Firewall policy.</param>
        /// <param name="routingRuleLinks">Describes Routing Rules associated
        /// with this Web Application Firewall policy.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// policy.</param>
        /// <param name="resourceState">Resource status of the policy.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public WebApplicationFirewallPolicy(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), PolicySettings policySettings = default(PolicySettings), CustomRuleList customRules = default(CustomRuleList), ManagedRuleSetList managedRules = default(ManagedRuleSetList), IList<FrontendEndpointLink> frontendEndpointLinks = default(IList<FrontendEndpointLink>), IList<RoutingRuleLink> routingRuleLinks = default(IList<RoutingRuleLink>), string provisioningState = default(string), string resourceState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            PolicySettings = policySettings;
            CustomRules = customRules;
            ManagedRules = managedRules;
            FrontendEndpointLinks = frontendEndpointLinks;
            RoutingRuleLinks = routingRuleLinks;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the pricing tier for web application firewall policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets describes settings for the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policySettings")]
        public PolicySettings PolicySettings { get; set; }

        /// <summary>
        /// Gets or sets describes custom rules inside the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customRules")]
        public CustomRuleList CustomRules { get; set; }

        /// <summary>
        /// Gets or sets describes managed rules inside the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedRules")]
        public ManagedRuleSetList ManagedRules { get; set; }

        /// <summary>
        /// Gets describes Frontend Endpoints associated with this Web
        /// Application Firewall policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendEndpointLinks")]
        public IList<FrontendEndpointLink> FrontendEndpointLinks { get; private set; }

        /// <summary>
        /// Gets describes Routing Rules associated with this Web Application
        /// Firewall policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingRuleLinks")]
        public IList<RoutingRuleLink> RoutingRuleLinks { get; private set; }

        /// <summary>
        /// Gets provisioning state of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets resource status of the policy.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Creating', 'Enabling', 'Enabled',
        /// 'Disabling', 'Disabled', 'Deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PolicySettings != null)
            {
                PolicySettings.Validate();
            }
        }
    }
}
