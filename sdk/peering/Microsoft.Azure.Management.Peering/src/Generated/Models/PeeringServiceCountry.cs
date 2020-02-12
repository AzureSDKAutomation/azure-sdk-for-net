// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using System.Linq;

    /// <summary>
    /// The peering service country.
    /// </summary>
    public partial class PeeringServiceCountry : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PeeringServiceCountry class.
        /// </summary>
        public PeeringServiceCountry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringServiceCountry class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        public PeeringServiceCountry(string name = default(string), string id = default(string), string type = default(string))
            : base(name, id, type)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
