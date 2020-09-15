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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response for long running operation
    /// </summary>
    public partial class OperationResponse
    {
        /// <summary>
        /// Initializes a new instance of the OperationResponse class.
        /// </summary>
        public OperationResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationResponse class.
        /// </summary>
        /// <param name="status">Operation state of the long running operation.
        /// Possible values include: 'Accepted', 'InProgress',
        /// 'TransientFailure', 'Succeeded', 'Failed', 'Canceled'</param>
        /// <param name="endTime">start time</param>
        /// <param name="error">The error property when status is
        /// failed.</param>
        /// <param name="startTime">start time</param>
        public OperationResponse(string status, System.DateTime? endTime = default(System.DateTime?), DataCollaborationErrorInfo error = default(DataCollaborationErrorInfo), System.DateTime? startTime = default(System.DateTime?))
        {
            EndTime = endTime;
            Error = error;
            StartTime = startTime;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start time
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the error property when status is failed.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public DataCollaborationErrorInfo Error { get; set; }

        /// <summary>
        /// Gets or sets start time
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets operation state of the long running operation.
        /// Possible values include: 'Accepted', 'InProgress',
        /// 'TransientFailure', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Error != null)
            {
                Error.Validate();
            }
        }
    }
}
