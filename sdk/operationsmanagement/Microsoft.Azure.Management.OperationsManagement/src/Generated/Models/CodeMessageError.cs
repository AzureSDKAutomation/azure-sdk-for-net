// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationsManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The error body contract.
    /// </summary>
    public partial class CodeMessageError
    {
        /// <summary>
        /// Initializes a new instance of the CodeMessageError class.
        /// </summary>
        public CodeMessageError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CodeMessageError class.
        /// </summary>
        /// <param name="error">The error details for a failed request.</param>
        public CodeMessageError(CodeMessageErrorError error = default(CodeMessageErrorError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error details for a failed request.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public CodeMessageErrorError Error { get; set; }

    }
}
