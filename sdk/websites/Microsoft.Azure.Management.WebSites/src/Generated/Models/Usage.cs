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
    /// Usage of the quota resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Usage : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">Friendly name shown in the UI.</param>
        /// <param name="resourceName">Name of the quota resource.</param>
        /// <param name="unit">Units of measurement for the quota
        /// resource.</param>
        /// <param name="currentValue">The current value of the resource
        /// counter.</param>
        /// <param name="limit">The resource limit.</param>
        /// <param name="nextResetTime">Next reset time for the resource
        /// counter.</param>
        /// <param name="computeMode">Compute mode used for this usage.
        /// Possible values include: 'Shared', 'Dedicated', 'Dynamic'</param>
        /// <param name="siteMode">Site mode used for this usage.</param>
        public Usage(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string displayName = default(string), string resourceName = default(string), string unit = default(string), long? currentValue = default(long?), long? limit = default(long?), System.DateTime? nextResetTime = default(System.DateTime?), ComputeModeOptions? computeMode = default(ComputeModeOptions?), string siteMode = default(string))
            : base(id, name, kind, type, systemData)
        {
            DisplayName = displayName;
            ResourceName = resourceName;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetTime = nextResetTime;
            ComputeMode = computeMode;
            SiteMode = siteMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets friendly name shown in the UI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets name of the quota resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceName")]
        public string ResourceName { get; private set; }

        /// <summary>
        /// Gets units of measurement for the quota resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the current value of the resource counter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentValue")]
        public long? CurrentValue { get; private set; }

        /// <summary>
        /// Gets the resource limit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.limit")]
        public long? Limit { get; private set; }

        /// <summary>
        /// Gets next reset time for the resource counter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextResetTime")]
        public System.DateTime? NextResetTime { get; private set; }

        /// <summary>
        /// Gets compute mode used for this usage. Possible values include:
        /// 'Shared', 'Dedicated', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.computeMode")]
        public ComputeModeOptions? ComputeMode { get; private set; }

        /// <summary>
        /// Gets site mode used for this usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.siteMode")]
        public string SiteMode { get; private set; }

    }
}
