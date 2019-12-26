// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sku of the resource
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Name of the sku</param>
        /// <param name="tier">Tier of the sku like Basic or Enterprise</param>
        public Sku(string name = default(string), string tier = default(string))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the sku
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets tier of the sku like Basic or Enterprise
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
