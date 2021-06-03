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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A snapshot of an app.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Snapshot : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="time">The time the snapshot was taken.</param>
        public Snapshot(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string time = default(string))
            : base(id, name, kind, type, systemData)
        {
            Time = time;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time the snapshot was taken.
        /// </summary>
        [JsonProperty(PropertyName = "properties.time")]
        public string Time { get; private set; }

    }
}
