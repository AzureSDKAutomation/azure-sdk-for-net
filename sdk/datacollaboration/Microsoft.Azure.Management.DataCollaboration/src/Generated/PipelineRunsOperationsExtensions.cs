// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PipelineRunsOperations.
    /// </summary>
    public static partial class PipelineRunsOperationsExtensions
    {
            /// <summary>
            /// List pipeline runs in a pipeline.
            /// </summary>
            /// <remarks>
            /// List pipelines run of a pipeline
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            public static IPage<PipelineRun> ListByPipeline(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string skipToken = default(string))
            {
                return operations.ListByPipelineAsync(resourceGroupName, workspaceName, pipelineName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List pipeline runs in a pipeline.
            /// </summary>
            /// <remarks>
            /// List pipelines run of a pipeline
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PipelineRun>> ListByPipelineAsync(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPipelineWithHttpMessagesAsync(resourceGroupName, workspaceName, pipelineName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get pipeline run.
            /// </summary>
            /// <remarks>
            /// Get a pipeline run in a pipeline
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='pipelineRunName'>
            /// The name of the pipeline run.
            /// </param>
            public static PipelineRun Get(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string pipelineRunName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, pipelineName, pipelineRunName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get pipeline run.
            /// </summary>
            /// <remarks>
            /// Get a pipeline run in a pipeline
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='pipelineRunName'>
            /// The name of the pipeline run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineRun> GetAsync(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string pipelineRunName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, pipelineName, pipelineRunName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request cancellation of a pipeline run
            /// </summary>
            /// <remarks>
            /// Request to cancel a pipeline run.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='pipelineRunName'>
            /// The name of the pipeline run.
            /// </param>
            public static PipelineRun Cancel(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string pipelineRunName)
            {
                return operations.CancelAsync(resourceGroupName, workspaceName, pipelineName, pipelineRunName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request cancellation of a pipeline run
            /// </summary>
            /// <remarks>
            /// Request to cancel a pipeline run.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='pipelineRunName'>
            /// The name of the pipeline run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineRun> CancelAsync(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string pipelineRunName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelWithHttpMessagesAsync(resourceGroupName, workspaceName, pipelineName, pipelineRunName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request cancellation of a pipeline run
            /// </summary>
            /// <remarks>
            /// Request to cancel a pipeline run.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='pipelineRunName'>
            /// The name of the pipeline run.
            /// </param>
            public static PipelineRun BeginCancel(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string pipelineRunName)
            {
                return operations.BeginCancelAsync(resourceGroupName, workspaceName, pipelineName, pipelineRunName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request cancellation of a pipeline run
            /// </summary>
            /// <remarks>
            /// Request to cancel a pipeline run.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='pipelineName'>
            /// The name of the pipeline.
            /// </param>
            /// <param name='pipelineRunName'>
            /// The name of the pipeline run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineRun> BeginCancelAsync(this IPipelineRunsOperations operations, string resourceGroupName, string workspaceName, string pipelineName, string pipelineRunName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCancelWithHttpMessagesAsync(resourceGroupName, workspaceName, pipelineName, pipelineRunName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List pipeline runs in a pipeline.
            /// </summary>
            /// <remarks>
            /// List pipelines run of a pipeline
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PipelineRun> ListByPipelineNext(this IPipelineRunsOperations operations, string nextPageLink)
            {
                return operations.ListByPipelineNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List pipeline runs in a pipeline.
            /// </summary>
            /// <remarks>
            /// List pipelines run of a pipeline
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PipelineRun>> ListByPipelineNextAsync(this IPipelineRunsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPipelineNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
