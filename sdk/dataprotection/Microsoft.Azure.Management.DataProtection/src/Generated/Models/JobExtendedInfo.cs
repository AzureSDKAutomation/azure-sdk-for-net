// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extended Information about the job
    /// </summary>
    public partial class JobExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the JobExtendedInfo class.
        /// </summary>
        public JobExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobExtendedInfo class.
        /// </summary>
        /// <param name="additionalDetails">Job's Additional Details</param>
        /// <param name="backupInstanceState">State of the Backup
        /// Instance</param>
        /// <param name="dataTransferedInBytes">Number of bytes
        /// transfered</param>
        /// <param name="recoveryDestination">Destination where restore is
        /// done</param>
        /// <param name="sourceRecoverPoint">Details of the Source Recovery
        /// Point</param>
        /// <param name="subTasks">List of Sub Tasks of the job</param>
        /// <param name="targetRecoverPoint">Details of the Target Recovery
        /// Point</param>
        public JobExtendedInfo(IDictionary<string, string> additionalDetails = default(IDictionary<string, string>), string backupInstanceState = default(string), double? dataTransferedInBytes = default(double?), string recoveryDestination = default(string), RestoreJobRecoveryPointDetails sourceRecoverPoint = default(RestoreJobRecoveryPointDetails), IList<JobSubTask> subTasks = default(IList<JobSubTask>), RestoreJobRecoveryPointDetails targetRecoverPoint = default(RestoreJobRecoveryPointDetails))
        {
            AdditionalDetails = additionalDetails;
            BackupInstanceState = backupInstanceState;
            DataTransferedInBytes = dataTransferedInBytes;
            RecoveryDestination = recoveryDestination;
            SourceRecoverPoint = sourceRecoverPoint;
            SubTasks = subTasks;
            TargetRecoverPoint = targetRecoverPoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets job's Additional Details
        /// </summary>
        [JsonProperty(PropertyName = "additionalDetails")]
        public IDictionary<string, string> AdditionalDetails { get; set; }

        /// <summary>
        /// Gets state of the Backup Instance
        /// </summary>
        [JsonProperty(PropertyName = "backupInstanceState")]
        public string BackupInstanceState { get; private set; }

        /// <summary>
        /// Gets number of bytes transfered
        /// </summary>
        [JsonProperty(PropertyName = "dataTransferedInBytes")]
        public double? DataTransferedInBytes { get; private set; }

        /// <summary>
        /// Gets destination where restore is done
        /// </summary>
        [JsonProperty(PropertyName = "recoveryDestination")]
        public string RecoveryDestination { get; private set; }

        /// <summary>
        /// Gets details of the Source Recovery Point
        /// </summary>
        [JsonProperty(PropertyName = "sourceRecoverPoint")]
        public RestoreJobRecoveryPointDetails SourceRecoverPoint { get; private set; }

        /// <summary>
        /// Gets list of Sub Tasks of the job
        /// </summary>
        [JsonProperty(PropertyName = "subTasks")]
        public IList<JobSubTask> SubTasks { get; private set; }

        /// <summary>
        /// Gets details of the Target Recovery Point
        /// </summary>
        [JsonProperty(PropertyName = "targetRecoverPoint")]
        public RestoreJobRecoveryPointDetails TargetRecoverPoint { get; private set; }

    }
}
