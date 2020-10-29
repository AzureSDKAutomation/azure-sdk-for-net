// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridCompute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Error details.
    /// </summary>
    public partial class ErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        public ErrorDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        /// <param name="code">The error's code.</param>
        /// <param name="message">A human readable error message.</param>
        /// <param name="target">Indicates which property in the request is
        /// responsible for the error.</param>
        /// <param name="details">Additional error details.</param>
        public ErrorDetail(string code, string message, string target = default(string), IList<ErrorDetail> details = default(IList<ErrorDetail>))
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
        /// Gets or sets the error's code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a human readable error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets indicates which property in the request is responsible
        /// for the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets additional error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorDetail> Details { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Details != null)
            {
                foreach (var element in Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
