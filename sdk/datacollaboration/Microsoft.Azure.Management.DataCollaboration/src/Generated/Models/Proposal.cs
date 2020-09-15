// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A proposal for data collaboration contract, can be shared and edited by
    /// multiple participants before signing.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Proposal : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the Proposal class.
        /// </summary>
        public Proposal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Proposal class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="contractStatus">Indicate if the contract is an
        /// editable Draft or a readonly Active contract. Possible values
        /// include: 'Draft', 'Active'</param>
        /// <param name="currentVersion">The proposal version, any change to
        /// the proposal or any of its underlying resources will result in a
        /// different value.</param>
        /// <param name="currentVersionTimestamp">Timestamp of the last time
        /// the proposal or any of its underlying resources were
        /// updated.</param>
        /// <param name="description">Textual description of the
        /// proposal</param>
        /// <param name="displayName">Display name of the proposal</param>
        /// <param name="invitationId">The invitation id for joining a
        /// proposal</param>
        /// <param name="invitationLocation">The invitation id for joining a
        /// proposal</param>
        /// <param name="provisioningState">Provisioning state of the proposal.
        /// Possible values include: 'Succeeded', 'Creating', 'Updating',
        /// 'Deleting', 'Moving', 'Failed'</param>
        /// <param name="terms">Terms of the proposal</param>
        /// <param name="systemData">SystemData Info of Workspace</param>
        public Proposal(string id = default(string), string name = default(string), string type = default(string), string contractStatus = default(string), string currentVersion = default(string), System.DateTime? currentVersionTimestamp = default(System.DateTime?), string description = default(string), string displayName = default(string), string invitationId = default(string), string invitationLocation = default(string), string provisioningState = default(string), string terms = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            ContractStatus = contractStatus;
            CurrentVersion = currentVersion;
            CurrentVersionTimestamp = currentVersionTimestamp;
            Description = description;
            DisplayName = displayName;
            InvitationId = invitationId;
            InvitationLocation = invitationLocation;
            ProvisioningState = provisioningState;
            Terms = terms;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets indicate if the contract is an editable Draft or a readonly
        /// Active contract. Possible values include: 'Draft', 'Active'
        /// </summary>
        [JsonProperty(PropertyName = "properties.contractStatus")]
        public string ContractStatus { get; private set; }

        /// <summary>
        /// Gets the proposal version, any change to the proposal or any of its
        /// underlying resources will result in a different value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentVersion")]
        public string CurrentVersion { get; private set; }

        /// <summary>
        /// Gets timestamp of the last time the proposal or any of its
        /// underlying resources were updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentVersionTimestamp")]
        public System.DateTime? CurrentVersionTimestamp { get; private set; }

        /// <summary>
        /// Gets or sets textual description of the proposal
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets display name of the proposal
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the invitation id for joining a proposal
        /// </summary>
        [JsonProperty(PropertyName = "properties.invitationId")]
        public string InvitationId { get; set; }

        /// <summary>
        /// Gets or sets the invitation id for joining a proposal
        /// </summary>
        [JsonProperty(PropertyName = "properties.invitationLocation")]
        public string InvitationLocation { get; set; }

        /// <summary>
        /// Gets provisioning state of the proposal. Possible values include:
        /// 'Succeeded', 'Creating', 'Updating', 'Deleting', 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets terms of the proposal
        /// </summary>
        [JsonProperty(PropertyName = "properties.terms")]
        public string Terms { get; set; }

        /// <summary>
        /// Gets or sets systemData Info of Workspace
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
