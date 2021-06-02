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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Worker App container scaling rule.
    /// </summary>
    public partial class WorkerAppScaleRule
    {
        /// <summary>
        /// Initializes a new instance of the WorkerAppScaleRule class.
        /// </summary>
        public WorkerAppScaleRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkerAppScaleRule class.
        /// </summary>
        /// <param name="name">Scale Rule Name</param>
        /// <param name="azureQueue">Azure Queue based scaling.</param>
        /// <param name="custom">Custom scale rule.</param>
        /// <param name="http">HTTP requests based scaling.</param>
        public WorkerAppScaleRule(string name = default(string), WorkerAppQueueScaleRule azureQueue = default(WorkerAppQueueScaleRule), WorkerAppCustomScaleRule custom = default(WorkerAppCustomScaleRule), WorkerAppHttpScaleRule http = default(WorkerAppHttpScaleRule))
        {
            Name = name;
            AzureQueue = azureQueue;
            Custom = custom;
            Http = http;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scale Rule Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets azure Queue based scaling.
        /// </summary>
        [JsonProperty(PropertyName = "azureQueue")]
        public WorkerAppQueueScaleRule AzureQueue { get; set; }

        /// <summary>
        /// Gets or sets custom scale rule.
        /// </summary>
        [JsonProperty(PropertyName = "custom")]
        public WorkerAppCustomScaleRule Custom { get; set; }

        /// <summary>
        /// Gets or sets HTTP requests based scaling.
        /// </summary>
        [JsonProperty(PropertyName = "http")]
        public WorkerAppHttpScaleRule Http { get; set; }

    }
}
