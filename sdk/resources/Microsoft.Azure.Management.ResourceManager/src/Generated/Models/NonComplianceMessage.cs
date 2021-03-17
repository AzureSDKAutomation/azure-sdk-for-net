// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A message that describes why a resource is non-compliant with the
    /// policy. This is shown in 'deny' error messages and on resource's
    /// non-compliant compliance results.
    /// </summary>
    public partial class NonComplianceMessage
    {
        /// <summary>
        /// Initializes a new instance of the NonComplianceMessage class.
        /// </summary>
        public NonComplianceMessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NonComplianceMessage class.
        /// </summary>
        /// <param name="message">A message that describes why a resource is
        /// non-compliant with the policy. This is shown in 'deny' error
        /// messages and on resource's non-compliant compliance
        /// results.</param>
        /// <param name="policyDefinitionReferenceId">The policy definition
        /// reference ID within a policy set definition the message is intended
        /// for. This is only applicable if the policy assignment assigns a
        /// policy set definition. If this is not provided the message applies
        /// to all policies assigned by this policy assignment.</param>
        public NonComplianceMessage(string message, string policyDefinitionReferenceId = default(string))
        {
            Message = message;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a message that describes why a resource is
        /// non-compliant with the policy. This is shown in 'deny' error
        /// messages and on resource's non-compliant compliance results.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the policy definition reference ID within a policy set
        /// definition the message is intended for. This is only applicable if
        /// the policy assignment assigns a policy set definition. If this is
        /// not provided the message applies to all policies assigned by this
        /// policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "policyDefinitionReferenceId")]
        public string PolicyDefinitionReferenceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
