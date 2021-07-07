// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Single item in a List or Get IpFilterRules operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IpFilterRule : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IpFilterRule class.
        /// </summary>
        public IpFilterRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpFilterRule class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="ipMask">IP Mask</param>
        /// <param name="action">The IP Filter Action. Possible values include:
        /// 'Accept', 'Reject'</param>
        /// <param name="filterName">IP Filter name</param>
        public IpFilterRule(string id = default(string), string name = default(string), string type = default(string), string ipMask = default(string), string action = default(string), string filterName = default(string))
            : base(id, name, type)
        {
            IpMask = ipMask;
            Action = action;
            FilterName = filterName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP Mask
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipMask")]
        public string IpMask { get; set; }

        /// <summary>
        /// Gets or sets the IP Filter Action. Possible values include:
        /// 'Accept', 'Reject'
        /// </summary>
        [JsonProperty(PropertyName = "properties.action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets IP Filter name
        /// </summary>
        [JsonProperty(PropertyName = "properties.filterName")]
        public string FilterName { get; set; }

    }
}
