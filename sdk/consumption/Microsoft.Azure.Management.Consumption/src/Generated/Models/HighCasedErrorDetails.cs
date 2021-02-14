// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The details of the error.
    /// </summary>
    public partial class HighCasedErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the HighCasedErrorDetails class.
        /// </summary>
        public HighCasedErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HighCasedErrorDetails class.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <param name="message">Error message indicating why the operation
        /// failed.</param>
        public HighCasedErrorDetails(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error code.
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets error message indicating why the operation failed.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; private set; }

    }
}
