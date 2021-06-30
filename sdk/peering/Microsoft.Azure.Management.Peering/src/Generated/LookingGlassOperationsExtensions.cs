// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LookingGlassOperations.
    /// </summary>
    public static partial class LookingGlassOperationsExtensions
    {
            /// <summary>
            /// Run looking glass functionality
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='command'>
            /// The command to be executed: ping, traceroute, bgpRoute. Possible values
            /// include: 'Traceroute', 'Ping', 'BgpRoute'
            /// </param>
            /// <param name='sourceType'>
            /// The type of the source: Edge site or Azure Region. Possible values include:
            /// 'EdgeSite', 'AzureRegion'
            /// </param>
            /// <param name='sourceLocation'>
            /// The location of the source.
            /// </param>
            /// <param name='destinationIP'>
            /// The IP address of the destination.
            /// </param>
            public static LookingGlassOutput Invoke(this ILookingGlassOperations operations, string command, string sourceType, string sourceLocation, string destinationIP)
            {
                return operations.InvokeAsync(command, sourceType, sourceLocation, destinationIP).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Run looking glass functionality
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='command'>
            /// The command to be executed: ping, traceroute, bgpRoute. Possible values
            /// include: 'Traceroute', 'Ping', 'BgpRoute'
            /// </param>
            /// <param name='sourceType'>
            /// The type of the source: Edge site or Azure Region. Possible values include:
            /// 'EdgeSite', 'AzureRegion'
            /// </param>
            /// <param name='sourceLocation'>
            /// The location of the source.
            /// </param>
            /// <param name='destinationIP'>
            /// The IP address of the destination.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LookingGlassOutput> InvokeAsync(this ILookingGlassOperations operations, string command, string sourceType, string sourceLocation, string destinationIP, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InvokeWithHttpMessagesAsync(command, sourceType, sourceLocation, destinationIP, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
