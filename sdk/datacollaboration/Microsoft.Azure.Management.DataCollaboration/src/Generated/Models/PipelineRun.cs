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
    using System.Linq;

    /// <summary>
    /// A pipeline run data transfer object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PipelineRun : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the PipelineRun class.
        /// </summary>
        public PipelineRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineRun class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="systemData">System Data of the Azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="durationMs">Pipeline run duration</param>
        /// <param name="endTime">End time of pipeline run</param>
        /// <param name="errorMessage">Error message if any</param>
        /// <param name="pipelineId">Object id of the pipeline used to create
        /// this run</param>
        /// <param name="pipelineName">Name of the pipeline used to create this
        /// run</param>
        /// <param name="pipelineRunMode">Indicate the pipeline execution mode.
        /// Production or Test. Possible values include: 'Production',
        /// 'Test'</param>
        /// <param name="pipelineRunStatus">Pipeline run status. Possible
        /// values include: 'Succeeded', 'Failed', 'InProgress', 'Preparing',
        /// 'Queued', 'Unknown', 'Cancelled', 'Canceling'</param>
        /// <param name="startTime">Start time of pipeline run</param>
        public PipelineRun(string id = default(string), string name = default(string), ProxyDtoSystemData systemData = default(ProxyDtoSystemData), string type = default(string), int? durationMs = default(int?), System.DateTime? endTime = default(System.DateTime?), string errorMessage = default(string), string pipelineId = default(string), string pipelineName = default(string), string pipelineRunMode = default(string), string pipelineRunStatus = default(string), System.DateTime? startTime = default(System.DateTime?))
            : base(id, name, systemData, type)
        {
            DurationMs = durationMs;
            EndTime = endTime;
            ErrorMessage = errorMessage;
            PipelineId = pipelineId;
            PipelineName = pipelineName;
            PipelineRunMode = pipelineRunMode;
            PipelineRunStatus = pipelineRunStatus;
            StartTime = startTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets pipeline run duration
        /// </summary>
        [JsonProperty(PropertyName = "properties.durationMs")]
        public int? DurationMs { get; private set; }

        /// <summary>
        /// Gets end time of pipeline run
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets error message if any
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets object id of the pipeline used to create this run
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineId")]
        public string PipelineId { get; private set; }

        /// <summary>
        /// Gets name of the pipeline used to create this run
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineName")]
        public string PipelineName { get; private set; }

        /// <summary>
        /// Gets indicate the pipeline execution mode. Production or Test.
        /// Possible values include: 'Production', 'Test'
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineRunMode")]
        public string PipelineRunMode { get; private set; }

        /// <summary>
        /// Gets pipeline run status. Possible values include: 'Succeeded',
        /// 'Failed', 'InProgress', 'Preparing', 'Queued', 'Unknown',
        /// 'Cancelled', 'Canceling'
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineRunStatus")]
        public string PipelineRunStatus { get; private set; }

        /// <summary>
        /// Gets start time of pipeline run
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

    }
}
