// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CaseCommentsOperations operations.
    /// </summary>
    public partial interface ICaseCommentsOperations
    {
        /// <summary>
        /// Creates the case comment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='operationalInsightsResourceProvider'>
        /// The namespace of workspaces resource provider-
        /// Microsoft.OperationalInsights.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='caseId'>
        /// Case ID
        /// </param>
        /// <param name='caseCommentId'>
        /// Case comment ID
        /// </param>
        /// <param name='message'>
        /// The comment message
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<AzureOperationResponse<CaseComment>> CreateCommentWithHttpMessagesAsync(string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, string caseCommentId, string message, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
