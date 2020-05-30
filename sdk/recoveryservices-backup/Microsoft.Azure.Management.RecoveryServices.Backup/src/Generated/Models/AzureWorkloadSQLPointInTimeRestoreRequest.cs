// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AzureWorkload SQL -specific restore. Specifically for PointInTime/Log
    /// restore
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureWorkloadSQLPointInTimeRestoreRequest")]
    public partial class AzureWorkloadSQLPointInTimeRestoreRequest : AzureWorkloadSQLRestoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSQLPointInTimeRestoreRequest class.
        /// </summary>
        public AzureWorkloadSQLPointInTimeRestoreRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSQLPointInTimeRestoreRequest class.
        /// </summary>
        /// <param name="recoveryType">Type of this recovery. Possible values
        /// include: 'Invalid', 'OriginalLocation', 'AlternateLocation',
        /// 'RestoreDisks', 'Offline'</param>
        /// <param name="sourceResourceId">Fully qualified ARM ID of the VM on
        /// which workload that was running is being recovered.</param>
        /// <param name="propertyBag">Workload specific property bag.</param>
        /// <param name="targetInfo">Details of target database</param>
        /// <param name="recoveryMode">Defines whether the current recovery
        /// mode is file restore or database restore. Possible values include:
        /// 'Invalid', 'FileRecovery', 'WorkloadRecovery'</param>
        /// <param name="shouldUseAlternateTargetLocation">Default option set
        /// to true. If this is set to false, alternate data directory must be
        /// provided</param>
        /// <param name="isNonRecoverable">SQL specific property where user can
        /// chose to set no-recovery when restore operation is tried</param>
        /// <param name="alternateDirectoryPaths">Data directory
        /// details</param>
        /// <param name="pointInTime">PointInTime value</param>
        public AzureWorkloadSQLPointInTimeRestoreRequest(string recoveryType = default(string), string sourceResourceId = default(string), IDictionary<string, string> propertyBag = default(IDictionary<string, string>), TargetRestoreInfo targetInfo = default(TargetRestoreInfo), string recoveryMode = default(string), bool? shouldUseAlternateTargetLocation = default(bool?), bool? isNonRecoverable = default(bool?), IList<SQLDataDirectoryMapping> alternateDirectoryPaths = default(IList<SQLDataDirectoryMapping>), System.DateTime? pointInTime = default(System.DateTime?))
            : base(recoveryType, sourceResourceId, propertyBag, targetInfo, recoveryMode, shouldUseAlternateTargetLocation, isNonRecoverable, alternateDirectoryPaths)
        {
            PointInTime = pointInTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pointInTime value
        /// </summary>
        [JsonProperty(PropertyName = "pointInTime")]
        public System.DateTime? PointInTime { get; set; }

    }
}
