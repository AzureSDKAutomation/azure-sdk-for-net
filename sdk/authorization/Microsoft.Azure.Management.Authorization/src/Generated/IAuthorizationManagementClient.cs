// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IAuthorizationManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IRoleAssignmentSchedulesOperations.
        /// </summary>
        IRoleAssignmentSchedulesOperations RoleAssignmentSchedules { get; }

        /// <summary>
        /// Gets the IRoleAssignmentScheduleInstancesOperations.
        /// </summary>
        IRoleAssignmentScheduleInstancesOperations RoleAssignmentScheduleInstances { get; }

        /// <summary>
        /// Gets the IRoleAssignmentScheduleRequestsOperations.
        /// </summary>
        IRoleAssignmentScheduleRequestsOperations RoleAssignmentScheduleRequests { get; }

        /// <summary>
        /// Gets the IRoleEligibilitySchedulesOperations.
        /// </summary>
        IRoleEligibilitySchedulesOperations RoleEligibilitySchedules { get; }

        /// <summary>
        /// Gets the IRoleEligibilityScheduleInstancesOperations.
        /// </summary>
        IRoleEligibilityScheduleInstancesOperations RoleEligibilityScheduleInstances { get; }

        /// <summary>
        /// Gets the IRoleEligibilityScheduleRequestsOperations.
        /// </summary>
        IRoleEligibilityScheduleRequestsOperations RoleEligibilityScheduleRequests { get; }

        /// <summary>
        /// Gets the IRoleManagementPoliciesOperations.
        /// </summary>
        IRoleManagementPoliciesOperations RoleManagementPolicies { get; }

        /// <summary>
        /// Gets the IRoleManagementPolicyAssignmentsOperations.
        /// </summary>
        IRoleManagementPolicyAssignmentsOperations RoleManagementPolicyAssignments { get; }

        /// <summary>
        /// Gets the IEligibleChildResourcesOperations.
        /// </summary>
        IEligibleChildResourcesOperations EligibleChildResources { get; }

        /// <summary>
        /// Gets the IRoleAssignmentsOperations.
        /// </summary>
        IRoleAssignmentsOperations RoleAssignments { get; }

    }
}
