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
    using System.Linq;

    /// <summary>
    /// Process Thread Information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProcessThreadInfo : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the ProcessThreadInfo class.
        /// </summary>
        public ProcessThreadInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessThreadInfo class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="identifier">Site extension ID.</param>
        /// <param name="href">HRef URI.</param>
        /// <param name="process">Process URI.</param>
        /// <param name="startAddress">Start address.</param>
        /// <param name="currentPriority">Current thread priority.</param>
        /// <param name="priorityLevel">Thread priority level.</param>
        /// <param name="basePriority">Base priority.</param>
        /// <param name="startTime">Start time.</param>
        /// <param name="totalProcessorTime">Total processor time.</param>
        /// <param name="userProcessorTime">User processor time.</param>
        /// <param name="state">Thread state.</param>
        /// <param name="waitReason">Wait reason.</param>
        public ProcessThreadInfo(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), int? identifier = default(int?), string href = default(string), string process = default(string), string startAddress = default(string), int? currentPriority = default(int?), string priorityLevel = default(string), int? basePriority = default(int?), System.DateTime? startTime = default(System.DateTime?), string totalProcessorTime = default(string), string userProcessorTime = default(string), string state = default(string), string waitReason = default(string))
            : base(id, name, kind, type, systemData)
        {
            Identifier = identifier;
            Href = href;
            Process = process;
            StartAddress = startAddress;
            CurrentPriority = currentPriority;
            PriorityLevel = priorityLevel;
            BasePriority = basePriority;
            StartTime = startTime;
            TotalProcessorTime = totalProcessorTime;
            UserProcessorTime = userProcessorTime;
            State = state;
            WaitReason = waitReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets site extension ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.identifier")]
        public int? Identifier { get; private set; }

        /// <summary>
        /// Gets or sets hRef URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets process URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.process")]
        public string Process { get; set; }

        /// <summary>
        /// Gets or sets start address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.start_address")]
        public string StartAddress { get; set; }

        /// <summary>
        /// Gets or sets current thread priority.
        /// </summary>
        [JsonProperty(PropertyName = "properties.current_priority")]
        public int? CurrentPriority { get; set; }

        /// <summary>
        /// Gets or sets thread priority level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority_level")]
        public string PriorityLevel { get; set; }

        /// <summary>
        /// Gets or sets base priority.
        /// </summary>
        [JsonProperty(PropertyName = "properties.base_priority")]
        public int? BasePriority { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.start_time")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets total processor time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.total_processor_time")]
        public string TotalProcessorTime { get; set; }

        /// <summary>
        /// Gets or sets user processor time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.user_processor_time")]
        public string UserProcessorTime { get; set; }

        /// <summary>
        /// Gets or sets thread state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets wait reason.
        /// </summary>
        [JsonProperty(PropertyName = "properties.wait_reason")]
        public string WaitReason { get; set; }

    }
}
