// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The top level data export resource container.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataExport : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DataExport class.
        /// </summary>
        public DataExport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataExport class.
        /// </summary>
        /// <param name="resourceId">The destination resource ID. This can be
        /// copied from the Properties entry of the destination resource in
        /// Azure.</param>
        /// <param name="dataExportId">The data export rule ID.</param>
        /// <param name="tableNames">An array of tables to export, for example:
        /// [“Heartbeat, SecurityEvent”].</param>
        /// <param name="dataExportType">The type of the destination resource.
        /// Possible values include: 'StorageAccount', 'EventHub'</param>
        /// <param name="eventHubName">Optional. Allows to define an Event Hub
        /// name. Not applicable when destination is Storage Account.</param>
        /// <param name="enable">Active when enabled.</param>
        /// <param name="createdDate">The latest data export rule modification
        /// time.</param>
        /// <param name="lastModifiedDate">Date and time when the export was
        /// last modified.</param>
        public DataExport(string resourceId, string dataExportId = default(string), IList<string> tableNames = default(IList<string>), string dataExportType = default(string), string eventHubName = default(string), bool? enable = default(bool?), string createdDate = default(string), string lastModifiedDate = default(string))
        {
            DataExportId = dataExportId;
            TableNames = tableNames;
            ResourceId = resourceId;
            DataExportType = dataExportType;
            EventHubName = eventHubName;
            Enable = enable;
            CreatedDate = createdDate;
            LastModifiedDate = lastModifiedDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data export rule ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataExportId")]
        public string DataExportId { get; set; }

        /// <summary>
        /// Gets or sets an array of tables to export, for example:
        /// [“Heartbeat, SecurityEvent”].
        /// </summary>
        [JsonProperty(PropertyName = "properties.tableNames")]
        public IList<string> TableNames { get; set; }

        /// <summary>
        /// Gets or sets the destination resource ID. This can be copied from
        /// the Properties entry of the destination resource in Azure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destination.resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets the type of the destination resource. Possible values include:
        /// 'StorageAccount', 'EventHub'
        /// </summary>
        [JsonProperty(PropertyName = "properties.destination.type")]
        public string DataExportType { get; private set; }

        /// <summary>
        /// Gets or sets optional. Allows to define an Event Hub name. Not
        /// applicable when destination is Storage Account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destination.metaData.eventHubName")]
        public string EventHubName { get; set; }

        /// <summary>
        /// Gets or sets active when enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Gets or sets the latest data export rule modification time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets date and time when the export was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
        }
    }
}
