// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The log profile resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LogProfileResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        public LogProfileResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="locations">List of regions for which Activity Log
        /// events should be stored or streamed. It is a comma separated list
        /// of valid ARM locations including the 'global' location.</param>
        /// <param name="categories">the categories of the logs. These
        /// categories are created as is convenient to the user. Some values
        /// are: 'Write', 'Delete', and/or 'Action.'</param>
        /// <param name="retentionPolicy">the retention policy for the events
        /// in the log.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="kind">Metadata used by portal/tooling/etc to render
        /// different UX experiences for resources of the same type; e.g.
        /// ApiApps are a kind of Microsoft.Web/sites type.  If supported, the
        /// resource provider must validate and persist this value.</param>
        /// <param name="etag">The etag field is *not* required. If it is
        /// provided in the response body, it must also be provided as a header
        /// per the normal etag convention.  Entity tags are used for comparing
        /// two or more entities from the same requested resource. HTTP/1.1
        /// uses entity tags in the etag (section 14.19), If-Match (section
        /// 14.24), If-None-Match (section 14.26), and If-Range (section 14.27)
        /// header fields. </param>
        /// <param name="storageAccountId">the resource id of the storage
        /// account to which you would like to send the Activity Log.</param>
        /// <param name="serviceBusRuleId">The service bus rule ID of the
        /// service bus namespace in which you would like to have Event Hubs
        /// created for streaming the Activity Log. The rule ID is of the
        /// format: '{service bus resource ID}/authorizationrules/{key
        /// name}'.</param>
        public LogProfileResource(string location, IList<string> locations, IList<string> categories, RetentionPolicy retentionPolicy, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), string etag = default(string), string storageAccountId = default(string), string serviceBusRuleId = default(string))
            : base(location, id, name, type, tags, kind, etag)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Locations = locations;
            Categories = categories;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id of the storage account to which you
        /// would like to send the Activity Log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the service bus rule ID of the service bus namespace
        /// in which you would like to have Event Hubs created for streaming
        /// the Activity Log. The rule ID is of the format: '{service bus
        /// resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusRuleId")]
        public string ServiceBusRuleId { get; set; }

        /// <summary>
        /// Gets or sets list of regions for which Activity Log events should
        /// be stored or streamed. It is a comma separated list of valid ARM
        /// locations including the 'global' location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets the categories of the logs. These categories are
        /// created as is convenient to the user. Some values are: 'Write',
        /// 'Delete', and/or 'Action.'
        /// </summary>
        [JsonProperty(PropertyName = "properties.categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for the events in the log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Locations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Locations");
            }
            if (Categories == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Categories");
            }
            if (RetentionPolicy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RetentionPolicy");
            }
            if (RetentionPolicy != null)
            {
                RetentionPolicy.Validate();
            }
        }
    }
}
