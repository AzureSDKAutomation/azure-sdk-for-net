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
    /// Effective Virtual Networks Parameter.
    /// </summary>
    public partial class EffectiveVirtualNetworksParameter
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveVirtualNetworksParameter
        /// class.
        /// </summary>
        public EffectiveVirtualNetworksParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveVirtualNetworksParameter
        /// class.
        /// </summary>
        /// <param name="conditionalMembers">Conditional Members.</param>
        public EffectiveVirtualNetworksParameter(string conditionalMembers = default(string))
        {
            ConditionalMembers = conditionalMembers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets conditional Members.
        /// </summary>
        [JsonProperty(PropertyName = "conditionalMembers")]
        public string ConditionalMembers { get; set; }

    }
}
