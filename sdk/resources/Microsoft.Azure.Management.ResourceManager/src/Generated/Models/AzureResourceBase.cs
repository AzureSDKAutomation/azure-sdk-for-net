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
    /// Common properties for all Azure resources.
    /// </summary>
    public partial class AzureResourceBase : IResource
    {
        /// <summary>
        /// Initializes a new instance of the AzureResourceBase class.
        /// </summary>
        public AzureResourceBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureResourceBase class.
        /// </summary>
        /// <param name="id">String Id used to locate any resource on
        /// Azure.</param>
        /// <param name="name">Name of this resource.</param>
        /// <param name="type">Type of this resource.</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        public AzureResourceBase(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData))
        {
            Id = id;
            Name = name;
            Type = type;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets string Id used to locate any resource on Azure.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets azure Resource Manager metadata containing createdBy and
        /// modifiedBy information.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
