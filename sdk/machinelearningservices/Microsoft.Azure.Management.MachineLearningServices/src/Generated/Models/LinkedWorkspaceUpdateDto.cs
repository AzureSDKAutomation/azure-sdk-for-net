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
    /// object used for updating linked workspace.
    /// </summary>
    public partial class LinkedWorkspaceUpdateDto
    {
        /// <summary>
        /// Initializes a new instance of the LinkedWorkspaceUpdateDto class.
        /// </summary>
        public LinkedWorkspaceUpdateDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkedWorkspaceUpdateDto class.
        /// </summary>
        /// <param name="userAssignedIdentityResourceId">ResourceId of the user
        /// assigned identity for the linked workspace</param>
        public LinkedWorkspaceUpdateDto(string userAssignedIdentityResourceId = default(string))
        {
            UserAssignedIdentityResourceId = userAssignedIdentityResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resourceId of the user assigned identity for the
        /// linked workspace
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentityResourceId")]
        public string UserAssignedIdentityResourceId { get; set; }

    }
}
