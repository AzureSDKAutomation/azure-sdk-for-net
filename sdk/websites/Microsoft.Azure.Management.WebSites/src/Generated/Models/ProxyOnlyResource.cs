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
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure proxy only resource. This resource is not tracked by Azure
    /// Resource Manager.
    /// </summary>
    public partial class ProxyOnlyResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ProxyOnlyResource class.
        /// </summary>
        public ProxyOnlyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProxyOnlyResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        public ProxyOnlyResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData))
        {
            Id = id;
            Name = name;
            Kind = kind;
            Type = type;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource Name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets kind of resource.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the system metadata relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
