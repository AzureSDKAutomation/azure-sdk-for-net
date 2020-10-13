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

    [Newtonsoft.Json.JsonObject("network-connection")]
    public partial class NetworkConnectionEntity : AlertEntity
    {
        /// <summary>
        /// Initializes a new instance of the NetworkConnectionEntity class.
        /// </summary>
        public NetworkConnectionEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkConnectionEntity class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourcePort">The source port number</param>
        /// <param name="destinationPort">The destination port number</param>
        /// <param name="protocol">The protocol type of the network connection
        /// (i.e. TCP, UDP)</param>
        public NetworkConnectionEntity(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IPEntity sourceAddress = default(IPEntity), int? sourcePort = default(int?), IPEntity destinationAddress = default(IPEntity), int? destinationPort = default(int?), string protocol = default(string))
            : base(additionalProperties)
        {
            SourceAddress = sourceAddress;
            SourcePort = sourcePort;
            DestinationAddress = destinationAddress;
            DestinationPort = destinationPort;
            Protocol = protocol;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddress")]
        public IPEntity SourceAddress { get; set; }

        /// <summary>
        /// Gets or sets the source port number
        /// </summary>
        [JsonProperty(PropertyName = "sourcePort")]
        public int? SourcePort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddress")]
        public IPEntity DestinationAddress { get; set; }

        /// <summary>
        /// Gets or sets the destination port number
        /// </summary>
        [JsonProperty(PropertyName = "destinationPort")]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Gets or sets the protocol type of the network connection (i.e. TCP,
        /// UDP)
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

    }
}
