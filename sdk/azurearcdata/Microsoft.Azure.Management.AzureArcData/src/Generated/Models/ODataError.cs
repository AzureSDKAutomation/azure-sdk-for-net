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
    /// Information about an error.
    /// </summary>
    public partial class ODataError
    {
        /// <summary>
        /// Initializes a new instance of the ODataError class.
        /// </summary>
        public ODataError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataError class.
        /// </summary>
        /// <param name="code">A language-independent error name.</param>
        /// <param name="message">The error message.</param>
        /// <param name="target">The target of the error (for example, the name
        /// of the property in error).</param>
        /// <param name="details">The error details.</param>
        public ODataError(string code = default(string), string message = default(string), string target = default(string), IList<ODataError> details = default(IList<ODataError>))
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
        /// Gets or sets a language-independent error name.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the target of the error (for example, the name of the
        /// property in error).
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ODataError> Details { get; set; }

    }
}
