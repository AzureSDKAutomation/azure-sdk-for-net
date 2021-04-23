// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ProviderRegistrationProperties : ResourceProviderManifestProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProviderRegistrationProperties
        /// class.
        /// </summary>
        public ProviderRegistrationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderRegistrationProperties
        /// class.
        /// </summary>
        /// <param name="providerType">Possible values include: 'NotSpecified',
        /// 'Internal', 'External', 'Hidden', 'RegistrationFree',
        /// 'LegacyRegistrationRequired', 'TenantOnly',
        /// 'AuthorizationFree'</param>
        /// <param name="provisioningState">Possible values include:
        /// 'NotSpecified', 'Accepted', 'Running', 'Creating', 'Created',
        /// 'Deleting', 'Deleted', 'Canceled', 'Failed', 'Succeeded',
        /// 'MovingResources', 'TransientFailure', 'RolloutInProgress'</param>
        public ProviderRegistrationProperties(ResourceProviderManifestPropertiesProviderAuthentication providerAuthentication = default(ResourceProviderManifestPropertiesProviderAuthentication), IList<ResourceProviderAuthorization> providerAuthorizations = default(IList<ResourceProviderAuthorization>), string namespaceProperty = default(string), string providerVersion = default(string), string providerType = default(string), IList<string> requiredFeatures = default(IList<string>), ResourceProviderManifestPropertiesFeaturesRule featuresRule = default(ResourceProviderManifestPropertiesFeaturesRule), ResourceProviderManifestPropertiesRequestHeaderOptions requestHeaderOptions = default(ResourceProviderManifestPropertiesRequestHeaderOptions), ResourceProviderManifestPropertiesManagement management = default(ResourceProviderManifestPropertiesManagement), IList<ResourceProviderCapabilities> capabilities = default(IList<ResourceProviderCapabilities>), IDictionary<string, string> metadata = default(IDictionary<string, string>), ResourceProviderManifestPropertiesTemplateDeploymentOptions templateDeploymentOptions = default(ResourceProviderManifestPropertiesTemplateDeploymentOptions), ProviderRegistrationPropertiesProviderHubMetadata providerHubMetadata = default(ProviderRegistrationPropertiesProviderHubMetadata), string provisioningState = default(string), ProviderRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications subscriptionLifecycleNotificationSpecifications = default(ProviderRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications))
            : base(providerAuthentication, providerAuthorizations, namespaceProperty, providerVersion, providerType, requiredFeatures, featuresRule, requestHeaderOptions, management, capabilities, metadata, templateDeploymentOptions)
        {
            ProviderHubMetadata = providerHubMetadata;
            ProvisioningState = provisioningState;
            SubscriptionLifecycleNotificationSpecifications = subscriptionLifecycleNotificationSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerHubMetadata")]
        public ProviderRegistrationPropertiesProviderHubMetadata ProviderHubMetadata { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NotSpecified', 'Accepted',
        /// 'Running', 'Creating', 'Created', 'Deleting', 'Deleted',
        /// 'Canceled', 'Failed', 'Succeeded', 'MovingResources',
        /// 'TransientFailure', 'RolloutInProgress'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionLifecycleNotificationSpecifications")]
        public ProviderRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications SubscriptionLifecycleNotificationSpecifications { get; set; }

    }
}
