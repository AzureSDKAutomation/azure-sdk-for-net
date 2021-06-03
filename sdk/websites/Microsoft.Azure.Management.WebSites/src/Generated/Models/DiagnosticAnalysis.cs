// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a diagnostic analysis done on an application
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiagnosticAnalysis : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticAnalysis class.
        /// </summary>
        public DiagnosticAnalysis()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticAnalysis class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="startTime">Start time of the period</param>
        /// <param name="endTime">End time of the period</param>
        /// <param name="abnormalTimePeriods">List of time periods.</param>
        /// <param name="payload">Data by each detector</param>
        /// <param name="nonCorrelatedDetectors">Data by each detector for
        /// detectors that did not corelate</param>
        public DiagnosticAnalysis(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), IList<AbnormalTimePeriod> abnormalTimePeriods = default(IList<AbnormalTimePeriod>), IList<AnalysisData> payload = default(IList<AnalysisData>), IList<DetectorDefinition> nonCorrelatedDetectors = default(IList<DetectorDefinition>))
            : base(id, name, kind, type, systemData)
        {
            StartTime = startTime;
            EndTime = endTime;
            AbnormalTimePeriods = abnormalTimePeriods;
            Payload = payload;
            NonCorrelatedDetectors = nonCorrelatedDetectors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start time of the period
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of the period
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets list of time periods.
        /// </summary>
        [JsonProperty(PropertyName = "properties.abnormalTimePeriods")]
        public IList<AbnormalTimePeriod> AbnormalTimePeriods { get; set; }

        /// <summary>
        /// Gets or sets data by each detector
        /// </summary>
        [JsonProperty(PropertyName = "properties.payload")]
        public IList<AnalysisData> Payload { get; set; }

        /// <summary>
        /// Gets or sets data by each detector for detectors that did not
        /// corelate
        /// </summary>
        [JsonProperty(PropertyName = "properties.nonCorrelatedDetectors")]
        public IList<DetectorDefinition> NonCorrelatedDetectors { get; set; }

    }
}
