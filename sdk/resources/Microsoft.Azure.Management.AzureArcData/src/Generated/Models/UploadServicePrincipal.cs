// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Service principal for uploading billing, metrics and logs.
    /// </summary>
    public partial class UploadServicePrincipal
    {
        /// <summary>
        /// Initializes a new instance of the UploadServicePrincipal class.
        /// </summary>
        public UploadServicePrincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UploadServicePrincipal class.
        /// </summary>
        /// <param name="clientId">Client ID of the service principal for
        /// uploading data.</param>
        /// <param name="tenantId">Tenant ID of the service principal.</param>
        /// <param name="authority">Authority for the service principal.
        /// Example: https://login.microsoftonline.com/</param>
        /// <param name="clientSecret">Secret of the service principal</param>
        public UploadServicePrincipal(System.Guid? clientId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?), string authority = default(string), string clientSecret = default(string))
        {
            ClientId = clientId;
            TenantId = tenantId;
            Authority = authority;
            ClientSecret = clientSecret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets client ID of the service principal for uploading data.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public System.Guid? ClientId { get; set; }

        /// <summary>
        /// Gets or sets tenant ID of the service principal.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or sets authority for the service principal. Example:
        /// https://login.microsoftonline.com/
        /// </summary>
        [JsonProperty(PropertyName = "authority")]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or sets secret of the service principal
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

    }
}
