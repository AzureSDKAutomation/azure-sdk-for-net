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
    /// Configuration of App Service site logs.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SiteLogsConfig : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SiteLogsConfig class.
        /// </summary>
        public SiteLogsConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteLogsConfig class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="applicationLogs">Application logs
        /// configuration.</param>
        /// <param name="httpLogs">HTTP logs configuration.</param>
        /// <param name="failedRequestsTracing">Failed requests tracing
        /// configuration.</param>
        /// <param name="detailedErrorMessages">Detailed error messages
        /// configuration.</param>
        public SiteLogsConfig(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), ApplicationLogsConfig applicationLogs = default(ApplicationLogsConfig), HttpLogsConfig httpLogs = default(HttpLogsConfig), EnabledConfig failedRequestsTracing = default(EnabledConfig), EnabledConfig detailedErrorMessages = default(EnabledConfig))
            : base(id, name, kind, type, systemData)
        {
            ApplicationLogs = applicationLogs;
            HttpLogs = httpLogs;
            FailedRequestsTracing = failedRequestsTracing;
            DetailedErrorMessages = detailedErrorMessages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application logs configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicationLogs")]
        public ApplicationLogsConfig ApplicationLogs { get; set; }

        /// <summary>
        /// Gets or sets HTTP logs configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpLogs")]
        public HttpLogsConfig HttpLogs { get; set; }

        /// <summary>
        /// Gets or sets failed requests tracing configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failedRequestsTracing")]
        public EnabledConfig FailedRequestsTracing { get; set; }

        /// <summary>
        /// Gets or sets detailed error messages configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.detailedErrorMessages")]
        public EnabledConfig DetailedErrorMessages { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApplicationLogs != null)
            {
                ApplicationLogs.Validate();
            }
            if (HttpLogs != null)
            {
                HttpLogs.Validate();
            }
        }
    }
}
