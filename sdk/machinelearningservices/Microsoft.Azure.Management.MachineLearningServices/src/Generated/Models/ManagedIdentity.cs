// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Managed identity configuration.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Managed")]
    public partial class ManagedIdentity : IdentityConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIdentity class.
        /// </summary>
        public ManagedIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIdentity class.
        /// </summary>
        /// <param name="clientId">Specifies a user-assigned identity by client
        /// ID. For system-assigned, do not set this field.</param>
        /// <param name="objectId">Specifies a user-assigned identity by object
        /// ID. For system-assigned, do not set this field.</param>
        /// <param name="resourceId">Specifies a user-assigned identity by ARM
        /// resource ID. For system-assigned, do not set this field.</param>
        public ManagedIdentity(System.Guid? clientId = default(System.Guid?), System.Guid? objectId = default(System.Guid?), string resourceId = default(string))
        {
            ClientId = clientId;
            ObjectId = objectId;
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies a user-assigned identity by client ID. For
        /// system-assigned, do not set this field.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public System.Guid? ClientId { get; set; }

        /// <summary>
        /// Gets or sets specifies a user-assigned identity by object ID. For
        /// system-assigned, do not set this field.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public System.Guid? ObjectId { get; set; }

        /// <summary>
        /// Gets or sets specifies a user-assigned identity by ARM resource ID.
        /// For system-assigned, do not set this field.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

    }
}
