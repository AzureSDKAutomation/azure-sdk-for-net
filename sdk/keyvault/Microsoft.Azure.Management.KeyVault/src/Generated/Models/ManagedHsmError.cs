// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The error exception.
    /// </summary>
    public partial class ManagedHsmError
    {
        /// <summary>
        /// Initializes a new instance of the ManagedHsmError class.
        /// </summary>
        public ManagedHsmError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedHsmError class.
        /// </summary>
        /// <param name="error">The server error.</param>
        public ManagedHsmError(Error error = default(Error))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the server error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; private set; }

    }
}
