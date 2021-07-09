// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The application type name resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationTypeResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationTypeResource class.
        /// </summary>
        public ApplicationTypeResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationTypeResource class.
        /// </summary>
        /// <param name="id">Azure resource identifier.</param>
        /// <param name="name">Azure resource name.</param>
        /// <param name="type">Azure resource type.</param>
        /// <param name="location">It will be deprecated in New API, resource
        /// location depends on the parent resource.</param>
        /// <param name="tags">Azure resource tags.</param>
        /// <param name="etag">Azure resource etag.</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response.</param>
        public ApplicationTypeResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), SystemData systemData = default(SystemData), string provisioningState = default(string))
            : base(id, name, type, location, tags, etag, systemData)
        {
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
