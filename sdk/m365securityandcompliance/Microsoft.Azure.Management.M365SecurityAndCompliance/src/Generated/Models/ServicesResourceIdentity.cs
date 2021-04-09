// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.M365SecurityAndCompliance.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Setting indicating whether the service has a managed identity
    /// associated with it.
    /// </summary>
    public partial class ServicesResourceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ServicesResourceIdentity class.
        /// </summary>
        public ServicesResourceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicesResourceIdentity class.
        /// </summary>
        /// <param name="principalId">The principal ID of the resource
        /// identity.</param>
        /// <param name="tenantId">The tenant ID of the resource.</param>
        /// <param name="type">Type of identity being specified, currently
        /// SystemAssigned and None are allowed. Possible values include:
        /// 'SystemAssigned', 'None'</param>
        public ServicesResourceIdentity(string principalId = default(string), string tenantId = default(string), string type = default(string))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal ID of the resource identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets type of identity being specified, currently
        /// SystemAssigned and None are allowed. Possible values include:
        /// 'SystemAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
