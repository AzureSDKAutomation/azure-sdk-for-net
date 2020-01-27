// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a case in Azure Security Insights.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CaseModel : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the CaseModel class.
        /// </summary>
        public CaseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CaseModel class.
        /// </summary>
        /// <param name="severity">The severity of the case. Possible values
        /// include: 'Critical', 'High', 'Medium', 'Low',
        /// 'Informational'</param>
        /// <param name="startTimeUtc">The start time of the case</param>
        /// <param name="status">The status of the case. Possible values
        /// include: 'Draft', 'New', 'InProgress', 'Closed'</param>
        /// <param name="title">The title of the case</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="caseNumber">a sequential number</param>
        /// <param name="closeReason">The reason the case was closed. Possible
        /// values include: 'Resolved', 'Dismissed', 'TruePositive',
        /// 'FalsePositive', 'Other'</param>
        /// <param name="closedReasonText">the case close reason
        /// details</param>
        /// <param name="createdTimeUtc">The time the case was created</param>
        /// <param name="description">The description of the case</param>
        /// <param name="endTimeUtc">The end time of the case</param>
        /// <param name="labels">List of labels relevant to this case</param>
        /// <param name="lastComment">the last comment in the case</param>
        /// <param name="lastUpdatedTimeUtc">The last time the case was
        /// updated</param>
        /// <param name="owner">Describes a user that the case is assigned
        /// to</param>
        /// <param name="relatedAlertIds">List of related alert
        /// identifiers</param>
        /// <param name="totalComments">the number of total comments in the
        /// case</param>
        public CaseModel(string severity, System.DateTime startTimeUtc, string status, string title, string id = default(string), string name = default(string), string type = default(string), string etag = default(string), int? caseNumber = default(int?), string closeReason = default(string), string closedReasonText = default(string), System.DateTime? createdTimeUtc = default(System.DateTime?), string description = default(string), System.DateTime? endTimeUtc = default(System.DateTime?), IList<string> labels = default(IList<string>), string lastComment = default(string), System.DateTime? lastUpdatedTimeUtc = default(System.DateTime?), UserInfo owner = default(UserInfo), IList<string> relatedAlertIds = default(IList<string>), int? totalComments = default(int?))
            : base(id, name, type, etag)
        {
            CaseNumber = caseNumber;
            CloseReason = closeReason;
            ClosedReasonText = closedReasonText;
            CreatedTimeUtc = createdTimeUtc;
            Description = description;
            EndTimeUtc = endTimeUtc;
            Labels = labels;
            LastComment = lastComment;
            LastUpdatedTimeUtc = lastUpdatedTimeUtc;
            Owner = owner;
            RelatedAlertIds = relatedAlertIds;
            Severity = severity;
            StartTimeUtc = startTimeUtc;
            Status = status;
            Title = title;
            TotalComments = totalComments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a sequential number
        /// </summary>
        [JsonProperty(PropertyName = "properties.caseNumber")]
        public int? CaseNumber { get; private set; }

        /// <summary>
        /// Gets or sets the reason the case was closed. Possible values
        /// include: 'Resolved', 'Dismissed', 'TruePositive', 'FalsePositive',
        /// 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "properties.closeReason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// Gets or sets the case close reason details
        /// </summary>
        [JsonProperty(PropertyName = "properties.closedReasonText")]
        public string ClosedReasonText { get; set; }

        /// <summary>
        /// Gets the time the case was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTimeUtc")]
        public System.DateTime? CreatedTimeUtc { get; private set; }

        /// <summary>
        /// Gets or sets the description of the case
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the end time of the case
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTimeUtc")]
        public System.DateTime? EndTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets list of labels relevant to this case
        /// </summary>
        [JsonProperty(PropertyName = "properties.labels")]
        public IList<string> Labels { get; set; }

        /// <summary>
        /// Gets the last comment in the case
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastComment")]
        public string LastComment { get; private set; }

        /// <summary>
        /// Gets the last time the case was updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTimeUtc")]
        public System.DateTime? LastUpdatedTimeUtc { get; private set; }

        /// <summary>
        /// Gets or sets describes a user that the case is assigned to
        /// </summary>
        [JsonProperty(PropertyName = "properties.owner")]
        public UserInfo Owner { get; set; }

        /// <summary>
        /// Gets list of related alert identifiers
        /// </summary>
        [JsonProperty(PropertyName = "properties.relatedAlertIds")]
        public IList<string> RelatedAlertIds { get; private set; }

        /// <summary>
        /// Gets or sets the severity of the case. Possible values include:
        /// 'Critical', 'High', 'Medium', 'Low', 'Informational'
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the start time of the case
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTimeUtc")]
        public System.DateTime StartTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the status of the case. Possible values include:
        /// 'Draft', 'New', 'InProgress', 'Closed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the title of the case
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets the number of total comments in the case
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalComments")]
        public int? TotalComments { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Severity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Severity");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
        }
    }
}
