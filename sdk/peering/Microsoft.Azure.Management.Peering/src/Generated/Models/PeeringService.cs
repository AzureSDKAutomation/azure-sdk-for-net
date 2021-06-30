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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Peering Service
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PeeringService : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PeeringService class.
        /// </summary>
        public PeeringService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringService class.
        /// </summary>
        /// <param name="location">The location of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="sku">The SKU that defines the type of the peering
        /// service.</param>
        /// <param name="peeringServiceLocation">The location (state/province)
        /// of the customer.</param>
        /// <param name="peeringServiceProvider">The name of the service
        /// provider.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="providerPrimaryPeeringLocation">The primary peering
        /// (Microsoft/service provider) location to be used for customer
        /// traffic.</param>
        /// <param name="providerBackupPeeringLocation">The backup peering
        /// (Microsoft/service provider) location to be used for customer
        /// traffic.</param>
        /// <param name="logAnalyticsWorkspaceProperties">The Log Analytics
        /// Workspace Properties</param>
        /// <param name="tags">The resource tags.</param>
        public PeeringService(string location, string name = default(string), string id = default(string), string type = default(string), PeeringServiceSku sku = default(PeeringServiceSku), string peeringServiceLocation = default(string), string peeringServiceProvider = default(string), string provisioningState = default(string), string providerPrimaryPeeringLocation = default(string), string providerBackupPeeringLocation = default(string), LogAnalyticsWorkspaceProperties logAnalyticsWorkspaceProperties = default(LogAnalyticsWorkspaceProperties), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(name, id, type)
        {
            Sku = sku;
            PeeringServiceLocation = peeringServiceLocation;
            PeeringServiceProvider = peeringServiceProvider;
            ProvisioningState = provisioningState;
            ProviderPrimaryPeeringLocation = providerPrimaryPeeringLocation;
            ProviderBackupPeeringLocation = providerBackupPeeringLocation;
            LogAnalyticsWorkspaceProperties = logAnalyticsWorkspaceProperties;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU that defines the type of the peering service.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public PeeringServiceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the location (state/province) of the customer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringServiceLocation")]
        public string PeeringServiceLocation { get; set; }

        /// <summary>
        /// Gets or sets the name of the service provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringServiceProvider")]
        public string PeeringServiceProvider { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the primary peering (Microsoft/service provider)
        /// location to be used for customer traffic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.providerPrimaryPeeringLocation")]
        public string ProviderPrimaryPeeringLocation { get; set; }

        /// <summary>
        /// Gets or sets the backup peering (Microsoft/service provider)
        /// location to be used for customer traffic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.providerBackupPeeringLocation")]
        public string ProviderBackupPeeringLocation { get; set; }

        /// <summary>
        /// Gets or sets the Log Analytics Workspace Properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.logAnalyticsWorkspaceProperties")]
        public LogAnalyticsWorkspaceProperties LogAnalyticsWorkspaceProperties { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
