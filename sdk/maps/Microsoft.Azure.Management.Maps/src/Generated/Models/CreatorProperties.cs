// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Creator resource properties
    /// </summary>
    public partial class CreatorProperties
    {
        /// <summary>
        /// Initializes a new instance of the CreatorProperties class.
        /// </summary>
        public CreatorProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreatorProperties class.
        /// </summary>
        /// <param name="provisioningState">The state of the resource
        /// provisioning, terminal states: Succeeded, Failed, Canceled</param>
        public CreatorProperties(string provisioningState = default(string))
        {
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the resource provisioning, terminal
        /// states: Succeeded, Failed, Canceled
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
