// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A request to perform the connectivity check operation on a API
    /// Management service.
    /// </summary>
    public partial class ConnectivityCheckRequest
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityCheckRequest class.
        /// </summary>
        public ConnectivityCheckRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityCheckRequest class.
        /// </summary>
        /// <param name="source">Definitions about the connectivity check
        /// origin.</param>
        /// <param name="destination">The connectivity check operation
        /// destination.</param>
        /// <param name="preferredIPVersion">The IP version to be used. Can
        /// either be IPv4 or IPv6. Possible values include: 'IPv4',
        /// 'IPv6'</param>
        public ConnectivityCheckRequest(ConnectivityCheckRequestSource source, ConnectivityCheckRequestDestination destination, string preferredIPVersion)
        {
            Source = source;
            Destination = destination;
            PreferredIPVersion = preferredIPVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets definitions about the connectivity check origin.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public ConnectivityCheckRequestSource Source { get; set; }

        /// <summary>
        /// Gets or sets the connectivity check operation destination.
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public ConnectivityCheckRequestDestination Destination { get; set; }

        /// <summary>
        /// Gets or sets the IP version to be used. Can either be IPv4 or IPv6.
        /// Possible values include: 'IPv4', 'IPv6'
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
            if (PreferredIPVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PreferredIPVersion");
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
