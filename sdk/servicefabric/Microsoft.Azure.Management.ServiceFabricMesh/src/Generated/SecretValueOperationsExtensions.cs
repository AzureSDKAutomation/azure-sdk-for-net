// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricMesh
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SecretValueOperations.
    /// </summary>
    public static partial class SecretValueOperationsExtensions
    {
            /// <summary>
            /// Adds the specified value as a new version of the specified secret resource.
            /// </summary>
            /// <remarks>
            /// Creates a new value of the specified secret resource. The name of the value
            /// is typically the version identifier. Once created the value cannot be
            /// changed.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            /// <param name='secretValueResourceDescription'>
            /// Description for creating a value of a secret resource.
            /// </param>
            public static SecretValueResourceDescription Create(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName, SecretValueResourceDescription secretValueResourceDescription)
            {
                return operations.CreateAsync(resourceGroupName, secretResourceName, secretValueResourceName, secretValueResourceDescription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds the specified value as a new version of the specified secret resource.
            /// </summary>
            /// <remarks>
            /// Creates a new value of the specified secret resource. The name of the value
            /// is typically the version identifier. Once created the value cannot be
            /// changed.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            /// <param name='secretValueResourceDescription'>
            /// Description for creating a value of a secret resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecretValueResourceDescription> CreateAsync(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName, SecretValueResourceDescription secretValueResourceDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, secretResourceName, secretValueResourceName, secretValueResourceDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified secret value resource.
            /// </summary>
            /// <remarks>
            /// Get the information about the specified named secret value resources. The
            /// information does not include the actual value of the secret.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            public static SecretValueResourceDescription Get(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName)
            {
                return operations.GetAsync(resourceGroupName, secretResourceName, secretValueResourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified secret value resource.
            /// </summary>
            /// <remarks>
            /// Get the information about the specified named secret value resources. The
            /// information does not include the actual value of the secret.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecretValueResourceDescription> GetAsync(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, secretResourceName, secretValueResourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified  value of the named secret resource.
            /// </summary>
            /// <remarks>
            /// Deletes the secret value resource identified by the name. The name of the
            /// resource is typically the version associated with that value. Deletion will
            /// fail if the specified value is in use.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            public static void Delete(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName)
            {
                operations.DeleteAsync(resourceGroupName, secretResourceName, secretValueResourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified  value of the named secret resource.
            /// </summary>
            /// <remarks>
            /// Deletes the secret value resource identified by the name. The name of the
            /// resource is typically the version associated with that value. Deletion will
            /// fail if the specified value is in use.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, secretResourceName, secretValueResourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List names of all values of the specified secret resource.
            /// </summary>
            /// <remarks>
            /// Gets information about all secret value resources of the specified secret
            /// resource. The information includes the names of the secret value resources,
            /// but not the actual values.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            public static IPage<SecretValueResourceDescription> List(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName)
            {
                return operations.ListAsync(resourceGroupName, secretResourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List names of all values of the specified secret resource.
            /// </summary>
            /// <remarks>
            /// Gets information about all secret value resources of the specified secret
            /// resource. The information includes the names of the secret value resources,
            /// but not the actual values.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecretValueResourceDescription>> ListAsync(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, secretResourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the specified value of the secret resource.
            /// </summary>
            /// <remarks>
            /// Lists the decrypted value of the specified named value of the secret
            /// resource. This is a privileged operation.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            public static SecretValue ListValue(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName)
            {
                return operations.ListValueAsync(resourceGroupName, secretResourceName, secretValueResourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the specified value of the secret resource.
            /// </summary>
            /// <remarks>
            /// Lists the decrypted value of the specified named value of the secret
            /// resource. This is a privileged operation.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='secretResourceName'>
            /// The name of the secret resource.
            /// </param>
            /// <param name='secretValueResourceName'>
            /// The name of the secret resource value which is typically the version
            /// identifier for the value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecretValue> ListValueAsync(this ISecretValueOperations operations, string resourceGroupName, string secretResourceName, string secretValueResourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListValueWithHttpMessagesAsync(resourceGroupName, secretResourceName, secretValueResourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List names of all values of the specified secret resource.
            /// </summary>
            /// <remarks>
            /// Gets information about all secret value resources of the specified secret
            /// resource. The information includes the names of the secret value resources,
            /// but not the actual values.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecretValueResourceDescription> ListNext(this ISecretValueOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List names of all values of the specified secret resource.
            /// </summary>
            /// <remarks>
            /// Gets information about all secret value resources of the specified secret
            /// resource. The information includes the names of the secret value resources,
            /// but not the actual values.
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
            public static async Task<IPage<SecretValueResourceDescription>> ListNextAsync(this ISecretValueOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
