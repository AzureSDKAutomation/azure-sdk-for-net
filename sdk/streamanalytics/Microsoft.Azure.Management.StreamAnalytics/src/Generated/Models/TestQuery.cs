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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The request object for query testing.
    /// </summary>
    public partial class TestQuery
    {
        /// <summary>
        /// Initializes a new instance of the TestQuery class.
        /// </summary>
        public TestQuery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestQuery class.
        /// </summary>
        /// <param name="streamingJob">Stream analytics job object which
        /// defines the input, output, and transformation for the query
        /// testing.</param>
        /// <param name="diagnostics">Diagnostics information related to query
        /// testing.</param>
        public TestQuery(StreamingJob streamingJob, TestQueryDiagnostics diagnostics = default(TestQueryDiagnostics))
        {
            Diagnostics = diagnostics;
            StreamingJob = streamingJob;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets diagnostics information related to query testing.
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public TestQueryDiagnostics Diagnostics { get; set; }

        /// <summary>
        /// Gets or sets stream analytics job object which defines the input,
        /// output, and transformation for the query testing.
        /// </summary>
        [JsonProperty(PropertyName = "streamingJob")]
        public StreamingJob StreamingJob { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StreamingJob == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StreamingJob");
            }
            if (Diagnostics != null)
            {
                Diagnostics.Validate();
            }
        }
    }
}
