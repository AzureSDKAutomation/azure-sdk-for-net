// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The available data types for office data connector.
    /// </summary>
    public partial class OfficeDataConnectorDataTypes
    {
        /// <summary>
        /// Initializes a new instance of the OfficeDataConnectorDataTypes
        /// class.
        /// </summary>
        public OfficeDataConnectorDataTypes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OfficeDataConnectorDataTypes
        /// class.
        /// </summary>
        /// <param name="exchange">Exchange data type connection.</param>
        /// <param name="sharePoint">SharePoint data type connection.</param>
        /// <param name="teams">Teams data type connection.</param>
        public OfficeDataConnectorDataTypes(OfficeDataConnectorDataTypesExchange exchange = default(OfficeDataConnectorDataTypesExchange), OfficeDataConnectorDataTypesSharePoint sharePoint = default(OfficeDataConnectorDataTypesSharePoint), OfficeDataConnectorDataTypesTeams teams = default(OfficeDataConnectorDataTypesTeams))
        {
            Exchange = exchange;
            SharePoint = sharePoint;
            Teams = teams;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets exchange data type connection.
        /// </summary>
        [JsonProperty(PropertyName = "exchange")]
        public OfficeDataConnectorDataTypesExchange Exchange { get; set; }

        /// <summary>
        /// Gets or sets sharePoint data type connection.
        /// </summary>
        [JsonProperty(PropertyName = "sharePoint")]
        public OfficeDataConnectorDataTypesSharePoint SharePoint { get; set; }

        /// <summary>
        /// Gets or sets teams data type connection.
        /// </summary>
        [JsonProperty(PropertyName = "teams")]
        public OfficeDataConnectorDataTypesTeams Teams { get; set; }

    }
}
