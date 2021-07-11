// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Report for the guest configuration assignment. Report contains
    /// information such as compliance status, reason, and more.
    /// </summary>
    public partial class GuestConfigurationAssignmentReportProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GuestConfigurationAssignmentReportProperties class.
        /// </summary>
        public GuestConfigurationAssignmentReportProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GuestConfigurationAssignmentReportProperties class.
        /// </summary>
        /// <param name="complianceStatus">A value indicating compliance status
        /// of the machine for the assigned guest configuration. Possible
        /// values include: 'Compliant', 'NonCompliant', 'Pending'</param>
        /// <param name="reportId">GUID that identifies the guest configuration
        /// assignment report under a subscription, resource group.</param>
        /// <param name="assignment">Configuration details of the guest
        /// configuration assignment.</param>
        /// <param name="vm">Information about the VM.</param>
        /// <param name="startTime">Start date and time of the guest
        /// configuration assignment compliance status check.</param>
        /// <param name="endTime">End date and time of the guest configuration
        /// assignment compliance status check.</param>
        /// <param name="details">Details of the assignment report.</param>
        /// <param name="vmssResourceId">Azure resource Id of the VMSS.</param>
        public GuestConfigurationAssignmentReportProperties(string complianceStatus = default(string), string reportId = default(string), AssignmentInfo assignment = default(AssignmentInfo), VMInfo vm = default(VMInfo), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), AssignmentReportDetails details = default(AssignmentReportDetails), string vmssResourceId = default(string))
        {
            ComplianceStatus = complianceStatus;
            ReportId = reportId;
            Assignment = assignment;
            Vm = vm;
            StartTime = startTime;
            EndTime = endTime;
            Details = details;
            VmssResourceId = vmssResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a value indicating compliance status of the machine for the
        /// assigned guest configuration. Possible values include: 'Compliant',
        /// 'NonCompliant', 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "complianceStatus")]
        public string ComplianceStatus { get; private set; }

        /// <summary>
        /// Gets GUID that identifies the guest configuration assignment report
        /// under a subscription, resource group.
        /// </summary>
        [JsonProperty(PropertyName = "reportId")]
        public string ReportId { get; private set; }

        /// <summary>
        /// Gets or sets configuration details of the guest configuration
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "assignment")]
        public AssignmentInfo Assignment { get; set; }

        /// <summary>
        /// Gets or sets information about the VM.
        /// </summary>
        [JsonProperty(PropertyName = "vm")]
        public VMInfo Vm { get; set; }

        /// <summary>
        /// Gets start date and time of the guest configuration assignment
        /// compliance status check.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets end date and time of the guest configuration assignment
        /// compliance status check.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets or sets details of the assignment report.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public AssignmentReportDetails Details { get; set; }

        /// <summary>
        /// Gets azure resource Id of the VMSS.
        /// </summary>
        [JsonProperty(PropertyName = "vmssResourceId")]
        public string VmssResourceId { get; private set; }

    }
}
