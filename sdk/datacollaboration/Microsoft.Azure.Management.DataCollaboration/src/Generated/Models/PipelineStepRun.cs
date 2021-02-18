// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// pipeline step run at data set level
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PipelineStepRun : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the PipelineStepRun class.
        /// </summary>
        public PipelineStepRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineStepRun class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="systemData">System Data of the Azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="durationMs">Duration of pipeline step run</param>
        /// <param name="endTime">End time of pipeline step run</param>
        /// <param name="errorMessage">Error message if any</param>
        /// <param name="pipelineStepName">The name of the step used for this
        /// step run</param>
        /// <param name="pipelineStepRunStatus">Pipeline step run status.
        /// Possible values include: 'Succeeded', 'Failed', 'InProgress',
        /// 'Preparing', 'Queued', 'Unknown', 'Cancelled', 'Canceling'</param>
        /// <param name="pipelineSubsteps">List of substeps</param>
        /// <param name="startTime">Start time of pipeline step run</param>
        public PipelineStepRun(string id = default(string), string name = default(string), ProxyDtoSystemData systemData = default(ProxyDtoSystemData), string type = default(string), int? durationMs = default(int?), System.DateTime? endTime = default(System.DateTime?), string errorMessage = default(string), string pipelineStepName = default(string), string pipelineStepRunStatus = default(string), IList<PipelineSubstep> pipelineSubsteps = default(IList<PipelineSubstep>), System.DateTime? startTime = default(System.DateTime?))
            : base(id, name, systemData, type)
        {
            DurationMs = durationMs;
            EndTime = endTime;
            ErrorMessage = errorMessage;
            PipelineStepName = pipelineStepName;
            PipelineStepRunStatus = pipelineStepRunStatus;
            PipelineSubsteps = pipelineSubsteps;
            StartTime = startTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets duration of pipeline step run
        /// </summary>
        [JsonProperty(PropertyName = "properties.durationMs")]
        public int? DurationMs { get; private set; }

        /// <summary>
        /// Gets end time of pipeline step run
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets error message if any
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets the name of the step used for this step run
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineStepName")]
        public string PipelineStepName { get; private set; }

        /// <summary>
        /// Gets pipeline step run status. Possible values include:
        /// 'Succeeded', 'Failed', 'InProgress', 'Preparing', 'Queued',
        /// 'Unknown', 'Cancelled', 'Canceling'
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineStepRunStatus")]
        public string PipelineStepRunStatus { get; private set; }

        /// <summary>
        /// Gets list of substeps
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineSubsteps")]
        public IList<PipelineSubstep> PipelineSubsteps { get; private set; }

        /// <summary>
        /// Gets start time of pipeline step run
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

    }
}
