// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TLS settings for the resource
    /// </summary>
    public partial class SignalRTlsSettings
    {
        /// <summary>
        /// Initializes a new instance of the SignalRTlsSettings class.
        /// </summary>
        public SignalRTlsSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRTlsSettings class.
        /// </summary>
        /// <param name="clientCertEnabled">Request client certificate during
        /// TLS handshake if enabled</param>
        public SignalRTlsSettings(bool? clientCertEnabled = default(bool?))
        {
            ClientCertEnabled = clientCertEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets request client certificate during TLS handshake if
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "clientCertEnabled")]
        public bool? ClientCertEnabled { get; set; }

    }
}
