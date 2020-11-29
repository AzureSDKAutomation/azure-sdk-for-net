// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a registry key entity
    /// </summary>
    [Newtonsoft.Json.JsonObject("registry-key")]
    public partial class RegistryKeyEntity : AlertEntity
    {
        /// <summary>
        /// Initializes a new instance of the RegistryKeyEntity class.
        /// </summary>
        public RegistryKeyEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistryKeyEntity class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="hive">The hive that holds the registry key</param>
        /// <param name="key">The registry key path</param>
        public RegistryKeyEntity(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string hive = default(string), string key = default(string))
            : base(additionalProperties)
        {
            Hive = hive;
            Key = key;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the hive that holds the registry key
        /// </summary>
        [JsonProperty(PropertyName = "hive")]
        public string Hive { get; set; }

        /// <summary>
        /// Gets or sets the registry key path
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

    }
}
