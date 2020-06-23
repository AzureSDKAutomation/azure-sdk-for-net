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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Datasources under OMS Workspace.
    /// </summary>
    public partial class DataSource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DataSource class.
        /// </summary>
        public DataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataSource class.
        /// </summary>
        /// <param name="properties">The data source properties in raw json
        /// format, each kind of data source have it's own schema.</param>
        /// <param name="kind">Possible values include: 'WindowsEvent',
        /// 'WindowsPerformanceCounter', 'IISLogs', 'LinuxSyslog',
        /// 'LinuxSyslogCollection', 'LinuxPerformanceObject',
        /// 'LinuxPerformanceCollection', 'CustomLog', 'CustomLogCollection',
        /// 'AzureAuditLog', 'AzureActivityLog', 'GenericDataSource',
        /// 'ChangeTrackingCustomPath', 'ChangeTrackingPath',
        /// 'ChangeTrackingServices', 'ChangeTrackingDataTypeConfiguration',
        /// 'ChangeTrackingDefaultRegistry', 'ChangeTrackingRegistry',
        /// 'ChangeTrackingLinuxPath', 'LinuxChangeTrackingPath',
        /// 'ChangeTrackingContentLocation', 'WindowsTelemetry', 'Office365',
        /// 'SecurityWindowsBaselineConfiguration',
        /// 'SecurityCenterSecurityWindowsBaselineConfiguration',
        /// 'SecurityEventCollectionConfiguration',
        /// 'SecurityInsightsSecurityEventCollectionConfiguration',
        /// 'ImportComputerGroup', 'NetworkMonitoring', 'Itsm', 'DnsAnalytics',
        /// 'ApplicationInsights', 'SqlDataClassification'</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="etag">The ETag of the data source.</param>
        /// <param name="tags">Resource tags.</param>
        public DataSource(object properties, string kind, string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type)
        {
            Properties = properties;
            Etag = etag;
            Kind = kind;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data source properties in raw json format, each
        /// kind of data source have it's own schema.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the data source.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'WindowsEvent',
        /// 'WindowsPerformanceCounter', 'IISLogs', 'LinuxSyslog',
        /// 'LinuxSyslogCollection', 'LinuxPerformanceObject',
        /// 'LinuxPerformanceCollection', 'CustomLog', 'CustomLogCollection',
        /// 'AzureAuditLog', 'AzureActivityLog', 'GenericDataSource',
        /// 'ChangeTrackingCustomPath', 'ChangeTrackingPath',
        /// 'ChangeTrackingServices', 'ChangeTrackingDataTypeConfiguration',
        /// 'ChangeTrackingDefaultRegistry', 'ChangeTrackingRegistry',
        /// 'ChangeTrackingLinuxPath', 'LinuxChangeTrackingPath',
        /// 'ChangeTrackingContentLocation', 'WindowsTelemetry', 'Office365',
        /// 'SecurityWindowsBaselineConfiguration',
        /// 'SecurityCenterSecurityWindowsBaselineConfiguration',
        /// 'SecurityEventCollectionConfiguration',
        /// 'SecurityInsightsSecurityEventCollectionConfiguration',
        /// 'ImportComputerGroup', 'NetworkMonitoring', 'Itsm', 'DnsAnalytics',
        /// 'ApplicationInsights', 'SqlDataClassification'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
        }
    }
}
