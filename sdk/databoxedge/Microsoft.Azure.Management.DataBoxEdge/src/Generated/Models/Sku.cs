// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The SKU type.
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
        /// <param name="name">SKU name. Possible values include: 'Gateway',
        /// 'Edge', 'TEA_1Node', 'TEA_1Node_UPS', 'TEA_1Node_Heater',
        /// 'TEA_1Node_UPS_Heater', 'TEA_4Node_Heater', 'TEA_4Node_UPS_Heater',
        /// 'TMA', 'TDC', 'TCA_Small', 'GPU', 'TCA_Large', 'EdgeP_Base',
        /// 'EdgeP_High', 'EdgePR_Base', 'EdgePR_Base_UPS', 'EdgeMR_Mini',
        /// 'RCA_Small', 'RCA_Large', 'RDC'</param>
        /// <param name="tier">The SKU tier. This is based on the SKU name.
        /// Possible values include: 'Standard'</param>
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
        /// Gets or sets SKU name. Possible values include: 'Gateway', 'Edge',
        /// 'TEA_1Node', 'TEA_1Node_UPS', 'TEA_1Node_Heater',
        /// 'TEA_1Node_UPS_Heater', 'TEA_4Node_Heater', 'TEA_4Node_UPS_Heater',
        /// 'TMA', 'TDC', 'TCA_Small', 'GPU', 'TCA_Large', 'EdgeP_Base',
        /// 'EdgeP_High', 'EdgePR_Base', 'EdgePR_Base_UPS', 'EdgeMR_Mini',
        /// 'RCA_Small', 'RCA_Large', 'RDC'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the SKU tier. This is based on the SKU name. Possible
        /// values include: 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
