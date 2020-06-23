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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class represent managed identities used for request and response
    /// </summary>
    public partial class ManagedIdentityParameters
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIdentityParameters class.
        /// </summary>
        public ManagedIdentityParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIdentityParameters class.
        /// </summary>
        /// <param name="type">Represent the identity type: systemAssigned,
        /// userAssigned, None. Possible values include: 'None',
        /// 'SystemAssigned', 'UserAssigned'</param>
        /// <param name="userAssignedIdentities">Get or set the user assigned
        /// identities</param>
        /// <param name="principalId">Get the principal id for the system
        /// assigned identity.
        /// Only be used in response.</param>
        /// <param name="tenantId">Get the tenant id for the system assigned
        /// identity.
        /// Only be used in response</param>
        public ManagedIdentityParameters(string type = default(string), IDictionary<string, UserAssignedIdentityProperty> userAssignedIdentities = default(IDictionary<string, UserAssignedIdentityProperty>), string principalId = default(string), string tenantId = default(string))
        {
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
            PrincipalId = principalId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets represent the identity type: systemAssigned,
        /// userAssigned, None. Possible values include: 'None',
        /// 'SystemAssigned', 'UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets get or set the user assigned identities
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, UserAssignedIdentityProperty> UserAssignedIdentities { get; set; }

        /// <summary>
        /// Gets get the principal id for the system assigned identity.
        /// Only be used in response.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets get the tenant id for the system assigned identity.
        /// Only be used in response
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

    }
}
