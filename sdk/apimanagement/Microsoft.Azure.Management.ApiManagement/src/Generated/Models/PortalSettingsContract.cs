// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Portal Settings for the Developer Portal.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PortalSettingsContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PortalSettingsContract class.
        /// </summary>
        public PortalSettingsContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PortalSettingsContract class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="url">A delegation Url.</param>
        /// <param name="validationKey">A base64-encoded validation key to
        /// validate, that a request is coming from Azure API
        /// Management.</param>
        /// <param name="subscriptions">Subscriptions delegation
        /// settings.</param>
        /// <param name="userRegistration">User registration delegation
        /// settings.</param>
        /// <param name="enabled">Redirect Anonymous users to the Sign-In
        /// page.</param>
        /// <param name="termsOfService">Terms of service contract
        /// properties.</param>
        public PortalSettingsContract(string id = default(string), string name = default(string), string type = default(string), string url = default(string), string validationKey = default(string), SubscriptionsDelegationSettingsProperties subscriptions = default(SubscriptionsDelegationSettingsProperties), RegistrationDelegationSettingsProperties userRegistration = default(RegistrationDelegationSettingsProperties), bool? enabled = default(bool?), TermsOfServiceProperties termsOfService = default(TermsOfServiceProperties))
            : base(id, name, type)
        {
            Url = url;
            ValidationKey = validationKey;
            Subscriptions = subscriptions;
            UserRegistration = userRegistration;
            Enabled = enabled;
            TermsOfService = termsOfService;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a delegation Url.
        /// </summary>
        [JsonProperty(PropertyName = "properties.url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets a base64-encoded validation key to validate, that a
        /// request is coming from Azure API Management.
        /// </summary>
        [JsonProperty(PropertyName = "properties.validationKey")]
        public string ValidationKey { get; set; }

        /// <summary>
        /// Gets or sets subscriptions delegation settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptions")]
        public SubscriptionsDelegationSettingsProperties Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets user registration delegation settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userRegistration")]
        public RegistrationDelegationSettingsProperties UserRegistration { get; set; }

        /// <summary>
        /// Gets or sets redirect Anonymous users to the Sign-In page.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets terms of service contract properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.termsOfService")]
        public TermsOfServiceProperties TermsOfService { get; set; }

    }
}
