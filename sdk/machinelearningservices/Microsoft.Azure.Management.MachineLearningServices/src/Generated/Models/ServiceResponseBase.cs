// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The base service response. The correct inherited response based on
    /// computeType will be returned (ex. ACIServiceResponse)
    /// </summary>
    public partial class ServiceResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the ServiceResponseBase class.
        /// </summary>
        public ServiceResponseBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceResponseBase class.
        /// </summary>
        /// <param name="description">The service description.</param>
        /// <param name="kvTags">The service tag dictionary. Tags are
        /// mutable.</param>
        /// <param name="properties">The service property dictionary.
        /// Properties are immutable.</param>
        /// <param name="state">The current state of the service. Possible
        /// values include: 'Transitioning', 'Healthy', 'Unhealthy', 'Failed',
        /// 'Unschedulable'</param>
        /// <param name="error">The error details.</param>
        /// <param name="deploymentType">The deployment type for the service.
        /// Possible values include: 'GRPCRealtimeEndpoint',
        /// 'HttpRealtimeEndpoint', 'Batch'</param>
        public ServiceResponseBase(string description = default(string), IDictionary<string, string> kvTags = default(IDictionary<string, string>), IDictionary<string, string> properties = default(IDictionary<string, string>), string state = default(string), ServiceResponseBaseError error = default(ServiceResponseBaseError), string deploymentType = default(string))
        {
            Description = description;
            KvTags = kvTags;
            Properties = properties;
            State = state;
            Error = error;
            DeploymentType = deploymentType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the service description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the service tag dictionary. Tags are mutable.
        /// </summary>
        [JsonProperty(PropertyName = "kvTags")]
        public IDictionary<string, string> KvTags { get; set; }

        /// <summary>
        /// Gets or sets the service property dictionary. Properties are
        /// immutable.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets the current state of the service. Possible values include:
        /// 'Transitioning', 'Healthy', 'Unhealthy', 'Failed', 'Unschedulable'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ServiceResponseBaseError Error { get; private set; }

        /// <summary>
        /// Gets or sets the deployment type for the service. Possible values
        /// include: 'GRPCRealtimeEndpoint', 'HttpRealtimeEndpoint', 'Batch'
        /// </summary>
        [JsonProperty(PropertyName = "deploymentType")]
        public string DeploymentType { get; set; }

    }
}
