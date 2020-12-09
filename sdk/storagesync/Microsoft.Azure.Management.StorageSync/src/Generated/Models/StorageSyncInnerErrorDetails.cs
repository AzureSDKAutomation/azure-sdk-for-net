// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error Details object.
    /// </summary>
    public partial class StorageSyncInnerErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the StorageSyncInnerErrorDetails
        /// class.
        /// </summary>
        public StorageSyncInnerErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageSyncInnerErrorDetails
        /// class.
        /// </summary>
        /// <param name="callStack">Call stack of the error.</param>
        /// <param name="message">Error message of the error.</param>
        /// <param name="innerException">Exception of the inner error.</param>
        /// <param name="innerExceptionCallStack">Call stack of the inner
        /// error.</param>
        public StorageSyncInnerErrorDetails(string callStack = default(string), string message = default(string), string innerException = default(string), string innerExceptionCallStack = default(string))
        {
            CallStack = callStack;
            Message = message;
            InnerException = innerException;
            InnerExceptionCallStack = innerExceptionCallStack;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets call stack of the error.
        /// </summary>
        [JsonProperty(PropertyName = "callStack")]
        public string CallStack { get; set; }

        /// <summary>
        /// Gets or sets error message of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets exception of the inner error.
        /// </summary>
        [JsonProperty(PropertyName = "innerException")]
        public string InnerException { get; set; }

        /// <summary>
        /// Gets or sets call stack of the inner error.
        /// </summary>
        [JsonProperty(PropertyName = "innerExceptionCallStack")]
        public string InnerExceptionCallStack { get; set; }

    }
}
