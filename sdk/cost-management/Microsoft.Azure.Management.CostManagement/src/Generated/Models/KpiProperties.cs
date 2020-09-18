// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Each KPI must contain a 'type' and 'enabled' key.
    /// </summary>
    public partial class KpiProperties
    {
        /// <summary>
        /// Initializes a new instance of the KpiProperties class.
        /// </summary>
        public KpiProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KpiProperties class.
        /// </summary>
        /// <param name="type">KPI type (Forecast, Budget). Possible values
        /// include: 'Forecast', 'Budget'</param>
        /// <param name="id">ID of resource related to metric (budget).</param>
        /// <param name="enabled">show the KPI in the UI?</param>
        public KpiProperties(string type = default(string), string id = default(string), bool? enabled = default(bool?))
        {
            Type = type;
            Id = id;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets KPI type (Forecast, Budget). Possible values include:
        /// 'Forecast', 'Budget'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets ID of resource related to metric (budget).
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets show the KPI in the UI?
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

    }
}
