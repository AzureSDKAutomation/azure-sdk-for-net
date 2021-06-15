// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OpenAI.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// OpenAI account is an Azure resource representing the provisioned
    /// account, it's type, location and SKU.
    /// </summary>
    public partial class Account : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        public Account()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="sku">SKU properties of the of the OpenAI
        /// account.</param>
        /// <param name="identity">Managed service identity of the OpenAI
        /// account.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="properties">Properties of OpenAI account.</param>
        public Account(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), Sku sku = default(Sku), Identity identity = default(Identity), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), AccountProperties properties = default(AccountProperties))
            : base(id, name, type, etag)
        {
            Sku = sku;
            Identity = identity;
            SystemData = systemData;
            Tags = tags;
            Location = location;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SKU properties of the of the OpenAI account.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets managed service identity of the OpenAI account.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets properties of OpenAI account.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AccountProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
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
