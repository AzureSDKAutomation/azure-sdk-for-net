// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maps.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters used to update an existing Maps Account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MapsAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the MapsAccountUpdateParameters
        /// class.
        /// </summary>
        public MapsAccountUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapsAccountUpdateParameters
        /// class.
        /// </summary>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used in viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key no
        /// greater than 128 characters and value no greater than 256
        /// characters.</param>
        /// <param name="kind">Get or Set Kind property. Possible values
        /// include: 'Gen1', 'Gen2'</param>
        /// <param name="sku">The SKU of this account.</param>
        /// <param name="uniqueId">A unique identifier for the maps
        /// account</param>
        /// <param name="disableLocalAuth">Allows toggle functionality on Azure
        /// Policy to disable Azure Maps local authentication support. This
        /// will disable Shared Keys authentication from any usage.</param>
        /// <param name="provisioningState">the state of the
        /// provisioning.</param>
        public MapsAccountUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), Sku sku = default(Sku), string uniqueId = default(string), bool? disableLocalAuth = default(bool?), string provisioningState = default(string))
        {
            Tags = tags;
            Kind = kind;
            Sku = sku;
            UniqueId = uniqueId;
            DisableLocalAuth = disableLocalAuth;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key no greater than 128 characters
        /// and value no greater than 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets get or Set Kind property. Possible values include:
        /// 'Gen1', 'Gen2'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the SKU of this account.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets a unique identifier for the maps account
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueId")]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or sets allows toggle functionality on Azure Policy to disable
        /// Azure Maps local authentication support. This will disable Shared
        /// Keys authentication from any usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableLocalAuth")]
        public bool? DisableLocalAuth { get; set; }

        /// <summary>
        /// Gets the state of the provisioning.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
