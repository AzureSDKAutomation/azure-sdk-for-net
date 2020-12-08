// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CertificatesOperations.
    /// </summary>
    public static partial class CertificatesOperationsExtensions
    {
            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Certificate> List(this ICertificatesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Certificate>> ListAsync(this ICertificatesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            public static IPage<Certificate> ListByResourceGroup(this ICertificatesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Certificate>> ListByResourceGroupAsync(this ICertificatesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Get a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            public static Certificate Get(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                return operations.GetAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Get a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Certificate> GetAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            public static Certificate CreateOrUpdate(this ICertificatesOperations operations, string resourceGroupName, string name, Certificate certificateEnvelope)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, name, certificateEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Certificate> CreateOrUpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string name, Certificate certificateEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, certificateEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Delete a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            public static void Delete(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                operations.DeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Delete a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            public static Certificate Update(this ICertificatesOperations operations, string resourceGroupName, string name, CertificatePatchResource certificateEnvelope)
            {
                return operations.UpdateAsync(resourceGroupName, name, certificateEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Certificate> UpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CertificatePatchResource certificateEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, certificateEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            public static Certificate BeginCreateOrUpdate(this ICertificatesOperations operations, string resourceGroupName, string name, Certificate certificateEnvelope)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, name, certificateEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Description for Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Certificate> BeginCreateOrUpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string name, Certificate certificateEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, certificateEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Certificate> ListNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates for a subscription.
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
            public static async Task<IPage<Certificate>> ListNextAsync(this ICertificatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Certificate> ListByResourceGroupNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Description for Get all certificates in a resource group.
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
            public static async Task<IPage<Certificate>> ListByResourceGroupNextAsync(this ICertificatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
