// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schedule for a given suppression configuration.
    /// </summary>
    public partial class SuppressionSchedule
    {
        /// <summary>
        /// Initializes a new instance of the SuppressionSchedule class.
        /// </summary>
        public SuppressionSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SuppressionSchedule class.
        /// </summary>
        /// <param name="startDate">Start date for suppression</param>
        /// <param name="endDate">End date for suppression</param>
        /// <param name="startTime">Start time for suppression</param>
        /// <param name="endTime">End date for suppression</param>
        /// <param name="recurrenceValues">Specifies the values for recurrence
        /// pattern</param>
        public SuppressionSchedule(string startDate = default(string), string endDate = default(string), string startTime = default(string), string endTime = default(string), IList<long?> recurrenceValues = default(IList<long?>))
        {
            StartDate = startDate;
            EndDate = endDate;
            StartTime = startTime;
            EndTime = endTime;
            RecurrenceValues = recurrenceValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start date for suppression
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date for suppression
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets start time for suppression
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets end date for suppression
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets specifies the values for recurrence pattern
        /// </summary>
        [JsonProperty(PropertyName = "recurrenceValues")]
        public IList<long?> RecurrenceValues { get; set; }

    }
}
