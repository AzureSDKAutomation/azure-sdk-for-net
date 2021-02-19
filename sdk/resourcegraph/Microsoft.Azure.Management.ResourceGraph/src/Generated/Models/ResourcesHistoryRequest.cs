// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ResourcesHistoryRequest
    {
        /// <summary>
        /// Initializes a new instance of the ResourcesHistoryRequest class.
        /// </summary>
        public ResourcesHistoryRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourcesHistoryRequest class.
        /// </summary>
        public ResourcesHistoryRequest(IList<string> subscriptions = default(IList<string>), string query = default(string), ResourcesHistoryRequestOptions options = default(ResourcesHistoryRequestOptions), string managementGroupId = default(string))
        {
            Subscriptions = subscriptions;
            Query = query;
            Options = options;
            ManagementGroupId = managementGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptions")]
        public IList<string> Subscriptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public ResourcesHistoryRequestOptions Options { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managementGroupId")]
        public string ManagementGroupId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Options != null)
            {
                Options.Validate();
            }
        }
    }
}
