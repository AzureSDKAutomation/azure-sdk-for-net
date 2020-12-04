// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters of a managed instance operation.
    /// </summary>
    public partial class ManagedInstanceOperationParametersPair
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceOperationParametersPair class.
        /// </summary>
        public ManagedInstanceOperationParametersPair()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceOperationParametersPair class.
        /// </summary>
        /// <param name="currentParameters">The current parameters.</param>
        /// <param name="requestedParameters">The requested parameters.</param>
        public ManagedInstanceOperationParametersPair(UpsertManagedServerOperationParameters currentParameters = default(UpsertManagedServerOperationParameters), UpsertManagedServerOperationParameters requestedParameters = default(UpsertManagedServerOperationParameters))
        {
            CurrentParameters = currentParameters;
            RequestedParameters = requestedParameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current parameters.
        /// </summary>
        [JsonProperty(PropertyName = "currentParameters")]
        public UpsertManagedServerOperationParameters CurrentParameters { get; private set; }

        /// <summary>
        /// Gets the requested parameters.
        /// </summary>
        [JsonProperty(PropertyName = "requestedParameters")]
        public UpsertManagedServerOperationParameters RequestedParameters { get; private set; }

    }
}
