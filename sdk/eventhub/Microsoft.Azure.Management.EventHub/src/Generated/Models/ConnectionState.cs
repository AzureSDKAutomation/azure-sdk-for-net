// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ConnectionState information.
    /// </summary>
    public partial class ConnectionState
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionState class.
        /// </summary>
        public ConnectionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionState class.
        /// </summary>
        /// <param name="status">Status of the connection. Possible values
        /// include: 'Pending', 'Approved', 'Rejected', 'Disconnected'</param>
        /// <param name="description">Description of the connection
        /// state.</param>
        public ConnectionState(string status = default(string), string description = default(string))
        {
            Status = status;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the connection. Possible values include:
        /// 'Pending', 'Approved', 'Rejected', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets description of the connection state.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
