// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The error object
    /// </summary>
    public partial class ErrorObject
    {
        /// <summary>
        /// Initializes a new instance of the ErrorObject class.
        /// </summary>
        public ErrorObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorObject class.
        /// </summary>
        /// <param name="code">Error code</param>
        /// <param name="message">Error message indicating why the operation
        /// failed.</param>
        /// <param name="subCode">The error sub code</param>
        /// <param name="httpStatusCode">The http status code</param>
        /// <param name="timeStamp">the timestamp for the error.</param>
        /// <param name="details">The error details.</param>
        public ErrorObject(string code = default(string), string message = default(string), int? subCode = default(int?), int? httpStatusCode = default(int?), string timeStamp = default(string), IList<ErrorDetail> details = default(IList<ErrorDetail>))
        {
            Code = code;
            Message = message;
            SubCode = subCode;
            HttpStatusCode = httpStatusCode;
            TimeStamp = timeStamp;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message indicating why the operation failed.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the error sub code
        /// </summary>
        [JsonProperty(PropertyName = "subCode")]
        public int? SubCode { get; set; }

        /// <summary>
        /// Gets or sets the http status code
        /// </summary>
        [JsonProperty(PropertyName = "httpStatusCode")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Gets the timestamp for the error.
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public string TimeStamp { get; private set; }

        /// <summary>
        /// Gets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorDetail> Details { get; private set; }

    }
}
