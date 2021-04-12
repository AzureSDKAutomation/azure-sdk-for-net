// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Application Insights WebTest definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WebTest : WebtestsResource
    {
        /// <summary>
        /// Initializes a new instance of the WebTest class.
        /// </summary>
        public WebTest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebTest class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="syntheticMonitorId">Unique ID of this WebTest. This is
        /// typically the same value as the Name field.</param>
        /// <param name="webTestName">User defined name if this
        /// WebTest.</param>
        /// <param name="webTestKind">The kind of web test this is, valid
        /// choices are ping, multistep, basic, and standard. Possible values
        /// include: 'ping', 'multistep', 'basic', 'standard'</param>
        /// <param name="locations">A list of where to physically run the tests
        /// from to give global coverage for accessibility of your
        /// application.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="kind">The kind of WebTest that this web test watches.
        /// Choices are ping and multistep. Possible values include: 'ping',
        /// 'multistep'</param>
        /// <param name="description">User defined description for this
        /// WebTest.</param>
        /// <param name="enabled">Is the test actively being monitored.</param>
        /// <param name="frequency">Interval in seconds between test runs for
        /// this WebTest. Default value is 300.</param>
        /// <param name="timeout">Seconds until this WebTest will timeout and
        /// fail. Default value is 30.</param>
        /// <param name="retryEnabled">Allow for retries should this WebTest
        /// fail.</param>
        /// <param name="configuration">An XML configuration specification for
        /// a WebTest.</param>
        /// <param name="provisioningState">Current state of this component,
        /// whether or not is has been provisioned within the resource group it
        /// is defined. Users cannot change this value but are able to read
        /// from it. Values will include Succeeded, Deploying, Canceled, and
        /// Failed.</param>
        /// <param name="request">The collection of request properties</param>
        /// <param name="validationRules">The collection of validation rule
        /// properties</param>
        public WebTest(string location, string syntheticMonitorId, string webTestName, WebTestKindEnum webTestKind, IList<WebTestGeolocation> locations, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), WebTestKind? kind = default(WebTestKind?), string description = default(string), bool? enabled = default(bool?), int? frequency = default(int?), int? timeout = default(int?), bool? retryEnabled = default(bool?), WebTestPropertiesConfiguration configuration = default(WebTestPropertiesConfiguration), string provisioningState = default(string), WebTestPropertiesRequest request = default(WebTestPropertiesRequest), WebTestPropertiesValidationRules validationRules = default(WebTestPropertiesValidationRules))
            : base(location, id, name, type, tags)
        {
            Kind = kind;
            SyntheticMonitorId = syntheticMonitorId;
            WebTestName = webTestName;
            Description = description;
            Enabled = enabled;
            Frequency = frequency;
            Timeout = timeout;
            WebTestKind = webTestKind;
            RetryEnabled = retryEnabled;
            Locations = locations;
            Configuration = configuration;
            ProvisioningState = provisioningState;
            Request = request;
            ValidationRules = validationRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the kind of WebTest that this web test watches.
        /// Choices are ping and multistep. Possible values include: 'ping',
        /// 'multistep'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public WebTestKind? Kind { get; set; }

        /// <summary>
        /// Gets or sets unique ID of this WebTest. This is typically the same
        /// value as the Name field.
        /// </summary>
        [JsonProperty(PropertyName = "properties.SyntheticMonitorId")]
        public string SyntheticMonitorId { get; set; }

        /// <summary>
        /// Gets or sets user defined name if this WebTest.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Name")]
        public string WebTestName { get; set; }

        /// <summary>
        /// Gets or sets user defined description for this WebTest.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets is the test actively being monitored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets interval in seconds between test runs for this
        /// WebTest. Default value is 300.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Frequency")]
        public int? Frequency { get; set; }

        /// <summary>
        /// Gets or sets seconds until this WebTest will timeout and fail.
        /// Default value is 30.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the kind of web test this is, valid choices are ping,
        /// multistep, basic, and standard. Possible values include: 'ping',
        /// 'multistep', 'basic', 'standard'
        /// </summary>
        [JsonProperty(PropertyName = "properties.Kind")]
        public WebTestKindEnum WebTestKind { get; set; }

        /// <summary>
        /// Gets or sets allow for retries should this WebTest fail.
        /// </summary>
        [JsonProperty(PropertyName = "properties.RetryEnabled")]
        public bool? RetryEnabled { get; set; }

        /// <summary>
        /// Gets or sets a list of where to physically run the tests from to
        /// give global coverage for accessibility of your application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Locations")]
        public IList<WebTestGeolocation> Locations { get; set; }

        /// <summary>
        /// Gets or sets an XML configuration specification for a WebTest.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Configuration")]
        public WebTestPropertiesConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets current state of this component, whether or not is has been
        /// provisioned within the resource group it is defined. Users cannot
        /// change this value but are able to read from it. Values will include
        /// Succeeded, Deploying, Canceled, and Failed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the collection of request properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.Request")]
        public WebTestPropertiesRequest Request { get; set; }

        /// <summary>
        /// Gets or sets the collection of validation rule properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.ValidationRules")]
        public WebTestPropertiesValidationRules ValidationRules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (SyntheticMonitorId == null)
            {
                throw new ValidationException(Rest.ValidationRules.CannotBeNull, "SyntheticMonitorId");
            }
            if (WebTestName == null)
            {
                throw new ValidationException(Rest.ValidationRules.CannotBeNull, "WebTestName");
            }
            if (Locations == null)
            {
                throw new ValidationException(Rest.ValidationRules.CannotBeNull, "Locations");
            }
        }
    }
}
