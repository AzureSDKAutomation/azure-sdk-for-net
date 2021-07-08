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
    /// Represents a bookmark in Azure Security Insights.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Bookmark : ResourceWithEtagV1
    {
        /// <summary>
        /// Initializes a new instance of the Bookmark class.
        /// </summary>
        public Bookmark()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Bookmark class.
        /// </summary>
        /// <param name="displayName">The display name of the bookmark</param>
        /// <param name="query">The query of the bookmark.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="created">The time the bookmark was created</param>
        /// <param name="createdBy">Describes a user that created the
        /// bookmark</param>
        /// <param name="labels">List of labels relevant to this
        /// bookmark</param>
        /// <param name="notes">The notes of the bookmark</param>
        /// <param name="queryResult">The query result of the bookmark.</param>
        /// <param name="updated">The last time the bookmark was
        /// updated</param>
        /// <param name="updatedBy">Describes a user that updated the
        /// bookmark</param>
        /// <param name="eventTime">The bookmark event time</param>
        /// <param name="queryStartTime">The start time for the query</param>
        /// <param name="queryEndTime">The end time for the query</param>
        /// <param name="incidentInfo">Describes an incident that relates to
        /// bookmark</param>
        public Bookmark(string displayName, string query, string id = default(string), string name = default(string), string type = default(string), string etag = default(string), System.DateTime? created = default(System.DateTime?), UserInfo createdBy = default(UserInfo), IList<string> labels = default(IList<string>), string notes = default(string), string queryResult = default(string), System.DateTime? updated = default(System.DateTime?), UserInfo updatedBy = default(UserInfo), System.DateTime? eventTime = default(System.DateTime?), System.DateTime? queryStartTime = default(System.DateTime?), System.DateTime? queryEndTime = default(System.DateTime?), IncidentInfo incidentInfo = default(IncidentInfo))
            : base(id, name, type, etag)
        {
            Created = created;
            CreatedBy = createdBy;
            DisplayName = displayName;
            Labels = labels;
            Notes = notes;
            Query = query;
            QueryResult = queryResult;
            Updated = updated;
            UpdatedBy = updatedBy;
            EventTime = eventTime;
            QueryStartTime = queryStartTime;
            QueryEndTime = queryEndTime;
            IncidentInfo = incidentInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time the bookmark was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets describes a user that created the bookmark
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdBy")]
        public UserInfo CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the display name of the bookmark
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets list of labels relevant to this bookmark
        /// </summary>
        [JsonProperty(PropertyName = "properties.labels")]
        public IList<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets the notes of the bookmark
        /// </summary>
        [JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the query of the bookmark.
        /// </summary>
        [JsonProperty(PropertyName = "properties.query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the query result of the bookmark.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryResult")]
        public string QueryResult { get; set; }

        /// <summary>
        /// Gets or sets the last time the bookmark was updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public System.DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or sets describes a user that updated the bookmark
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedBy")]
        public UserInfo UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the bookmark event time
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventTime")]
        public System.DateTime? EventTime { get; set; }

        /// <summary>
        /// Gets or sets the start time for the query
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStartTime")]
        public System.DateTime? QueryStartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the query
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryEndTime")]
        public System.DateTime? QueryEndTime { get; set; }

        /// <summary>
        /// Gets or sets describes an incident that relates to bookmark
        /// </summary>
        [JsonProperty(PropertyName = "properties.incidentInfo")]
        public IncidentInfo IncidentInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
            if (CreatedBy != null)
            {
                CreatedBy.Validate();
            }
            if (UpdatedBy != null)
            {
                UpdatedBy.Validate();
            }
        }
    }
}
