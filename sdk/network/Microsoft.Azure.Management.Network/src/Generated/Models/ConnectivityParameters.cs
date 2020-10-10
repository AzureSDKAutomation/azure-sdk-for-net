// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that determine how the connectivity check will be performed.
    /// </summary>
    public partial class ConnectivityParameters
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityParameters class.
        /// </summary>
        public ConnectivityParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityParameters class.
        /// </summary>
        /// <param name="source">The source of the connection.</param>
        /// <param name="destination">The destination of connection.</param>
        /// <param name="protocol">Network protocol. Possible values include:
        /// 'Tcp', 'Http', 'Https', 'Icmp'</param>
        /// <param name="protocolConfiguration">Configuration of the
        /// protocol.</param>
        /// <param name="preferredIPVersion">Preferred IP version of the
        /// connection. Possible values include: 'IPv4', 'IPv6'</param>
        public ConnectivityParameters(ConnectivitySource source, ConnectivityDestination destination, string protocol = default(string), ProtocolConfiguration protocolConfiguration = default(ProtocolConfiguration), string preferredIPVersion = default(string))
        {
            Source = source;
            Destination = destination;
            Protocol = protocol;
            ProtocolConfiguration = protocolConfiguration;
            PreferredIPVersion = preferredIPVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source of the connection.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public ConnectivitySource Source { get; set; }

        /// <summary>
        /// Gets or sets the destination of connection.
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public ConnectivityDestination Destination { get; set; }

        /// <summary>
        /// Gets or sets network protocol. Possible values include: 'Tcp',
        /// 'Http', 'Https', 'Icmp'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets configuration of the protocol.
        /// </summary>
        [JsonProperty(PropertyName = "protocolConfiguration")]
        public ProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// Gets or sets preferred IP version of the connection. Possible
        /// values include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "preferredIPVersion")]
        public string PreferredIPVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Destination == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Destination");
            }
            if (Source != null)
            {
                Source.Validate();
            }
            if (Destination != null)
            {
                Destination.Validate();
            }
        }
    }
}
