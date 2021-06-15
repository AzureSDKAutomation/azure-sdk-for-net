// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Maintenance window properties of a server.
    /// </summary>
    public partial class MaintenanceWindow
    {
        /// <summary>
        /// Initializes a new instance of the MaintenanceWindow class.
        /// </summary>
        public MaintenanceWindow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaintenanceWindow class.
        /// </summary>
        /// <param name="customWindow">indicates whether custom window is
        /// enabled or disabled</param>
        /// <param name="startHour">start hour for maintenance window</param>
        /// <param name="startMinute">start minute for maintenance
        /// window</param>
        /// <param name="dayOfWeek">day of week for maintenance window</param>
        public MaintenanceWindow(string customWindow = default(string), int? startHour = default(int?), int? startMinute = default(int?), int? dayOfWeek = default(int?))
        {
            CustomWindow = customWindow;
            StartHour = startHour;
            StartMinute = startMinute;
            DayOfWeek = dayOfWeek;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether custom window is enabled or disabled
        /// </summary>
        [JsonProperty(PropertyName = "customWindow")]
        public string CustomWindow { get; set; }

        /// <summary>
        /// Gets or sets start hour for maintenance window
        /// </summary>
        [JsonProperty(PropertyName = "startHour")]
        public int? StartHour { get; set; }

        /// <summary>
        /// Gets or sets start minute for maintenance window
        /// </summary>
        [JsonProperty(PropertyName = "startMinute")]
        public int? StartMinute { get; set; }

        /// <summary>
        /// Gets or sets day of week for maintenance window
        /// </summary>
        [JsonProperty(PropertyName = "dayOfWeek")]
        public int? DayOfWeek { get; set; }

    }
}
