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
    /// InnerError
    /// </summary>
    /// <remarks>
    /// Inner Error
    /// </remarks>
    public partial class InnerError
    {
        /// <summary>
        /// Initializes a new instance of the InnerError class.
        /// </summary>
        public InnerError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InnerError class.
        /// </summary>
        /// <param name="additionalInfo">Any Key value pairs that can be
        /// provided to the cleint for additional  verbose information.</param>
        /// <param name="code">Unique code for this error</param>
        /// <param name="embeddedInnerError">Child Inner Error, to allow
        /// Nesting.</param>
        public InnerError(IDictionary<string, string> additionalInfo = default(IDictionary<string, string>), string code = default(string), InnerError embeddedInnerError = default(InnerError))
        {
            AdditionalInfo = additionalInfo;
            Code = code;
            EmbeddedInnerError = embeddedInnerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets any Key value pairs that can be provided to the cleint
        /// for additional  verbose information.
        /// </summary>
        [JsonProperty(PropertyName = "additionalInfo")]
        public IDictionary<string, string> AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or sets unique code for this error
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets child Inner Error, to allow Nesting.
        /// </summary>
        [JsonProperty(PropertyName = "embeddedInnerError")]
        public InnerError EmbeddedInnerError { get; set; }

    }
}
