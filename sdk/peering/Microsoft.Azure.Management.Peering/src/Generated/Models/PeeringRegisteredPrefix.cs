// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The customer's prefix that is registered by the peering service
    /// provider.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PeeringRegisteredPrefix : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PeeringRegisteredPrefix class.
        /// </summary>
        public PeeringRegisteredPrefix()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringRegisteredPrefix class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="prefix">The customer's prefix from which traffic
        /// originates.</param>
        /// <param name="prefixValidationState">The prefix validation state.
        /// Possible values include: 'None', 'Invalid', 'Verified', 'Failed',
        /// 'Pending', 'Warning', 'Unknown'</param>
        /// <param name="peeringServicePrefixKey">The peering service prefix
        /// key that is to be shared with the customer.</param>
        /// <param name="errorMessage">The error message associated with the
        /// validation state, if any.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        public PeeringRegisteredPrefix(string name = default(string), string id = default(string), string type = default(string), string prefix = default(string), string prefixValidationState = default(string), string peeringServicePrefixKey = default(string), string errorMessage = default(string), string provisioningState = default(string))
            : base(name, id, type)
        {
            Prefix = prefix;
            PrefixValidationState = prefixValidationState;
            PeeringServicePrefixKey = peeringServicePrefixKey;
            ErrorMessage = errorMessage;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the customer's prefix from which traffic originates.
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets the prefix validation state. Possible values include: 'None',
        /// 'Invalid', 'Verified', 'Failed', 'Pending', 'Warning', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefixValidationState")]
        public string PrefixValidationState { get; private set; }

        /// <summary>
        /// Gets the peering service prefix key that is to be shared with the
        /// customer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringServicePrefixKey")]
        public string PeeringServicePrefixKey { get; private set; }

        /// <summary>
        /// Gets the error message associated with the validation state, if
        /// any.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
