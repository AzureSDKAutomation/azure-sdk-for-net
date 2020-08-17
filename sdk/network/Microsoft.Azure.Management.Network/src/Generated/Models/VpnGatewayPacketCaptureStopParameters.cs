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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stop packet capture parameters.
    /// </summary>
    public partial class VpnGatewayPacketCaptureStopParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VpnGatewayPacketCaptureStopParameters class.
        /// </summary>
        public VpnGatewayPacketCaptureStopParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VpnGatewayPacketCaptureStopParameters class.
        /// </summary>
        /// <param name="sasUrl">SAS url for packet capture on vpn
        /// gateway.</param>
        public VpnGatewayPacketCaptureStopParameters(string sasUrl = default(string))
        {
            SasUrl = sasUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SAS url for packet capture on vpn gateway.
        /// </summary>
        [JsonProperty(PropertyName = "sasUrl")]
        public string SasUrl { get; set; }

    }
}
