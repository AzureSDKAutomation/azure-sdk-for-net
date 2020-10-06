// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Logger update contract.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LoggerUpdateContract
    {
        /// <summary>
        /// Initializes a new instance of the LoggerUpdateContract class.
        /// </summary>
        public LoggerUpdateContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoggerUpdateContract class.
        /// </summary>
        /// <param name="loggerType">Logger type. Possible values include:
        /// 'azureEventHub', 'applicationInsights', 'azureMonitor'</param>
        /// <param name="description">Logger description.</param>
        /// <param name="credentials">Logger credentials.</param>
        /// <param name="isBuffered">Whether records are buffered in the logger
        /// before publishing. Default is assumed to be true.</param>
        public LoggerUpdateContract(string loggerType = default(string), string description = default(string), IDictionary<string, string> credentials = default(IDictionary<string, string>), bool? isBuffered = default(bool?))
        {
            LoggerType = loggerType;
            Description = description;
            Credentials = credentials;
            IsBuffered = isBuffered;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets logger type. Possible values include: 'azureEventHub',
        /// 'applicationInsights', 'azureMonitor'
        /// </summary>
        [JsonProperty(PropertyName = "properties.loggerType")]
        public string LoggerType { get; set; }

        /// <summary>
        /// Gets or sets logger description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets logger credentials.
        /// </summary>
        [JsonProperty(PropertyName = "properties.credentials")]
        public IDictionary<string, string> Credentials { get; set; }

        /// <summary>
        /// Gets or sets whether records are buffered in the logger before
        /// publishing. Default is assumed to be true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isBuffered")]
        public bool? IsBuffered { get; set; }

    }
}
