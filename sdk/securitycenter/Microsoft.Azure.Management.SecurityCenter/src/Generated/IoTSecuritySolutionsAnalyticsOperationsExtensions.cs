// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IoTSecuritySolutionsAnalyticsOperations.
    /// </summary>
    public static partial class IoTSecuritySolutionsAnalyticsOperationsExtensions
    {
            /// <summary>
            /// Security Analytics of a security solution
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The solution manager name
            /// </param>
            public static IoTSecuritySolutionAnalyticsModelList GetAll(this IIoTSecuritySolutionsAnalyticsOperations operations, string resourceGroupName, string solutionName)
            {
                return operations.GetAllAsync(resourceGroupName, solutionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security Analytics of a security solution
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The solution manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IoTSecuritySolutionAnalyticsModelList> GetAllAsync(this IIoTSecuritySolutionsAnalyticsOperations operations, string resourceGroupName, string solutionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllWithHttpMessagesAsync(resourceGroupName, solutionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security Analytics of a security solution
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The solution manager name
            /// </param>
            public static IoTSecuritySolutionAnalyticsModel GetDefault(this IIoTSecuritySolutionsAnalyticsOperations operations, string resourceGroupName, string solutionName)
            {
                return operations.GetDefaultAsync(resourceGroupName, solutionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security Analytics of a security solution
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The solution manager name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IoTSecuritySolutionAnalyticsModel> GetDefaultAsync(this IIoTSecuritySolutionsAnalyticsOperations operations, string resourceGroupName, string solutionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDefaultWithHttpMessagesAsync(resourceGroupName, solutionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
