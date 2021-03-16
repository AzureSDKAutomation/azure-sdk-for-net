// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Configurations for provisioning the cluster with HTTP proxy servers.
    /// </summary>
    public partial class ManagedClusterHTTPProxyConfig
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterHTTPProxyConfig
        /// class.
        /// </summary>
        public ManagedClusterHTTPProxyConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterHTTPProxyConfig
        /// class.
        /// </summary>
        /// <param name="httpProxy">HTTP proxy server endpoint to use.</param>
        /// <param name="httpsProxy">HTTPS proxy server endpoint to
        /// use.</param>
        /// <param name="noProxy">Endpoints that should not go through
        /// proxy.</param>
        /// <param name="trustedCa">Alternative CA cert to use for connecting
        /// to proxy servers.</param>
        public ManagedClusterHTTPProxyConfig(string httpProxy = default(string), string httpsProxy = default(string), IList<string> noProxy = default(IList<string>), string trustedCa = default(string))
        {
            HttpProxy = httpProxy;
            HttpsProxy = httpsProxy;
            NoProxy = noProxy;
            TrustedCa = trustedCa;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTTP proxy server endpoint to use.
        /// </summary>
        [JsonProperty(PropertyName = "httpProxy")]
        public string HttpProxy { get; set; }

        /// <summary>
        /// Gets or sets HTTPS proxy server endpoint to use.
        /// </summary>
        [JsonProperty(PropertyName = "httpsProxy")]
        public string HttpsProxy { get; set; }

        /// <summary>
        /// Gets or sets endpoints that should not go through proxy.
        /// </summary>
        [JsonProperty(PropertyName = "noProxy")]
        public IList<string> NoProxy { get; set; }

        /// <summary>
        /// Gets or sets alternative CA cert to use for connecting to proxy
        /// servers.
        /// </summary>
        [JsonProperty(PropertyName = "trustedCa")]
        public string TrustedCa { get; set; }

    }
}
