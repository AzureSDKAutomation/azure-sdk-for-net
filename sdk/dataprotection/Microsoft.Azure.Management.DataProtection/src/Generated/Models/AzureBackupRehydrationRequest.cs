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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AzureBackupRehydrationRequest
    /// </summary>
    /// <remarks>
    /// Azure Backup Rehydrate Request
    /// </remarks>
    public partial class AzureBackupRehydrationRequest
    {
        /// <summary>
        /// Initializes a new instance of the AzureBackupRehydrationRequest
        /// class.
        /// </summary>
        public AzureBackupRehydrationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBackupRehydrationRequest
        /// class.
        /// </summary>
        /// <param name="recoveryPointId">Id of the recovery point to be
        /// recovered</param>
        /// <param name="rehydrationRetentionDuration">Retention duration in
        /// ISO 8601 format i.e P10D .</param>
        /// <param name="rehydrationPriority">Priority to be used for
        /// rehydration. Values High or Standard. Possible values include:
        /// 'Invalid', 'High', 'Standard'</param>
        public AzureBackupRehydrationRequest(string recoveryPointId, string rehydrationRetentionDuration, string rehydrationPriority = default(string))
        {
            RecoveryPointId = recoveryPointId;
            RehydrationPriority = rehydrationPriority;
            RehydrationRetentionDuration = rehydrationRetentionDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the recovery point to be recovered
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets priority to be used for rehydration. Values High or
        /// Standard. Possible values include: 'Invalid', 'High', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "rehydrationPriority")]
        public string RehydrationPriority { get; set; }

        /// <summary>
        /// Gets or sets retention duration in ISO 8601 format i.e P10D .
        /// </summary>
        [JsonProperty(PropertyName = "rehydrationRetentionDuration")]
        public string RehydrationRetentionDuration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecoveryPointId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecoveryPointId");
            }
            if (RehydrationRetentionDuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RehydrationRetentionDuration");
            }
        }
    }
}
