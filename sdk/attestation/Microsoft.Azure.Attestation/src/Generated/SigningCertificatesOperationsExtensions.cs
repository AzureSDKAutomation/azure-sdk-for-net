// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Attestation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SigningCertificatesOperations.
    /// </summary>
    public static partial class SigningCertificatesOperationsExtensions
    {
            /// <summary>
            /// Retrieves the attestation signing keys in use by the attestation service
            /// </summary>
            /// <remarks>
            /// Retrieves metadata signing certificates in use by the attestation service
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            public static JSONWebKeySet Get(this ISigningCertificatesOperations operations, string instanceUrl)
            {
                return operations.GetAsync(instanceUrl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the attestation signing keys in use by the attestation service
            /// </summary>
            /// <remarks>
            /// Retrieves metadata signing certificates in use by the attestation service
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JSONWebKeySet> GetAsync(this ISigningCertificatesOperations operations, string instanceUrl, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(instanceUrl, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
