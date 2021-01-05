// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A constrained resource data transfer object
    /// </summary>
    public partial class ConstrainedResource : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the ConstrainedResource class.
        /// </summary>
        public ConstrainedResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConstrainedResource class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="systemData">SystemData Info of constrained
        /// resource</param>
        public ConstrainedResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets systemData Info of constrained resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
