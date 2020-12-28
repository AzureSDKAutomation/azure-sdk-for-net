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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The start and end date for pulling data for the cost detailed report.
    /// </summary>
    public partial class GenerateDetailedCostReportTimePeriod
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GenerateDetailedCostReportTimePeriod class.
        /// </summary>
        public GenerateDetailedCostReportTimePeriod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GenerateDetailedCostReportTimePeriod class.
        /// </summary>
        /// <param name="start">The start date to pull data from. example
        /// format 2020-03-15</param>
        /// <param name="end">The end date to pull data to. example format
        /// 2020-03-15</param>
        public GenerateDetailedCostReportTimePeriod(string start, string end)
        {
            Start = start;
            End = end;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start date to pull data from. example format
        /// 2020-03-15
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }

        /// <summary>
        /// Gets or sets the end date to pull data to. example format
        /// 2020-03-15
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public string End { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Start == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Start");
            }
            if (End == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "End");
            }
        }
    }
}
