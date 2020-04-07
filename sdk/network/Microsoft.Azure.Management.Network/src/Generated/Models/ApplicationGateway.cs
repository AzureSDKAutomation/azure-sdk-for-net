// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application gateway resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGateway class.
        /// </summary>
        public ApplicationGateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGateway class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">SKU of the application gateway resource.</param>
        /// <param name="sslPolicy">SSL policy of the application gateway
        /// resource.</param>
        /// <param name="operationalState">Operational state of the application
        /// gateway resource. Possible values include: 'Stopped', 'Starting',
        /// 'Running', 'Stopping'</param>
        /// <param name="gatewayIPConfigurations">Subnets of the application
        /// gateway resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="authenticationCertificates">Authentication
        /// certificates of the application gateway resource. For default
        /// limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="trustedRootCertificates">Trusted Root certificates of
        /// the application gateway resource. For default limits, see
        /// [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="sslCertificates">SSL certificates of the application
        /// gateway resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="frontendIPConfigurations">Frontend IP addresses of the
        /// application gateway resource. For default limits, see [Application
        /// Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="frontendPorts">Frontend ports of the application
        /// gateway resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="probes">Probes of the application gateway
        /// resource.</param>
        /// <param name="backendAddressPools">Backend address pool of the
        /// application gateway resource. For default limits, see [Application
        /// Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="backendHttpSettingsCollection">Backend http settings
        /// of the application gateway resource. For default limits, see
        /// [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="httpListeners">Http listeners of the application
        /// gateway resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="urlPathMaps">URL path map of the application gateway
        /// resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="requestRoutingRules">Request routing rules of the
        /// application gateway resource.</param>
        /// <param name="rewriteRuleSets">Rewrite rules for the application
        /// gateway resource.</param>
        /// <param name="redirectConfigurations">Redirect configurations of the
        /// application gateway resource. For default limits, see [Application
        /// Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).</param>
        /// <param name="webApplicationFirewallConfiguration">Web application
        /// firewall configuration.</param>
        /// <param name="firewallPolicy">Reference to the FirewallPolicy
        /// resource.</param>
        /// <param name="enableHttp2">Whether HTTP2 is enabled on the
        /// application gateway resource.</param>
        /// <param name="enableFips">Whether FIPS is enabled on the application
        /// gateway resource.</param>
        /// <param name="autoscaleConfiguration">Autoscale
        /// Configuration.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// application gateway resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// application gateway resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="customErrorConfigurations">Custom error configurations
        /// of the application gateway resource.</param>
        /// <param name="forceFirewallPolicyAssociation">If true, associates a
        /// firewall policy with an application gateway regardless whether the
        /// policy differs from the WAF Config.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="zones">A list of availability zones denoting where the
        /// resource needs to come from.</param>
        /// <param name="identity">The identity of the application gateway, if
        /// configured.</param>
        public ApplicationGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ApplicationGatewaySku sku = default(ApplicationGatewaySku), ApplicationGatewaySslPolicy sslPolicy = default(ApplicationGatewaySslPolicy), string operationalState = default(string), IList<ApplicationGatewayIPConfiguration> gatewayIPConfigurations = default(IList<ApplicationGatewayIPConfiguration>), IList<ApplicationGatewayAuthenticationCertificate> authenticationCertificates = default(IList<ApplicationGatewayAuthenticationCertificate>), IList<ApplicationGatewayTrustedRootCertificate> trustedRootCertificates = default(IList<ApplicationGatewayTrustedRootCertificate>), IList<ApplicationGatewaySslCertificate> sslCertificates = default(IList<ApplicationGatewaySslCertificate>), IList<ApplicationGatewayFrontendIPConfiguration> frontendIPConfigurations = default(IList<ApplicationGatewayFrontendIPConfiguration>), IList<ApplicationGatewayFrontendPort> frontendPorts = default(IList<ApplicationGatewayFrontendPort>), IList<ApplicationGatewayProbe> probes = default(IList<ApplicationGatewayProbe>), IList<ApplicationGatewayBackendAddressPool> backendAddressPools = default(IList<ApplicationGatewayBackendAddressPool>), IList<ApplicationGatewayBackendHttpSettings> backendHttpSettingsCollection = default(IList<ApplicationGatewayBackendHttpSettings>), IList<ApplicationGatewayHttpListener> httpListeners = default(IList<ApplicationGatewayHttpListener>), IList<ApplicationGatewayUrlPathMap> urlPathMaps = default(IList<ApplicationGatewayUrlPathMap>), IList<ApplicationGatewayRequestRoutingRule> requestRoutingRules = default(IList<ApplicationGatewayRequestRoutingRule>), IList<ApplicationGatewayRewriteRuleSet> rewriteRuleSets = default(IList<ApplicationGatewayRewriteRuleSet>), IList<ApplicationGatewayRedirectConfiguration> redirectConfigurations = default(IList<ApplicationGatewayRedirectConfiguration>), ApplicationGatewayWebApplicationFirewallConfiguration webApplicationFirewallConfiguration = default(ApplicationGatewayWebApplicationFirewallConfiguration), SubResource firewallPolicy = default(SubResource), bool? enableHttp2 = default(bool?), bool? enableFips = default(bool?), ApplicationGatewayAutoscaleConfiguration autoscaleConfiguration = default(ApplicationGatewayAutoscaleConfiguration), string resourceGuid = default(string), string provisioningState = default(string), IList<ApplicationGatewayCustomError> customErrorConfigurations = default(IList<ApplicationGatewayCustomError>), bool? forceFirewallPolicyAssociation = default(bool?), string etag = default(string), IList<string> zones = default(IList<string>), ManagedServiceIdentity identity = default(ManagedServiceIdentity))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            SslPolicy = sslPolicy;
            OperationalState = operationalState;
            GatewayIPConfigurations = gatewayIPConfigurations;
            AuthenticationCertificates = authenticationCertificates;
            TrustedRootCertificates = trustedRootCertificates;
            SslCertificates = sslCertificates;
            FrontendIPConfigurations = frontendIPConfigurations;
            FrontendPorts = frontendPorts;
            Probes = probes;
            BackendAddressPools = backendAddressPools;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
            HttpListeners = httpListeners;
            UrlPathMaps = urlPathMaps;
            RequestRoutingRules = requestRoutingRules;
            RewriteRuleSets = rewriteRuleSets;
            RedirectConfigurations = redirectConfigurations;
            WebApplicationFirewallConfiguration = webApplicationFirewallConfiguration;
            FirewallPolicy = firewallPolicy;
            EnableHttp2 = enableHttp2;
            EnableFips = enableFips;
            AutoscaleConfiguration = autoscaleConfiguration;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            CustomErrorConfigurations = customErrorConfigurations;
            ForceFirewallPolicyAssociation = forceFirewallPolicyAssociation;
            Etag = etag;
            Zones = zones;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SKU of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public ApplicationGatewaySku Sku { get; set; }

        /// <summary>
        /// Gets or sets SSL policy of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslPolicy")]
        public ApplicationGatewaySslPolicy SslPolicy { get; set; }

        /// <summary>
        /// Gets operational state of the application gateway resource.
        /// Possible values include: 'Stopped', 'Starting', 'Running',
        /// 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationalState")]
        public string OperationalState { get; private set; }

        /// <summary>
        /// Gets or sets subnets of the application gateway resource. For
        /// default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayIPConfigurations")]
        public IList<ApplicationGatewayIPConfiguration> GatewayIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets authentication certificates of the application gateway
        /// resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationCertificates")]
        public IList<ApplicationGatewayAuthenticationCertificate> AuthenticationCertificates { get; set; }

        /// <summary>
        /// Gets or sets trusted Root certificates of the application gateway
        /// resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.trustedRootCertificates")]
        public IList<ApplicationGatewayTrustedRootCertificate> TrustedRootCertificates { get; set; }

        /// <summary>
        /// Gets or sets SSL certificates of the application gateway resource.
        /// For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslCertificates")]
        public IList<ApplicationGatewaySslCertificate> SslCertificates { get; set; }

        /// <summary>
        /// Gets or sets frontend IP addresses of the application gateway
        /// resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<ApplicationGatewayFrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets frontend ports of the application gateway resource.
        /// For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPorts")]
        public IList<ApplicationGatewayFrontendPort> FrontendPorts { get; set; }

        /// <summary>
        /// Gets or sets probes of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probes")]
        public IList<ApplicationGatewayProbe> Probes { get; set; }

        /// <summary>
        /// Gets or sets backend address pool of the application gateway
        /// resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPools")]
        public IList<ApplicationGatewayBackendAddressPool> BackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets backend http settings of the application gateway
        /// resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettingsCollection")]
        public IList<ApplicationGatewayBackendHttpSettings> BackendHttpSettingsCollection { get; set; }

        /// <summary>
        /// Gets or sets http listeners of the application gateway resource.
        /// For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpListeners")]
        public IList<ApplicationGatewayHttpListener> HttpListeners { get; set; }

        /// <summary>
        /// Gets or sets URL path map of the application gateway resource. For
        /// default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.urlPathMaps")]
        public IList<ApplicationGatewayUrlPathMap> UrlPathMaps { get; set; }

        /// <summary>
        /// Gets or sets request routing rules of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestRoutingRules")]
        public IList<ApplicationGatewayRequestRoutingRule> RequestRoutingRules { get; set; }

        /// <summary>
        /// Gets or sets rewrite rules for the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rewriteRuleSets")]
        public IList<ApplicationGatewayRewriteRuleSet> RewriteRuleSets { get; set; }

        /// <summary>
        /// Gets or sets redirect configurations of the application gateway
        /// resource. For default limits, see [Application Gateway
        /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectConfigurations")]
        public IList<ApplicationGatewayRedirectConfiguration> RedirectConfigurations { get; set; }

        /// <summary>
        /// Gets or sets web application firewall configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webApplicationFirewallConfiguration")]
        public ApplicationGatewayWebApplicationFirewallConfiguration WebApplicationFirewallConfiguration { get; set; }

        /// <summary>
        /// Gets or sets reference to the FirewallPolicy resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallPolicy")]
        public SubResource FirewallPolicy { get; set; }

        /// <summary>
        /// Gets or sets whether HTTP2 is enabled on the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableHttp2")]
        public bool? EnableHttp2 { get; set; }

        /// <summary>
        /// Gets or sets whether FIPS is enabled on the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableFips")]
        public bool? EnableFips { get; set; }

        /// <summary>
        /// Gets or sets autoscale Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoscaleConfiguration")]
        public ApplicationGatewayAutoscaleConfiguration AutoscaleConfiguration { get; set; }

        /// <summary>
        /// Gets the resource GUID property of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the application gateway resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets custom error configurations of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customErrorConfigurations")]
        public IList<ApplicationGatewayCustomError> CustomErrorConfigurations { get; set; }

        /// <summary>
        /// Gets or sets if true, associates a firewall policy with an
        /// application gateway regardless whether the policy differs from the
        /// WAF Config.
        /// </summary>
        [JsonProperty(PropertyName = "properties.forceFirewallPolicyAssociation")]
        public bool? ForceFirewallPolicyAssociation { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting where the
        /// resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets or sets the identity of the application gateway, if
        /// configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Probes != null)
            {
                foreach (var element in Probes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (BackendHttpSettingsCollection != null)
            {
                foreach (var element1 in BackendHttpSettingsCollection)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (RequestRoutingRules != null)
            {
                foreach (var element2 in RequestRoutingRules)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (WebApplicationFirewallConfiguration != null)
            {
                WebApplicationFirewallConfiguration.Validate();
            }
            if (AutoscaleConfiguration != null)
            {
                AutoscaleConfiguration.Validate();
            }
        }
    }
}
