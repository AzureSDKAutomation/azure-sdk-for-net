// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the Gcp resource that was assessed
    /// </summary>
    [Newtonsoft.Json.JsonObject("Gcp")]
    public partial class AssessmentGcpResourceDetails : AssessmentResourceDetails
    {
        /// <summary>
        /// Initializes a new instance of the AssessmentGcpResourceDetails
        /// class.
        /// </summary>
        public AssessmentGcpResourceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssessmentGcpResourceDetails
        /// class.
        /// </summary>
        /// <param name="projectId">Gcp project Id</param>
        /// <param name="gcpResourceId">Gcp resource Id</param>
        public AssessmentGcpResourceDetails(string projectId, string gcpResourceId)
        {
            ProjectId = projectId;
            GcpResourceId = gcpResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets gcp project Id
        /// </summary>
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; private set; }

        /// <summary>
        /// Gets gcp resource Id
        /// </summary>
        [JsonProperty(PropertyName = "gcpResourceId")]
        public string GcpResourceId { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
