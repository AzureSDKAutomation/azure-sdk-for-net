// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EventGrid Partner Namespace.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PartnerNamespace : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the PartnerNamespace class.
        /// </summary>
        public PartnerNamespace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerNamespace class.
        /// </summary>
        /// <param name="location">Location of the resource.</param>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        /// <param name="tags">Tags of the resource.</param>
        /// <param name="provisioningState">Provisioning state of the partner
        /// namespace. Possible values include: 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="partnerRegistrationFullyQualifiedId">The fully
        /// qualified ARM Id of the partner registration that should be
        /// associated with this partner namespace. This takes the following
        /// format:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}.</param>
        /// <param name="endpoint">Endpoint for the partner namespace.</param>
        /// <param name="systemData">The system metadata relating to Partner
        /// Namespace resource.</param>
        public PartnerNamespace(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string partnerRegistrationFullyQualifiedId = default(string), string endpoint = default(string), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            PartnerRegistrationFullyQualifiedId = partnerRegistrationFullyQualifiedId;
            Endpoint = endpoint;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the partner namespace. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Canceled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the fully qualified ARM Id of the partner registration
        /// that should be associated with this partner namespace. This takes
        /// the following format:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerRegistrationFullyQualifiedId")]
        public string PartnerRegistrationFullyQualifiedId { get; set; }

        /// <summary>
        /// Gets endpoint for the partner namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets the system metadata relating to Partner Namespace resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
