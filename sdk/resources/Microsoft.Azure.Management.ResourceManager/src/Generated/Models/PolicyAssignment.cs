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
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The policy assignment.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PolicyAssignment : IResource
    {
        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        public PolicyAssignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        /// <param name="displayName">The display name of the policy
        /// assignment.</param>
        /// <param name="policyDefinitionId">The ID of the policy definition or
        /// policy set definition being assigned.</param>
        /// <param name="scope">The scope for the policy assignment.</param>
        /// <param name="notScopes">The policy's excluded scopes.</param>
        /// <param name="parameters">The parameter values for the assigned
        /// policy rule. The keys are the parameter names.</param>
        /// <param name="description">This message will be part of response in
        /// case of policy violation.</param>
        /// <param name="metadata">The policy assignment metadata. Metadata is
        /// an open ended object and is typically a collection of key value
        /// pairs.</param>
        /// <param name="enforcementMode">The policy assignment enforcement
        /// mode. Possible values are Default and DoNotEnforce. Possible values
        /// include: 'Default', 'DoNotEnforce'</param>
        /// <param name="nonComplianceMessages">The messages that describe why
        /// a resource is non-compliant with the policy.</param>
        /// <param name="id">The ID of the policy assignment.</param>
        /// <param name="type">The type of the policy assignment.</param>
        /// <param name="name">The name of the policy assignment.</param>
        /// <param name="location">The location of the policy assignment. Only
        /// required when utilizing managed identity.</param>
        /// <param name="identity">The managed identity associated with the
        /// policy assignment.</param>
        public PolicyAssignment(string displayName = default(string), string policyDefinitionId = default(string), string scope = default(string), IList<string> notScopes = default(IList<string>), IDictionary<string, ParameterValuesValue> parameters = default(IDictionary<string, ParameterValuesValue>), string description = default(string), object metadata = default(object), string enforcementMode = default(string), IList<NonComplianceMessage> nonComplianceMessages = default(IList<NonComplianceMessage>), string id = default(string), string type = default(string), string name = default(string), string location = default(string), Identity identity = default(Identity))
        {
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Scope = scope;
            NotScopes = notScopes;
            Parameters = parameters;
            Description = description;
            Metadata = metadata;
            EnforcementMode = enforcementMode;
            NonComplianceMessages = nonComplianceMessages;
            Id = id;
            Type = type;
            Name = name;
            Location = location;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the policy definition or policy set
        /// definition being assigned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyDefinitionId")]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// Gets the scope for the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; private set; }

        /// <summary>
        /// Gets or sets the policy's excluded scopes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notScopes")]
        public IList<string> NotScopes { get; set; }

        /// <summary>
        /// Gets or sets the parameter values for the assigned policy rule. The
        /// keys are the parameter names.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, ParameterValuesValue> Parameters { get; set; }

        /// <summary>
        /// Gets or sets this message will be part of response in case of
        /// policy violation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the policy assignment metadata. Metadata is an open
        /// ended object and is typically a collection of key value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Gets or sets the policy assignment enforcement mode. Possible
        /// values are Default and DoNotEnforce. Possible values include:
        /// 'Default', 'DoNotEnforce'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enforcementMode")]
        public string EnforcementMode { get; set; }

        /// <summary>
        /// Gets or sets the messages that describe why a resource is
        /// non-compliant with the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nonComplianceMessages")]
        public IList<NonComplianceMessage> NonComplianceMessages { get; set; }

        /// <summary>
        /// Gets the ID of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the name of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the location of the policy assignment. Only required
        /// when utilizing managed identity.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the managed identity associated with the policy
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

    }
}
