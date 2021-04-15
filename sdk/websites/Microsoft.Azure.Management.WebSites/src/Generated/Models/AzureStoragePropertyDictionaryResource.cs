// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AzureStorageInfo dictionary resource.
    /// </summary>
    public partial class AzureStoragePropertyDictionaryResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureStoragePropertyDictionaryResource class.
        /// </summary>
        public AzureStoragePropertyDictionaryResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureStoragePropertyDictionaryResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="properties">Azure storage accounts.</param>
        public AzureStoragePropertyDictionaryResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, AzureStorageInfoValue> properties = default(IDictionary<string, AzureStorageInfoValue>))
            : base(id, name, kind, type, systemData)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure storage accounts.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, AzureStorageInfoValue> Properties { get; set; }

    }
}
