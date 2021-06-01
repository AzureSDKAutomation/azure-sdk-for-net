// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobsOperations.
    /// </summary>
    public static partial class JobsOperationsExtensions
    {
            /// <summary>
            /// Lists Jobs in the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='skip'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='jobType'>
            /// Type of job to be returned.
            /// </param>
            /// <param name='tags'>
            /// Tags for job to be returned.
            /// </param>
            /// <param name='tag'>
            /// Jobs returned will have this tag key.
            /// </param>
            public static IPage<JobBaseResource> List(this IJobsOperations operations, string resourceGroupName, string workspaceName, string skip = default(string), string jobType = default(string), string tags = default(string), string tag = default(string))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, skip, jobType, tags, tag).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists Jobs in the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='skip'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='jobType'>
            /// Type of job to be returned.
            /// </param>
            /// <param name='tags'>
            /// Tags for job to be returned.
            /// </param>
            /// <param name='tag'>
            /// Jobs returned will have this tag key.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobBaseResource>> ListAsync(this IJobsOperations operations, string resourceGroupName, string workspaceName, string skip = default(string), string jobType = default(string), string tags = default(string), string tag = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, skip, jobType, tags, tag, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Job (asynchronous).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            public static JobsDeleteHeaders Delete(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName)
            {
                return operations.DeleteAsync(id, resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Job (asynchronous).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobsDeleteHeaders> DeleteAsync(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(id, resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets a Job by name/id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            public static JobBaseResource Get(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName)
            {
                return operations.GetAsync(id, resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Job by name/id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobBaseResource> GetAsync(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(id, resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates and executes a Job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='body'>
            /// Job definition object.
            /// </param>
            public static JobBaseResource CreateOrUpdate(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName, JobBaseResource body)
            {
                return operations.CreateOrUpdateAsync(id, resourceGroupName, workspaceName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates and executes a Job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='body'>
            /// Job definition object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobBaseResource> CreateOrUpdateAsync(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName, JobBaseResource body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(id, resourceGroupName, workspaceName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a Job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            public static void Cancel(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName)
            {
                operations.CancelAsync(id, resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a Job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(id, resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a Job (asynchronous).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            public static JobsDeleteHeaders BeginDelete(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName)
            {
                return operations.BeginDeleteAsync(id, resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Job (asynchronous).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The name and identifier for the Job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of Azure Machine Learning workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobsDeleteHeaders> BeginDeleteAsync(this IJobsOperations operations, string id, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(id, resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists Jobs in the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobBaseResource> ListNext(this IJobsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists Jobs in the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobBaseResource>> ListNextAsync(this IJobsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
