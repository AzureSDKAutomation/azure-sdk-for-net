// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result of the query compilation request.
    /// </summary>
    public partial class QueryCompilationResult
    {
        /// <summary>
        /// Initializes a new instance of the QueryCompilationResult class.
        /// </summary>
        public QueryCompilationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryCompilationResult class.
        /// </summary>
        /// <param name="errors">Error messages produced by the
        /// compiler.</param>
        /// <param name="warnings">Warning messages produced by the
        /// compiler.</param>
        /// <param name="inputs">All input names used by the query.</param>
        /// <param name="outputs">All output names used by the query.</param>
        /// <param name="functions">All function names used by the
        /// query.</param>
        public QueryCompilationResult(IList<QueryCompilationError> errors = default(IList<QueryCompilationError>), IList<string> warnings = default(IList<string>), IList<string> inputs = default(IList<string>), IList<string> outputs = default(IList<string>), IList<string> functions = default(IList<string>))
        {
            Errors = errors;
            Warnings = warnings;
            Inputs = inputs;
            Outputs = outputs;
            Functions = functions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error messages produced by the compiler.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<QueryCompilationError> Errors { get; private set; }

        /// <summary>
        /// Gets warning messages produced by the compiler.
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public IList<string> Warnings { get; private set; }

        /// <summary>
        /// Gets all input names used by the query.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<string> Inputs { get; private set; }

        /// <summary>
        /// Gets all output names used by the query.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public IList<string> Outputs { get; private set; }

        /// <summary>
        /// Gets all function names used by the query.
        /// </summary>
        [JsonProperty(PropertyName = "functions")]
        public IList<string> Functions { get; private set; }

    }
}
