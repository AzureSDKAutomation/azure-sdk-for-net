// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Generic object modeling results of script execution.
    /// </summary>
    public partial class ScriptStatus
    {
        /// <summary>
        /// Initializes a new instance of the ScriptStatus class.
        /// </summary>
        public ScriptStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptStatus class.
        /// </summary>
        /// <param name="containerInstanceId">ACI resource Id.</param>
        /// <param name="storageAccountId">Storage account resource Id.</param>
        /// <param name="startTime">Start time of the script execution.</param>
        /// <param name="endTime">End time of the script execution.</param>
        /// <param name="expirationTime">Time the deployment script resource
        /// will expire.</param>
        /// <param name="error">Error that is relayed from the script
        /// execution.</param>
        public ScriptStatus(string containerInstanceId = default(string), string storageAccountId = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), System.DateTime? expirationTime = default(System.DateTime?), ErrorResponse error = default(ErrorResponse))
        {
            ContainerInstanceId = containerInstanceId;
            StorageAccountId = storageAccountId;
            StartTime = startTime;
            EndTime = endTime;
            ExpirationTime = expirationTime;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ACI resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "containerInstanceId")]
        public string ContainerInstanceId { get; private set; }

        /// <summary>
        /// Gets storage account resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; private set; }

        /// <summary>
        /// Gets start time of the script execution.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets end time of the script execution.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets time the deployment script resource will expire.
        /// </summary>
        [JsonProperty(PropertyName = "expirationTime")]
        public System.DateTime? ExpirationTime { get; private set; }

        /// <summary>
        /// Gets or sets error that is relayed from the script execution.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

    }
}
