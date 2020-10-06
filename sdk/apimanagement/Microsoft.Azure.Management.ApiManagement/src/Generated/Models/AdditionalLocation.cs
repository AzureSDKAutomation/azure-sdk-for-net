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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of an additional API Management resource location.
    /// </summary>
    public partial class AdditionalLocation
    {
        /// <summary>
        /// Initializes a new instance of the AdditionalLocation class.
        /// </summary>
        public AdditionalLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdditionalLocation class.
        /// </summary>
        /// <param name="location">The location name of the additional region
        /// among Azure Data center regions.</param>
        /// <param name="sku">SKU properties of the API Management
        /// service.</param>
        /// <param name="zones">A list of availability zones denoting where the
        /// resource needs to come from.</param>
        /// <param name="publicIPAddresses">Public Static Load Balanced IP
        /// addresses of the API Management service in the additional location.
        /// Available only for Basic, Standard and Premium SKU.</param>
        /// <param name="privateIPAddresses">Private Static Load Balanced IP
        /// addresses of the API Management service which is deployed in an
        /// Internal Virtual Network in a particular additional location.
        /// Available only for Basic, Standard and Premium SKU.</param>
        /// <param name="virtualNetworkConfiguration">Virtual network
        /// configuration for the location.</param>
        /// <param name="gatewayRegionalUrl">Gateway URL of the API Management
        /// service in the Region.</param>
        /// <param name="disableGateway">Property only valid for an Api
        /// Management service deployed in multiple locations. This can be used
        /// to disable the gateway in this additional location.</param>
        public AdditionalLocation(string location, ApiManagementServiceSkuProperties sku, IList<string> zones = default(IList<string>), IList<string> publicIPAddresses = default(IList<string>), IList<string> privateIPAddresses = default(IList<string>), VirtualNetworkConfiguration virtualNetworkConfiguration = default(VirtualNetworkConfiguration), string gatewayRegionalUrl = default(string), bool? disableGateway = default(bool?))
        {
            Location = location;
            Sku = sku;
            Zones = zones;
            PublicIPAddresses = publicIPAddresses;
            PrivateIPAddresses = privateIPAddresses;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            GatewayRegionalUrl = gatewayRegionalUrl;
            DisableGateway = disableGateway;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location name of the additional region among Azure
        /// Data center regions.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets SKU properties of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ApiManagementServiceSkuProperties Sku { get; set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting where the
        /// resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets public Static Load Balanced IP addresses of the API Management
        /// service in the additional location. Available only for Basic,
        /// Standard and Premium SKU.
        /// </summary>
        [JsonProperty(PropertyName = "publicIPAddresses")]
        public IList<string> PublicIPAddresses { get; private set; }

        /// <summary>
        /// Gets private Static Load Balanced IP addresses of the API
        /// Management service which is deployed in an Internal Virtual Network
        /// in a particular additional location. Available only for Basic,
        /// Standard and Premium SKU.
        /// </summary>
        [JsonProperty(PropertyName = "privateIPAddresses")]
        public IList<string> PrivateIPAddresses { get; private set; }

        /// <summary>
        /// Gets or sets virtual network configuration for the location.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkConfiguration")]
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }

        /// <summary>
        /// Gets gateway URL of the API Management service in the Region.
        /// </summary>
        [JsonProperty(PropertyName = "gatewayRegionalUrl")]
        public string GatewayRegionalUrl { get; private set; }

        /// <summary>
        /// Gets or sets property only valid for an Api Management service
        /// deployed in multiple locations. This can be used to disable the
        /// gateway in this additional location.
        /// </summary>
        [JsonProperty(PropertyName = "disableGateway")]
        public bool? DisableGateway { get; set; }

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
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (VirtualNetworkConfiguration != null)
            {
                VirtualNetworkConfiguration.Validate();
            }
        }
    }
}
