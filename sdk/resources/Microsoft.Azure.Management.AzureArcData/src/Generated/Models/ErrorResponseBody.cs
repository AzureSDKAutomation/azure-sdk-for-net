// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error response from the Batch service.
    /// </summary>
    public partial class ErrorResponseBody
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponseBody class.
        /// </summary>
        public ErrorResponseBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseBody class.
        /// </summary>
        /// <param name="code">An identifier for the error. Codes are invariant
        /// and are intended to be consumed programmatically.</param>
        /// <param name="message">A message describing the error, intended to
        /// be suitable for display in a user interface.</param>
        /// <param name="target">The target of the particular error. For
        /// example, the name of the property in error.</param>
        /// <param name="details">A list of additional details about the
        /// error.</param>
        public ErrorResponseBody(string code = default(string), string message = default(string), string target = default(string), IList<ErrorResponseBody> details = default(IList<ErrorResponseBody>))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an identifier for the error. Codes are invariant and
        /// are intended to be consumed programmatically.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the error, intended to be
        /// suitable for display in a user interface.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the target of the particular error. For example, the
        /// name of the property in error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets a list of additional details about the error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorResponseBody> Details { get; set; }

    }
}
