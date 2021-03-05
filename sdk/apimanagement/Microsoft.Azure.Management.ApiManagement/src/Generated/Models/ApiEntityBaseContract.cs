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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// API base contract details.
    /// </summary>
    public partial class ApiEntityBaseContract
    {
        /// <summary>
        /// Initializes a new instance of the ApiEntityBaseContract class.
        /// </summary>
        public ApiEntityBaseContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiEntityBaseContract class.
        /// </summary>
        /// <param name="description">Description of the API. May include HTML
        /// formatting tags.</param>
        /// <param name="authenticationSettings">Collection of authentication
        /// settings included into this API.</param>
        /// <param name="subscriptionKeyParameterNames">Protocols over which
        /// API is made available.</param>
        /// <param name="apiType">Type of API. Possible values include: 'http',
        /// 'soap'</param>
        /// <param name="apiRevision">Describes the Revision of the Api. If no
        /// value is provided, default revision 1 is created</param>
        /// <param name="apiVersion">Indicates the Version identifier of the
        /// API if the API is versioned</param>
        /// <param name="isCurrent">Indicates if API revision is current api
        /// revision.</param>
        /// <param name="isOnline">Indicates if API revision is accessible via
        /// the gateway.</param>
        /// <param name="apiRevisionDescription">Description of the Api
        /// Revision.</param>
        /// <param name="apiVersionDescription">Description of the Api
        /// Version.</param>
        /// <param name="apiVersionSetId">A resource identifier for the related
        /// ApiVersionSet.</param>
        /// <param name="subscriptionRequired">Specifies whether an API or
        /// Product subscription is required for accessing the API.</param>
        /// <param name="termsOfServiceUrl"> A URL to the Terms of Service for
        /// the API. MUST be in the format of a URL.</param>
        /// <param name="contact">Contact information for the API.</param>
        /// <param name="license">License information for the API.</param>
        public ApiEntityBaseContract(string description = default(string), AuthenticationSettingsContract authenticationSettings = default(AuthenticationSettingsContract), SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default(SubscriptionKeyParameterNamesContract), string apiType = default(string), string apiRevision = default(string), string apiVersion = default(string), bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = default(string), string apiVersionDescription = default(string), string apiVersionSetId = default(string), bool? subscriptionRequired = default(bool?), string termsOfServiceUrl = default(string), ApiContactInformation contact = default(ApiContactInformation), ApiLicenseInformation license = default(ApiLicenseInformation))
        {
            Description = description;
            AuthenticationSettings = authenticationSettings;
            SubscriptionKeyParameterNames = subscriptionKeyParameterNames;
            ApiType = apiType;
            ApiRevision = apiRevision;
            ApiVersion = apiVersion;
            IsCurrent = isCurrent;
            IsOnline = isOnline;
            ApiRevisionDescription = apiRevisionDescription;
            ApiVersionDescription = apiVersionDescription;
            ApiVersionSetId = apiVersionSetId;
            SubscriptionRequired = subscriptionRequired;
            TermsOfServiceUrl = termsOfServiceUrl;
            Contact = contact;
            License = license;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the API. May include HTML formatting
        /// tags.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets collection of authentication settings included into
        /// this API.
        /// </summary>
        [JsonProperty(PropertyName = "authenticationSettings")]
        public AuthenticationSettingsContract AuthenticationSettings { get; set; }

        /// <summary>
        /// Gets or sets protocols over which API is made available.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionKeyParameterNames")]
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get; set; }

        /// <summary>
        /// Gets or sets type of API. Possible values include: 'http', 'soap'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string ApiType { get; set; }

        /// <summary>
        /// Gets or sets describes the Revision of the Api. If no value is
        /// provided, default revision 1 is created
        /// </summary>
        [JsonProperty(PropertyName = "apiRevision")]
        public string ApiRevision { get; set; }

        /// <summary>
        /// Gets or sets indicates the Version identifier of the API if the API
        /// is versioned
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates if API revision is current api revision.
        /// </summary>
        [JsonProperty(PropertyName = "isCurrent")]
        public bool? IsCurrent { get; set; }

        /// <summary>
        /// Gets indicates if API revision is accessible via the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "isOnline")]
        public bool? IsOnline { get; private set; }

        /// <summary>
        /// Gets or sets description of the Api Revision.
        /// </summary>
        [JsonProperty(PropertyName = "apiRevisionDescription")]
        public string ApiRevisionDescription { get; set; }

        /// <summary>
        /// Gets or sets description of the Api Version.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersionDescription")]
        public string ApiVersionDescription { get; set; }

        /// <summary>
        /// Gets or sets a resource identifier for the related ApiVersionSet.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersionSetId")]
        public string ApiVersionSetId { get; set; }

        /// <summary>
        /// Gets or sets specifies whether an API or Product subscription is
        /// required for accessing the API.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionRequired")]
        public bool? SubscriptionRequired { get; set; }

        /// <summary>
        /// Gets or sets  A URL to the Terms of Service for the API. MUST be in
        /// the format of a URL.
        /// </summary>
        [JsonProperty(PropertyName = "termsOfServiceUrl")]
        public string TermsOfServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets contact information for the API.
        /// </summary>
        [JsonProperty(PropertyName = "contact")]
        public ApiContactInformation Contact { get; set; }

        /// <summary>
        /// Gets or sets license information for the API.
        /// </summary>
        [JsonProperty(PropertyName = "license")]
        public ApiLicenseInformation License { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApiRevision != null)
            {
                if (ApiRevision.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiRevision", 100);
                }
                if (ApiRevision.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ApiRevision", 1);
                }
            }
            if (ApiVersion != null)
            {
                if (ApiVersion.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiVersion", 100);
                }
            }
            if (ApiRevisionDescription != null)
            {
                if (ApiRevisionDescription.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiRevisionDescription", 256);
                }
            }
            if (ApiVersionDescription != null)
            {
                if (ApiVersionDescription.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ApiVersionDescription", 256);
                }
            }
        }
    }
}
