// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Azure proxy resource.
    /// </summary>
    public partial class ProxyResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ProxyResource class.
        /// </summary>
        public ProxyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProxyResource class.
        /// </summary>
        /// <param name="id">Azure resource Id.</param>
        /// <param name="name">Azure resource name.</param>
        /// <param name="type">Azure resource type.</param>
        public ProxyResource(string id = default(string), string name = default(string), string type = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets azure resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets azure resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets azure resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
