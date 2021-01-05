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
    /// A pipeline data transfer object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Pipeline : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the Pipeline class.
        /// </summary>
        public Pipeline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Pipeline class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="description">General Description of the pipeline
        /// content</param>
        /// <param name="pipelineId">Unique id for identifying a pipeline
        /// resource</param>
        /// <param name="provisioningState">Provisioning state of the pipeline.
        /// Possible values include: 'Succeeded', 'Creating', 'Updating',
        /// 'Deleting', 'Moving', 'Failed'</param>
        /// <param name="systemData">SystemData Info of pipeline</param>
        public Pipeline(string id = default(string), string name = default(string), string type = default(string), string description = default(string), string pipelineId = default(string), string provisioningState = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            Description = description;
            PipelineId = pipelineId;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets general Description of the pipeline content
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets unique id for identifying a pipeline resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.pipelineId")]
        public string PipelineId { get; private set; }

        /// <summary>
        /// Gets provisioning state of the pipeline. Possible values include:
        /// 'Succeeded', 'Creating', 'Updating', 'Deleting', 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets systemData Info of pipeline
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
