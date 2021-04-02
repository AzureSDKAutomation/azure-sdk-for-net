// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The quota request submit response with request id.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class QuotaRequestSubmitResponse201
    {
        /// <summary>
        /// Initializes a new instance of the QuotaRequestSubmitResponse201
        /// class.
        /// </summary>
        public QuotaRequestSubmitResponse201()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaRequestSubmitResponse201
        /// class.
        /// </summary>
        /// <param name="id">The quota request id. Please use the requestId to
        /// check the request status.</param>
        /// <param name="name">The operation Id</param>
        /// <param name="type">The resource type</param>
        /// <param name="provisioningState">The quota request status. Possible
        /// values include: 'Accepted', 'Invalid', 'Succeeded', 'Failed',
        /// 'InProgress'</param>
        /// <param name="message">A user friendly message.</param>
        public QuotaRequestSubmitResponse201(string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string), string message = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            ProvisioningState = provisioningState;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the quota request id. Please use the requestId to check the
        /// request status.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the operation Id
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the quota request status. Possible values include: 'Accepted',
        /// 'Invalid', 'Succeeded', 'Failed', 'InProgress'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a user friendly message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.message")]
        public string Message { get; private set; }

    }
}
