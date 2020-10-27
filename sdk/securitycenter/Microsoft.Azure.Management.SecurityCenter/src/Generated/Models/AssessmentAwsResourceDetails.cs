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
    /// Details of the Aws resource that was assessed
    /// </summary>
    [Newtonsoft.Json.JsonObject("Aws")]
    public partial class AssessmentAwsResourceDetails : AssessmentResourceDetails
    {
        /// <summary>
        /// Initializes a new instance of the AssessmentAwsResourceDetails
        /// class.
        /// </summary>
        public AssessmentAwsResourceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssessmentAwsResourceDetails
        /// class.
        /// </summary>
        /// <param name="accountId">AWS account Id of the assessed
        /// resource</param>
        /// <param name="awsResourceId">AWS resource Id. can be ARN or
        /// other</param>
        /// <param name="region">The region of the resource in AWS</param>
        public AssessmentAwsResourceDetails(string accountId, string awsResourceId, string region)
        {
            AccountId = accountId;
            AwsResourceId = awsResourceId;
            Region = region;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets AWS account Id of the assessed resource
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets AWS resource Id. can be ARN or other
        /// </summary>
        [JsonProperty(PropertyName = "awsResourceId")]
        public string AwsResourceId { get; private set; }

        /// <summary>
        /// Gets the region of the resource in AWS
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; private set; }

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
