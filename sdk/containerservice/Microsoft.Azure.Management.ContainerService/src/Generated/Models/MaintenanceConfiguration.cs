// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// maintenance configuration.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MaintenanceConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the MaintenanceConfiguration class.
        /// </summary>
        public MaintenanceConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaintenanceConfiguration class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="type">Resource type</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        /// <param name="timeInWeek">Weekday time slots allowed to
        /// upgrade.</param>
        /// <param name="notAllowedTime">Time slots on which upgrade is not
        /// allowed.</param>
        public MaintenanceConfiguration(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IList<TimeInWeek> timeInWeek = default(IList<TimeInWeek>), IList<TimeSpan> notAllowedTime = default(IList<TimeSpan>))
            : base(id, name, type)
        {
            SystemData = systemData;
            TimeInWeek = timeInWeek;
            NotAllowedTime = notAllowedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the system metadata related to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets weekday time slots allowed to upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeInWeek")]
        public IList<TimeInWeek> TimeInWeek { get; set; }

        /// <summary>
        /// Gets or sets time slots on which upgrade is not allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notAllowedTime")]
        public IList<TimeSpan> NotAllowedTime { get; set; }

    }
}
