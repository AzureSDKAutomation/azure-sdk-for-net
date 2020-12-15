// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{

    /// <summary>
    /// Defines values for JobExecutionLifecycle.
    /// </summary>
    public static class JobExecutionLifecycle
    {
        public const string Created = "Created";
        public const string InProgress = "InProgress";
        public const string WaitingForChildJobExecutions = "WaitingForChildJobExecutions";
        public const string WaitingForRetry = "WaitingForRetry";
        public const string Succeeded = "Succeeded";
        public const string SucceededWithSkipped = "SucceededWithSkipped";
        public const string Failed = "Failed";
        public const string TimedOut = "TimedOut";
        public const string Canceled = "Canceled";
        public const string Skipped = "Skipped";
    }
}
